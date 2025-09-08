using WH.Api.Services.Catalog;

namespace WH.Api.Jobs.Trash
{
    public class CatalogНоменклатураJob(ICatalogНоменклатураService service, ILogger<CatalogНоменклатураJob> logger)
        : CatalogJob<CatalogНоменклатураJob>(service, logger)
    { }
}
