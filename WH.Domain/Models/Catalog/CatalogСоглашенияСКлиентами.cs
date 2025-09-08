using System.ComponentModel.DataAnnotations;

namespace WH.Domain.Models.Catalog
{
    public class CatalogСоглашенияСКлиентами : Entity
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        public bool DeletionMark { get; set; }
        [MaxLength(AppSettings.DESCRIPTION)] public string? Description { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Номер { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Партнер_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Соглашение_Key { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Статус { get; set; }

        //public string DataVersion { get; set; }
        //public DateTime Дата { get; set; }
        //public string СегментПартнеров_Key { get; set; }
        //public string Контрагент_Key { get; set; }
        //public string Организация_Key { get; set; }
        //public string Валюта_Key { get; set; }
        //public string ГрафикОплаты_Key { get; set; }
        //public int СуммаДокумента { get; set; }
        //public bool Типовое { get; set; }
        //public string СрокПоставки { get; set; }
        //public string ВидЦен_Key { get; set; }
        //public bool ЦенаВключаетНДС { get; set; }
        //public bool ИспользуетсяВРаботеТорговыхПредставителей { get; set; }
        //public string Склад_Key { get; set; }
        //public string СегментНоменклатуры_Key { get; set; }
        //public DateTime ДатаНачалаДействия { get; set; }
        //public DateTime ДатаОкончанияДействия { get; set; }
        //public string Комментарий { get; set; }
        //public bool Регулярное { get; set; }
        //public string Период { get; set; }
        //public int КоличествоПериодов { get; set; }
        //public bool Согласован { get; set; }
        //public string Менеджер_Key { get; set; }
        //public string УдалитьНалогообложениеНДС { get; set; }
        //public string ХозяйственнаяОперация { get; set; }
        //public string СпособРасчетаВознаграждения { get; set; }
        //public int ПроцентВознаграждения { get; set; }
        //public bool УдержатьВознаграждение { get; set; }
        //public int ПроцентРучнойСкидки { get; set; }
        //public int ПроцентРучнойНаценки { get; set; }
        //public bool ДоступноВнешнимПользователям { get; set; }
        //public string ПорядокОплаты { get; set; }
        //public string ГруппаФинансовогоУчета_Key { get; set; }
        //public bool ИспользуютсяДоговорыКонтрагентов { get; set; }
        //public bool ОграничиватьРучныеСкидки { get; set; }
        //public string ФормаОплаты { get; set; }
        //public string КонтактноеЛицо_Key { get; set; }
        //public string ПорядокРасчетов { get; set; }
        //public bool ВозвращатьМногооборотнуюТару { get; set; }
        //public int СрокВозвратаМногооборотнойТары { get; set; }
        //public bool РассчитыватьДатуВозвратаТарыПоКалендарю { get; set; }
        //public string Календарь_Key { get; set; }
        //public string ВариантРасчетаЦен { get; set; }
        //public string СценарийПланирования_Key { get; set; }
        //public string ВидПлана_Key { get; set; }
        //public bool ТребуетсяЗалогЗаТару { get; set; }
        //public string КалендарьВозвратаТары_Key { get; set; }
        //public string ВидСоглашенияДляОграниченияЧтения { get; set; }
        //public string ВидСоглашенияДляОграниченияИзменения { get; set; }
        //public string СтатьяДвиженияДенежныхСредств_Key { get; set; }
        //public bool ВозможнаРеализацияБезПереходаПраваСобственности { get; set; }
        //public bool ОбеспечиватьЗаказыОбособленно { get; set; }
        //public string КодНаименованияСделки { get; set; }
        //public string СпособОпределенияЦеныСделки { get; set; }
        //public string КодУсловийПоставки { get; set; }
        //public string НаправлениеДеятельности_Key { get; set; }
        //public string ВалютаВзаиморасчетов_Key { get; set; }
        //public bool РазбиватьРасходныеОрдераПоРаспоряжениям { get; set; }
        //public int МинимальнаяСуммаЗаказа { get; set; }
        //public string ЧастотаЗаказа { get; set; }
        //public bool Доброга_Доставка { get; set; }
        //public string Б_Идентификатор { get; set; }
        //public string Б_НомерВерсии { get; set; }
        //public object[] Товары { get; set; }
        //public Ценовыегруппы[] ЦеновыеГруппы { get; set; }
        //public object[] ДополнительныеРеквизиты { get; set; }
        //public Этапыграфикаоплаты[] ЭтапыГрафикаОплаты { get; set; }
        //public bool Predefined { get; set; }
        //public string PredefinedDataName { get; set; }        
    }

    //public class Ценовыегруппы
    //{
    //    public string Ref_Key { get; set; }
    //    public string LineNumber { get; set; }
    //    public string ЦеноваяГруппа_Key { get; set; }
    //    public string ВидЦен_Key { get; set; }
    //    public string СрокПоставки { get; set; }
    //    public int ПроцентРучнойСкидки { get; set; }
    //    public int ПроцентРучнойНаценки { get; set; }
    //}

    //public class Этапыграфикаоплаты
    //{
    //    public string Ref_Key { get; set; }
    //    public string LineNumber { get; set; }
    //    public string ВариантОплаты { get; set; }
    //    public string Сдвиг { get; set; }
    //    public int ПроцентПлатежа { get; set; }
    //    public int ПроцентЗалогаЗаТару { get; set; }
    //}
}
