using WH.Api.Services.AccumulationRegister;

namespace WH.Api.Jobs.AccumulationRegister
{
    public class AccumulationRegisterТоварыНаСкладахBalanceAndTurnoversLastTripleMonthJob(
        IAccumulationRegisterТоварыНаСкладахBalanceAndTurnoversService service,
        ILogger<AccumulationRegisterТоварыНаСкладахBalanceAndTurnoversLastTripleMonthJob> logger,
        IJobResultService jobResultService)
        : AccumulationRegisterLastTripleMonthJob<AccumulationRegisterТоварыНаСкладахBalanceAndTurnoversLastTripleMonthJob>(service, logger, jobResultService)
    {
    }
}
