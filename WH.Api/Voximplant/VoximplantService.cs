using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WH.Api.Common;
using WH.Api.Data;
using WH.Api.Services;
using WH.Domain.Models.Call;
using Model = WH.Domain.Models.Call;

namespace WH.Api.Voximplant
{
    public interface IVoximplantService : ILoadingByDateService
    { }

    public class VoximplantService : IVoximplantService
    {
        private readonly IVoximplantClient _client;
        private readonly IVoximplantParameters _parameters;
        private readonly IDbContextFactory<AppDbContext> _dbContextFactory;
        private readonly ILogger<VoximplantService> _logger;

        private readonly string _entityName = typeof(CallItem).Name;

        public VoximplantService(IVoximplantClient client, IVoximplantParameters parameters, IDbContextFactory<AppDbContext> dbContextFactory, ILogger<VoximplantService> logger)
        {
            _client = client;
            _parameters = parameters;
            _dbContextFactory = dbContextFactory;
            _logger = logger;
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

        private async Task<int> LoadingAsync(DateTime date)
        {
            int skip = 0;
            int total = 0;
            int insertedRows = 0;

            var startTimestamp = Stopwatch.GetTimestamp();

            do
            {
                string uri = _parameters.GetUri(date, skip);
                var result = await _client.GetValuesAsync<Model.Voximplant>(uri);

                if (result != null)
                {
                    total = result.Total;

                    if (result.CallItems != null)
                    {
                        insertedRows += await InsertRangeAsync(result.CallItems);
                    }
                }
                skip += 50;

            } while (skip < total);


            _logger.LogDebug("{Method} {Entity} {Date} {ElapsedTime}",
                nameof(LoadingAsync), _entityName, date.ToShortDateString(), Stopwatch.GetElapsedTime(startTimestamp).TotalSeconds);

            return insertedRows;
        }

        public async Task<int> DeleteRangeAsync(DateTime begin, DateTime end)
        {
            using var dbContext = _dbContextFactory.CreateDbContext();
            return await dbContext.Set<CallItem>().Where(e => e.CallStartDate >= begin && e.CallStartDate < end).ExecuteDeleteAsync();
        }

        private async Task<int> InsertRangeAsync(CallItem[] values)
        {
            using var dbContext = _dbContextFactory.CreateDbContext();
            await dbContext.AddRangeAsync(values);
            return await dbContext.SaveChangesAsync();
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
            var result = new List<ServiceResult>
            {
                await LoadingPrePreviousMonthAsync(),
                await LoadingPreviousMonthAsync(),
                await LoadingCurrentMonthAsync()
            };

            return result;
        }
    }
}
