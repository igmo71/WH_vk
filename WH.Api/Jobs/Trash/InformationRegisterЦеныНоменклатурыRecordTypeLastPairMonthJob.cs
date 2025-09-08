using WH.Api.Services.InformationRegister;

namespace WH.Api.Jobs.Trash
{
    public class InformationRegisterЦеныНоменклатурыRecordTypeLastPairMonthJob(
        IInformationRegisterЦеныНоменклатурыRecordTypeService service,
        ILogger<InformationRegisterЦеныНоменклатурыRecordTypeLastPairMonthJob> logger,
        IJobResultService jobResultService)
        : InformationRegisterPeriodicLastPairMonthJob<InformationRegisterЦеныНоменклатурыRecordTypeLastPairMonthJob>(service, logger, jobResultService)
    {
    }
}
