using Microsoft.EntityFrameworkCore;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.Catalog;
using WH.Domain.Models.Catalog;

namespace WH.Api.Services.Catalog
{
    public interface ICatalogСтруктураПредприятияService : ICatalogService
    { }

    public class CatalogСтруктураПредприятияService : CatalogService<CatalogСтруктураПредприятия>, ICatalogСтруктураПредприятияService
    {
        public CatalogСтруктураПредприятияService(
            IODataClient oDataClient,
            ICatalogСтруктураПредприятияParameters oDataParameters,
            IDbContextFactory<AppDbContext> dbContextFactory,
            ILogger<CatalogСтруктураПредприятияService> logger)
        : base(oDataClient, oDataParameters, dbContextFactory, logger)
        { }
    }
}
