using WH.Api.Services.AccumulationRegister;

namespace WH.Api.Jobs.Trash
{
    public class AccumulationRegisterЗакупкиRecordTypeLastPairMonthJob(
        IAccumulationRegisterЗакупкиRecordTypeService service,
        ILogger<AccumulationRegisterЗакупкиRecordTypeLastPairMonthJob> logger,
        IJobResultService jobResultService)
        : AccumulationRegisterLastPairMonthJob<AccumulationRegisterЗакупкиRecordTypeLastPairMonthJob>(service, logger, jobResultService)
    {
    }
}
