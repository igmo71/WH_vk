using WH.Api.Services.AccumulationRegister;

namespace WH.Api.Jobs.AccumulationRegister
{
    public class AccumulationRegisterТоварыНаСкладахBalanceLastTripleMonthJob(
        IAccumulationRegisterТоварыНаСкладахBalanceService service,
        ILogger<AccumulationRegisterТоварыНаСкладахBalanceLastTripleMonthJob> logger,
        IJobResultService jobResultService)
        : AccumulationRegisterLastTripleMonthJob<AccumulationRegisterТоварыНаСкладахBalanceLastTripleMonthJob>(service, logger, jobResultService)
    {
    }
}
