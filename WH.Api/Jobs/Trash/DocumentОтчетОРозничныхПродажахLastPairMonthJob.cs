using WH.Api.Services.Document;

namespace WH.Api.Jobs.Trash
{
    public class DocumentОтчетОРозничныхПродажахLastPairMonthJob(
        IDocumentОтчетОРозничныхПродажахService service,
        ILogger<DocumentОтчетОРозничныхПродажахLastPairMonthJob> logger,
        IJobResultService jobResultService)
        : DocumentLastPairMonthJob<DocumentОтчетОРозничныхПродажахLastPairMonthJob>(service, logger, jobResultService)
    {
    }
}
