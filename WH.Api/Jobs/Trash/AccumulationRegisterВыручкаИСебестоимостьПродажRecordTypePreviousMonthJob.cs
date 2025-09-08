using WH.Api.Services.AccumulationRegister;

namespace WH.Api.Jobs.Trash
{
    public class AccumulationRegisterВыручкаИСебестоимостьПродажRecordTypePreviousMonthJob(
        IAccumulationRegisterВыручкаИСебестоимостьПродажRecordTypeService service,
        ILogger<AccumulationRegisterВыручкаИСебестоимостьПродажRecordTypePreviousMonthJob> logger)
        : AccumulationRegisterPreviousMonthJob<AccumulationRegisterВыручкаИСебестоимостьПродажRecordTypePreviousMonthJob>(service, logger)
    {
    }
}
