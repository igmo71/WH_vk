using WH.Api.Services.AccumulationRegister;

namespace WH.Api.Jobs.Trash
{
    public class AccumulationRegisterВыручкаИСебестоимостьПродажTurnoversPreviousMonthJob(
        IAccumulationRegisterВыручкаИСебестоимостьПродажTurnoversService service,
        ILogger<AccumulationRegisterВыручкаИСебестоимостьПродажTurnoversPreviousMonthJob> logger)
        : AccumulationRegisterPreviousMonthJob<AccumulationRegisterВыручкаИСебестоимостьПродажTurnoversPreviousMonthJob>(service, logger)
    {
    }
}
