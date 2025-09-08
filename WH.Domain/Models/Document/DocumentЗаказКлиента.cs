using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Text.Json.Serialization;

namespace WH.Domain.Models.Document
{
    public class DocumentЗаказКлиента : Entity, IHaveDate
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Number { get; set; }
        [Column(TypeName = nameof(SqlDbType.Date))] public DateTime Date { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Подразделение_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Менеджер_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Склад_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Партнер_Key { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? ХозяйственнаяОперация { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Статус { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? НалогообложениеНДС { get; set; }
        public double СуммаДокумента { get; set; }
        public bool ЦенаВключаетНДС { get; set; }
        public bool Согласован { get; set; }
        public bool СкидкиРассчитаны { get; set; }
        public List<DocumentЗаказКлиентаТовары>? Товары { get; set; }

        [JsonPropertyName("Доброга_ИсточникЗаявки_Key")]
        [MaxLength(AppSettings.GUID)] public string? ИсточникЗаявки_Key { get; set; }

        //public string DataVersion { get; set; }
        //public bool DeletionMark { get; set; }
        //public bool Posted { get; set; }
        //public string Контрагент_Key { get; set; }
        //public string Организация_Key { get; set; }
        //public string Соглашение_Key { get; set; }
        //public string Сделка_Key { get; set; }
        //public string Валюта_Key { get; set; }
        //public string ГрафикОплаты_Key { get; set; }
        //public DateTime ЖелаемаяДатаОтгрузки { get; set; }
        //public string ДополнительнаяИнформация { get; set; }
        //public string ДокументОснование { get; set; }
        //public string ДокументОснование_Type { get; set; }
        //public bool НеОтгружатьЧастями { get; set; }
        //public string МаксимальныйКодСтроки { get; set; }
        //public DateTime ДатаСогласования { get; set; }
        //public string ФормаОплаты { get; set; }
        //public string БанковскийСчет_Key { get; set; }
        //public string БанковскийСчетКонтрагента_Key { get; set; }
        //public string Касса_Key { get; set; }
        //public int СуммаАвансаДоОбеспечения { get; set; }
        //public int СуммаПредоплатыДоОтгрузки { get; set; }
        //public DateTime ДатаОтгрузки { get; set; }
        //public string АдресДоставки { get; set; }
        //public string Комментарий { get; set; }
        //public string НомерПоДаннымКлиента { get; set; }
        //public DateTime ДатаПоДаннымКлиента { get; set; }
        //public string Грузоотправитель_Key { get; set; }
        //public string Грузополучатель_Key { get; set; }
        //public string БанковскийСчетГрузоотправителя_Key { get; set; }
        //public string БанковскийСчетГрузополучателя_Key { get; set; }
        //public string ГруппаФинансовогоУчета_Key { get; set; }
        //public string КартаЛояльности_Key { get; set; }
        //public string Договор_Key { get; set; }
        //public string Автор { get; set; }
        //public string Автор_Type { get; set; }
        //public string ПорядокРасчетов { get; set; }
        //public string Назначение_Key { get; set; }
        //public string СпособДоставки { get; set; }
        //public string ПеревозчикПартнер_Key { get; set; }
        //public string ЗонаДоставки_Key { get; set; }
        //public DateTime ВремяДоставкиС { get; set; }
        //public DateTime ВремяДоставкиПо { get; set; }
        //public string АдресДоставкиПеревозчика { get; set; }
        //public string АдресДоставкиЗначенияПолей { get; set; }
        //public string АдресДоставкиПеревозчикаЗначенияПолей { get; set; }
        //public string ДополнительнаяИнформацияПоДоставке { get; set; }
        //public string КонтактноеЛицо_Key { get; set; }
        //public string Руководитель_Key { get; set; }
        //public string ГлавныйБухгалтер_Key { get; set; }
        //public bool ВернутьМногооборотнуюТару { get; set; }
        //public int СрокВозвратаМногооборотнойТары { get; set; }
        //public string СостояниеЗаполненияМногооборотнойТары { get; set; }
        //public int СуммаВозвратнойТары { get; set; }
        //public string НазначениеПлатежа { get; set; }
        //public bool ТребуетсяЗалогЗаТару { get; set; }
        //public string Приоритет_Key { get; set; }
        //public string ИдентификаторПлатежа { get; set; }
        //public bool ОсобыеУсловияПеревозки { get; set; }
        //public string ОсобыеУсловияПеревозкиОписание { get; set; }
        //public string НаправлениеДеятельности_Key { get; set; }
        //public string ПорядокОплаты { get; set; }
        //public DateTime Доброга_ДатаСозданияДокумента { get; set; }
        ////public DateTime Доброга_ЖелаемаяДатаДоставки { get; set; }
        //public string Доброга_ДоставкаДолгота { get; set; }
        //public string Доброга_ДоставкаШирота { get; set; }
        //public bool Доброга_СкидкиСогласованы { get; set; }
        //public string Доброга_ЗаданиеДляКладовщика { get; set; }
        //public string Доброга_ДоставкаКонтактноеЛицо { get; set; }
        //public string Доброга_ДоставкаТелефон { get; set; }
        //public DateTime Б_ДатаДокумента { get; set; }
        //public string Б_Идентификатор { get; set; }
        //public string Б_НомерВерсии { get; set; }
        //public Этапыграфикаоплаты[] ЭтапыГрафикаОплаты { get; set; }
        //public object[] СкидкиНаценки { get; set; }
        //public Дополнительныереквизиты[] ДополнительныеРеквизиты { get; set; }        
    }

    public class DocumentЗаказКлиентаТовары
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        public int LineNumber { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Номенклатура_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Упаковка_Key { get; set; }
        public double КоличествоУпаковок { get; set; }
        public double Количество { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ВидЦены_Key { get; set; }
        public double Цена { get; set; }
        public double Сумма { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? СтавкаНДС { get; set; }
        public double СуммаНДС { get; set; }
        public double СуммаСНДС { get; set; }
        public double СуммаРучнойСкидки { get; set; }
        public double ПроцентРучнойСкидки { get; set; }
        public double СуммаАвтоматическойСкидки { get; set; }
        public double ПроцентАвтоматическойСкидки { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Склад_Key { get; set; }
        public bool Отменено { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ПричинаОтмены_Key { get; set; }
        public int КодСтроки { get; set; }
        public DateTime ДатаОтгрузки { get; set; }

        //public string КлючСвязи { get; set; }
        //public string Характеристика_Key { get; set; }
        //public string СрокПоставки { get; set; }
        //public string Содержание { get; set; }
        //public int СтатусУказанияСерий { get; set; }
        //public string ВариантОбеспечения { get; set; }
        //public string Серия_Key { get; set; }
        //public string НоменклатураНабора_Key { get; set; }
        //public string ХарактеристикаНабора_Key { get; set; }
    }

    //public class Этапыграфикаоплаты
    //{
    //    public string Ref_Key { get; set; }
    //    public string LineNumber { get; set; }
    //    public string ВариантОплаты { get; set; }
    //    public DateTime ДатаПлатежа { get; set; }
    //    public int ПроцентПлатежа { get; set; }
    //    public int СуммаПлатежа { get; set; }
    //    public int ПроцентЗалогаЗаТару { get; set; }
    //    public int СуммаЗалогаЗаТару { get; set; }
    //    public int СуммаОтклоненияМерныхТоваров { get; set; }
    //    public string Сдвиг { get; set; }
    //}

    //public class Дополнительныереквизиты
    //{
    //    public string Ref_Key { get; set; }
    //    public string LineNumber { get; set; }
    //    public string Свойство_Key { get; set; }
    //    public string Значение { get; set; }
    //    public string Значение_Type { get; set; }
    //    public string ТекстоваяСтрока { get; set; }
    //}
}
