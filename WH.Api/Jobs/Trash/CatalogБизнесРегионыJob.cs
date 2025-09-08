using WH.Api.Services.Catalog;

namespace WH.Api.Jobs.Trash
{
    public class CatalogБизнесРегионыJob(ICatalogБизнесРегионыService service, ILogger<CatalogБизнесРегионыJob> logger)
        : CatalogJob<CatalogБизнесРегионыJob>(service, logger)
    { }
}
