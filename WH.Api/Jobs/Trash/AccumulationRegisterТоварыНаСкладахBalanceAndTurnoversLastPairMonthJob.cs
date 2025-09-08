using WH.Api.Services.AccumulationRegister;

namespace WH.Api.Jobs.Trash
{
    public class AccumulationRegisterТоварыНаСкладахBalanceAndTurnoversLastPairMonthJob(
        IAccumulationRegisterТоварыНаСкладахBalanceAndTurnoversService service,
        ILogger<AccumulationRegisterТоварыНаСкладахBalanceAndTurnoversLastPairMonthJob> logger,
        IJobResultService jobResultService)
        : AccumulationRegisterLastPairMonthJob<AccumulationRegisterТоварыНаСкладахBalanceAndTurnoversLastPairMonthJob>(service, logger, jobResultService)
    {
    }
}
