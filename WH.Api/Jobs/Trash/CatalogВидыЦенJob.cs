using WH.Api.Services.Catalog;

namespace WH.Api.Jobs.Trash
{
    public class CatalogВидыЦенJob(ICatalogВидыЦенService service, ILogger<CatalogВидыЦенJob> logger)
        : CatalogJob<CatalogВидыЦенJob>(service, logger)
    { }
}
