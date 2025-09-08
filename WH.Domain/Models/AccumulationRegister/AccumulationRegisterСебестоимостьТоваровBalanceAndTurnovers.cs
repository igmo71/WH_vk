using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace WH.Domain.Models.AccumulationRegister
{
    public class AccumulationRegisterСебестоимостьТоваровBalanceAndTurnovers : Entity, IHaveDate, IHaveId
    {
        [MaxLength(AppSettings.GUID)] public string? Id { get; set; }
        [Column(TypeName = nameof(SqlDbType.Date))] public DateTime Date { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Номенклатура_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Партия { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Партия_Type { get; set; }
        public double КоличествоOpeningBalance { get; set; }
        public double КоличествоTurnover { get; set; }
        public double КоличествоReceipt { get; set; }
        public double КоличествоExpense { get; set; }
        public double КоличествоClosingBalance { get; set; }
        public double СтоимостьOpeningBalance { get; set; }
        public double СтоимостьTurnover { get; set; }
        public double СтоимостьReceipt { get; set; }
        public double СтоимостьExpense { get; set; }
        public double СтоимостьClosingBalance { get; set; }
        //public double ДопРасходыOpeningBalance { get; set; }
        //public double ДопРасходыTurnover { get; set; }
        //public double ДопРасходыReceipt { get; set; }
        //public double ДопРасходыExpense { get; set; }
        //public double ДопРасходыClosingBalance { get; set; }

        [NotMapped]
        public АналитикаУчетаНоменклатуры? АналитикаУчетаНоменклатуры { get; set; }

        //public string АналитикаУчетаНоменклатуры_Key { get; set; }
        //public string РазделУчета { get; set; }
        //public string ВидЗапасов_Key { get; set; }
        //public string Организация_Key { get; set; }
        //public string АналитикаУчетаПартий_Key { get; set; }
        //public string АналитикаФинансовогоУчета { get; set; }
        //public string АналитикаФинансовогоУчета_Type { get; set; }
        //public string ВидДеятельностиНДС { get; set; }
        //public float СтоимостьБезНДСOpeningBalance { get; set; }
        //public int СтоимостьБезНДСTurnover { get; set; }
        //public int СтоимостьБезНДСReceipt { get; set; }
        //public int СтоимостьБезНДСExpense { get; set; }
        //public float СтоимостьБезНДСClosingBalance { get; set; }
        //public int СтоимостьЗабалансоваяOpeningBalance { get; set; }
        //public int СтоимостьЗабалансоваяTurnover { get; set; }
        //public int СтоимостьЗабалансоваяReceipt { get; set; }
        //public int СтоимостьЗабалансоваяExpense { get; set; }
        //public int СтоимостьЗабалансоваяClosingBalance { get; set; }
        //public int ДопРасходыБезНДСOpeningBalance { get; set; }
        //public int ДопРасходыБезНДСTurnover { get; set; }
        //public int ДопРасходыБезНДСReceipt { get; set; }
        //public int ДопРасходыБезНДСExpense { get; set; }
        //public int ДопРасходыБезНДСClosingBalance { get; set; }
        //public int ТрудозатратыOpeningBalance { get; set; }
        //public int ТрудозатратыTurnover { get; set; }
        //public int ТрудозатратыReceipt { get; set; }
        //public int ТрудозатратыExpense { get; set; }
        //public int ТрудозатратыClosingBalance { get; set; }
        //public int ПостатейныеПостоянныеСНДСOpeningBalance { get; set; }
        //public int ПостатейныеПостоянныеСНДСTurnover { get; set; }
        //public int ПостатейныеПостоянныеСНДСReceipt { get; set; }
        //public int ПостатейныеПостоянныеСНДСExpense { get; set; }
        //public int ПостатейныеПостоянныеСНДСClosingBalance { get; set; }
        //public int ПостатейныеПеременныеСНДСOpeningBalance { get; set; }
        //public int ПостатейныеПеременныеСНДСTurnover { get; set; }
        //public int ПостатейныеПеременныеСНДСReceipt { get; set; }
        //public int ПостатейныеПеременныеСНДСExpense { get; set; }
        //public int ПостатейныеПеременныеСНДСClosingBalance { get; set; }
        //public int ПостатейныеПостоянныеБезНДСOpeningBalance { get; set; }
        //public int ПостатейныеПостоянныеБезНДСTurnover { get; set; }
        //public int ПостатейныеПостоянныеБезНДСReceipt { get; set; }
        //public int ПостатейныеПостоянныеБезНДСExpense { get; set; }
        //public int ПостатейныеПостоянныеБезНДСClosingBalance { get; set; }
        //public int ПостатейныеПеременныеБезНДСOpeningBalance { get; set; }
        //public int ПостатейныеПеременныеБезНДСTurnover { get; set; }
        //public int ПостатейныеПеременныеБезНДСReceipt { get; set; }
        //public int ПостатейныеПеременныеБезНДСExpense { get; set; }
        //public int ПостатейныеПеременныеБезНДСClosingBalance { get; set; }
        //public float СтоимостьРеглOpeningBalance { get; set; }
        //public int СтоимостьРеглTurnover { get; set; }
        //public int СтоимостьРеглReceipt { get; set; }
        //public int СтоимостьРеглExpense { get; set; }
        //public float СтоимостьРеглClosingBalance { get; set; }
        //public int СтоимостьЗабалансоваяРеглOpeningBalance { get; set; }
        //public int СтоимостьЗабалансоваяРеглTurnover { get; set; }
        //public int СтоимостьЗабалансоваяРеглReceipt { get; set; }
        //public int СтоимостьЗабалансоваяРеглExpense { get; set; }
        //public int СтоимостьЗабалансоваяРеглClosingBalance { get; set; }
        //public int ДопРасходыРеглOpeningBalance { get; set; }
        //public int ДопРасходыРеглTurnover { get; set; }
        //public int ДопРасходыРеглReceipt { get; set; }
        //public int ДопРасходыРеглExpense { get; set; }
        //public int ДопРасходыРеглClosingBalance { get; set; }
        //public int ТрудозатратыРеглOpeningBalance { get; set; }
        //public int ТрудозатратыРеглTurnover { get; set; }
        //public int ТрудозатратыРеглReceipt { get; set; }
        //public int ТрудозатратыРеглExpense { get; set; }
        //public int ТрудозатратыРеглClosingBalance { get; set; }
        //public int ПостатейныеПостоянныеРеглOpeningBalance { get; set; }
        //public int ПостатейныеПостоянныеРеглTurnover { get; set; }
        //public int ПостатейныеПостоянныеРеглReceipt { get; set; }
        //public int ПостатейныеПостоянныеРеглExpense { get; set; }
        //public int ПостатейныеПостоянныеРеглClosingBalance { get; set; }
        //public int ПостатейныеПеременныеРеглOpeningBalance { get; set; }
        //public int ПостатейныеПеременныеРеглTurnover { get; set; }
        //public int ПостатейныеПеременныеРеглReceipt { get; set; }
        //public int ПостатейныеПеременныеРеглExpense { get; set; }
        //public int ПостатейныеПеременныеРеглClosingBalance { get; set; }
        //public int ПостояннаяРазницаOpeningBalance { get; set; }
        //public int ПостояннаяРазницаTurnover { get; set; }
        //public int ПостояннаяРазницаReceipt { get; set; }
        //public int ПостояннаяРазницаExpense { get; set; }
        //public int ПостояннаяРазницаClosingBalance { get; set; }
        //public int ВременнаяРазницаOpeningBalance { get; set; }
        //public int ВременнаяРазницаTurnover { get; set; }
        //public int ВременнаяРазницаReceipt { get; set; }
        //public int ВременнаяРазницаExpense { get; set; }
        //public int ВременнаяРазницаClosingBalance { get; set; }
        //public int СтоимостьУпрOpeningBalance { get; set; }
        //public int СтоимостьУпрTurnover { get; set; }
        //public int СтоимостьУпрReceipt { get; set; }
        //public int СтоимостьУпрExpense { get; set; }
        //public int СтоимостьУпрClosingBalance { get; set; }
        //public int ДопРасходыУпрOpeningBalance { get; set; }
        //public int ДопРасходыУпрTurnover { get; set; }
        //public int ДопРасходыУпрReceipt { get; set; }
        //public int ДопРасходыУпрExpense { get; set; }
        //public int ДопРасходыУпрClosingBalance { get; set; }
        //public int ТрудозатратыУпрOpeningBalance { get; set; }
        //public int ТрудозатратыУпрTurnover { get; set; }
        //public int ТрудозатратыУпрReceipt { get; set; }
        //public int ТрудозатратыУпрExpense { get; set; }
        //public int ТрудозатратыУпрClosingBalance { get; set; }
        //public int ПостатейныеПостоянныеУпрOpeningBalance { get; set; }
        //public int ПостатейныеПостоянныеУпрTurnover { get; set; }
        //public int ПостатейныеПостоянныеУпрReceipt { get; set; }
        //public int ПостатейныеПостоянныеУпрExpense { get; set; }
        //public int ПостатейныеПостоянныеУпрClosingBalance { get; set; }
        //public int ПостатейныеПеременныеУпрOpeningBalance { get; set; }
        //public int ПостатейныеПеременныеУпрTurnover { get; set; }
        //public int ПостатейныеПеременныеУпрReceipt { get; set; }
        //public int ПостатейныеПеременныеУпрExpense { get; set; }
        //public int ПостатейныеПеременныеУпрClosingBalance { get; set; }
    }

    //public class Аналитикаучетаноменклатуры
    //{
    //    public string Номенклатура_Key { get; set; }
    //    public string Характеристика_Key { get; set; }
    //    public string Серия_Key { get; set; }
    //    public string Назначение_Key { get; set; }
    //    public string PredefinedDataName { get; set; }
    //    public bool DeletionMark { get; set; }
    //    public string Склад { get; set; }
    //    public string Склад_Type { get; set; }
    //    public string СтатьяКалькуляции { get; set; }
    //    public string DataVersion { get; set; }
    //    public string Ref_Key { get; set; }
    //    public bool Predefined { get; set; }
    //    public string Description { get; set; }
    //    public string НоменклатураnavigationLinkUrl { get; set; }
    //}

}
