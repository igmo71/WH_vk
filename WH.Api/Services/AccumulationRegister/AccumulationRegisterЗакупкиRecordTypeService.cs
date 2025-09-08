using MassTransit;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.AccumulationRegister;
using TEntity = WH.Domain.Models.AccumulationRegister.AccumulationRegisterЗакупкиRecordType;

namespace WH.Api.Services.AccumulationRegister
{
    public interface IAccumulationRegisterЗакупкиRecordTypeService : IAccumulationRegisterService
    { }

    public class AccumulationRegisterЗакупкиRecordTypeService
        : AccumulationRegisterService<TEntity>, IAccumulationRegisterЗакупкиRecordTypeService
    {
        private readonly string _entityName = nameof(AccumulationRegisterЗакупкиRecordTypeService);

        public AccumulationRegisterЗакупкиRecordTypeService(
            IODataClient oDataClient,
            IAccumulationRegisterЗакупкиRecordTypeParameters oDataParameters,
            IDbContextFactory<AppDbContext> dbContextFactory,
            ILogger<AccumulationRegisterЗакупкиRecordTypeService> logger,
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
                        //value.Id = $"{value.Recorder}_{value.LineNumber}";
                        value.Id = NewId.Next().ToString();
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
