using Quartz;
using System.Diagnostics;
using WH.Api.Services.Catalog;

namespace WH.Api.Jobs.Catalog
{
    public class CatalogsAllJob(
        ILogger<CatalogsAllJob> logger,
        ICatalogsAllService catalogsAllService,
        IJobResultService jobResultService) : IJob
    {
        private readonly ILogger<CatalogsAllJob> _logger = logger;
        private readonly ICatalogsAllService _catalogsAllService = catalogsAllService;
        private readonly IJobResultService _jobResultService = jobResultService;

        public async Task Execute(IJobExecutionContext context)
        {

            if (context.RefireCount > 2)
                return;

            try
            {
                var jobStartTimestamp = Stopwatch.GetTimestamp();

                string jobName = nameof(CatalogsAllJob);

                _logger.LogInformation("{Job} {Begin}", jobName, DateTime.Now);

                await _jobResultService.SetBeginAsync(jobName);

                var serviceResult = await _catalogsAllService.LoadingAsync();

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
