using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Xml.Linq;
using WH.Api.Data;
using WH.Domain.Models;

namespace WH.Api.Services
{
    public class CurrencyService(HttpClient httpClient, IDbContextFactory<AppDbContext> dbContextFactory, ILogger<CurrencyService> logger)
    {
        private readonly HttpClient _httpClient = httpClient;
        protected readonly IDbContextFactory<AppDbContext> _dbContextFactory = dbContextFactory;
        protected readonly ILogger<CurrencyService> _logger = logger;

        public async Task<ServiceResult> FetchAndStoreRatesAsync(DateTime? from, DateTime? to, string? currencyCode)
        {
            from ??= new DateTime(2023, 1, 1);
            to ??= DateTime.Today;
            currencyCode ??= "R01235";
         
            ServiceResult serviceResult = new();
            var loadingTimestamp = Stopwatch.GetTimestamp();

            using var dbContext = _dbContextFactory.CreateDbContext();
            await dbContext.CurrencyRates.Where(e => e.Date >= from && e.Date <= to).ExecuteDeleteAsync();

            string url = $"https://www.cbr.ru/scripts/XML_dynamic.asp?date_req1={from:dd.MM.yyyy}&date_req2={to:dd.MM.yyyy}&VAL_NM_RQ={currencyCode}";
            var response = await _httpClient.GetAsync(url);

            var encoding = Encoding.GetEncoding("windows-1251");
            var ruCulture = new CultureInfo("ru-RU");
            using var reader = new StreamReader(await response.Content.ReadAsStreamAsync(), encoding);
            var xml = XDocument.Load(reader);

            var rates = xml.Descendants("Record")
                           .Select(x => new CurrencyRate
                           {
                               Date = DateTime.Parse(x.Attribute("Date")!.Value, ruCulture),
                               CurrencyCode = currencyCode,
                               Value = decimal.Parse(x.Element("Value")!.Value.Replace(',', '.'), CultureInfo.InvariantCulture)
                           });

            dbContext.CurrencyRates.AddRange(rates);
            var insertedRows = await dbContext.SaveChangesAsync();

            serviceResult.Values["Entity"] = nameof(CurrencyRate);
            serviceResult.Values["Duration"] = Stopwatch.GetElapsedTime(loadingTimestamp);
            serviceResult.Values["InsertedRows"] = insertedRows;

            _logger.LogInformation("{Method} {Entity} {@ServiceResult}", nameof(FetchAndStoreRatesAsync), nameof(CurrencyRate), serviceResult);

            return serviceResult;
        }
    }
}
