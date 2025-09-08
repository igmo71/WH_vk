using MassTransit;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.AccumulationRegister;
using WH.Domain.Models.AccumulationRegister;
using TEntity = WH.Domain.Models.AccumulationRegister.AccumulationRegisterГрафикПоступленияТоваровRecordType;



namespace WH.Api.Services.AccumulationRegister
{
    public interface IAccumulationRegisterГрафикПоступленияТоваровRecordTypeService : IAccumulationRegisterService
    { }

    public class AccumulationRegisterГрафикПоступленияТоваровRecordTypeService
        : AccumulationRegisterService<TEntity>, IAccumulationRegisterГрафикПоступленияТоваровRecordTypeService
    {
        private readonly string _entityName = nameof(AccumulationRegisterГрафикПоступленияТоваровRecordType);

        public AccumulationRegisterГрафикПоступленияТоваровRecordTypeService(IODataClient oDataClient,
            IAccumulationRegisterГрафикПоступленияТоваровRecordTypeParameters oDataParameters,
            IDbContextFactory<AppDbContext> dbContextFactory,
            ILogger<AccumulationRegisterГрафикПоступленияТоваровRecordTypeService> logger,
            IConfiguration configuration)
        : base(oDataClient, oDataParameters, dbContextFactory, logger, configuration)
        {

        }

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
