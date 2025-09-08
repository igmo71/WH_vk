using Microsoft.EntityFrameworkCore;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.Trash;
using WH.Domain.Models.Catalog;

namespace WH.Api.Services.Catalog
{
    public interface ICatalogВидыДеятельностиService : ICatalogService
    { }

    public class CatalogВидыДеятельностиService(
        IODataClient oDataClient,
        ICatalogВидыДеятельностиParameters oDataParameters,
        IDbContextFactory<AppDbContext> dbContextFactory,
        ILogger<CatalogВидыДеятельностиService> logger)
    : CatalogService<CatalogВидыДеятельности>(oDataClient, oDataParameters, dbContextFactory, logger), ICatalogВидыДеятельностиService
    { }
}
