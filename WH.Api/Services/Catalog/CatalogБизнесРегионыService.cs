using Microsoft.EntityFrameworkCore;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.Catalog;
using WH.Domain.Models.Catalog;

namespace WH.Api.Services.Catalog
{
    public interface ICatalogБизнесРегионыService : ICatalogService
    { }

    public class CatalogБизнесРегионыService(
        IODataClient oDataClient,
        ICatalogБизнесРегионыParameters oDataParameters,
        IDbContextFactory<AppDbContext> dbContextFactory,
        ILogger<CatalogБизнесРегионыService> logger)
    : CatalogService<CatalogБизнесРегионы>(oDataClient, oDataParameters, dbContextFactory, logger), ICatalogБизнесРегионыService
    { }
}
