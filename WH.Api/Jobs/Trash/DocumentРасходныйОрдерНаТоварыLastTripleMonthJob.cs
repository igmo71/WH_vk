using WH.Api.Services.Document;

namespace WH.Api.Jobs.Trash
{
    public class DocumentРасходныйОрдерНаТоварыLastTripleMonthJob(
        IDocumentРасходныйОрдерНаТоварыService service,
        ILogger<DocumentРасходныйОрдерНаТоварыLastTripleMonthJob> logger,
        IJobResultService jobResultService)
    : DocumentLastTripleMonthJob<DocumentРасходныйОрдерНаТоварыLastTripleMonthJob>(service, logger, jobResultService)
    {
    }
}
