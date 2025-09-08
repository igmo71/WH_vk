using WH.Api.Services.Catalog;

namespace WH.Api.Jobs.Trash
{
    public class CatalogПроизводителиJob(ICatalogПроизводителиService service, ILogger<CatalogПроизводителиJob> logger)
        : CatalogJob<CatalogПроизводителиJob>(service, logger)
    { }
}
