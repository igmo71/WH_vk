using MassTransit;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.Trash;
using WH.Domain.Models;
using WH.Domain.Models.AccumulationRegister;
using TEntity = WH.Domain.Models.AccumulationRegister.AccumulationRegisterСебестоимостьТоваровBalance;

namespace WH.Api.Services.Trash
{
    public interface IAccumulationRegisterСебестоимостьТоваровBalanceService : IAppService
    {

        Task<ServiceResult> LoadingAsync(DateTime? date = null);
    }

    public class AccumulationRegisterСебестоимостьТоваровBalanceService : IAccumulationRegisterСебестоимостьТоваровBalanceService
    {
        private readonly IODataClient _oDataClient;
        private readonly IAccumulationRegisterСебестоимостьТоваровBalanceParameters _oDataParameters;
        private readonly IDbContextFactory<AppDbContext> _dbContextFactory;
        private readonly ILogger<TEntity> _logger;
        private readonly string _entityName = nameof(AccumulationRegisterСебестоимостьТоваровBalance);

        public AccumulationRegisterСебестоимостьТоваровBalanceService(
            IODataClient oDataClient,
            IAccumulationRegisterСебестоимостьТоваровBalanceParameters oDataParameters,
            IDbContextFactory<AppDbContext> dbContextFactory,
            ILogger<TEntity> logger)
        {
            _oDataClient = oDataClient;
            _oDataParameters = oDataParameters;
            _dbContextFactory = dbContextFactory;
            _logger = logger;
        }


        public async Task<ServiceResult> LoadingAsync(DateTime? date = null)
        {
            ServiceResult serviceResult = new();

            var loadingTimestamp = Stopwatch.GetTimestamp();

            await DeleteAllAsync();

            var getODataTimestamp = Stopwatch.GetTimestamp();
            TEntity[]? values = await GetODataValuesAsync(date);
            var getODataElapsedTime = Stopwatch.GetElapsedTime(getODataTimestamp).TotalSeconds;

            var dbInsertTimestamp = Stopwatch.GetTimestamp();
            int insertedRows = await InsertValuesAsync(values);
            var dbInsertElapsedTime = Stopwatch.GetElapsedTime(dbInsertTimestamp).TotalSeconds;

            serviceResult.Values["Entity"] = _entityName;
            serviceResult.Values["Duration"] = Stopwatch.GetElapsedTime(loadingTimestamp);
            serviceResult.Values["InsertedRows"] = insertedRows;

            _logger.LogInformation("{Method} {Entity} {@ServiceResult}", nameof(LoadingAsync), _entityName, serviceResult);

            return serviceResult;
        }

        public async Task<int> DeleteAllAsync()
        {
            using var dbContext = _dbContextFactory.CreateDbContext();
            return await dbContext.Set<TEntity>().ExecuteDeleteAsync();
        }

        private async Task<TEntity[]?> GetODataValuesAsync(DateTime? date = null)
        {
            string uri = _oDataParameters.GetUri(date);

            var rootobject = await _oDataClient.GetValuesAsync<Rootobject<TEntity>>(uri);

            var values = rootobject?.Values;
            return values;
        }

        private async Task<int> InsertValuesAsync(TEntity[]? values)
        {
            int insertedRows = 0;
            if (values != null)
            {
                foreach (var value in values)
                {
                    value.Id = NewId.Next().ToString();
                    value.Номенклатура_Key = value.АналитикаУчетаНоменклатуры?.Номенклатура_Key;
                }

                using var dbContext = _dbContextFactory.CreateDbContext();
                await dbContext.AddRangeAsync(values);
                insertedRows = await dbContext.SaveChangesAsync();
            }

            return insertedRows;
        }
    }
}
