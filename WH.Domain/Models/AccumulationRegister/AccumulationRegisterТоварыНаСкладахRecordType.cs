using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Text.Json.Serialization;

namespace WH.Domain.Models.AccumulationRegister
{
    public class AccumulationRegisterТоварыНаСкладахRecordType : Entity, IHaveDate, IHaveId
    {
        [MaxLength(AppSettings.GUID)] public string? Id { get; set; }
        [Column(TypeName = nameof(SqlDbType.Date))]
        [JsonPropertyName("Period")] public DateTime Date { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Recorder { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Recorder_Type { get; set; }
        public int LineNumber { get; set; }
        [MaxLength(AppSettings.RECORD_TYPE)] public string? RecordType { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Номенклатура_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Назначение_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Склад_Key { get; set; }
        public double ВНаличии { get; set; }
        public double КОтгрузке { get; set; }
        public bool КонтролироватьОстатки { get; set; }

        //public bool Active { get; set; }
        //public string Характеристика_Key { get; set; }
        //public string Помещение_Key { get; set; }
        //public string Серия_Key { get; set; }
    }

}
