using System.Text.Json.Serialization;

namespace WH.Domain.Models.AccumulationRegister
{
    public class ВНаличииClosingBalance
    {
        [JsonPropertyName("ВНаличииClosingBalance")]
        public double? Value { get; set; }
    }
}
