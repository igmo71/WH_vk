using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Text.Json.Serialization;

namespace WH.Domain.Models.AccumulationRegister
{
    public class AccumulationRegisterВыручкаИСебестоимостьПродажRecordType : Entity, IHaveDate, IHaveId
    {
        [MaxLength(AppSettings.GUID)] public string? Id { get; set; }

        [Column(TypeName = nameof(SqlDbType.Date))]
        [JsonPropertyName("Period")] public DateTime Date { get; set; }

        [MaxLength(AppSettings.GUID)] public string? Recorder { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Recorder_Type { get; set; }
        public int LineNumber { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Номенклатура_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Подразделение_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Менеджер_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Партнер_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ЗаказКлиента { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? ЗаказКлиента_Type { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Соглашение_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Склад { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Склад_Type { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ДокументДвижения { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? ДокументДвижения_Type { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? ХозяйственнаяОперация { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ВидЗапасов_Key { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? ТипЗапасов { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? РазделУчета { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? ВидДеятельностиНДС { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? НалогообложениеНДС { get; set; }
        public double Количество { get; set; }
        public double СуммаВыручки { get; set; }
        public double СуммаВыручкиБезНДС { get; set; }
        public double Стоимость { get; set; }
        public double СтоимостьБезНДС { get; set; }
        public double ДопРасходы { get; set; }
        public double ДопРасходыБезНДС { get; set; }
        public double СуммаРучнойСкидки { get; set; }
        public double СуммаАвтоматическойСкидки { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Партия { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Партия_Type { get; set; }
        public bool РасчетСебестоимости { get; set; }
        public bool РасчетПартий { get; set; }
        public bool РасчетНеЗавершен { get; set; }

        [NotMapped]
        public АналитикаУчетаНоменклатуры? АналитикаУчетаНоменклатуры { get; set; }
        [NotMapped]
        public АналитикаУчетаПоПартнерам? АналитикаУчетаПоПартнерам { get; set; }

        //public bool Active { get; set; }
        //public string Партия { get; set; }
        //public string Партия_Type { get; set; }
        //public string АналитикаУчетаПартий_Key { get; set; }
        //public string АналитикаФинансовогоУчета { get; set; }
        //public string АналитикаФинансовогоУчета_Type { get; set; }
        //public string АналитикаУчетаНаборов_Key { get; set; }
        //public string Договор { get; set; }
        //public string Договор_Type { get; set; }
        //public string НаправлениеДеятельностиКонтрагента_Key { get; set; }
        //public string НаправлениеДеятельностиНоменклатуры_Key { get; set; }
        //public int СтоимостьУпр { get; set; }
        //public float СтоимостьРегл { get; set; }
        //public int СтоимостьЗабалансовая { get; set; }
        //public int СтоимостьЗабалансоваяРегл { get; set; }
        //public float СуммаВыручкиРегл { get; set; }
        //public int ПостояннаяРазница { get; set; }
        //public int ДопРасходыУпр { get; set; }
        //public float ДопРасходыРегл { get; set; }
        //public int ПостатейныеПостоянныеСНДС { get; set; }
        //public int ПостатейныеПостоянныеБезНДС { get; set; }
        //public int ПостатейныеПостоянныеУпр { get; set; }
        //public int ПостатейныеПостоянныеРегл { get; set; }
        //public int Трудозатраты { get; set; }
        //public int ТрудозатратыУпр { get; set; }
        //public int ТрудозатратыРегл { get; set; }
        //public int ПостатейныеПеременныеСНДС { get; set; }
        //public int ПостатейныеПеременныеБезНДС { get; set; }
        //public int ПостатейныеПеременныеУпр { get; set; }
        //public int ПостатейныеПеременныеРегл { get; set; }
        //public int ВременнаяРазница { get; set; }
        //public float СуммаВыручкиСНДСРегл { get; set; }
        //public string ВалютаВзаиморасчетов_Key { get; set; }
        //public float СуммаВВалютеВзаиморасчетов { get; set; }
        //public float СуммаБезНДСВВалютеВзаиморасчетов { get; set; }
        //public string ВалютаДокумента_Key { get; set; }
        //public float СуммаВВалютеДокумента { get; set; }
        //public float СуммаБезНДСВВалютеДокумента { get; set; }
        //public string ИсточникГФУНоменклатуры { get; set; }
        //public string ИсточникГФУНоменклатуры_Type { get; set; }
        //public string ИсточникГФУРасчетов { get; set; }
        //public string ИсточникГФУРасчетов_Type { get; set; }        
    }
}
