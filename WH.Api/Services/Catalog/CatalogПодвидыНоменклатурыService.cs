using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.Catalog;
using WH.Domain.Models;
using WH.Domain.Models.Catalog;
using TEntity = WH.Domain.Models.Catalog.CatalogПодвидыНоменклатуры;


namespace WH.Api.Services.Catalog
{
    public interface ICatalogПодвидыНоменклатурыService : ICatalogService
    { }

    public class CatalogПодвидыНоменклатурыService : ICatalogПодвидыНоменклатурыService
    {
        private readonly IODataClient _oDataClient;
        private readonly ICatalogПодвидыНоменклатурыParameters _oDataParameters;
        private readonly IDbContextFactory<AppDbContext> _dbContextFactory;
        private readonly ILogger<CatalogПодвидыНоменклатурыService> _logger;

        private readonly string _entityName = nameof(CatalogПодвидыНоменклатуры);

        public CatalogПодвидыНоменклатурыService(
            IODataClient oDataClient,
            ICatalogПодвидыНоменклатурыParameters oDataParameters,
            IDbContextFactory<AppDbContext> dbContextFactory,
            ILogger<CatalogПодвидыНоменклатурыService> logger)
        {

            _oDataClient = oDataClient;
            _oDataParameters = oDataParameters;
            _dbContextFactory = dbContextFactory;
            _logger = logger;
        }

        public async Task<ServiceResult> LoadingAsync()
        {
            ServiceResult serviceResult = new();

            var loadingTimestamp = Stopwatch.GetTimestamp();

            await DeleteAllAsync();

            int insertedRows = 0;
            int? odataCount = await GetODataCountAsync();
            int iterations = _oDataParameters.GetIterationsCount(odataCount);

            for (int i = 0; i < iterations; i++)
            {
                var getODataTimestamp = Stopwatch.GetTimestamp();
                TEntity[]? values = await GetODataValuesAsync(i);
                var getODataElapsedTime = Stopwatch.GetElapsedTime(getODataTimestamp).TotalSeconds;

                var dbInsertTimestamp = Stopwatch.GetTimestamp();
                if (values != null)
                {
                    insertedRows += await InsertRangeAsync(values);
                }
                var dbInsertElapsedTime = Stopwatch.GetElapsedTime(dbInsertTimestamp).TotalSeconds;

                _logger.LogDebug("{Method} {Entity} {i}/{iterations} {GetODataElapsedTime} {DBInsertElapsedTime}",
                    nameof(LoadingAsync), _entityName, i + 1, iterations, getODataElapsedTime, dbInsertElapsedTime);
            }

            serviceResult.Values["Entity"] = _entityName;
            serviceResult.Values["Duration"] = Stopwatch.GetElapsedTime(loadingTimestamp);
            serviceResult.Values["InsertedRows"] = insertedRows;

            _logger.LogInformation("{Method} {Entity} {@ServiceResult}", nameof(LoadingAsync), _entityName, serviceResult);

            return serviceResult;
        }

        private async Task<TEntity[]?> GetODataValuesAsync(int i)
        {
            string uri = _oDataParameters.GetUri(null, null, i);
            var rootobject = await _oDataClient.GetValuesAsync<Rootobject<TEntity>>(uri);
            var values = rootobject?.Values;
            return values;
        }

        public async Task<ServiceResult> GetODataAndDbCountAsync()
        {
            ServiceResult serviceResult = new();

            int? odataCount = await GetODataCountAsync();

            using var dbContext = _dbContextFactory.CreateDbContext();

            int? dbCount = await dbContext.Set<TEntity>().CountAsync();

            serviceResult.Values["Entity"] = _entityName;
            serviceResult.Values["Count OData"] = odataCount ?? 0;
            serviceResult.Values["Count DB"] = dbCount;

            _logger.LogDebug("{Method} {Entity} {@ServiceResult}", nameof(GetODataAndDbCountAsync), _entityName, serviceResult);

            return serviceResult;
        }

        public async Task<int> DeleteAllAsync()
        {
            using var dbContext = _dbContextFactory.CreateDbContext();
            return await dbContext.Set<TEntity>().ExecuteDeleteAsync();
        }

        private async Task<int> InsertRangeAsync(TEntity[] values)
        {
            using var dbContext = _dbContextFactory.CreateDbContext();
            await dbContext.AddRangeAsync(values);
            return await dbContext.SaveChangesAsync();
        }

        private async Task<int> GetODataCountAsync()
        {
            string uri = _oDataParameters.GetCountUri();
            return await _oDataClient.GetValuesAsync<int>(uri);
        }
    }
}
