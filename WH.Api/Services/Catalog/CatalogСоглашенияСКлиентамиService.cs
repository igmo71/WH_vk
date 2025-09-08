using Microsoft.EntityFrameworkCore;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.Catalog;
using WH.Domain.Models.Catalog;

namespace WH.Api.Services.Catalog
{
    public interface ICatalogСоглашенияСКлиентамиService : ICatalogService
    { }

    public class CatalogСоглашенияСКлиентамиService(
        IODataClient oDataClient,
        ICatalogСоглашенияСКлиентамиParameters oDataParameters,
        IDbContextFactory<AppDbContext> dbContextFactory,
        ILogger<CatalogСоглашенияСКлиентамиService> logger)
    : CatalogService<CatalogСоглашенияСКлиентами>(oDataClient, oDataParameters, dbContextFactory, logger), ICatalogСоглашенияСКлиентамиService
    {
    }
}
