using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WH.Domain.Models.DataMining
{
    public class ScuSaleRank : Entity
    {
        [MaxLength(AppSettings.GUID)] public string? Id { get; set; }

        [JsonPropertyName("[Номенклатура Вид-Подвид].[Номенклатура Вид - Подвид].[Вид].[MEMBER_CAPTION]")]
        [MaxLength(AppSettings.DESCRIPTION)]
        public string? ВидНоменклатуры { get; set; }


        [JsonPropertyName("[Номенклатура Вид-Подвид].[Номенклатура Вид - Подвид].[Подвид].[MEMBER_CAPTION]")]
        [MaxLength(AppSettings.DESCRIPTION)]
        public string? ПодвидНоменклатуры { get; set; }


        [JsonPropertyName("[Номенклатура Вид-Подвид].[Номенклатура Вид - Подвид].[Номенклатура].[MEMBER_CAPTION]")]
        [MaxLength(AppSettings.DESCRIPTION)]
        public string? Номенклатура { get; set; }


        [JsonPropertyName("[Measures].[Вид]")]
        [MaxLength(AppSettings.GUID)]
        public string? ВидНоменклатуры_Key { get; set; }


        [JsonPropertyName("[Measures].[Подвид]")]
        [MaxLength(AppSettings.GUID)]
        public string? ПодвидНоменклатуры_Key { get; set; }


        [JsonPropertyName("[Measures].[Номенклатура]")]
        [MaxLength(AppSettings.GUID)]
        public string? Номенклатура_Key { get; set; }


        [JsonPropertyName("[Measures].[Вес1]")]
        [MaxLength(AppSettings.VALUE)]
        [NotMapped]
        public string? ВесStr { get; set; }

        public double Вес { get; set; }


        [JsonPropertyName("[Measures].[Percentage]")]
        [MaxLength(AppSettings.VALUE)]
        [NotMapped]
        public string? PercentageStr { get; set; }

        public double Percentage { get; set; }

        [MaxLength(AppSettings.GUID)] public string? Склад { get; set; }
    }
}
