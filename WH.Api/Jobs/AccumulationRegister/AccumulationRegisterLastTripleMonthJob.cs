using Quartz;
using System.Diagnostics;
using WH.Api.Services;

namespace WH.Api.Jobs.AccumulationRegister
{
    public class AccumulationRegisterLastTripleMonthJob<TJob>(
        IAccumulationRegisterService service,
        ILogger<TJob> logger,
        IJobResultService jobResultService) : IJob
    {
        private readonly IAccumulationRegisterService _service = service;
        private readonly ILogger<TJob> _logger = logger;
        private readonly IJobResultService _jobResultService = jobResultService;

        public async Task Execute(IJobExecutionContext context)
        {
            if (context.RefireCount > 2)
                return;

            try
            {
                var jobStartTimestamp = Stopwatch.GetTimestamp();

                string jobName = typeof(TJob).Name;

                _logger.LogInformation("{Job} {Begin}", jobName, DateTime.Now);

                await _jobResultService.SetBeginAsync(jobName);

                var serviceResult = await _service.LoadingLastTripleMonthsAsync();

                await _jobResultService.SetEndAsync(jobName);

                _logger.LogInformation("{Job} {End} {Duration} {@ServiceResult}",
                    jobName, DateTime.Now, Stopwatch.GetElapsedTime(jobStartTimestamp), serviceResult);
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "{Message}", ex.Message);
                throw new JobExecutionException(msg: ex.Message, cause: ex, refireImmediately: true);
            }
        }
    }
}
