using Microsoft.EntityFrameworkCore;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.Catalog;
using WH.Domain.Models.Catalog;

namespace WH.Api.Services.Catalog
{
    public interface ICatalogТэгиПартнеровService : ICatalogService
    { }

    public class CatalogТэгиПартнеровService : CatalogService<CatalogТэгиПартнеров>, ICatalogТэгиПартнеровService
    {
        public CatalogТэгиПартнеровService(
            IODataClient oDataClient,
            ICatalogТэгиПартнеровParameters oDataParameters,
            IDbContextFactory<AppDbContext> dbContextFactory,
            ILogger<CatalogТэгиПартнеровService> logger)
        : base(oDataClient, oDataParameters, dbContextFactory, logger)
        { }
    }
}
