using Microsoft.EntityFrameworkCore;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.Catalog;
using WH.Domain.Models.Catalog;

namespace WH.Api.Services.Catalog
{
    public interface ICatalogВидыНоменклатурыService : ICatalogService
    { }

    public class CatalogВидыНоменклатурыService(
        IODataClient oDataClient,
        ICatalogВидыНоменклатурыParameters oDataParameters,
        IDbContextFactory<AppDbContext> dbContextFactory,
        ILogger<CatalogВидыНоменклатурыService> logger)
    : CatalogService<CatalogВидыНоменклатуры>(oDataClient, oDataParameters, dbContextFactory, logger), ICatalogВидыНоменклатурыService
    { }
}
