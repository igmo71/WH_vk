using WH.Api.Services.AccumulationRegister;

namespace WH.Api.Jobs.Trash
{
    public class AccumulationRegisterВыручкаИСебестоимостьПродажRecordTypeCurrentMonthJob(
        IAccumulationRegisterВыручкаИСебестоимостьПродажRecordTypeService service,
        ILogger<AccumulationRegisterВыручкаИСебестоимостьПродажRecordTypeCurrentMonthJob> logger)
        : AccumulationRegisterCurrentMonthJob<AccumulationRegisterВыручкаИСебестоимостьПродажRecordTypeCurrentMonthJob>(service, logger)
    { }
}
