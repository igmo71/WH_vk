using WH.Api.Services.AccumulationRegister;

namespace WH.Api.Jobs.AccumulationRegister
{
    public class AccumulationRegisterВыручкаИСебестоимостьПродажTurnoversLastTripleMonthJob(
        IAccumulationRegisterВыручкаИСебестоимостьПродажTurnoversService service,
        ILogger<AccumulationRegisterВыручкаИСебестоимостьПродажTurnoversLastTripleMonthJob> logger,
        IJobResultService jobResultService)
        : AccumulationRegisterLastTripleMonthJob<AccumulationRegisterВыручкаИСебестоимостьПродажTurnoversLastTripleMonthJob>(service, logger, jobResultService)
    {
    }
}
