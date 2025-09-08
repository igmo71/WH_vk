
using MassTransit;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.Trash;
using WH.Api.Services.AccumulationRegister;
using WH.Domain.Models.AccumulationRegister;
using TEntity = WH.Domain.Models.AccumulationRegister.AccumulationRegisterСебестоимостьТоваровBalanceAndTurnovers;

namespace WH.Api.Services.Trash
{
    public interface IAccumulationRegisterСебестоимостьТоваровBalanceAndTurnoversService : IAccumulationRegisterService
    { }

    public class AccumulationRegisterСебестоимостьТоваровBalanceAndTurnoversService
        : AccumulationRegisterService<TEntity>, IAccumulationRegisterСебестоимостьТоваровBalanceAndTurnoversService
    {
        private readonly string _entityName = nameof(AccumulationRegisterСебестоимостьТоваровBalanceAndTurnovers);

        public AccumulationRegisterСебестоимостьТоваровBalanceAndTurnoversService(
            IODataClient oDataClient,
            IAccumulationRegisterСебестоимостьТоваровBalanceAndTurnoversParameters oDataParameters,
            IDbContextFactory<AppDbContext> dbContextFactory,
            ILogger<AccumulationRegisterСебестоимостьТоваровBalanceAndTurnoversService> logger,
            IConfiguration configuration)
        : base(oDataClient, oDataParameters, dbContextFactory, logger, configuration)
        { }

        protected override async Task<int> LoadingAsync(DateTime date)
        {
            int insertedRows = 0;
            int? odataCount = await GetODataCountAsync(date);
            int iterations = _oDataParameters.GetIterationsCount(odataCount);

            for (int i = 0; i < iterations; i++)
            {
                var getODataTimestamp = Stopwatch.GetTimestamp();
                TEntity[]? values = await GetODataValuesAsync(date, i);
                var getODataElapsedTime = Stopwatch.GetElapsedTime(getODataTimestamp).TotalSeconds;

                var dbInsertTimestamp = Stopwatch.GetTimestamp();
                if (values != null)
                {
                    foreach (var value in values)
                    {
                        value.Id = NewId.Next().ToString();
                        value.Date = date;
                        value.Номенклатура_Key = value.АналитикаУчетаНоменклатуры?.Номенклатура_Key;
                    }
                    insertedRows += await InsertRangeAsync(values);
                }
                var dbInsertElapsedTime = Stopwatch.GetElapsedTime(dbInsertTimestamp).TotalSeconds;

                _logger.LogDebug("{Method} {Entity} {Date} {i}/{iterations} {Count} {GetODataElapsedTime} {DBInsertElapsedTime}",
                    nameof(LoadingAsync), _entityName, date.ToShortDateString(), i + 1, iterations, values?.Length, getODataElapsedTime, dbInsertElapsedTime);
            }

            return insertedRows;
        }
    }
}
