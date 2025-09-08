using WH.Api.Services.Catalog;

namespace WH.Api.Jobs.Trash
{
    public class CatalogПричиныОтменыЗаказовКлиентовJob(ICatalogПричиныОтменыЗаказовКлиентовService service, ILogger<CatalogПричиныОтменыЗаказовКлиентовJob> logger)
        : CatalogJob<CatalogПричиныОтменыЗаказовКлиентовJob>(service, logger)
    { }
}
