using Microsoft.EntityFrameworkCore;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.Catalog;
using WH.Domain.Models.Catalog;

namespace WH.Api.Services.Catalog
{
    public interface ICatalogВидыЦенService : ICatalogService
    { }

    public class CatalogВидыЦенService(
        IODataClient oDataClient,
        ICatalogВидыЦенParameters oDataParameters,
        IDbContextFactory<AppDbContext> dbContextFactory,
        ILogger<CatalogВидыЦенService> logger)
    : CatalogService<CatalogВидыЦен>(oDataClient, oDataParameters, dbContextFactory, logger), ICatalogВидыЦенService
    { }
}
