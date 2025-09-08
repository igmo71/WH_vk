using Microsoft.EntityFrameworkCore;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.Catalog;
using WH.Domain.Models.Catalog;

namespace WH.Api.Services.Catalog
{
    public interface ICatalogПартнерыVipService : ICatalogService
    { }

    public class CatalogПартнерыVipService : CatalogService<CatalogПартнерыVip>, ICatalogПартнерыVipService
    {
        public CatalogПартнерыVipService(
            IODataClient oDataClient,
            ICatalogПартнерыVipParameters oDataParameters,
            IDbContextFactory<AppDbContext> dbContextFactory,
            ILogger<CatalogПартнерыVipService> logger)
        : base(oDataClient, oDataParameters, dbContextFactory, logger)
        { }
    }
}
