using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Text.Json.Serialization;

namespace WH.Domain.Models.AccumulationRegister
{
    public class AccumulationRegisterГрафикПоступленияТоваровRecordType : Entity, IHaveDate, IHaveId
    {
        [MaxLength(AppSettings.GUID)] public string? Id { get; set; }

        [Column(TypeName = nameof(SqlDbType.Date))]
        [JsonPropertyName("Period")] public DateTime Date { get; set; }

        [MaxLength(AppSettings.GUID)] public string? Recorder { get; set; }

        [MaxLength(AppSettings.VALUE)] public string? Recorder_Type { get; set; }

        public int LineNumber { get; set; }

        [MaxLength(AppSettings.GUID)] public string? Номенклатура_Key { get; set; }

        [MaxLength(AppSettings.GUID)] public string? Склад_Key { get; set; }

        [Column(TypeName = nameof(SqlDbType.Date))]
        public DateTime ДатаСобытия { get; set; }

        public double КоличествоИзЗаказов { get; set; }

        public double КоличествоПодЗаказ { get; set; }

        public double КоличествоИзЗаказовСНеподтвержденными { get; set; }

        public double КоличествоПодЗаказСНеподтвержденными { get; set; }

        //public bool Active { get; set; }
        //public string RecordType { get; set; }
        //public string Характеристика_Key { get; set; }
        //public string Назначение_Key { get; set; }
    }

}
