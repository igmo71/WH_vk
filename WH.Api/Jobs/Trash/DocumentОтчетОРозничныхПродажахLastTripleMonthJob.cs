using WH.Api.Services.Document;

namespace WH.Api.Jobs.Trash
{
    public class DocumentОтчетОРозничныхПродажахLastTripleMonthJob(
        IDocumentОтчетОРозничныхПродажахService service,
        ILogger<DocumentОтчетОРозничныхПродажахLastTripleMonthJob> logger,
        IJobResultService jobResultService)
        : DocumentLastTripleMonthJob<DocumentОтчетОРозничныхПродажахLastTripleMonthJob>(service, logger, jobResultService)
    {
    }
}
