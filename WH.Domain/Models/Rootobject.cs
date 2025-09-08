using System.Text.Json.Serialization;

namespace WH.Domain.Models
{
    public class Rootobject<T>
    {
        [JsonPropertyName("odata.metadata")]
        public string? ODataMetadata { get; set; }


        [JsonPropertyName("odata.count")]
        public int? ODataCount { get; set; }


        [JsonPropertyName("value")]
        public T[]? Values { get; set; }
    }
}
