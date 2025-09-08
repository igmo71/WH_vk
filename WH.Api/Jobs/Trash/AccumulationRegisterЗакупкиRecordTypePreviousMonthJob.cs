using WH.Api.Services.AccumulationRegister;

namespace WH.Api.Jobs.Trash
{
    public class AccumulationRegisterЗакупкиRecordTypePreviousMonthJob(
        IAccumulationRegisterЗакупкиRecordTypeService service,
        ILogger<AccumulationRegisterЗакупкиRecordTypePreviousMonthJob> logger)
        : AccumulationRegisterPreviousMonthJob<AccumulationRegisterЗакупкиRecordTypePreviousMonthJob>(service, logger)
    {
    }
}
