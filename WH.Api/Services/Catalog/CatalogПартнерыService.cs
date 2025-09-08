using Microsoft.EntityFrameworkCore;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.Catalog;
using WH.Domain.Models.Catalog;

namespace WH.Api.Services.Catalog
{
    public interface ICatalogПартнерыService : ICatalogService
    { }

    public class CatalogПартнерыService : CatalogService<CatalogПартнеры>, ICatalogПартнерыService
    {
        public CatalogПартнерыService(
            IODataClient oDataClient,
            ICatalogПартнерыParameters oDataParameters,
            IDbContextFactory<AppDbContext> dbContextFactory,
            ILogger<CatalogПартнерыService> logger)
        : base(oDataClient, oDataParameters, dbContextFactory, logger)
        { }
    }
}
