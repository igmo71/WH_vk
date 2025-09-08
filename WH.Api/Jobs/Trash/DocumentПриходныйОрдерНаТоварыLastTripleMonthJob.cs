using WH.Api.Services.Document;

namespace WH.Api.Jobs.Trash
{
    public class DocumentПриходныйОрдерНаТоварыLastTripleMonthJob(
        IDocumentПриходныйОрдерНаТоварыService service,
        ILogger<DocumentПриходныйОрдерНаТоварыLastTripleMonthJob> logger,
        IJobResultService jobResultService)
    : DocumentLastTripleMonthJob<DocumentПриходныйОрдерНаТоварыLastTripleMonthJob>(service, logger, jobResultService)
    {
    }
}
