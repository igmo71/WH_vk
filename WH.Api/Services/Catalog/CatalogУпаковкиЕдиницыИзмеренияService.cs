using Microsoft.EntityFrameworkCore;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.Catalog;
using WH.Domain.Models.Catalog;

namespace WH.Api.Services.Catalog
{
    public interface ICatalogУпаковкиЕдиницыИзмеренияService : ICatalogService
    { }

    public class CatalogУпаковкиЕдиницыИзмеренияService(
        IODataClient oDataClient,
        ICatalogУпаковкиЕдиницыИзмеренияParameters oDataParameters,
        IDbContextFactory<AppDbContext> dbContextFactory,
        ILogger<CatalogУпаковкиЕдиницыИзмеренияService> logger)
    : CatalogService<CatalogУпаковкиЕдиницыИзмерения>(oDataClient, oDataParameters, dbContextFactory, logger), ICatalogУпаковкиЕдиницыИзмеренияService
    { }
}
