using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WH.Api.Common;
using WH.Api.Data;
using WH.Domain.Models.Awesome;

namespace WH.Api.Services.Awesome
{
    public interface IAwesomeТоварыНаСкладахRecordTypeОперацияЦеныService
    {
        Task<ServiceResult> LoadingAsync(DateTime dateBegin, DateTime dateEnd);
        Task<ServiceResult> LoadingAsync(int year, int month);
        Task<List<ServiceResult>> LoadingLastTripleMonthsAsync();
    }

    public class AwesomeТоварыНаСкладахRecordTypeОперацияЦеныService : IAwesomeТоварыНаСкладахRecordTypeОперацияЦеныService
    {
        private readonly IDbContextFactory<AppDbContext> _dbContextFactory;
        private readonly ILogger<AwesomeТоварыНаСкладахRecordTypeОперацияЦеныService> _logger;

        public AwesomeТоварыНаСкладахRecordTypeОперацияЦеныService(
            IDbContextFactory<AppDbContext> dbContextFactory,
            ILogger<AwesomeТоварыНаСкладахRecordTypeОперацияЦеныService> logger,
            IConfiguration configuration)
        {
            _dbContextFactory = dbContextFactory;
            _logger = logger;
        }

        public async Task<ServiceResult> LoadingAsync(DateTime dateBegin, DateTime dateEnd)
        {
            ServiceResult serviceResult = new();

            var startTimestamp = Stopwatch.GetTimestamp();

            using var appDbContext = _dbContextFactory.CreateDbContext();

            appDbContext.Database.SetCommandTimeout(180);

            var vТоварыНаСкладахBalanceAndTurnoversNoWhs = await appDbContext.VТоварыНаСкладахBalanceAndTurnoversNoWhs
                .AsNoTracking()
                .Where(e => e.Date >= dateBegin && e.Date < dateEnd
                    && (e.ВНаличииOpeningBalance != 0 || e.ВНаличииTurnover != 0 || e.ВНаличииReceipt != 0 || e.ВНаличииExpense != 0)
                )
                .ToArrayAsync();

            string?[] distinctНоменклатураKey = vТоварыНаСкладахBalanceAndTurnoversNoWhs
                .Select(e => e.Номенклатура_Key)
                .Distinct()
                .ToArray();

            var vТоварыНаСкладахRecordTypeОперацияЦеныOp = await appDbContext.VТоварыНаСкладахRecordTypeОперацияЦеныOp
                .AsNoTracking()
                .Where(e => e.Date >= dateBegin && e.Date < dateEnd)
                .ToArrayAsync();

            var yesterdayAwesomeТоварыНаСкладахRecordTypeОперацияЦены = await appDbContext.AwesomeТоварыНаСкладахRecordTypeОперацияЦены
                .AsNoTracking()
                .Where(e => e.Date == dateBegin.AddDays(-1) && e.ВНаличии != 0)
                .ToArrayAsync();

            appDbContext.AwesomeТоварыНаСкладахRecordTypeОперацияЦены
                .Where(e => e.Date >= dateBegin.AddDays(-1))
                .ExecuteDelete();

            List<Task<List<AwesomeТоварыНаСкладахRecordTypeОперацияЦены>>> loadingTasks = [];

            foreach (var номенклатураKey in distinctНоменклатураKey)
            {
                loadingTasks.Add(Task.Run(() =>
                {
                    var awesomeТоварыНаСкладахRecordTypeОперацияЦены = new List<AwesomeТоварыНаСкладахRecordTypeОперацияЦены>();

                    foreach (var yesterdayItem in yesterdayAwesomeТоварыНаСкладахRecordTypeОперацияЦены.Where(e => e.Номенклатура_Key == номенклатураKey))
                    {
                        awesomeТоварыНаСкладахRecordTypeОперацияЦены.Add(yesterdayItem);
                    }

                    foreach (var recordTypeItem in vТоварыНаСкладахRecordTypeОперацияЦеныOp.Where(e => e.Номенклатура_Key == номенклатураKey).OrderBy(e => e.Date))
                    {
                        awesomeТоварыНаСкладахRecordTypeОперацияЦены.Add(AwesomeТоварыНаСкладахRecordTypeОперацияЦены.From(recordTypeItem));
                    }

                    foreach (var balanceAndTurnoversItem in vТоварыНаСкладахBalanceAndTurnoversNoWhs.Where(e => e.Номенклатура_Key == номенклатураKey).OrderBy(e => e.Date))
                    {
                        var yesterdayData = awesomeТоварыНаСкладахRecordTypeОперацияЦены
                            .Where(e =>
                                e != null &&
                                e.Date == balanceAndTurnoversItem.Date.AddDays(-1) &&
                                e.Номенклатура_Key == balanceAndTurnoversItem.Номенклатура_Key &&
                                e.RecordType == "Receipt" &&
                                e.ЦенаЗакупки != null)
                            .ToList();

                        if (yesterdayData == null || yesterdayData.Count == 0)
                            continue;

                        Func<AwesomeТоварыНаСкладахRecordTypeОперацияЦены, bool> yesterdayPriceIsNormal = e => e.ЦенаЗакупки != null && double.IsNormal((double)e.ЦенаЗакупки);
                        
                        var yesterdayPriceAvg = yesterdayData.Where(yesterdayPriceIsNormal).Sum(e => e.ЦенаЗакупки) / yesterdayData.Where(yesterdayPriceIsNormal).Count();
                        
                        var yesterdayCostPrice = yesterdayData.Sum(v => v.Количество * v.ЦенаЗакупки);
                        
                        var yesterdayCount = yesterdayData.Sum(v => v.Количество);

                        double? price = yesterdayCount == 0 ? yesterdayPriceAvg : yesterdayCostPrice / yesterdayCount;

                        if (price != null && !double.IsNormal((double)price))
                        {
                            _logger.LogWarning("AwesomeТоварыНаСкладахRecordTypeОперацияЦеныService LoadAsync - Price NOT Is Normal {Price} {@YesterdayData}", price, yesterdayData);
                            continue;
                        }

                        awesomeТоварыНаСкладахRecordTypeОперацияЦены.Add(AwesomeТоварыНаСкладахRecordTypeОперацияЦены.From(balanceAndTurnoversItem, price));
                    }

                    return awesomeТоварыНаСкладахRecordTypeОперацияЦены;
                }));
            }

            while (loadingTasks.Count > 0)
            {
                Task<List<AwesomeТоварыНаСкладахRecordTypeОперацияЦены>> completedTask = await Task.WhenAny(loadingTasks);

                var loadedТоварыНаСкладахRecordTypeОперацияЦены = await completedTask;

                await appDbContext.AwesomeТоварыНаСкладахRecordTypeОперацияЦены.AddRangeAsync(loadedТоварыНаСкладахRecordTypeОперацияЦены);

                loadingTasks.Remove(completedTask);
            }

            int savedCount = appDbContext.SaveChanges();

            serviceResult.Values["Entity"] = "AwesomeТоварыНаСкладахRecordTypeОперацияЦены";
            serviceResult.Values["Period"] = $"{dateBegin:d}-{dateEnd:d}";
            serviceResult.Values["Duration"] = Stopwatch.GetElapsedTime(startTimestamp);
            serviceResult.Values["SavedCount"] = savedCount;

            _logger.LogDebug("AwesomeТоварыНаСкладахRecordTypeОперацияЦеныService LoadAsync {DateBegin} - {DateEnd} Saved {SavedCount} in {ElapsedTime}",
                    dateBegin, dateEnd, savedCount, serviceResult.Values);

            return serviceResult;
        }

        public async Task<ServiceResult> LoadingAsync(int year, int month)
        {
            var (begin, end) = DateHelper.GetPeriodBy(year, month);
            return await LoadingAsync(begin, end);
        }

        public async Task<List<ServiceResult>> LoadingLastTripleMonthsAsync()
        {
            var entity = nameof(AwesomeТоварыНаСкладахRecordTypeОперацияЦеныService);
            var method = nameof(LoadingLastTripleMonthsAsync);
            var result = new List<ServiceResult>();

            (DateTime begin, DateTime end) prePreviousMonth = DateHelper.GetPrePreviousMonth();
            (DateTime begin, DateTime end) previousMonth = DateHelper.GetPreviousMonth();
            (DateTime begin, DateTime end) currentMonth = DateHelper.GetCurrentMonth();

            _logger.LogDebug("{Entity} {Method} - Start", entity, method);

            result.Add(await LoadingAsync(prePreviousMonth.begin, prePreviousMonth.end));
            result.Add(await LoadingAsync(previousMonth.begin, previousMonth.end));
            result.Add(await LoadingAsync(currentMonth.begin, currentMonth.end));

            _logger.LogDebug("{Entity} {Method} - Ok", entity, method);

            return result;
        }
    }
}
