using WH.Api.Services.Document;

namespace WH.Api.Jobs.Trash
{
    public class DocumentРеализацияТоваровУслугCurrentMonthJob(
        IDocumentРеализацияТоваровУслугService service, ILogger<DocumentРеализацияТоваровУслугCurrentMonthJob> logger)
        : DocumentCurrentMonthJob<DocumentРеализацияТоваровУслугCurrentMonthJob>(service, logger)
    {
    }
}
