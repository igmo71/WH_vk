using WH.Api.Services.AccumulationRegister;

namespace WH.Api.Jobs.Trash
{
    public class AccumulationRegisterВыручкаИСебестоимостьПродажRecordTypeLastPairMonthJob(
        IAccumulationRegisterВыручкаИСебестоимостьПродажRecordTypeService service,
        ILogger<AccumulationRegisterВыручкаИСебестоимостьПродажRecordTypeLastPairMonthJob> logger,
        IJobResultService jobResultService)
        : AccumulationRegisterLastPairMonthJob<AccumulationRegisterВыручкаИСебестоимостьПродажRecordTypeLastPairMonthJob>(service, logger, jobResultService)
    { }
}
