using WH.Api.Services.Document;

namespace WH.Api.Jobs.Trash
{
    public class DocumentРеализацияТоваровУслугLastPairMonthJob(
        IDocumentРеализацияТоваровУслугService service,
        ILogger<DocumentРеализацияТоваровУслугLastPairMonthJob> logger,
        IJobResultService jobResultService)
        : DocumentLastPairMonthJob<DocumentРеализацияТоваровУслугLastPairMonthJob>(service, logger, jobResultService)
    {
    }
}
