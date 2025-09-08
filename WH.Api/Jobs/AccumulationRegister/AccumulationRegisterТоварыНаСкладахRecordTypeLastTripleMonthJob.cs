using WH.Api.Services.AccumulationRegister;

namespace WH.Api.Jobs.AccumulationRegister
{
    public class AccumulationRegisterТоварыНаСкладахRecordTypeLastTripleMonthJob(
        IAccumulationRegisterТоварыНаСкладахRecordTypeService service,
        ILogger<AccumulationRegisterТоварыНаСкладахRecordTypeLastTripleMonthJob> logger,
        IJobResultService jobResultService)
    : AccumulationRegisterLastTripleMonthJob<AccumulationRegisterТоварыНаСкладахRecordTypeLastTripleMonthJob>(service, logger, jobResultService)
    {
    }
}
