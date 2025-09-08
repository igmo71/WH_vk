using WH.Api.Services.AccumulationRegister;

namespace WH.Api.Jobs.AccumulationRegister
{
    public class AccumulationRegisterЗакупкиRecordTypeLastTripleMonthJob(
        IAccumulationRegisterЗакупкиRecordTypeService service,
        ILogger<AccumulationRegisterЗакупкиRecordTypeLastTripleMonthJob> logger,
        IJobResultService jobResultService)
        : AccumulationRegisterLastTripleMonthJob<AccumulationRegisterЗакупкиRecordTypeLastTripleMonthJob>(service, logger, jobResultService)
    {
    }
}
