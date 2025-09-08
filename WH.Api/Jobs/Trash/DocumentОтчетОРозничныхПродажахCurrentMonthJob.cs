using WH.Api.Services.Document;

namespace WH.Api.Jobs.Trash
{
    public class DocumentОтчетОРозничныхПродажахCurrentMonthJob(
        IDocumentОтчетОРозничныхПродажахService service, ILogger<DocumentОтчетОРозничныхПродажахCurrentMonthJob> logger)
        : DocumentCurrentMonthJob<DocumentОтчетОРозничныхПродажахCurrentMonthJob>(service, logger)
    {
    }
}
