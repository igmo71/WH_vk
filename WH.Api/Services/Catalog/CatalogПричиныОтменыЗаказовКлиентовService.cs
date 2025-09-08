using Microsoft.EntityFrameworkCore;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.Catalog;
using WH.Domain.Models.Catalog;

namespace WH.Api.Services.Catalog
{
    public interface ICatalogПричиныОтменыЗаказовКлиентовService : ICatalogService
    { }

    public class CatalogПричиныОтменыЗаказовКлиентовService : CatalogService<CatalogПричиныОтменыЗаказовКлиентов>, ICatalogПричиныОтменыЗаказовКлиентовService
    {
        public CatalogПричиныОтменыЗаказовКлиентовService(
            IODataClient oDataClient,
            ICatalogПричиныОтменыЗаказовКлиентовParameters oDataParameters,
            IDbContextFactory<AppDbContext> dbContextFactory,
            ILogger<CatalogПричиныОтменыЗаказовКлиентовService> logger)
        : base(oDataClient, oDataParameters, dbContextFactory, logger)
        {

        }
    }
}
