using Quartz;
using WH.Api.Services;

namespace WH.Api.Jobs.Trash
{
    public class InformationRegisterPeriodicLastPairMonthJob<TJob>(
        IInformationRegisterPeriodicService service,
        ILogger<TJob> logger,
        IJobResultService jobResultService) : IJob
    {
        private readonly IInformationRegisterPeriodicService _service = service;
        private readonly ILogger<TJob> _logger = logger;
        private readonly IJobResultService _jobResultService = jobResultService;

        public async Task Execute(IJobExecutionContext context)
        {
            if (context.RefireCount > 2)
                return;

            try
            {
                string jobName = typeof(TJob).Name;
                await _jobResultService.SetBeginAsync(jobName);
                var serviceResult = await _service.LoadingLastPairMonthsAsync();
                await _jobResultService.SetEndAsync(jobName);
                _logger.LogInformation("{Job} {@ServiceResult}", jobName, serviceResult);
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "{Message}", ex.Message);
                throw new JobExecutionException(msg: ex.Message, cause: ex, refireImmediately: true) { };
            }
        }
    }
}
