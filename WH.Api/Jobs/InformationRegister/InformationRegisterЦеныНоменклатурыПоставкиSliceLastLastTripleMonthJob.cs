using WH.Api.Services.InformationRegister;

namespace WH.Api.Jobs.InformationRegister
{
    public class InformationRegisterЦеныНоменклатурыПоставкиSliceLastLastTripleMonthJob(
        IInformationRegisterЦеныНоменклатурыПоставкиSliceLastService service,
        ILogger<InformationRegisterЦеныНоменклатурыПоставкиSliceLastLastTripleMonthJob> logger,
        IJobResultService jobResultService)
        : InformationRegisterPeriodicLastTripleMonthJob<InformationRegisterЦеныНоменклатурыПоставкиSliceLastLastTripleMonthJob>(service, logger, jobResultService)
    {
    }
}
