using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Text.Json.Serialization;

namespace WH.Domain.Models.AccumulationRegister
{
    public class AccumulationRegisterВыручкаИСебестоимостьПродажTurnovers : Entity, IHaveDate, IHaveId
    {
        [MaxLength(AppSettings.GUID)] public string? Id { get; set; }
        [Column(TypeName = nameof(SqlDbType.Date))] public DateTime Date { get; set; }

        [MaxLength(AppSettings.GUID)] public string? Номенклатура_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Партнер_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Подразделение_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Менеджер_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ЗаказКлиента { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? ЗаказКлиента_Type { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Соглашение_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Склад { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Склад_Type { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? ХозяйственнаяОперация { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ВидЗапасов_Key { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? ТипЗапасов { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? РазделУчета { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? ВидДеятельностиНДС { get; set; }

        [JsonPropertyName("КоличествоTurnover")] public double Количество { get; set; }
        [JsonPropertyName("СуммаВыручкиTurnover")] public double СуммаВыручки { get; set; }
        [JsonPropertyName("СуммаВыручкиБезНДСTurnover")] public double СуммаВыручкиБезНДС { get; set; }
        [JsonPropertyName("СтоимостьTurnover")] public double Стоимость { get; set; }
        [JsonPropertyName("СтоимостьБезНДСTurnover")] public double СтоимостьБезНДС { get; set; }
        [JsonPropertyName("ДопРасходыTurnover")] public double ДопРасходы { get; set; }
        [JsonPropertyName("ДопРасходыБезНДСTurnover")] public double ДопРасходыБезНДС { get; set; }
        [JsonPropertyName("ТрудозатратыTurnover")] public double Трудозатраты { get; set; }
        [JsonPropertyName("СуммаРучнойСкидкиTurnover")] public double СуммаРучнойСкидки { get; set; }
        [JsonPropertyName("СуммаАвтоматическойСкидкиTurnover")] public double СуммаАвтоматическойСкидки { get; set; }

        [NotMapped]
        public АналитикаУчетаНоменклатуры? АналитикаУчетаНоменклатуры { get; set; }
        [NotMapped]
        public АналитикаУчетаПоПартнерам? АналитикаУчетаПоПартнерам { get; set; }

        //[MaxLength(AppSettings.GUID)] public string? АналитикаУчетаПартий_Key { get; set; }
        //[MaxLength(AppSettings.GUID)] public string? Соглашение_Key { get; set; }
        //[MaxLength(AppSettings.GUID)] public string? Договор { get; set; }
        //[MaxLength(AppSettings.VALUE)] public string? Договор_Type { get; set; }
        //[MaxLength(AppSettings.GUID)] public string? Партия { get; set; }
        //[MaxLength(AppSettings.VALUE)] public string? Партия_Type { get; set; }
        //[MaxLength(AppSettings.GUID)] public string? АналитикаФинансовогоУчета { get; set; }
        //[MaxLength(AppSettings.VALUE)] public string? АналитикаФинансовогоУчета_Type { get; set; }
        //[MaxLength(AppSettings.GUID)] public string? АналитикаУчетаНаборов_Key { get; set; }
        //[MaxLength(AppSettings.GUID)] public string? НаправлениеДеятельностиКонтрагента_Key { get; set; }
        //[MaxLength(AppSettings.GUID)] public string? НаправлениеДеятельностиНоменклатуры_Key { get; set; }

        //[JsonPropertyName("СуммаВыручкиРеглTurnover")] public double СуммаВыручкиРегл { get; set; }
        //[JsonPropertyName("СуммаВыручкиСНДСРеглTurnover")] public double СуммаВыручкиСНДСРегл { get; set; }
        //[JsonPropertyName("СтоимостьУпрTurnover")] public double СтоимостьУпр { get; set; }
        //[JsonPropertyName("СтоимостьРеглTurnover")] public double СтоимостьРегл { get; set; }
        //[JsonPropertyName("СтоимостьЗабалансоваяTurnover")] public double СтоимостьЗабалансовая { get; set; }
        //[JsonPropertyName("СтоимостьЗабалансоваяРеглTurnover")] public double СтоимостьЗабалансоваяРегл { get; set; }
        //[JsonPropertyName("ДопРасходыУпрTurnover")] public double ДопРасходыУпр { get; set; }
        //[JsonPropertyName("ДопРасходыРеглTurnover")] public double ДопРасходыРегл { get; set; }
        //[JsonPropertyName("ТрудозатратыУпрTurnover")] public double ТрудозатратыУпр { get; set; }
        //[JsonPropertyName("ТрудозатратыРеглTurnover")] public double ТрудозатратыРегл { get; set; }
        //[JsonPropertyName("ПостояннаяРазницаTurnover")] public double ПостояннаяРазница { get; set; }
        //[JsonPropertyName("ВременнаяРазницаTurnover")] public double ВременнаяРазница { get; set; }
        //[JsonPropertyName("ПостатейныеПостоянныеСНДСTurnover")] public double ПостатейныеПостоянныеСНДС { get; set; }
        //[JsonPropertyName("ПостатейныеПостоянныеБезНДСTurnover")] public double ПостатейныеПостоянныеБезНДС { get; set; }
        //[JsonPropertyName("ПостатейныеПостоянныеУпрTurnover")] public double ПостатейныеПостоянныеУпр { get; set; }
        //[JsonPropertyName("ПостатейныеПостоянныеРеглTurnover")] public double ПостатейныеПостоянныеРегл { get; set; }
        //[JsonPropertyName("ПостатейныеПеременныеСНДСTurnover")] public double ПостатейныеПеременныеСНДС { get; set; }
        //[JsonPropertyName("ПостатейныеПеременныеБезНДСTurnover")] public double ПостатейныеПеременныеБезНДС { get; set; }
        //[JsonPropertyName("ПостатейныеПеременныеУпрTurnover")] public double ПостатейныеПеременныеУпр { get; set; }
        //[JsonPropertyName("ПостатейныеПеременныеРеглTurnover")] public double ПостатейныеПеременныеРегл { get; set; }
    }
}
