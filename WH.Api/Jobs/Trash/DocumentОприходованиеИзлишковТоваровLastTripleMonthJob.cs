using WH.Api.Services.Document;

namespace WH.Api.Jobs.Trash
{
    public class DocumentОприходованиеИзлишковТоваровLastTripleMonthJob(
        IDocumentОприходованиеИзлишковТоваровService service,
        ILogger<DocumentОприходованиеИзлишковТоваровLastTripleMonthJob> logger,
        IJobResultService jobResultService)
        : DocumentLastTripleMonthJob<DocumentОприходованиеИзлишковТоваровLastTripleMonthJob>(service, logger, jobResultService)
    { }
}
