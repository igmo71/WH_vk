using Quartz;
using System.Diagnostics;
using WH.Api.Services.Awesome;

namespace WH.Api.Jobs.Awesome
{
    public class AwesomeТоварыНаСкладахRecordTypeОперацияЦеныLastTripleMonthJob : IJob
    {
        private readonly IAwesomeТоварыНаСкладахRecordTypeОперацияЦеныService _service;
        private readonly ILogger<AwesomeТоварыНаСкладахRecordTypeОперацияЦеныLastTripleMonthJob> _logger;
        private readonly IJobResultService _jobResultService;

        public AwesomeТоварыНаСкладахRecordTypeОперацияЦеныLastTripleMonthJob(
            IAwesomeТоварыНаСкладахRecordTypeОперацияЦеныService service,
            ILogger<AwesomeТоварыНаСкладахRecordTypeОперацияЦеныLastTripleMonthJob> logger,
            IJobResultService jobResultService)
        {
            _service = service;
            _logger = logger;
            _jobResultService = jobResultService;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            if (context.RefireCount > 2)
                return;

            try
            {
                var jobStartTimestamp = Stopwatch.GetTimestamp();

                string jobName = nameof(AwesomeТоварыНаСкладахRecordTypeОперацияЦеныLastTripleMonthJob);

                _logger.LogInformation("{Job} {Begin}", jobName, DateTime.Now);

                await _jobResultService.SetBeginAsync(jobName);

                var serviceResult = await _service.LoadingLastTripleMonthsAsync();

                await _jobResultService.SetEndAsync(jobName);

                _logger.LogInformation("{Job} {End} {Duration} {@ServiceResult}",
                    jobName, DateTime.Now, Stopwatch.GetElapsedTime(jobStartTimestamp), serviceResult);
            }
            catch (Exception ex)
            {
                throw new JobExecutionException(msg: ex.Message, cause: ex, refireImmediately: true);
            }
        }
    }
}
