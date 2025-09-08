using Microsoft.EntityFrameworkCore;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.Trash;
using WH.Api.Services.Catalog;
using WH.Domain.Models.Catalog;

namespace WH.Api.Services.Trash
{
    public interface ICatalogИсточникиЗаявокService : ICatalogService
    { }

    public class CatalogИсточникиЗаявокService(
        IODataClient oDataClient,
        ICatalogИсточникиЗаявокParameters oDataParameters,
        IDbContextFactory<AppDbContext> dbContextFactory,
        ILogger<CatalogИсточникиЗаявокService> logger)
    : CatalogService<CatalogИсточникиЗаявок>(oDataClient, oDataParameters, dbContextFactory, logger), ICatalogИсточникиЗаявокService
    {
    }
}
