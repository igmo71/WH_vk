using WH.Api.Services.AccumulationRegister;

namespace WH.Api.Jobs.Trash
{
    public class AccumulationRegisterТоварыНаСкладахBalanceAndTurnoversPreviousMonthJob(
        IAccumulationRegisterТоварыНаСкладахBalanceAndTurnoversService service,
        ILogger<AccumulationRegisterТоварыНаСкладахBalanceAndTurnoversPreviousMonthJob> logger)
        : AccumulationRegisterPreviousMonthJob<AccumulationRegisterТоварыНаСкладахBalanceAndTurnoversPreviousMonthJob>(service, logger)
    {
    }
}
