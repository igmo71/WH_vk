using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Text.Json.Serialization;

namespace WH.Domain.Models.InformationRegister
{
    public class InformationRegisterЦеныНоменклатурыRecordType : Entity, IHaveDate, IHaveId, IHaveRecorder, IHaveLineNumber
    {
        // Period,Recorder,Recorder_Type,LineNumber,Номенклатура_Key,Упаковка_Key,ВидЦены_Key,Цена
        [MaxLength(AppSettings.ID)] public string? Id { get; set; }

        [Column(TypeName = nameof(SqlDbType.Date))]
        [JsonPropertyName("Period")] public DateTime Date { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Recorder { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Recorder_Type { get; set; }
        public int LineNumber { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Номенклатура_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Упаковка_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ВидЦены_Key { get; set; }
        public double Цена { get; set; }

        //[MaxLength(AppSettings.GUID)] public string? Recorder { get; set; }
        //[MaxLength(AppSettings.VALUE)] public string? Recorder_Type { get; set; }
        //public bool Active { get; set; }
        //public string Характеристика_Key { get; set; }
        //public string Валюта_Key { get; set; }
    }
}
