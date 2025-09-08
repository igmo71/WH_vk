using MassTransit;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WH.Api.Data;
using WH.Api.Services;
using WH.Domain.Models;
using WH.Domain.Models.DataMining;

namespace WH.Api.DataMining
{
    public interface IDataMiningService
    {
        Task<ServiceResult> LoadingPredictsAsync();
        Task<ServiceResult> LoadingScuSaleRanksAsync();
    }

    public class DataMiningService : IDataMiningService
    {
        private readonly IDbContextFactory<AppDbContext> _dbContextFactory;
        private readonly IDataMiningClient _client;
        private readonly DataMiningClientConfiguration _config;
        private readonly ILogger _logger;

        public DataMiningService(IDbContextFactory<AppDbContext> dbContextFactory, IDataMiningClient client, IConfiguration configuration, ILogger<DataMiningService> logger)
        {
            _dbContextFactory = dbContextFactory;
            _client = client;
            _config = configuration.GetSection(DataMiningClientConfiguration.Section).Get<DataMiningClientConfiguration>()
                ?? throw new ApplicationException("DataMiningConfig not found");
            _logger = logger;
        }

        public async Task<ServiceResult> LoadingPredictsAsync()
        {
            _logger.LogInformation("{Method} start at  {DateTime}", nameof(LoadingPredictsAsync), DateTime.Now);

            ServiceResult serviceResult = new();

            if (_config.Structures == null)
                return serviceResult;

            var loadingTimestamp = Stopwatch.GetTimestamp();

            await DeleteRangeAsync<Predict>();

            int insertedRows = 0;

            foreach (var structure in _config.Structures)
            {

                var query =
                    $"SELECT FLATTENED [Predict__{structure}].[Номенклатура Вид Подвид Key], PredictTimeSeries([Predict__{structure}].[Вес],4) From [Predict__{structure}]";

                var predicts = await _client.GetPredictsAsync(_config.Uri, query);

                if (predicts != null)
                {
                    foreach (var predict in predicts)
                    {
                        predict.Склад = structure;

                        if (predict.НоменклатураВидПодвидKey != null)
                        {
                            var keys = predict.НоменклатураВидПодвидKey.Split('_');
                            predict.ВидНоменклатуры_Key = keys[0];
                            predict.ПодвидНоменклатуры_Key = keys[1];
                        }
                    }

                    insertedRows += await AddRangeAsync(predicts);
                }
                _logger.LogDebug("{Method} for {structure} - Ok", nameof(LoadingPredictsAsync), structure);
            }

            serviceResult.Values["Entity"] = nameof(Predict);
            serviceResult.Values["Duration"] = Stopwatch.GetElapsedTime(loadingTimestamp);
            serviceResult.Values["InsertedRows"] = insertedRows;

            _logger.LogInformation("{Method} {@ServiceResult}", nameof(LoadingPredictsAsync), serviceResult);

            return serviceResult;
        }

        public async Task<ServiceResult> LoadingScuSaleRanksAsync()
        {
            _logger.LogInformation("{Method} start at {DateTime}", nameof(LoadingScuSaleRanksAsync), DateTime.Now);

            ServiceResult serviceResult = new();

            if (_config.Structures == null)
                return serviceResult;

            var loadingTimestamp = Stopwatch.GetTimestamp();

            await DeleteRangeAsync<ScuSaleRank>();

            int insertedRows = 0;

            foreach (var structure in _config.Structures)
            {

                var query = BuildScuSaleRanksQuery(structure);

                var scuSaleRanks = await _client.GetScuSaleRanksAsync(_config.Uri, query);

                if (scuSaleRanks != null)
                {
                    foreach (var scuSaleRank in scuSaleRanks)
                    {
                        scuSaleRank.Id = NewId.Next().ToString();
                        scuSaleRank.Склад = structure;

                        // For Windows (comment if Docker)
                        //scuSaleRank.Вес = double.Parse(scuSaleRank.ВесStr?.Replace('.', ',') ?? "0");
                        //scuSaleRank.Percentage = double.Parse(scuSaleRank.PercentageStr?.Replace('.', ',') ?? "0");

                        // For Docker (comment if Windows)
                        scuSaleRank.Вес = double.Parse(scuSaleRank.ВесStr ?? "0");
                        scuSaleRank.Percentage = double.Parse(scuSaleRank.PercentageStr ?? "0");
                    }

                    insertedRows += await AddRangeAsync(scuSaleRanks);
                }
                _logger.LogDebug("{Method} for {structure}  - Ok", nameof(LoadingScuSaleRanksAsync), structure);
            }

            serviceResult.Values["Entity"] = nameof(ScuSaleRank);
            serviceResult.Values["Duration"] = Stopwatch.GetElapsedTime(loadingTimestamp);
            serviceResult.Values["InsertedRows"] = insertedRows;

            _logger.LogInformation("{Method} {@ServiceResult}", nameof(LoadingScuSaleRanksAsync), serviceResult);

            return serviceResult;
        }

        private async Task DeleteRangeAsync<TEntity>() where TEntity : Entity
        {
            using var context = await _dbContextFactory.CreateDbContextAsync();
            await context.Set<TEntity>().ExecuteDeleteAsync();
        }

        private async Task<int> AddRangeAsync<TEntity>(IEnumerable<TEntity> predicts) where TEntity : Entity
        {
            using var context = await _dbContextFactory.CreateDbContextAsync();
            await context.AddRangeAsync(predicts);
            var result = await context.SaveChangesAsync();
            return result;
        }

        private string BuildScuSaleRanksQuery(string structure)
        {
            var today = DateTime.Today;
            var todayMonthAgo = today.AddMonths(-1);
            var todayYearAgo = today.AddYears(-1);
            var todayYearAgoMonthAgo = today.AddYears(-1).AddMonths(-1);
            string query = $@"
             WITH MEMBER  [Measures].[Подвид] as IIf([Measures].[Вес1]>0,[Номенклатура Вид-Подвид].[Номенклатура Вид - Подвид].CURRENTMEMBER.PARENT.MEMBER_KEY,null)
             MEMBER [Measures].[Вид] as IIf([Measures].[Вес1]>0,[Номенклатура Вид-Подвид].[Номенклатура Вид - Подвид].CURRENTMEMBER.PARENT.PARENT.MEMBER_KEY,null) 
             MEMBER [Measures].[Номенклатура] as IIf([Measures].[Вес1]>0,[Номенклатура Вид-Подвид].[Номенклатура Вид - Подвид].CURRENTMEMBER.MEMBER_KEY,null) 
             MEMBER [Measures].[Вес1] as IIf([Номенклатура Вид-Подвид].[Номенклатура Вид - Подвид].CURRENTMEMBER.LEVEL.ORDINAL>2 AND [Measures].[Вес]>0,[Measures].[Вес],null)
             MEMBER [Measures].[Percentage] as IIf([Measures].[Group]>0, [Measures].[Вес1] / [Measures].[Group],null) , FORMAT_STRING=""0.0000"" 
             MEMBER [Measures].[Group] as 
	            IIf(
	            ([Номенклатура Вид-Подвид].[Номенклатура Вид - Подвид].CURRENTMEMBER.PARENT,[Measures].[Вес])>0 AND [Номенклатура Вид-Подвид].[Номенклатура Вид - Подвид].CURRENTMEMBER.LEVEL.ORDINAL>2 AND [Measures].[Вес]>0,
		            ([Номенклатура Вид-Подвид].[Номенклатура Вид - Подвид].CURRENTMEMBER.PARENT,[Measures].[Вес]),
	                null)
             SELECT  NON EMPTY  {{[Measures].[Вид] ,[Measures].[Подвид],[Measures].[Номенклатура],[Measures].[Вес1],[Measures].[Percentage] }} ON COLUMNS,
             NON EMPTY {{ ([Номенклатура Вид-Подвид].[Номенклатура Вид - Подвид].ALLMEMBERS ) }} ON ROWS 
            FROM ( SELECT ( 
{{ [Календарь].[Г-ММ-Д].[Год].&[{todayMonthAgo.Year}].&[{todayMonthAgo.Month}].&[{todayMonthAgo.Day}]:[Календарь].[Г-ММ-Д].[Год].&[{today.Year}].&[{today.Month}].&[{today.AddDays(-1).Day}], 
   [Календарь].[Г-ММ-Д].[Год].&[{todayYearAgoMonthAgo.Year}].&[{todayYearAgoMonthAgo.Month}].&[{todayYearAgoMonthAgo.Day}]:[Календарь].[Г-ММ-Д].[Год].&[{todayYearAgo.Year}].&[{todayYearAgo.Month}].&[{todayYearAgo.AddDays(-1).Day}] }}) ON COLUMNS
                    FROM ( SELECT ( {{[Склады].[Склады].&[{structure}] }} ) ON COLUMNS FROM [Выручка И Себестоимость Продаж])) 
                    WHERE ( [Склады].[Склады].&[{structure}], [Календарь].[Г-М-Д].CurrentMember ) CELL PROPERTIES VALUE, BACK_COLOR, FORE_COLOR, FORMATTED_VALUE, FORMAT_STRING, FONT_NAME, FONT_SIZE, FONT_FLAGS";
            return query;
        }
    }
}
