using WH.Api.Services.Catalog;

namespace WH.Api.Jobs.Trash
{
    public class CatalogПодвидыНоменклатурыJob(ICatalogПодвидыНоменклатурыService service, ILogger<CatalogПодвидыНоменклатурыJob> logger)
        : CatalogJob<CatalogПодвидыНоменклатурыJob>(service, logger)
    { }
}
