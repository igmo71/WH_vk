using WH.Api.Services.InformationRegister;

namespace WH.Api.Jobs.InformationRegister
{
    public class InformationRegisterЦеныНоменклатурыRecordTypeLastTripleMonthJob(
        IInformationRegisterЦеныНоменклатурыRecordTypeService service,
        ILogger<InformationRegisterЦеныНоменклатурыRecordTypeLastTripleMonthJob> logger,
        IJobResultService jobResultService)
        : InformationRegisterPeriodicLastTripleMonthJob<InformationRegisterЦеныНоменклатурыRecordTypeLastTripleMonthJob>(service, logger, jobResultService)
    {
    }
}
