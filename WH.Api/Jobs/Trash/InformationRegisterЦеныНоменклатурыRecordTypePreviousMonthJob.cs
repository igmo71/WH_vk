using WH.Api.Services.InformationRegister;

namespace WH.Api.Jobs.Trash
{
    public class InformationRegisterЦеныНоменклатурыRecordTypePreviousMonthJob(
        IInformationRegisterЦеныНоменклатурыRecordTypeService service, ILogger<InformationRegisterЦеныНоменклатурыRecordTypePreviousMonthJob> logger)
        : InformationRegisterPeriodicPreviousMonthJob<InformationRegisterЦеныНоменклатурыRecordTypePreviousMonthJob>(service, logger)
    {
    }
}
