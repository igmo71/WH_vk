using WH.Api.Services.AccumulationRegister;

namespace WH.Api.Jobs.Trash
{
    public class AccumulationRegisterВыручкаИСебестоимостьПродажTurnoversLastPairMonthJob(
        IAccumulationRegisterВыручкаИСебестоимостьПродажTurnoversService service,
        ILogger<AccumulationRegisterВыручкаИСебестоимостьПродажTurnoversLastPairMonthJob> logger,
        IJobResultService jobResultService)
        : AccumulationRegisterLastPairMonthJob<AccumulationRegisterВыручкаИСебестоимостьПродажTurnoversLastPairMonthJob>(service, logger, jobResultService)
    {
    }
}
