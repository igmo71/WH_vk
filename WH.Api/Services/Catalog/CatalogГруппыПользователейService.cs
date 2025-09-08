using Microsoft.EntityFrameworkCore;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.Catalog;
using WH.Domain.Models.Catalog;

namespace WH.Api.Services.Catalog
{
    public interface ICatalogГруппыПользователейService : ICatalogService
    { }

    public class CatalogГруппыПользователейService(
        IODataClient oDataClient,
        ICatalogГруппыПользователейParameters oDataParameters,
        IDbContextFactory<AppDbContext> dbContextFactory,
        ILogger<CatalogГруппыПользователейService> logger)
    : CatalogService<CatalogГруппыПользователей>(oDataClient, oDataParameters, dbContextFactory, logger), ICatalogГруппыПользователейService
    {    }
}
