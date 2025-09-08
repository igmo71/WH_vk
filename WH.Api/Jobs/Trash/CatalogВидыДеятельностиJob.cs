using WH.Api.Services.Catalog;

namespace WH.Api.Jobs.Trash
{
    public class CatalogВидыДеятельностиJob(ICatalogВидыДеятельностиService service, ILogger<CatalogВидыДеятельностиJob> logger)
        : CatalogJob<CatalogВидыДеятельностиJob>(service, logger)
    { }
}
