using WH.Api.Services.Document;

namespace WH.Api.Jobs.Trash
{
    public class DocumentЗаказКлиентаCurrentMonthJob(
        IDocumentЗаказКлиентаService service, ILogger<DocumentЗаказКлиентаCurrentMonthJob> logger)
        : DocumentCurrentMonthJob<DocumentЗаказКлиентаCurrentMonthJob>(service, logger)
    {
    }
}
