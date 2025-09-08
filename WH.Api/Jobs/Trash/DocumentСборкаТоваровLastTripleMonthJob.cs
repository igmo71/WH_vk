using WH.Api.Services.Document;

namespace WH.Api.Jobs.Trash
{
    public class DocumentСборкаТоваровLastTripleMonthJob(
        IDocumentСборкаТоваровService service,
        ILogger<DocumentСборкаТоваровLastTripleMonthJob> logger,
        IJobResultService jobResultService)
        : DocumentLastTripleMonthJob<DocumentСборкаТоваровLastTripleMonthJob>(service, logger, jobResultService)
    {
    }
}
