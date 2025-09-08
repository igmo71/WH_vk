using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Text.Json.Serialization;

namespace WH.Domain.Models.Document
{
    public class DocumentАктОРасхожденияхПослеОтгрузки : Entity, IHaveDate
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Number { get; set; }
        [Column(TypeName = nameof(SqlDbType.Date))] public DateTime Date { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Партнер_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Менеджер_Key { get; set; }
        public double МассаБруттоПоФакту { get; set; }
        public double МассаНеттоПоФакту { get; set; }
        public List<DocumentАктОРасхожденияхПослеОтгрузкиТовары>? Товары { get; set; }

        //public string DataVersion { get; set; }
        //public bool DeletionMark { get; set; }
        //public bool Posted { get; set; }
        //public string Организация_Key { get; set; }
        //public string ОснованиеДляСоставленияАкта { get; set; }
        //public string Валюта_Key { get; set; }
        //public string МестоПриемкиТовара { get; set; }
        //public DateTime ДатаДоставкиТоваров { get; set; }
        //public string ПереченьСопроводительныхДокументов { get; set; }
        //public string ВызываемыйПредставительПартнера { get; set; }
        //public string ВидДокументаВызоваПредставителяПартнера { get; set; }
        //public string НомерДокументаОВызовеПредставителяПартнера { get; set; }
        //public DateTime ДатаДокументаОВызовеПредставителяПартнера { get; set; }
        //public string Грузоотправитель { get; set; }
        //public string Производитель { get; set; }
        //public string Контрагент_Key { get; set; }
        //public string СтраховаяКомпания_Key { get; set; }
        //public string КонтрагентСтраховойКомпании_Key { get; set; }
        //public string НомерДоговораПоставки { get; set; }
        //public DateTime ДатаДоговораПоставки { get; set; }
        //public string НомерКоммерческогоАкта { get; set; }
        //public DateTime ДатаКоммерческогоАкта { get; set; }
        //public string НомерУдостоверенияОКачестве { get; set; }
        //public DateTime ДатаУдостоверенияОКачестве { get; set; }
        //public string НомерВетеринарногоСвидетельства { get; set; }
        //public DateTime ДатаВетеринарногоСвидетельства { get; set; }
        //public string НомерЖелезнодорожнойНакладной { get; set; }
        //public DateTime ДатаЖелезнодорожнойНакладной { get; set; }
        //public string НомерКоносамента { get; set; }
        //public DateTime ДатаКоносамента { get; set; }
        //public string СпособДоставки { get; set; }
        //public string НомерТранспортногоСредства { get; set; }
        //public DateTime ДатаОтправленияТоваров { get; set; }
        //public string ПунктОтправления { get; set; }
        //public string СкладОтправителяТовара { get; set; }
        //public string СведенияОСостоянииТранспортаПоСопроводительнымДокументам { get; set; }
        //public string СведенияОСостоянииТранспортаПоФакту { get; set; }
        //public string УсловияХраненияТовараДоВскрытияНаСкладеПолучателя { get; set; }
        //public int СведенияОТемпературеПриРазгрузке { get; set; }
        //public string СостояниеТарыИУпаковки { get; set; }
        //public string СодержаниеНаружнойМаркировки { get; set; }
        //public DateTime ДатаВскрытияТары { get; set; }
        //public string ОрганизацияВзвесившаяИОпломбировавшаяТовар { get; set; }
        //public string ПорядокОтбораТовараДляВыборочнойПроверки { get; set; }
        //public string СпособОпределенияКоличества { get; set; }
        //public string МестоОпределенияКоличества { get; set; }
        //public string СведенияОбИсправностиВесоизмерительныхПриборов { get; set; }
        //public string ПрочиеДанные { get; set; }
        //public string ПодробноеОписаниеДефектов { get; set; }
        //public string ЗаключениеКомиссии { get; set; }
        //public string Приложение { get; set; }
        //public string ДокументУдостоверяющийПолномочияПредставителяПартнера { get; set; }
        //public string НомерДокументаУдостоверяющегоПолномочияПредставителяПартнера { get; set; }
        //public DateTime ДатаВыдачиДокументаУдостоверяющегоПолномочияПредставителяПартнера { get; set; }
        //public int КоличествоЛистовПриложения { get; set; }
        //public string РешениеРуководителя { get; set; }
        //public string КладовщикПринявшийТовар { get; set; }
        //public int МассаБруттоПоДаннымПроизводителя { get; set; }
        //public int МассаБруттоВПунктеОтправления { get; set; }
        //public int МассаБруттоВПунктеНазначения { get; set; }
        //public string КоличествоМестПоДокументамГрузоотправителя { get; set; }
        //public string КоличествоМестПоФакту { get; set; }
        //public int МассаБруттоПоДокументамГрузоотправителя { get; set; }
        //public int МассаНеттоПоДокументамГрузоотправителя { get; set; }
        //public int МассаТарыПоДокументамГрузоотправителя { get; set; }
        //public int МассаТарыПоФакту { get; set; }
        //public string СтепеньЗаполненияПоДокументамГрузоотправителя { get; set; }
        //public string СтепеньЗаполненияПоФакту { get; set; }
        //public string ПредседательКомиссии { get; set; }
        //public string ДолжностьПредседателяКомиссии { get; set; }
        //public string ЧленКомиссии1 { get; set; }
        //public string ДолжностьЧленаКомиссии1 { get; set; }
        //public string ЧленКомиссии2 { get; set; }
        //public string ДолжностьЧленаКомиссии2 { get; set; }
        //public string ЧленКомиссии3 { get; set; }
        //public string ДолжностьЧленаКомиссии3 { get; set; }
        //public string Комментарий { get; set; }
        //public string КонтактноеЛицо_Key { get; set; }
        //public string Руководитель { get; set; }
        //public string ГлавныйБухгалтер { get; set; }
        //public string Соглашение { get; set; }
        //public string Соглашение_Type { get; set; }
        //public string Статус { get; set; }
        //public string НалогообложениеНДС { get; set; }
        //public bool ЦенаВключаетНДС { get; set; }
        //public string ХозяйственнаяОперация { get; set; }
        //public string Договор_Key { get; set; }
        //public string ДополнительнаяИнформация { get; set; }
        //public string ДолжностьРуководителя { get; set; }
        //public int ТемператураВТолщеМясаРыбы { get; set; }
        //public string СпособОтраженияРасхождений { get; set; }
        //public string ТипОснованияАктаОРасхождении { get; set; }
        //public string НомерВходящегоДокумента { get; set; }
        //public DateTime ДатаВходящегоДокумента { get; set; }
        //public string Подразделение_Key { get; set; }
        //public object[] ПриемкаТоваров { get; set; }
        //public object[] Серии { get; set; }
        //public object[] ДополнительныеРеквизиты { get; set; }
    }

    public class DocumentАктОРасхожденияхПослеОтгрузкиТовары
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        public int LineNumber { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Номенклатура_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Реализация { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Реализация_Type { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ЗаказКлиента { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? ЗаказКлиента_Type { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Склад_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Упаковка_Key { get; set; }
        public double КоличествоУпаковок { get; set; }
        public double Количество { get; set; }
        public double Цена { get; set; }
        public double Сумма { get; set; }
        public double КоличествоУпаковокПоДокументу { get; set; }
        public double КоличествоПоДокументу { get; set; }
        public double СуммаПоДокументу { get; set; }
        public bool ЗаполненоПоРеализации { get; set; }

        [JsonPropertyName("САР_ПричинаРасхождения_Key")]
        [MaxLength(AppSettings.GUID)] public string? ПричинаРасхожденияKey { get; set; }

        //public string ТекстовоеОписание { get; set; }
        //public string Характеристика_Key { get; set; }
        //public string Назначение_Key { get; set; }
        //public string ВидЦены_Key { get; set; }
        //public string КодСтроки { get; set; }
        //public string СтавкаНДС { get; set; }
        //public float СуммаНДС { get; set; }
        //public float СуммаСНДС { get; set; }
        //public string Серия_Key { get; set; }
        //public int СтатусУказанияСерий { get; set; }
        //public float СуммаНДСПоДокументу { get; set; }
        //public float СуммаСНДСПоДокументу { get; set; }
        //public string НомерПаспорта { get; set; }
        //public string Действие { get; set; }
        //public string КомментарийКлиента { get; set; }
        //public string КомментарийМенеджера { get; set; }
        //public string ДокументПоступления_Key { get; set; }
    }
}
