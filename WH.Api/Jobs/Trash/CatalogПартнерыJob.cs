using WH.Api.Services.Catalog;

namespace WH.Api.Jobs.Trash
{
    public class CatalogПартнерыJob(ICatalogПартнерыService service, ILogger<CatalogПартнерыJob> logger)
        : CatalogJob<CatalogПартнерыJob>(service, logger)
    { }
}
