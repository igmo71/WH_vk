using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace WH.Domain.Models.InformationRegister
{
    public class InformationRegisterЦеныНоменклатурыЗакупочныеSliceLast
    {
        public Guid Id { get; set; }
        [Column(TypeName = nameof(SqlDbType.Date))] public DateTime Date { get; set; }
        public DateTime Period { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Номенклатура_Key { get; set; }
        public double Цена { get; set; }
    }

}
