using MassTransit;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WH.Api.Data;
using WH.Api.OData.ODataParameters.Wms;
using WH.Api.OData.Wms;
using WH.Api.Services.AccumulationRegister;
using TEntity = WH.Domain.Models.Wms.AccumulationRegisterТоварыВЯчейкахBalanceAndTurnovers;



namespace WH.Api.Services.Wms
{
    public interface IAccumulationRegisterТоварыВЯчейкахBalanceAndTurnoversService : IAccumulationRegisterService
    { }

    public class AccumulationRegisterТоварыВЯчейкахBalanceAndTurnoversService
        : AccumulationRegisterService<TEntity>, IAccumulationRegisterТоварыВЯчейкахBalanceAndTurnoversService
    {
        private readonly string _entityName = nameof(AccumulationRegisterТоварыВЯчейкахBalanceAndTurnoversService);

        public AccumulationRegisterТоварыВЯчейкахBalanceAndTurnoversService(
            IWmsODataClient oDataClient,
            IAccumulationRegisterТоварыВЯчейкахBalanceAndTurnoversParameters oDataParameters,
            IDbContextFactory<AppDbContext> dbContextFactory,
            ILogger<AccumulationRegisterService<TEntity>> logger,
            IConfiguration configuration)
            : base(oDataClient, oDataParameters, dbContextFactory, logger, configuration)
        {
        }

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
                }
                insertedRows = await InsertRangeAsync(values);
            }
            var dbInsertElapsedTime = Stopwatch.GetElapsedTime(dbInsertTimestamp).TotalSeconds;

            _logger.LogDebug("{Method} {Entity} {Date} {Count} {GetODataElapsedTime} {DBInsertElapsedTime}",
                nameof(LoadingAsync), _entityName, date.ToShortDateString(), values?.Length, getODataElapsedTime, dbInsertElapsedTime);

            return insertedRows;
        }
    }
}
