using Microsoft.EntityFrameworkCore;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.Catalog;
using WH.Domain.Models.Catalog;

namespace WH.Api.Services.Catalog
{
    public interface ICatalogЦеновыеГруппыService : ICatalogService
    { }

    public class CatalogЦеновыеГруппыService(
        IODataClient oDataClient,
        ICatalogЦеновыеГруппыParameters oDataParameters,
        IDbContextFactory<AppDbContext> dbContextFactory,
        ILogger<CatalogЦеновыеГруппыService> logger)
    : CatalogService<CatalogЦеновыеГруппы>(oDataClient, oDataParameters, dbContextFactory, logger), ICatalogЦеновыеГруппыService
    { }
}
