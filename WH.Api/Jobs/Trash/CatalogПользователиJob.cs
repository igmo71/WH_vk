using WH.Api.Services.Catalog;

namespace WH.Api.Jobs.Trash
{
    public class CatalogПользователиJob(ICatalogПользователиService service, ILogger<CatalogПользователиJob> logger)
        : CatalogJob<CatalogПользователиJob>(service, logger)
    { }
}
