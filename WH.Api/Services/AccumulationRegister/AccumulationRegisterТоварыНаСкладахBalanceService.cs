
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WH.Api.Common;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.AccumulationRegister;
using WH.Domain.Models;
using WH.Domain.Models.AccumulationRegister;

namespace WH.Api.Services.AccumulationRegister
{
    public interface IAccumulationRegisterТоварыНаСкладахBalanceService : IAccumulationRegisterService
    {

    }

    public class AccumulationRegisterТоварыНаСкладахBalanceService : IAccumulationRegisterТоварыНаСкладахBalanceService
    {
        protected readonly IODataClient _oDataClient;
        protected readonly IAccumulationRegisterТоварыНаСкладахBalanceParameters _oDataParameters;
        protected readonly IDbContextFactory<AppDbContext> _dbContextFactory;
        protected readonly ILogger<AccumulationRegisterТоварыНаСкладахBalance> _logger;
        protected readonly IConfiguration _configuration;

        private readonly string _entityName = typeof(AccumulationRegisterТоварыНаСкладахBalance).Name;

        public AccumulationRegisterТоварыНаСкладахBalanceService(
            IODataClient oDataClient,
            IAccumulationRegisterТоварыНаСкладахBalanceParameters oDataParameters,
            IDbContextFactory<AppDbContext> dbContextFactory,
            ILogger<AccumulationRegisterТоварыНаСкладахBalance> logger,
            IConfiguration configuration)
        {
            _oDataClient = oDataClient;
            _oDataParameters = oDataParameters;
            _dbContextFactory = dbContextFactory;
            _logger = logger;
            _configuration = configuration;
        }

        public async Task<ServiceResult> LoadingAsync(DateTime begin, DateTime end)
        {
            ServiceResult serviceResult = new();

            var loadingTimestamp = Stopwatch.GetTimestamp();

            await DeleteRangeAsync(begin, end);

            var currentDay = begin;

            int insertedRows = 0;

            while (currentDay < end)
            {
                insertedRows += await LoadingAsync(currentDay);

                currentDay = currentDay.AddDays(1);
            }

            serviceResult.Values["Entity"] = _entityName;
            serviceResult.Values["Period"] = $"{begin:d}-{end:d}";
            serviceResult.Values["Duration"] = Stopwatch.GetElapsedTime(loadingTimestamp);
            serviceResult.Values["InsertedRows"] = insertedRows;

            _logger.LogInformation("{Method} {Entity} {@ServiceResult}", nameof(LoadingAsync), _entityName, serviceResult);

            return serviceResult;
        }

        public async Task<int> DeleteRangeAsync(DateTime begin, DateTime end)
        {
            using var dbContext = _dbContextFactory.CreateDbContext();
            dbContext.Database.SetCommandTimeout(180);
            return await dbContext.Set<AccumulationRegisterТоварыНаСкладахBalance>()
                .Where(e => e.Date >= begin && e.Date < end)
                .ExecuteDeleteAsync();
        }

        private async Task<int> LoadingAsync(DateTime date)
        {
            int insertedRows = 0;
            var getODataTimestamp = Stopwatch.GetTimestamp();
            AccumulationRegisterТоварыНаСкладахBalance[]? values = await GetODataValuesAsync(date);
            var getODataElapsedTime = Stopwatch.GetElapsedTime(getODataTimestamp).TotalSeconds;

            var dbInsertTimestamp = Stopwatch.GetTimestamp();
            if (values != null)
            {
                foreach (var value in values)
                    value.Date = date;
                insertedRows = await InsertRangeAsync(values);
            }
            var dbInsertElapsedTime = Stopwatch.GetElapsedTime(dbInsertTimestamp).TotalSeconds;

            _logger.LogDebug("{Method} {Entity} {Date} {Count} {GetODataElapsedTime} {DBInsertElapsedTime}",
                nameof(LoadingAsync), _entityName, date.ToShortDateString(), values?.Length, getODataElapsedTime, dbInsertElapsedTime);

            return insertedRows;
        }

        private async Task<AccumulationRegisterТоварыНаСкладахBalance[]?> GetODataValuesAsync(DateTime date)
        {
            string uri = _oDataParameters.GetUri(date);
            var rootobject = await _oDataClient.GetValuesAsync<Rootobject<AccumulationRegisterТоварыНаСкладахBalance>>(uri);
            var values = rootobject?.Values;
            return values;
        }

        private async Task<int> InsertRangeAsync(AccumulationRegisterТоварыНаСкладахBalance[] values)
        {
            using var dbContext = _dbContextFactory.CreateDbContext();
            await dbContext.AddRangeAsync(values);
            return await dbContext.SaveChangesAsync();
        }

        public Task<ServiceResult> LoadingAsync(int year, int month)
        {
            var (begin, end) = DateHelper.GetPeriodBy(year, month);
            return LoadingAsync(begin, end);
        }

        public Task<ServiceResult> LoadingAsync(int lastDays)
        {
            throw new NotImplementedException();
        }

        public Task<List<ServiceResult>> LoadingLastPairMonthsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<ServiceResult>> LoadingLastTripleMonthsAsync()
        {
            var result = new List<ServiceResult>
            {
                await LoadingPrePreviousMonthAsync(),
                await LoadingPreviousMonthAsync(),
                await LoadingCurrentMonthAsync()
            };

            return result;
        }

        private Task<ServiceResult> LoadingPrePreviousMonthAsync()
        {
            var (begin, end) = DateHelper.GetPrePreviousMonth();
            return LoadingAsync(begin, end);
        }

        public Task<ServiceResult> LoadingPreviousMonthAsync()
        {
            var (begin, end) = DateHelper.GetPreviousMonth();
            return LoadingAsync(begin, end);
        }

        public Task<ServiceResult> LoadingCurrentMonthAsync()
        {
            var (begin, end) = DateHelper.GetCurrentMonth();
            return LoadingAsync(begin, end);
        }

        public Task<ServiceResult> GetODataAndDbCountAsync(DateTime begin, DateTime end)
        {
            throw new NotImplementedException();
        }
    }
}
