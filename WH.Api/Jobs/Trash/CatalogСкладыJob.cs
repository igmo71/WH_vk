using WH.Api.Services.Catalog;

namespace WH.Api.Jobs.Trash
{
    public class CatalogСкладыJob(ICatalogСкладыService service, ILogger<CatalogСкладыJob> logger)
        : CatalogJob<CatalogСкладыJob>(service, logger)
    { }
}
