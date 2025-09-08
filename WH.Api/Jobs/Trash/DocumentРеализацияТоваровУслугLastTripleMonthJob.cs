using WH.Api.Services.Document;

namespace WH.Api.Jobs.Trash
{
    public class DocumentРеализацияТоваровУслугLastTripleMonthJob(
        IDocumentРеализацияТоваровУслугService service,
        ILogger<DocumentРеализацияТоваровУслугLastTripleMonthJob> logger,
        IJobResultService jobResultService)
        : DocumentLastTripleMonthJob<DocumentРеализацияТоваровУслугLastTripleMonthJob>(service, logger, jobResultService)
    {
    }
}
