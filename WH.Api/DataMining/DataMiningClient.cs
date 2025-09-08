using System.Net.Mime;
using System.Text;
using System.Text.Json;
using WH.Domain.Models.DataMining;

namespace WH.Api.DataMining
{
    public interface IDataMiningClient
    {
        Task<ScuSaleRank[]?> GetScuSaleRanksAsync(string uri, string body);
        Task<Predict[]?> GetPredictsAsync(string uri, string body);
    }


    public class DataMiningClient(HttpClient httpClient) : IDataMiningClient
    {
        private readonly HttpClient _httpClient = httpClient;

        public async Task<ScuSaleRank[]?> GetScuSaleRanksAsync(string uri, string body)
        {
            var stringContent = new StringContent(body, encoding: Encoding.UTF8, MediaTypeNames.Text.Plain);

            using var response = await _httpClient.PostAsync(uri, stringContent);

            if (!response.IsSuccessStatusCode)
                return default;

            var responseContent = await response.Content.ReadAsStringAsync();

            var values = JsonSerializer.Deserialize<ScuSaleRank[]>(responseContent);

            return values;
        }

        public async Task<Predict[]?> GetPredictsAsync(string uri, string body)
        {
            var stringContent = new StringContent(body, encoding: Encoding.UTF8, MediaTypeNames.Text.Plain);

            using var response = await _httpClient.PostAsync(uri, stringContent);

            if (!response.IsSuccessStatusCode)
                return default;

            var responseContent = await response.Content.ReadAsStringAsync();

            var values = JsonSerializer.Deserialize<Predict[]>(responseContent);

            return values;
        }
    }
}
