using WH.Api.Services.Catalog;

namespace WH.Api.Jobs.Trash
{
    public class CatalogВидыНоменклатурыJob(ICatalogВидыНоменклатурыService service, ILogger<CatalogВидыНоменклатурыJob> logger)
        : CatalogJob<CatalogВидыНоменклатурыJob>(service, logger)
    { }
}
