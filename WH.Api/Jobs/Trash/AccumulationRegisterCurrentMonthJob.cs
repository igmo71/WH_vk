using Quartz;
using WH.Api.Services;

namespace WH.Api.Jobs.Trash
{
    public abstract class AccumulationRegisterCurrentMonthJob<TJob>(IAccumulationRegisterService service, ILogger<TJob> logger) : IJob
    {
        readonly IAccumulationRegisterService _service = service;
        readonly ILogger<TJob> _logger = logger;

        public async Task Execute(IJobExecutionContext context)
        {
            if (context.RefireCount > 2)
                return;

            try
            {
                var serviceResult = await _service.LoadingCurrentMonthAsync();
                _logger.LogInformation("{Job} {@ServiceResult}", typeof(TJob).Name, serviceResult);
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "{Message}", ex.Message);
                throw new JobExecutionException(msg: ex.Message, cause: ex, refireImmediately: true) { };
            }
        }
    }
}
