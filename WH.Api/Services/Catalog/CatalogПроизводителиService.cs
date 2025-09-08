using Microsoft.EntityFrameworkCore;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.Catalog;
using WH.Domain.Models.Catalog;

namespace WH.Api.Services.Catalog
{
    public interface ICatalogПроизводителиService : ICatalogService
    { }

    public class CatalogПроизводителиService(
        IODataClient oDataClient,
        ICatalogПроизводителиParameters oDataParameters,
        IDbContextFactory<AppDbContext> dbContextFactory,
        ILogger<CatalogПроизводителиService> logger)
    : CatalogService<CatalogПроизводители>(oDataClient, oDataParameters, dbContextFactory, logger), ICatalogПроизводителиService
    { }
}
