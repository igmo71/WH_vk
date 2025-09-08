using Quartz;
using System.Diagnostics;
using WH.Api.Voximplant;

namespace WH.Api.Jobs.Call
{
    public class VoximplantCurrentMonthJob(IVoximplantService service, ILogger<VoximplantCurrentMonthJob> logger) : IJob
    {
        private readonly IVoximplantService _service = service;
        private readonly ILogger<VoximplantCurrentMonthJob> _logger = logger;

        public async Task Execute(IJobExecutionContext context)
        {
            if (context.RefireCount > 2)
                return;

            try
            {
                var jobStartTimestamp = Stopwatch.GetTimestamp();

                string jobName = nameof(VoximplantCurrentMonthJob);

                _logger.LogInformation("{Job} {Begin}", jobName, DateTime.Now);

                var serviceResult = await _service.LoadingCurrentMonthAsync();

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
