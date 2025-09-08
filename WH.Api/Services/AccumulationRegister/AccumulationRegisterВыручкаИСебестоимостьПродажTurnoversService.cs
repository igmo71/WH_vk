using MassTransit;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.AccumulationRegister;
using WH.Domain.Models;
using WH.Domain.Models.AccumulationRegister;
using TEntity = WH.Domain.Models.AccumulationRegister.AccumulationRegisterВыручкаИСебестоимостьПродажTurnovers;

namespace WH.Api.Services.AccumulationRegister
{
    public interface IAccumulationRegisterВыручкаИСебестоимостьПродажTurnoversService : IAccumulationRegisterService
    {
        Task<ServiceResult> GetODataAndDbСуммаВыручкиTurnoverAsync(DateTime date);
    }

    public class AccumulationRegisterВыручкаИСебестоимостьПродажTurnoversService
        : AccumulationRegisterService<TEntity>, IAccumulationRegisterВыручкаИСебестоимостьПродажTurnoversService
    {
        private readonly string _entityName = nameof(AccumulationRegisterВыручкаИСебестоимостьПродажTurnovers);

        public AccumulationRegisterВыручкаИСебестоимостьПродажTurnoversService(
            IODataClient oDataClient,
            IAccumulationRegisterВыручкаИСебестоимостьПродажTurnoversParameters oDataParameters,
            IDbContextFactory<AppDbContext> dbContextFactory,
            ILogger<AccumulationRegisterВыручкаИСебестоимостьПродажTurnoversService> logger,
            IConfiguration configuration)
        : base(oDataClient, oDataParameters, dbContextFactory, logger, configuration)
        { }

        protected override async Task<int> LoadingAsync(DateTime date)
        {
            int insertedRows = 0;

            var getODataTimestamp = Stopwatch.GetTimestamp();
            TEntity[]? values = await GetODataValuesAsync(date);
            var getODataElapsedTime = Stopwatch.GetElapsedTime(getODataTimestamp).TotalSeconds;

            var dbInsertTimestamp = Stopwatch.GetTimestamp();

            if (values != null)
            {
                foreach (var value in values)
                {
                    value.Id = NewId.Next().ToString();
                    value.Date = date;
                    value.Номенклатура_Key = value.АналитикаУчетаНоменклатуры?.Номенклатура_Key;
                    value.Партнер_Key = value.АналитикаУчетаПоПартнерам?.Партнер_Key;
                }
                insertedRows = await InsertRangeAsync(values);
            }
            var dbInsertElapsedTime = Stopwatch.GetElapsedTime(dbInsertTimestamp).TotalSeconds;

            _logger.LogDebug("{Method} {Entity} {Date} {Count} {GetODataElapsedTime} {DBInsertElapsedTime}",
                nameof(LoadingAsync), _entityName, date.ToShortDateString(), values?.Length, getODataElapsedTime, dbInsertElapsedTime);

            return insertedRows;
        }

        public async Task<ServiceResult> GetODataAndDbСуммаВыручкиTurnoverAsync(DateTime date)
        {
            ServiceResult serviceResult = new();
            double? odataSum = null;

            string uri = ((IAccumulationRegisterВыручкаИСебестоимостьПродажTurnoversParameters)_oDataParameters).GetСуммаВыручкиTurnoverUri(date);

            var rootobject = await _oDataClient.GetValuesAsync<Rootobject<СуммаВыручкиTurnover>>(uri);
            if (rootobject?.ODataCount > 0)
                odataSum = rootobject?.Values?[0].Value;

            using var dbContext = _dbContextFactory.CreateDbContext();

            var dbSum = await dbContext.AccumulationRegisterВыручкаИСебестоимостьПродажTurnovers
                .Where(e => e.Date >= date && e.Date < date.AddDays(1))
                .Select(e => e.СуммаВыручки)
                .SumAsync();

            serviceResult.Values["Entity"] = _entityName;
            serviceResult.Values["Date"] = $"{date:d}";
            serviceResult.Values["СуммаВыручкиTurnover OData"] = odataSum ?? 0;
            serviceResult.Values["СуммаВыручкиTurnover DB"] = dbSum;

            _logger.LogDebug("{Method} {Entity} {@ServiceResult}", nameof(GetODataAndDbСуммаВыручкиTurnoverAsync), _entityName, serviceResult);

            return serviceResult;
        }
    }
}
