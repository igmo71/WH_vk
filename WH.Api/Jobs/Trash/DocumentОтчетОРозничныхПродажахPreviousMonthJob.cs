using WH.Api.Services.Document;

namespace WH.Api.Jobs.Trash
{
    public class DocumentОтчетОРозничныхПродажахPreviousMonthJob(
        IDocumentОтчетОРозничныхПродажахService service, ILogger<DocumentОтчетОРозничныхПродажахPreviousMonthJob> logger)
        : DocumentPreviousMonthJob<DocumentОтчетОРозничныхПродажахPreviousMonthJob>(service, logger)
    {
    }
}
