using WH.Api.Services.AccumulationRegister;

namespace WH.Api.Jobs.Trash
{
    public class AccumulationRegisterТоварыНаСкладахBalanceAndTurnoversCurrentMonthJob(
        IAccumulationRegisterТоварыНаСкладахBalanceAndTurnoversService service,
        ILogger<AccumulationRegisterТоварыНаСкладахBalanceAndTurnoversCurrentMonthJob> logger)
        : AccumulationRegisterCurrentMonthJob<AccumulationRegisterТоварыНаСкладахBalanceAndTurnoversCurrentMonthJob>(service, logger)
    {
    }
}
