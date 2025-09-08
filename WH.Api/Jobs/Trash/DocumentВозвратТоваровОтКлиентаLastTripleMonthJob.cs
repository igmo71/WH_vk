using WH.Api.Services.Document;

namespace WH.Api.Jobs.Trash
{
    public class DocumentВозвратТоваровОтКлиентаLastTripleMonthJob(
        IDocumentВозвратТоваровОтКлиентаService service,
        ILogger<DocumentВозвратТоваровОтКлиентаLastTripleMonthJob> logger,
        IJobResultService jobResultService)
        : DocumentLastTripleMonthJob<DocumentВозвратТоваровОтКлиентаLastTripleMonthJob>(service, logger, jobResultService)
    {
    }
}
