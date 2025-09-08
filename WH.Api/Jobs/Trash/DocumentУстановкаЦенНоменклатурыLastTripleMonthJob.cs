using WH.Api.Services.Document;

namespace WH.Api.Jobs.Trash
{
    public class DocumentУстановкаЦенНоменклатурыLastTripleMonthJob(
        IDocumentУстановкаЦенНоменклатурыService service,
        ILogger<DocumentУстановкаЦенНоменклатурыLastTripleMonthJob> logger,
        IJobResultService jobResultService)
        : DocumentLastTripleMonthJob<DocumentУстановкаЦенНоменклатурыLastTripleMonthJob>(service, logger, jobResultService)
    {
    }
}
