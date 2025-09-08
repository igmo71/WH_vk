using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace WH.Domain.Models.AccumulationRegister
{
    public class AccumulationRegisterТоварыНаСкладахBalanceAndTurnovers : Entity, IHaveDate, IHaveId
    {
        [MaxLength(AppSettings.GUID)] public string? Id { get; set; }
        [Column(TypeName = nameof(SqlDbType.Date))] public DateTime Date { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Номенклатура_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Склад_Key { get; set; }
        public double ВНаличииOpeningBalance { get; set; }
        public double ВНаличииTurnover { get; set; }
        public double ВНаличииReceipt { get; set; }
        public double ВНаличииExpense { get; set; }
        public double ВНаличииClosingBalance { get; set; }

        public double КОтгрузкеOpeningBalance { get; set; }
        public double КОтгрузкеTurnover { get; set; }
        public double КОтгрузкеReceipt { get; set; }
        public double КОтгрузкеExpense { get; set; }
        public double КОтгрузкеClosingBalance { get; set; }

        //public string Характеристика_Key { get; set; }
        //public string Назначение_Key { get; set; }
        //public string Помещение_Key { get; set; }
        //public string Серия_Key { get; set; }
    }

}
