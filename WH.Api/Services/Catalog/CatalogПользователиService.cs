using Microsoft.EntityFrameworkCore;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.Catalog;
using WH.Domain.Models.Catalog;

namespace WH.Api.Services.Catalog
{
    public interface ICatalogПользователиService : ICatalogService
    { }

    public class CatalogПользователиService : CatalogService<CatalogПользователи>, ICatalogПользователиService
    {
        public CatalogПользователиService(
            IODataClient oDataClient,
            ICatalogПользователиParameters oDataParameters,
            IDbContextFactory<AppDbContext> dbContextFactory,
            ILogger<CatalogПользователиService> logger)
        : base(oDataClient, oDataParameters, dbContextFactory, logger)
        { }
    }
}
