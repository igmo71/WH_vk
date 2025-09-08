using System.ComponentModel.DataAnnotations;

namespace WH.Domain.Models.Awesome
{
    public class VТоварыНаСкладахBalanceAndTurnoversNoWhs
    {
        public DateTime Date { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Номенклатура_Key { get; set; }
        public double? ВНаличииOpeningBalance { get; set; }
        public double? ВНаличииClosingBalance { get; set; }
        public double? ВНаличииTurnover { get; set; }
        public double? ВНаличииReceipt { get; set; }
        public double? ВНаличииExpense { get; set; }
    }
}
