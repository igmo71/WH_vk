
namespace WH.Api.Voximplant
{
    public interface IVoximplantClient
    {
        Task<T?> GetValuesAsync<T>(string uri);
    }

    public class VoximplantClient(HttpClient httpClient) : IVoximplantClient
    {
        private readonly HttpClient _httpClient = httpClient;

        public Task<T?> GetValuesAsync<T>(string uri) // TODO: use async/await ?
        {
            return _httpClient.GetFromJsonAsync<T>(uri);
        }
    }
}
