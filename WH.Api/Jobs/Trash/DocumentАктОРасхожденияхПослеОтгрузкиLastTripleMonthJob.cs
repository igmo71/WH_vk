using WH.Api.Services.Document;

namespace WH.Api.Jobs.Trash
{
    public class DocumentАктОРасхожденияхПослеОтгрузкиLastTripleMonthJob(
        IDocumentАктОРасхожденияхПослеОтгрузкиService service,
        ILogger<DocumentАктОРасхожденияхПослеОтгрузкиLastTripleMonthJob> logger,
        IJobResultService jobResultService)
        : DocumentLastTripleMonthJob<DocumentАктОРасхожденияхПослеОтгрузкиLastTripleMonthJob>(service, logger, jobResultService)
    {
    }
}
