using WH.Api.Jobs.AccumulationRegister;
using WH.Api.Services.Wms;

namespace WH.Api.Jobs.Wms
{
    public class AccumulationRegisterТоварыВЯчейкахBalanceAndTurnoversLastTripleMonthJob(
        IAccumulationRegisterТоварыВЯчейкахBalanceAndTurnoversService service,
        ILogger<AccumulationRegisterТоварыВЯчейкахBalanceAndTurnoversLastTripleMonthJob> logger,
        IJobResultService jobResultService)
    : AccumulationRegisterLastTripleMonthJob<AccumulationRegisterТоварыВЯчейкахBalanceAndTurnoversLastTripleMonthJob>(service, logger, jobResultService)
    {
    }
}
