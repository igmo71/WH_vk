using Quartz;
using System.Diagnostics;
using WH.Api.Services;

namespace WH.Api.Jobs.Trash
{
    public class DocumentLastTripleMonthJob<TJob>(
        IDocumentService service,
        ILogger<TJob> logger,
        IJobResultService jobResultService) : IJob
    {
        private readonly IDocumentService _service = service;
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
                await _jobResultService.SetBeginAsync(jobName);
                var serviceResult = await _service.LoadingLastTripleMonthsAsync();
                await _jobResultService.SetEndAsync(jobName);
                var jobDuration = Stopwatch.GetElapsedTime(jobStartTimestamp).TotalSeconds;
                _logger.LogInformation("{Job} {Duration} {@ServiceResult}", jobName, jobDuration, serviceResult);
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "{Message}", ex.Message);
                throw new JobExecutionException(msg: ex.Message, cause: ex, refireImmediately: true) { };
            }
        }
    }
}
