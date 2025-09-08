using WH.Api.Services.InformationRegister;

namespace WH.Api.Jobs.Trash
{
    public class InformationRegisterЦеныНоменклатурыRecordTypeCurrentMonthJob(
        IInformationRegisterЦеныНоменклатурыRecordTypeService service, ILogger<InformationRegisterЦеныНоменклатурыRecordTypeCurrentMonthJob> logger)
        : InformationRegisterPeriodicCurrentMonthJob<InformationRegisterЦеныНоменклатурыRecordTypeCurrentMonthJob>(service, logger)
    {
    }
}
