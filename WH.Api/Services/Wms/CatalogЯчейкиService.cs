using Microsoft.EntityFrameworkCore;
using WH.Api.Data;
using WH.Api.OData.ODataParameters.Wms;
using WH.Api.OData.Wms;
using WH.Api.Services.Catalog;
using WH.Domain.Models.Wms;

namespace WH.Api.Services.Wms
{
    public interface ICatalogЯчейкиService : ICatalogService
    { }

    public class CatalogЯчейкиService : CatalogService<CatalogЯчейки>, ICatalogЯчейкиService
    {
        public CatalogЯчейкиService(
            IWmsODataClient oDataClient,
            ICatalogЯчейкиParameters oDataParameters,
            IDbContextFactory<AppDbContext> dbContextFactory,
            ILogger<CatalogЯчейкиService> logger)
        : base(oDataClient, oDataParameters, dbContextFactory, logger)
        {

        }
    }
}
