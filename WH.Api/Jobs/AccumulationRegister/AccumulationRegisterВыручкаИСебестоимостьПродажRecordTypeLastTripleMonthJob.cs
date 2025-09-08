using WH.Api.Services.AccumulationRegister;

namespace WH.Api.Jobs.AccumulationRegister
{
    public class AccumulationRegisterВыручкаИСебестоимостьПродажRecordTypeLastTripleMonthJob(
        IAccumulationRegisterВыручкаИСебестоимостьПродажRecordTypeService service,
        ILogger<AccumulationRegisterВыручкаИСебестоимостьПродажRecordTypeLastTripleMonthJob> logger,
        IJobResultService jobResultService)
        : AccumulationRegisterLastTripleMonthJob<AccumulationRegisterВыручкаИСебестоимостьПродажRecordTypeLastTripleMonthJob>(service, logger, jobResultService)
    { }
}
