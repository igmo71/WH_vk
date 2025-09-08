using WH.Api.Services.AccumulationRegister;

namespace WH.Api.Jobs.AccumulationRegister
{
    public class AccumulationRegisterГрафикПоступленияТоваровRecordTypeLastTripleMonthJob(
        IAccumulationRegisterГрафикПоступленияТоваровRecordTypeService service,
        ILogger<AccumulationRegisterГрафикПоступленияТоваровRecordTypeLastTripleMonthJob> logger,
        IJobResultService jobResultService)
        : AccumulationRegisterLastTripleMonthJob<AccumulationRegisterГрафикПоступленияТоваровRecordTypeLastTripleMonthJob>(service, logger, jobResultService)
    { }
}
