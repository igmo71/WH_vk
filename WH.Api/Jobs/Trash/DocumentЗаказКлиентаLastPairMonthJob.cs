using WH.Api.Services.Document;

namespace WH.Api.Jobs.Trash
{
    public class DocumentЗаказКлиентаLastPairMonthJob(
        IDocumentЗаказКлиентаService service,
        ILogger<DocumentЗаказКлиентаLastPairMonthJob> logger,
        IJobResultService jobResultService)
        : DocumentLastPairMonthJob<DocumentЗаказКлиентаLastPairMonthJob>(service, logger, jobResultService)
    {
    }
}
