using Quartz;
using System.Diagnostics;
using WH.Api.DataMining;

namespace WH.Api.Jobs.DataMining
{
    public class DataMiningJob(IDataMiningService service, ILogger<DataMiningJob> logger) : IJob
    {
        private readonly IDataMiningService _service = service;
        private readonly ILogger<DataMiningJob> _logger = logger;

        public async Task Execute(IJobExecutionContext context)
        {
            if (context.RefireCount > 2)
                return;

            try
            {
                var jobStartTimestamp = Stopwatch.GetTimestamp();

                string jobName = nameof(DataMiningJob);

                _logger.LogInformation("{Job} {Begin}", jobName, DateTime.Now);

                var serviceResult = await _service.LoadingPredictsAsync();
                _logger.LogInformation("{Job} {Sevice} {@ServiceResult}", jobName, nameof(_service.LoadingPredictsAsync), serviceResult);

                serviceResult = await _service.LoadingScuSaleRanksAsync();
                _logger.LogInformation("{Job} {Sevice} {@ServiceResult}", jobName, nameof(_service.LoadingScuSaleRanksAsync), serviceResult);

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