using WH.Api.Services.Document;

namespace WH.Api.Jobs.Trash
{
    public class DocumentЗаказКлиентаLastTripleMonthJob(
        IDocumentЗаказКлиентаService service,
        ILogger<DocumentЗаказКлиентаLastTripleMonthJob> logger,
        IJobResultService jobResultService)
        : DocumentLastTripleMonthJob<DocumentЗаказКлиентаLastTripleMonthJob>(service, logger, jobResultService)
    {
    }
}
