using Microsoft.EntityFrameworkCore;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.Trash;
using WH.Api.Services.Catalog;
using WH.Domain.Models.Catalog;

namespace WH.Api.Services.Trash
{
    public interface ICatalogСхемаПредприятияService : ICatalogService
    { }

    public class CatalogСхемаПредприятияService : CatalogService<CatalogСхемаПредприятия>, ICatalogСхемаПредприятияService
    {
        public CatalogСхемаПредприятияService(
            IODataClient oDataClient,
            ICatalogСхемаПредприятияParameters oDataParameters,
            IDbContextFactory<AppDbContext> dbContextFactory,
            ILogger<CatalogСхемаПредприятияService> logger)
        : base(oDataClient, oDataParameters, dbContextFactory, logger)
        { }
    }
}
