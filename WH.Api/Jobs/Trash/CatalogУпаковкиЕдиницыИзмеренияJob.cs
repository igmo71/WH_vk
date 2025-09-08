using WH.Api.Services.Catalog;

namespace WH.Api.Jobs.Trash
{
    public class CatalogУпаковкиЕдиницыИзмеренияJob(ICatalogУпаковкиЕдиницыИзмеренияService service, ILogger<CatalogУпаковкиЕдиницыИзмеренияJob> logger)
        : CatalogJob<CatalogУпаковкиЕдиницыИзмеренияJob>(service, logger)
    { }
}
