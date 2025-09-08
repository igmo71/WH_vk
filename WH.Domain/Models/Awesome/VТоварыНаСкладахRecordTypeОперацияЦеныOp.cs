using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace WH.Domain.Models.Awesome
{
    public class VТоварыНаСкладахRecordTypeОперацияЦеныOp : Entity
    {
        [Column(TypeName = nameof(SqlDbType.Date))]
        public DateTime Date { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Recorder { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Recorder_Type { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Операция { get; set; }
        [MaxLength(AppSettings.RECORD_TYPE)] public string? RecordType { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Номенклатура_Key { get; set; }
        public double? ВНаличии { get; set; }
        public double? Количество { get; set; }
        public double? ЦенаЗакупки { get; set; }
        public double? ЦенаПродажи { get; set; }
    }
}
