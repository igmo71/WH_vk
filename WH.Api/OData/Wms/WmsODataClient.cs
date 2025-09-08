namespace WH.Api.OData.Wms
{
    public interface IWmsODataClient : IODataClient
    { }

    public class WmsODataClient(HttpClient httpClient) : IWmsODataClient
    {
        private readonly HttpClient _httpClient = httpClient;

        public Task<T?> GetValuesAsync<T>(string uri) // TODO: use async/await ?
        {
            return _httpClient.GetFromJsonAsync<T>(uri);
        }
    }
}
