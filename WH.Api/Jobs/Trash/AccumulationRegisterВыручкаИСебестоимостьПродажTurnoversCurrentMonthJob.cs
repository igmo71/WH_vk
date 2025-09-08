using WH.Api.Services.AccumulationRegister;

namespace WH.Api.Jobs.Trash
{
    public class AccumulationRegisterВыручкаИСебестоимостьПродажTurnoversCurrentMonthJob(
        IAccumulationRegisterВыручкаИСебестоимостьПродажTurnoversService service,
        ILogger<AccumulationRegisterВыручкаИСебестоимостьПродажTurnoversCurrentMonthJob> logger)
        : AccumulationRegisterCurrentMonthJob<AccumulationRegisterВыручкаИСебестоимостьПродажTurnoversCurrentMonthJob>(service, logger)
    {
    }
}
