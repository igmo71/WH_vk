using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WH.Domain.Models.DataMining
{
    public class Predict : Entity
    {
        [JsonPropertyName("Номенклатура Вид Подвид Key")]
        [MaxLength(73)] public string? НоменклатураВидПодвидKey { get; set; }

        [JsonPropertyName("Expression.$TIME")]
        public int WeekNum { get; set; }

        [JsonPropertyName("Expression.Вес")]
        public double Вес { get; set; }

        [MaxLength(AppSettings.GUID)] public string? ВидНоменклатуры_Key { get; set; }

        [MaxLength(AppSettings.GUID)] public string? ПодвидНоменклатуры_Key { get; set; }

        [MaxLength(AppSettings.GUID)] public string? Склад { get; set; }
    }
}
