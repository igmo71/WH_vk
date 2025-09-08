using WH.Api.Services.Document;

namespace WH.Api.Jobs.Trash
{
    public class DocumentЗаказКлиентаPreviousMonthJob(
        IDocumentЗаказКлиентаService service, ILogger<DocumentЗаказКлиентаPreviousMonthJob> logger)
        : DocumentPreviousMonthJob<DocumentЗаказКлиентаPreviousMonthJob>(service, logger)
    {
    }
}
