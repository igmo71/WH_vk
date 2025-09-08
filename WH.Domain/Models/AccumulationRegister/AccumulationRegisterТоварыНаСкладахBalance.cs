using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace WH.Domain.Models.AccumulationRegister
{
    public class AccumulationRegisterТоварыНаСкладахBalance
    {
        public Guid Id { get; set; }
        [Column(TypeName = nameof(SqlDbType.Date))] public DateTime Date { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Номенклатура_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Склад_Key { get; set; }
        public double ВНаличииBalance { get; set; }
    }

}
