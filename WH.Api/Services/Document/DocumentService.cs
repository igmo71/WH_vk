using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WH.Api.Common;
using WH.Api.Data;
using WH.Api.OData;
using WH.Domain.Models;

namespace WH.Api.Services.Document
{
    public abstract class DocumentService<TEntity> : IDocumentService
        where TEntity : Entity, IHaveDate
    {
        protected readonly IODataClient _oDataClient;
        protected readonly IODataParameters _oDataParameters;
        protected readonly IDbContextFactory<AppDbContext> _dbContextFactory;
        protected readonly ILogger<IDocumentService> _logger;
        protected readonly IConfiguration _configuration;

        private readonly string _entityName = typeof(TEntity).Name;

        public DocumentService(
            IODataClient oDataClient,
            IODataParameters oDataParameters,
            IDbContextFactory<AppDbContext> dbContextFactory,
            ILogger<IDocumentService> logger,
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

        public async Task<ServiceResult> LoadingAsync(int year, int month)
        {
            var (begin, end) = DateHelper.GetPeriodBy(year, month);
            return await LoadingAsync(begin, end);
        }

        public async Task<ServiceResult> LoadingAsync(int lastDays)
        {
            var (begin, end) = DateHelper.GetPeriodBy(lastDays);
            return await LoadingAsync(begin, end);
        }

        public async Task<ServiceResult> LoadingCurrentMonthAsync()
        {
            var (begin, end) = DateHelper.GetCurrentMonth();
            return await LoadingAsync(begin, end);
        }

        public async Task<ServiceResult> LoadingPreviousMonthAsync()
        {
            var (begin, end) = DateHelper.GetPreviousMonth();
            return await LoadingAsync(begin, end);
        }

        public async Task<ServiceResult> LoadingPrePreviousMonthAsync()
        {
            var (begin, end) = DateHelper.GetPrePreviousMonth();
            return await LoadingAsync(begin, end);
        }

        public async Task<List<ServiceResult>> LoadingLastPairMonthsAsync()
        {
            var result = new List<ServiceResult>
            {
                await LoadingPreviousMonthAsync(),
                await LoadingCurrentMonthAsync()
            };

            return result;
        }

        public async Task<List<ServiceResult>> LoadingLastTripleMonthsAsync()
        {
            var (begin, end) = DateHelper.GetLastTripleMonth();

            var result = new List<ServiceResult>()
            {
                await LoadingAsync(begin, end)
            };

            return result;
        }

        private async Task<int> LoadingAsync(DateTime date)
        {
            int insertedRows = 0;

            var getODataTimestamp = Stopwatch.GetTimestamp();
            TEntity[]? values = await GetODataValuesAsync(date);
            var getODataElapsedTime = Stopwatch.GetElapsedTime(getODataTimestamp).TotalSeconds;

            var dbInsertTimestamp = Stopwatch.GetTimestamp();
            if (values != null)
            {
                insertedRows = await InsertRangeAsync(values);
            }
            var dbInsertElapsedTime = Stopwatch.GetElapsedTime(dbInsertTimestamp).TotalSeconds;

            _logger.LogDebug("{Method} {Entity} {Date} {Count} {GetODataElapsedTime} {DBInsertElapsedTime}",
                nameof(LoadingAsync), _entityName, date.ToShortDateString(), values?.Length, getODataElapsedTime, dbInsertElapsedTime);

            return insertedRows;
        }

        private async Task<TEntity[]?> GetODataValuesAsync(DateTime date)
        {
            string uri = _oDataParameters.GetUri(date, date.AddDays(1));
            var rootobject = await _oDataClient.GetValuesAsync<Rootobject<TEntity>>(uri);
            var values = rootobject?.Values;
            return values;
        }

        public async Task<int> DeleteRangeAsync(DateTime begin, DateTime end)
        {
            using var dbContext = _dbContextFactory.CreateDbContext();
            dbContext.Database.SetCommandTimeout(180);
            return await dbContext.Set<TEntity>().Where(e => e.Date >= begin && e.Date < end).ExecuteDeleteAsync();
        }

        private async Task<int> InsertRangeAsync(TEntity[] values)
        {
            using var dbContext = _dbContextFactory.CreateDbContext();
            await dbContext.AddRangeAsync(values);
            return await dbContext.SaveChangesAsync();
        }

        public async Task<ServiceResult> GetODataAndDbCountAsync(DateTime begin, DateTime end)
        {
            ServiceResult serviceResult = new();

            string uri = _oDataParameters.GetCountUri(begin, end);

            int? odataCount = await _oDataClient.GetValuesAsync<int>(uri);

            using var dbContext = _dbContextFactory.CreateDbContext();

            int? dbCount = await dbContext.Set<TEntity>().Where(e => e.Date >= begin && e.Date < end).CountAsync();

            serviceResult.Values["Entity"] = _entityName;
            serviceResult.Values["Period"] = $"{begin:d}-{end:d}";
            serviceResult.Values["Count OData"] = odataCount ?? 0;
            serviceResult.Values["Count DB"] = dbCount;

            _logger.LogDebug("{Method} {Entity} {@ServiceResult}", nameof(GetODataAndDbCountAsync), _entityName, serviceResult);

            return serviceResult;
        }
    }
}
