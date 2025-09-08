using WH.Api.Services.InformationRegister;

namespace WH.Api.Jobs.InformationRegister
{
    public class InformationRegisterЦеныНоменклатурыЗакупочныеSliceLastLastTripleMonthJob(
        IInformationRegisterЦеныНоменклатурыЗакупочныеSliceLastService service,
        ILogger<InformationRegisterЦеныНоменклатурыЗакупочныеSliceLastLastTripleMonthJob> logger,
        IJobResultService jobResultService)
        : InformationRegisterPeriodicLastTripleMonthJob<InformationRegisterЦеныНоменклатурыЗакупочныеSliceLastLastTripleMonthJob>(service, logger, jobResultService)
    {
    }
}
