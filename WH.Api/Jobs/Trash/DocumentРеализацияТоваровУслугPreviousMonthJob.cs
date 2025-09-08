using WH.Api.Services.Document;

namespace WH.Api.Jobs.Trash
{
    public class DocumentРеализацияТоваровУслугPreviousMonthJob(
        IDocumentРеализацияТоваровУслугService service, ILogger<DocumentРеализацияТоваровУслугPreviousMonthJob> logger)
        : DocumentPreviousMonthJob<DocumentРеализацияТоваровУслугPreviousMonthJob>(service, logger)
    {
    }
}
