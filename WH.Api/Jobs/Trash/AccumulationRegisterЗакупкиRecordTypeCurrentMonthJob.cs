using WH.Api.Services.AccumulationRegister;

namespace WH.Api.Jobs.Trash
{
    public class AccumulationRegisterЗакупкиRecordTypeCurrentMonthJob(
        IAccumulationRegisterЗакупкиRecordTypeService service,
        ILogger<AccumulationRegisterЗакупкиRecordTypeCurrentMonthJob> logger)
        : AccumulationRegisterCurrentMonthJob<AccumulationRegisterЗакупкиRecordTypeCurrentMonthJob>(service, logger)
    {
    }
}
