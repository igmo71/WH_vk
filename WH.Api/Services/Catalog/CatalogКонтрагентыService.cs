using Microsoft.EntityFrameworkCore;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.Catalog;
using WH.Domain.Models.Catalog;

namespace WH.Api.Services.Catalog
{
    public interface ICatalogКонтрагентыService : ICatalogService
    { }

    public class CatalogКонтрагентыService : CatalogService<CatalogКонтрагенты>, ICatalogКонтрагентыService
    {
        public CatalogКонтрагентыService(
            IODataClient oDataClient,
            ICatalogКонтрагентыParameters oDataParameters,
            IDbContextFactory<AppDbContext> dbContextFactory,
            ILogger<CatalogКонтрагентыService> logger)
        : base(oDataClient, oDataParameters, dbContextFactory, logger)
        { }
    }
}
