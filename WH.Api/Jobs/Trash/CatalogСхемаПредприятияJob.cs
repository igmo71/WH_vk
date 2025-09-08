using WH.Api.Services.Trash;

namespace WH.Api.Jobs.Trash
{
    public class CatalogСхемаПредприятияJob(ICatalogСхемаПредприятияService service, ILogger<CatalogСхемаПредприятияJob> logger)
        : CatalogJob<CatalogСхемаПредприятияJob>(service, logger)
    { }
}
