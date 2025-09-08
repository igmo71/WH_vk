using Microsoft.EntityFrameworkCore;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.Catalog;
using WH.Domain.Models.Catalog;

namespace WH.Api.Services.Catalog
{
    public interface ICatalogСкладыService : ICatalogService
    { }

    public class CatalogСкладыService : CatalogService<CatalogСклады>, ICatalogСкладыService
    {
        public CatalogСкладыService(
            IODataClient oDataClient,
            ICatalogСкладыParameters oDataParameters,
            IDbContextFactory<AppDbContext> dbContextFactory,
            ILogger<CatalogСкладыService> logger)
        : base(oDataClient, oDataParameters, dbContextFactory, logger)
        {

        }
    }
}
