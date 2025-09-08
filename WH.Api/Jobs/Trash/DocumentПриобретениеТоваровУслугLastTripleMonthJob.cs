using WH.Api.Services.Document;

namespace WH.Api.Jobs.Trash
{
    public class DocumentПриобретениеТоваровУслугLastTripleMonthJob(
        IDocumentПриобретениеТоваровУслугService service,
        ILogger<DocumentПриобретениеТоваровУслугLastTripleMonthJob> logger,
        IJobResultService jobResultService)
    : DocumentLastTripleMonthJob<DocumentПриобретениеТоваровУслугLastTripleMonthJob>(service, logger, jobResultService)
    {
    }
}
