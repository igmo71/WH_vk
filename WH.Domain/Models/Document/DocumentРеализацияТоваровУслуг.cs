using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Text.Json.Serialization;

namespace WH.Domain.Models.Document
{
    public class DocumentРеализацияТоваровУслуг : Entity, IHaveDate
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Number { get; set; }
        [Column(TypeName = nameof(SqlDbType.Date))] public DateTime Date { get; set; }
        public double СуммаДокумента { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Подразделение_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Менеджер_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Склад_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Партнер_Key { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? ХозяйственнаяОперация { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ЗаказКлиента { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? ЗаказКлиента_Type { get; set; }
        public bool РеализацияПоЗаказам { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Статус { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? НалогообложениеНДС { get; set; }
        public bool ЦенаВключаетНДС { get; set; }
        public bool Согласован { get; set; }
        public bool СкидкиРассчитаны { get; set; }
        public List<DocumentРеализацияТоваровУслугТовары>? Товары { get; set; }

        [JsonPropertyName("Доброга_ИсточникЗаявки_Key")]
        [MaxLength(AppSettings.GUID)] public string? ИсточникЗаявки_Key { get; set; }

        //public string DataVersion { get; set; }
        //public bool DeletionMark { get; set; }
        //public bool Posted { get; set; }
        //public double СуммаВзаиморасчетов { get; set; }
        //public string Соглашение_Key { get; set; 
        //public string ФормаОплаты { get; set; }
        //public string Договор_Key { get; set; }
        //public string Основание { get; set; }
        //public DateTime ОснованиеДата { get; set; }
        //public string ОснованиеНомер { get; set; }
        //public string ПорядокОплаты { get; set; }}
        //public string Организация_Key { get; set; }
        //public string Контрагент_Key { get; set; }
        //public string НаправлениеДеятельности_Key { get; set; }
        //public string Комментарий { get; set; }
        //public string АдресДоставки { get; set; }
        //public string БанковскийСчетОрганизации_Key { get; set; }
        //public string БанковскийСчетКонтрагента_Key { get; set; }
        //public string БанковскийСчетГрузоотправителя_Key { get; set; }
        //public string БанковскийСчетГрузополучателя_Key { get; set; }
        //public string Валюта_Key { get; set; }
        //public string ВалютаВзаиморасчетов_Key { get; set; }
        //public string Грузоотправитель_Key { get; set; }
        //public string Грузополучатель_Key { get; set; }
        //public DateTime УдалитьДатаПлатежа { get; set; }
        //public DateTime ДатаРаспоряжения { get; set; }
        //public string ДоверенностьВыдана { get; set; }
        //public DateTime ДоверенностьДата { get; set; }
        //public string ДоверенностьЛицо { get; set; }
        //public string ДоверенностьНомер { get; set; }
        //public string Сделка_Key { get; set; }
        //public string Касса_Key { get; set; }
        //public string Отпустил_Key { get; set; }
        //public string ОтпустилДолжность { get; set; }
        //public string ГруппаФинансовогоУчета_Key { get; set; }
        //public string КартаЛояльности_Key { get; set; }
        //public string Автор_Key { get; set; }
        //public double УдалитьСуммаПредоплаты { get; set; }
        //public double УдалитьСуммаПредоплатыЗаТару { get; set; }
        //public string СпособДоставки { get; set; }
        //public string ЗонаДоставки_Key { get; set; }
        //public string АдресДоставкиЗначенияПолей { get; set; }
        //public string ПеревозчикПартнер_Key { get; set; }
        //public DateTime ВремяДоставкиС { get; set; }
        //public DateTime ВремяДоставкиПо { get; set; }
        //public string АдресДоставкиПеревозчика { get; set; }
        //public string АдресДоставкиПеревозчикаЗначенияПолей { get; set; }
        //public string ДополнительнаяИнформацияПоДоставке { get; set; }
        //public string КонтактноеЛицо_Key { get; set; }
        //public string Руководитель_Key { get; set; }
        //public string ГлавныйБухгалтер_Key { get; set; }
        //public string ПорядокРасчетов { get; set; }
        //public bool ВернутьМногооборотнуюТару { get; set; }
        //public DateTime ДатаВозвратаМногооборотнойТары { get; set; }
        //public string СостояниеЗаполненияМногооборотнойТары { get; set; }
        //public bool ВидыЗапасовУказаныВручную { get; set; }
        //public bool ТребуетсяЗалогЗаТару { get; set; }
        //public string ДопоставкаПоРеализации { get; set; }
        //public string ДопоставкаПоРеализации_Type { get; set; }
        //public DateTime ДатаПереходаПраваСобственности { get; set; }
        //public string ВариантОформленияПродажи { get; set; }
        //public string ИдентификаторПлатежа { get; set; }
        //public bool ОсобыеУсловияПеревозки { get; set; }
        //public string ОсобыеУсловияПеревозкиОписание { get; set; }
        //public double Курс { get; set; }
        //public string Кратность { get; set; }
        //public bool ЕстьМаркируемаяПродукцияГИСМ { get; set; }
        //public bool УдалитьЕстьАлкогольнаяПродукцияДляРеализацииРозницаЕГАИС { get; set; }
        //public bool ЕстьДокументы { get; set; }
        //public string дбр_ФизЛицоОформившееПродажу_Key { get; set; }
        //public double СуммаВзаиморасчетовПоТаре { get; set; }
        //public DateTime Доброга_ЖелаемаяДатаДоставки { get; set; }
        //public string Доброга_ЗаданиеДляКладовщика { get; set; }
        //public DateTime Б_ДатаДокумента { get; set; }
        //public string Б_Идентификатор { get; set; }
        //public string Б_НомерВерсии { get; set; }
        //public object[] СкидкиНаценки { get; set; }
        //public ВидыЗапасов[] ВидыЗапасов { get; set; }
        //public object[] ДополнительныеРеквизиты { get; set; }
        //public РасшифровкаПлатежа[] РасшифровкаПлатежа { get; set; }
        //public object[] Серии { get; set; }
        //public Этапыграфикаоплаты[] ЭтапыГрафикаОплаты { get; set; }       
    }

    public class DocumentРеализацияТоваровУслугТовары
    {
        [MaxLength(AppSettings.GUID)] public required string ИдентификаторСтроки { get; set; }
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        public int LineNumber { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Номенклатура_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Упаковка_Key { get; set; }
        public double КоличествоУпаковок { get; set; }
        public double Количество { get; set; }
        public double Цена { get; set; }
        public double Сумма { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ВидЦены_Key { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? СтавкаНДС { get; set; }
        public double СуммаНДС { get; set; }
        public double СуммаСНДС { get; set; }
        public double СуммаРучнойСкидки { get; set; }
        public double ПроцентРучнойСкидки { get; set; }
        public double СуммаАвтоматическойСкидки { get; set; }
        public double ПроцентАвтоматическойСкидки { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Склад_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ЗаказКлиента { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? ЗаказКлиента_Type { get; set; }
        public int КодСтроки { get; set; }

        //public double СуммаВзаиморасчетов { get; set; }
        //public string АналитикаУчетаНоменклатуры_Key { get; set; }
        //public string Характеристика_Key { get; set; }
        //public string Назначение_Key { get; set; }
        //public string КлючСвязи { get; set; }
        //public string СрокПоставки { get; set; }
        //public int СтатусУказанияСерий { get; set; }
        //public string Серия_Key { get; set; }
        //public string НоменклатураНабора_Key { get; set; }
        //public string ХарактеристикаНабора_Key { get; set; }
        //public string АналитикаУчетаНаборов_Key { get; set; }
        //public string КодТНВЭД_Key { get; set; }
    }

    //public class ВидыЗапасов
    //{
    //    public string Ref_Key { get; set; }
    //    public string LineNumber { get; set; }
    //    public string АналитикаУчетаНоменклатуры_Key { get; set; }
    //    public string ВидЗапасов_Key { get; set; }
    //    public string НомерГТД_Key { get; set; }
    //    public string Упаковка_Key { get; set; }
    //    public double КоличествоУпаковок { get; set; }
    //    public double Количество { get; set; }
    //    public double СуммаСНДС { get; set; }
    //    public string СтавкаНДС { get; set; }
    //    public double СуммаНДС { get; set; }
    //    public string ИдентификаторСтроки { get; set; }
    //    public double СуммаВзаиморасчетов { get; set; }
    //    public string ЗаказКлиента { get; set; }
    //    public string ЗаказКлиента_Type { get; set; }
    //    public double СуммаРучнойСкидки { get; set; }
    //    public int СуммаАвтоматическойСкидки { get; set; }
    //    public string АналитикаУчетаНаборов_Key { get; set; }
    //    public double Цена { get; set; }
    //    public string ВидЗапасовПолучателя_Key { get; set; }
    //    public string КодТНВЭД_Key { get; set; }
    //}

    //public class РасшифровкаПлатежа
    //{
    //    public string Ref_Key { get; set; }
    //    public string LineNumber { get; set; }
    //    public string Заказ { get; set; }
    //    public string Заказ_Type { get; set; }
    //    public double Сумма { get; set; }
    //    public string ВалютаВзаиморасчетов_Key { get; set; }
    //    public double СуммаВзаиморасчетов { get; set; }
    //}

    //public class ЭтапыГрафикаОплаты
    //{
    //    public string Ref_Key { get; set; }
    //    public string LineNumber { get; set; }
    //    public string Заказ { get; set; }
    //    public string Заказ_Type { get; set; }
    //    public bool СверхЗаказа { get; set; }
    //    public string ВариантОплаты { get; set; }
    //    public DateTime ДатаПлатежа { get; set; }
    //    public string Сдвиг { get; set; }
    //    public double СуммаПлатежа { get; set; }
    //    public int ПроцентПлатежа { get; set; }
    //    public int СуммаЗалогаЗаТару { get; set; }
    //    public int ПроцентЗалогаЗаТару { get; set; }
    //    public double СуммаВзаиморасчетов { get; set; }
    //    public int СуммаВзаиморасчетовПоТаре { get; set; }
    //}
}
