using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WH.Domain.Models.Catalog
{
    public class CatalogНоменклатура : Entity
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        public bool DeletionMark { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Parent_Key { get; set; }
        public bool IsFolder { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Артикул { get; set; }
        [MaxLength(AppSettings.DESCRIPTION)] public string? Description { get; set; }
        [MaxLength(AppSettings.GUID)] public string? БазоваяНоменклатура_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ВидНоменклатуры_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ПодвидНоменклатуры_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ТипУпаковки_Key { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? ТипНоменклатуры { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Производитель_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Марка_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ЦеноваяГруппа_Key { get; set; }
        public double? ВесЧислитель { get; set; }
        public double? ВесЗнаменатель { get; set; }

        [NotMapped]
        public ДополнительныйРеквизит[]? ДополнительныеРеквизиты { get; set; }

        //[MaxLength(AppSettings.FULL_NAME)] public string? НаименованиеПолное { get; set; }
        //[Column(TypeName = nameof(SqlDbType.Date))] public DateTime? Доброга_ДатаСоздания { get; set; }
        //[MaxLength(AppSettings.VALUE)] public string? ГоловнаяНоменклатура { get; set; }
        //[MaxLength(AppSettings.VALUE)] public string? ГоловнаяНоменклатура_Type { get; set; }
        //public double? КоэффициентГоловной { get; set; }
        //public string? Code { get; set; }
        //public string? DataVersion { get; set; }
        //public bool? АлкогольнаяПродукция { get; set; }
        //public string? ВариантОформленияПродажи { get; set; }
        //public string? ВесЕдиницаИзмерения_Key { get; set; }   // TODO: ?
        //public bool? ВесИспользовать { get; set; }
        //public bool? ВесМожноУказыватьВДокументах { get; set; }
        //public bool? ВестиУчетПоГТД { get; set; }
        //public bool? ВестиУчетСертификатовНоменклатуры { get; set; }
        //public string? ВидАлкогольнойПродукции_Key { get; set; }
        //public string? ГруппаДоступа_Key { get; set; }
        //public string? ГруппаФинансовогоУчета_Key { get; set; }
        //public string? ЕдиницаИзмерения_Key { get; set; }   // TODO: ?
        //public string? ЕдиницаИзмеренияСрокаГодности { get; set; }
        //public bool? ЕстьТоварыДругогоКачества { get; set; }
        //public bool? ИмпортнаяАлкогольнаяПродукция { get; set; }
        //public string? ДлинаЕдиницаИзмерения_Key { get; set; }
        //public int? ДлинаЗнаменатель { get; set; }
        //public bool? ДлинаИспользовать { get; set; }
        //public bool? ДлинаМожноУказыватьВДокументах { get; set; }
        //public int? ДлинаЧислитель { get; set; }
        //public string? ИспользованиеХарактеристик { get; set; }
        //public bool? ИспользоватьИндивидуальныйШаблонЦенника { get; set; }
        //public bool? ИспользоватьИндивидуальныйШаблонЭтикетки { get; set; }
        //public bool? ИспользоватьУпаковки { get; set; }
        //public string? Качество { get; set; }
        //public string? КодДляПоиска { get; set; }   // TODO: ?
        //public string? НаборУпаковок_Key { get; set; }   // TODO: ?
        //public string? НоменклатураМногооборотнаяТара_Key { get; set; }
        //public int? ОбъемДАЛ { get; set; }
        //public string? Описание { get; set; }
        //public bool? ПодакцизныйТовар { get; set; }
        //public bool? ПоставляетсяВМногооборотнойТаре { get; set; }
        //public string? ПроизводительИмпортерДляДекларацийАлко_Key { get; set; }
        //public string? СкладскаяГруппа_Key { get; set; }
        //public string? СрокГодности { get; set; }
        //public string? СтавкаНДС { get; set; }
        //public string? ТоварнаяКатегория_Key { get; set; }   // TODO: ?
        //public string? ФайлКартинки_Key { get; set; }
        //public string? ФайлОписанияДляСайта_Key { get; set; }
        //public string? ОбъемЕдиницаИзмерения_Key { get; set; }
        //public int? ОбъемЗнаменатель { get; set; }
        //public bool? ОбъемИспользовать { get; set; }
        //public bool? ОбъемМожноУказыватьВДокументах { get; set; }
        //public float? ОбъемЧислитель { get; set; }
        //public string? ХарактеристикаМногооборотнаяТара_Key { get; set; }
        //public string? ПлощадьЕдиницаИзмерения_Key { get; set; }
        //public int? ПлощадьЗнаменатель { get; set; }
        //public string? СхемаОбеспечения_Key { get; set; }
        //public string? СпособОбеспеченияПотребностей_Key { get; set; }
        //public bool? ПлощадьИспользовать { get; set; }
        //public bool? ПлощадьМожноУказыватьВДокументах { get; set; }
        //public int? ПлощадьЧислитель { get; set; }        
        //public string? ШаблонЦенника_Key { get; set; }
        //public string? ЕдиницаДляОтчетов_Key { get; set; }
        //public float? КоэффициентЕдиницыДляОтчетов { get; set; }
        //public string? ШаблонЭтикетки_Key { get; set; }
        //public string? СезоннаяГруппа_Key { get; set; }
        //public string? КоллекцияНоменклатуры_Key { get; set; }
        //public string? Принципал { get; set; }
        //public string? Принципал_Type { get; set; }
        //public string? Контрагент { get; set; }
        //public string? Контрагент_Type { get; set; }
        //public string? РейтингПродаж_Key { get; set; }
        //public bool? ОбособленнаяЗакупкаПродажа { get; set; }
        //public string? ГруппаАналитическогоУчета_Key { get; set; }
        //public string? КодТНВЭД_Key { get; set; }
        //public string? КодОКВЭД_Key { get; set; }
        //public string? КодОКП_Key { get; set; }
        //public bool? ОблагаетсяНДПИПоПроцентнойСтавке { get; set; }
        //public string? ВладелецСерий_Key { get; set; }
        //public string? ВладелецХарактеристик_Key { get; set; }
        //public string? ВладелецТоварныхКатегорий_Key { get; set; }
        //public int? Крепость { get; set; }
        //public string? ОсобенностьУчета { get; set; }
        //public bool? ПродукцияМаркируемаяДляГИСМ { get; set; }
        //public bool? КиЗГИСМ { get; set; }
        //public string? КиЗГИСМВид { get; set; }
        //public string? КиЗГИСМСпособВыпускаВОборот { get; set; }
        //public string? КиЗГИСМGTIN { get; set; }
        //public string? КиЗГИСМРазмер { get; set; }
        //public bool? УдалитьСырьевойТовар { get; set; }
        //public bool? ПодконтрольнаяПродукцияВЕТИС { get; set; }
        //public bool? АлкогольнаяПродукцияВоВскрытойТаре { get; set; }
        //public string? КодРаздел7ДекларацииНДС { get; set; }
        //public bool? ОблагаетсяНДСУПокупателя { get; set; }
        //public string? КодОКВЭД2_Key { get; set; }
        //public string? КодОКПД2_Key { get; set; }
        //public string? Б_Идентификатор { get; set; }
        //public string? Б_НомерВерсии { get; set; }
        //public object[] ДрагоценныеМатериалы { get; set; }
        //public bool Predefined { get; set; }
        //public string? PredefinedDataName { get; set; }
    }

    public class ДополнительныйРеквизит
    {
        //public string? Ref_Key { get; set; }
        //public string? LineNumber { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Свойство_Key { get; set; }
        public string? Значение { get; set; }
        //public string? Значение_Type { get; set; }
        //public string? ТекстоваяСтрока { get; set; }
    }
}
