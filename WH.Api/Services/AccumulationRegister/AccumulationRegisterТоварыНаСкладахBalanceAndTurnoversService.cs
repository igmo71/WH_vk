using MassTransit;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.AccumulationRegister;
using WH.Domain.Models;
using WH.Domain.Models.AccumulationRegister;
using TEntity = WH.Domain.Models.AccumulationRegister.AccumulationRegisterТоварыНаСкладахBalanceAndTurnovers;

namespace WH.Api.Services.AccumulationRegister
{
    public interface IAccumulationRegisterТоварыНаСкладахBalanceAndTurnoversService : IAccumulationRegisterService
    {
        Task<ServiceResult> GetODataAndDbClosingBalanceAsync(DateTime date);
    }

    public class AccumulationRegisterТоварыНаСкладахBalanceAndTurnoversService
        : AccumulationRegisterService<TEntity>, IAccumulationRegisterТоварыНаСкладахBalanceAndTurnoversService
    {
        private readonly string _entityName = nameof(AccumulationRegisterТоварыНаСкладахBalanceAndTurnoversService);

        public AccumulationRegisterТоварыНаСкладахBalanceAndTurnoversService(
            IODataClient oDataClient,
            IAccumulationRegisterТоварыНаСкладахBalanceAndTurnoversParameters oDataParameters,
            IDbContextFactory<AppDbContext> dbContextFactory,
            ILogger<AccumulationRegisterТоварыНаСкладахBalanceAndTurnoversService> logger,
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
                }
                insertedRows = await InsertRangeAsync(values);
            }
            var dbInsertElapsedTime = Stopwatch.GetElapsedTime(dbInsertTimestamp).TotalSeconds;

            _logger.LogDebug("{Method} {Entity} {Date} {Count} {GetODataElapsedTime} {DBInsertElapsedTime}",
                nameof(LoadingAsync), _entityName, date.ToShortDateString(), values?.Length, getODataElapsedTime, dbInsertElapsedTime);

            return insertedRows;
        }

        public async Task<ServiceResult> GetODataAndDbClosingBalanceAsync(DateTime date)
        {
            ServiceResult serviceResult = new();
            double? odataSum = null;

            string uri = ((IAccumulationRegisterТоварыНаСкладахBalanceAndTurnoversParameters)_oDataParameters).GetClosingBalance(date);

            var rootobject = await _oDataClient.GetValuesAsync<Rootobject<ВНаличииClosingBalance>>(uri);
            if (rootobject?.ODataCount > 0)
                odataSum = rootobject?.Values?[0].Value;

            using var dbContext = _dbContextFactory.CreateDbContext();

            var dbSum = await dbContext.AccumulationRegisterТоварыНаСкладахBalanceAndTurnovers
                .Where(e => e.Date >= date && e.Date < date.AddDays(1))
                .Select(e => e.ВНаличииClosingBalance)
                .SumAsync();

            serviceResult.Values["Entity"] = _entityName;
            serviceResult.Values["Date"] = $"{date:d}";
            serviceResult.Values["ClosingBalance OData"] = odataSum ?? 0;
            serviceResult.Values["ClosingBalance DB"] = dbSum;

            _logger.LogDebug("{Method} {Entity} {@ServiceResult}", nameof(GetODataAndDbClosingBalanceAsync), _entityName, serviceResult);

            return serviceResult;
        }
    }
}
