using System.ComponentModel.DataAnnotations;

namespace WH.Domain.Models.Catalog
{
    public class CatalogВидыНоменклатуры : Entity
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        public bool DeletionMark { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Parent_Key { get; set; }
        public bool IsFolder { get; set; }
        [MaxLength(AppSettings.DESCRIPTION)] public string? Description { get; set; }

        //public string DataVersion { get; set; }
        //public bool? АлкогольнаяПродукция { get; set; }
        //public string УдалитьВариантОказанияУслуг { get; set; }
        //public string ВариантОформленияПродажи { get; set; }
        //public string ВариантПредставленияНабораВПечатныхФормах { get; set; }
        //public string ВариантРасчетаЦеныНабора { get; set; }
        //public bool? ВестиУчетПоГТД { get; set; }
        //public bool? ВестиУчетСертификатовНоменклатуры { get; set; }
        //public string ВидАлкогольнойПродукции_Key { get; set; }
        //public string ВладелецСерий_Key { get; set; }
        //public string ВладелецТоварныхКатегорий_Key { get; set; }
        //public string ВладелецХарактеристик_Key { get; set; }
        //public string ГруппаАналитическогоУчета_Key { get; set; }
        //public string ГруппаДоступа_Key { get; set; }
        //public string ГруппаФинансовогоУчета_Key { get; set; }
        //public string ЕдиницаДляОтчетов_Key { get; set; }
        //public string ЕдиницаИзмерения_Key { get; set; }
        //public string ЕдиницаИзмеренияСрокаГодности { get; set; }
        //public bool? ЗапретРедактированияНаименованияДляПечатиНоменклатуры { get; set; }
        //public bool? ЗапретРедактированияНаименованияДляПечатиХарактеристики { get; set; }
        //public bool? ЗапретРедактированияРабочегоНаименованияНоменклатуры { get; set; }
        //public bool? ЗапретРедактированияРабочегоНаименованияХарактеристики { get; set; }
        //public bool? ИмпортнаяАлкогольнаяПродукция { get; set; }
        //public string ИспользованиеХарактеристик { get; set; }
        //public bool? ИспользоватьИндивидуальноеНаименованиеПриПечати { get; set; }
        //public bool? ИспользоватьКоличествоСерии { get; set; }
        //public bool? ИспользоватьНомерСерии { get; set; }
        //public bool? ИспользоватьСерии { get; set; }
        //public bool? ИспользоватьСрокГодностиСерии { get; set; }
        //public bool? ИспользоватьУпаковки { get; set; }
        //public bool? ИспользоватьХарактеристики { get; set; }
        //public bool? КонтролироватьДублиНоменклатуры { get; set; }
        //public bool? КонтролироватьДублиХарактеристик { get; set; }
        //public int? КоэффициентЕдиницыДляОтчетов { get; set; }
        //public string НаборСвойств_Key { get; set; }
        //public string НаборСвойствСерий_Key { get; set; }
        //public string НаборСвойствХарактеристик_Key { get; set; }
        //public string НаборУпаковок_Key { get; set; }
        //public string НаименованиеДляПечати { get; set; }
        //public string НастройкаИспользованияСерий { get; set; }
        //public string НоменклатураМногооборотнаяТара_Key { get; set; }
        //public bool? ОбособленнаяЗакупкаПродажа { get; set; }
        //public bool? НастройкиСерийБерутсяИзДругогоВидаНоменклатуры { get; set; }
        //public string Описание { get; set; }
        //public bool? ПодакцизныйТовар { get; set; }
        //public bool? ПоставляетсяВМногооборотнойТаре { get; set; }
        //public string СезоннаяГруппа_Key { get; set; }
        //public string УдалитьПолитикаУчетаСерийДляПодразделений_Key { get; set; }
        //public string ПолитикаУчетаСерий_Key { get; set; }
        //public string СкладскаяГруппа_Key { get; set; }
        //public bool? СодержитДрагоценныеМатериалы { get; set; }
        //public string ТипНоменклатуры { get; set; }
        //public string ТочностьУказанияСрокаГодностиСерии { get; set; }
        //public string СтавкаНДС { get; set; }
        //public string ХарактеристикаМногооборотнаяТара_Key { get; set; }
        //public bool? ТоварныеКатегорииОбщиеСДругимВидомНоменклатуры { get; set; }
        //public string ШаблонНаименованияДляПечатиНоменклатуры { get; set; }
        //public string ШаблонНаименованияДляПечатиХарактеристики { get; set; }
        //public string ШаблонРабочегоНаименованияНоменклатуры { get; set; }
        //public string ШаблонРабочегоНаименованияСерии { get; set; }
        //public string ШаблонРабочегоНаименованияХарактеристики { get; set; }
        //public string ШаблонЦенника_Key { get; set; }
        //public string ШаблонЭтикетки_Key { get; set; }
        //public string ШаблонЭтикеткиСерии_Key { get; set; }
        //public string КодОКВЭД_Key { get; set; }
        //public string КодТНВЭД_Key { get; set; }
        //public string КодОКП_Key { get; set; }
        //public string СхемаОбеспечения_Key { get; set; }
        //public string СпособОбеспеченияПотребностей_Key { get; set; }
        //public string ЦеноваяГруппа_Key { get; set; }
        //public int? Крепость { get; set; }
        //public string ОсобенностьУчета { get; set; }
        //public bool? ПродукцияМаркируемаяДляГИСМ { get; set; }
        //public bool? КиЗГИСМ { get; set; }
        //public bool? ИспользоватьRFIDМеткиСерии { get; set; }
        //public bool? ИспользоватьНомерКИЗГИСМСерии { get; set; }
        //public string УдалитьВариантНастройкиСерийДляСкладов { get; set; }
        //public string УдалитьВариантНастройкиСерийДляПодразделений { get; set; }
        //public bool? УдалитьСырьевойТовар { get; set; }
        //public bool? ПодконтрольнаяПродукцияВЕТИС { get; set; }
        //public string КодРаздел7ДекларацииНДС { get; set; }
        //public bool? АвтоматическиГенерироватьСерии { get; set; }
        //public bool? ИспользоватьДатуПроизводстваСерии { get; set; }
        //public bool? ИспользоватьПроизводителяЕГАИССерии { get; set; }
        //public bool? ИспользоватьСправку2ЕГАИССерии { get; set; }
        //public bool? ИспользоватьПроизводителяВЕТИССерии { get; set; }
        //public bool? ИспользоватьЗаписьСкладскогоЖурналаВЕТИССерии { get; set; }
        //public bool? ИспользоватьИдентификаторПартииВЕТИССерии { get; set; }
        //public bool? ОблагаетсяНДСУПокупателя { get; set; }
        //public string КодОКВЭД2_Key { get; set; }
        //public string КодОКПД2_Key { get; set; }
        //public string Б_Идентификатор { get; set; }
        //public string Б_НомерВерсии { get; set; }
        //public Реквизитыдляконтроляноменклатуры[] РеквизитыДляКонтроляНоменклатуры { get; set; }
        //public object[] РеквизитыДляКонтроляХарактеристик { get; set; }
        //public object[] РеквизитыДляКонтроляСерий { get; set; }
        //public Реквизитыбыстрогоотбораноменклатуры[] РеквизитыБыстрогоОтбораНоменклатуры { get; set; }
        //public object[] РеквизитыБыстрогоОтбораХарактеристик { get; set; }
        //public Политикиучетасерий[] ПолитикиУчетаСерий { get; set; }
        //public bool Predefined { get; set; }
        //public string PredefinedDataName { get; set; }        
    }

    //public class Реквизитыдляконтроляноменклатуры
    //{
    //    public string Ref_Key { get; set; }
    //    public string LineNumber { get; set; }
    //    public bool Уникален { get; set; }
    //    public string ИмяРеквизита { get; set; }
    //    public string ПредставлениеРеквизита { get; set; }
    //    public bool ЭтоДопРеквизит { get; set; }
    //    public bool ОбязателенДляЗаполнения { get; set; }
    //    public bool ОтборПриВыборе { get; set; }
    //    public string Свойство_Key { get; set; }
    //    public bool ОтображатьПриСоздании { get; set; }
    //    public bool ДоступностьУникален { get; set; }
    //    public bool ДоступностьОбязателенДляЗаполнения { get; set; }
    //    public bool ДоступностьОтображатьПриСоздании { get; set; }
    //}

    //public class Реквизитыбыстрогоотбораноменклатуры
    //{
    //    public string Ref_Key { get; set; }
    //    public string LineNumber { get; set; }
    //    public string ИмяРеквизита { get; set; }
    //    public string ПредставлениеРеквизита { get; set; }
    //    public bool ЭтоДопРеквизит { get; set; }
    //    public string Свойство_Key { get; set; }
    //    public bool Используется { get; set; }
    //}

    //public class Политикиучетасерий
    //{
    //    public string Ref_Key { get; set; }
    //    public string LineNumber { get; set; }
    //    public string Склад { get; set; }
    //    public string Склад_Type { get; set; }
    //    public string ПолитикаУчетаСерий_Key { get; set; }
    //}
}
