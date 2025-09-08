namespace WH.Api.OData
{
    public interface IODataClient
    {
        Task<T?> GetValuesAsync<T>(string uri);
    }

    public class ODataClient(HttpClient httpClient) : IODataClient
    {
        private readonly HttpClient _httpClient = httpClient;

        public Task<T?> GetValuesAsync<T>(string uri) // TODO: use async/await ?
        {
            return _httpClient.GetFromJsonAsync<T>(uri);
        }
    }
}
