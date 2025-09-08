using Quartz;
using System.Diagnostics;
using WH.Api.Services.Document;

namespace WH.Api.Jobs.Document
{
    public class DocumentsAllJob(
        ILogger<DocumentsAllJob> logger,
        IDocumentsAllService documentsAllService,
        IJobResultService jobResultService) : IJob
    {
        private readonly ILogger<DocumentsAllJob> _logger = logger;
        private readonly IDocumentsAllService _documentsAllService = documentsAllService;
        private readonly IJobResultService _jobResultService = jobResultService;

        public async Task Execute(IJobExecutionContext context)
        {

            if (context.RefireCount > 2)
                return;

            try
            {
                var jobStartTimestamp = Stopwatch.GetTimestamp();

                string jobName = nameof(DocumentsAllJob);

                _logger.LogInformation("{Job} {Begin}", jobName, DateTime.Now);

                await _jobResultService.SetBeginAsync(jobName);

                var serviceResult = await _documentsAllService.LoadingLastTripleMonthsAsync();

                await _jobResultService.SetEndAsync(jobName);

                _logger.LogInformation("{Job} {End} {Duration} {@ServiceResult}",
                    jobName, DateTime.Now, Stopwatch.GetElapsedTime(jobStartTimestamp), serviceResult);
            }
            catch (Exception ex)
            {
                throw new JobExecutionException(msg: ex.Message, cause: ex, refireImmediately: true) { };
            }
        }
    }
}
