using WH.Api.Services.Catalog;

namespace WH.Api.Jobs.Trash
{
    public class CatalogСоглашенияСКлиентамиJob(ICatalogСоглашенияСКлиентамиService service, ILogger<CatalogСоглашенияСКлиентамиJob> logger)
        : CatalogJob<CatalogСоглашенияСКлиентамиJob>(service, logger)
    { }
}
