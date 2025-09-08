using Microsoft.EntityFrameworkCore;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.Catalog;
using WH.Domain.Models.Catalog;

namespace WH.Api.Services.Catalog
{
    public interface ICatalogМаркиService : ICatalogService
    { }

    public class CatalogМаркиService(
        IODataClient oDataClient,
        ICatalogМаркиParameters oDataParameters,
        IDbContextFactory<AppDbContext> dbContextFactory,
        ILogger<CatalogМаркиService> logger)
    : CatalogService<CatalogМарки>(oDataClient, oDataParameters, dbContextFactory, logger), ICatalogМаркиService
    { }
}
