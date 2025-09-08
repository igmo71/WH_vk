using Microsoft.EntityFrameworkCore;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.Catalog;
using WH.Domain.Models.Catalog;

namespace WH.Api.Services.Catalog
{
    public interface ICatalogЗначенияСвойствОбъектовService : ICatalogService
    { }
    public class CatalogЗначенияСвойствОбъектовService(
        IODataClient oDataClient,
        ICatalogЗначенияСвойствОбъектовParameters oDataParameters,
        IDbContextFactory<AppDbContext> dbContextFactory,
        ILogger<CatalogЗначенияСвойствОбъектовService> logger)
    : CatalogService<CatalogЗначенияСвойствОбъектов>(oDataClient, oDataParameters, dbContextFactory, logger), ICatalogЗначенияСвойствОбъектовService
    {
    }
}
