using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace WH.Domain.Models.Wms
{
    public class AccumulationRegisterТоварыВЯчейкахBalanceAndTurnovers : Entity, IHaveDate, IHaveId
    {
        [MaxLength(AppSettings.GUID)] public string? Id { get; set; }
        [Column(TypeName = nameof(SqlDbType.Date))] public DateTime Date { get; set; }

        [MaxLength(AppSettings.GUID)] public string? Склад_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Ячейка_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Номенклатура_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Серия_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ЕдиницаИзмерения_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Паллет_Key { get; set; }
        public DateTime Дата { get; set; }
        public double КоличествоOpeningBalance { get; set; }
        public double КоличествоTurnover { get; set; }
        public double КоличествоReceipt { get; set; }
        public double КоличествоExpense { get; set; }
        public double КоличествоClosingBalance { get; set; }
    }
}
