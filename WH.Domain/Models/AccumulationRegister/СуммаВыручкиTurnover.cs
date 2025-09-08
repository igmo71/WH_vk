using System.Text.Json.Serialization;

namespace WH.Domain.Models.AccumulationRegister
{
    public class СуммаВыручкиTurnover
    {
        [JsonPropertyName("СуммаВыручкиTurnover")]
        public double? Value { get; set; }
    }
}
