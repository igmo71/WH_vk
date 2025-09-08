using System.ComponentModel.DataAnnotations;

namespace WH.Domain.Models.Catalog
{
    public class CatalogСклады : Entity
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        public bool DeletionMark { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Parent_Key { get; set; }
        public bool IsFolder { get; set; }
        [MaxLength(AppSettings.DESCRIPTION)] public string? Description { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Подразделение_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? БизнесРегион_Key { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? ТипСклада { get; set; }

        //public string DataVersion { get; set; }
        //public string ВыборГруппы { get; set; }
        //public bool? ИспользоватьАдресноеХранение { get; set; }
        //public bool? ИспользоватьАдресноеХранениеСправочно { get; set; }
        //public bool? ИспользоватьОрдернуюСхемуПриОтгрузке { get; set; }
        //public bool? ИспользоватьОрдернуюСхемуПриОтраженииИзлишковНедостач { get; set; }
        //public bool? ИспользоватьОрдернуюСхемуПриПоступлении { get; set; }
        //public bool? ИспользоватьСерииНоменклатуры { get; set; }
        //public bool? ИспользоватьСкладскиеПомещения { get; set; }
        //public string Календарь_Key { get; set; }
        //public bool? КонтролироватьОперативныеОстатки { get; set; }
        //public string НастройкаАдресногоХранения { get; set; }
        //public string РозничныйВидЦены_Key { get; set; }
        //public string ТекущаяДолжностьОтветственного { get; set; }
        //public string ТекущийОтветственный_Key { get; set; }
        //public string УровеньОбслуживания { get; set; }
        //public string УчетныйВидЦены_Key { get; set; }
        //public bool? НачинатьОтгрузкуПослеФормированияЗаданияНаПеревозку { get; set; }
        //public string ИспользованиеРабочихУчастков { get; set; }
        //public string ИсточникИнформацииОЦенахДляПечати { get; set; }
        //public bool? ИспользоватьСтатусыРасходныхОрдеров { get; set; }
        //public bool? ИспользоватьСтатусыПриходныхОрдеров { get; set; }
        //public bool? ИспользоватьСтатусыПересчетовТоваров { get; set; }
        //public DateTime? ДатаНачалаОрдернойСхемыПриОтгрузке { get; set; }
        //public DateTime? ДатаНачалаОрдернойСхемыПриПоступлении { get; set; }
        //public DateTime? ДатаНачалаОрдернойСхемыПриОтраженииИзлишковНедостач { get; set; }
        //public DateTime? ДатаНачалаИспользованияСкладскихПомещений { get; set; }
        //public DateTime? ДатаНачалаАдресногоХраненияОстатков { get; set; }
        //public bool? УчитыватьСебестоимостьПоСериям { get; set; }
        //public bool? КонтролироватьОбеспечение { get; set; }
        //public bool? СкладОтветственногоХранения { get; set; }
        //public string ВидПоклажедержателя { get; set; }
        //public string Поклажедержатель { get; set; }
        //public string Поклажедержатель_Type { get; set; }
        //public int? СрокОтветственногоХранения { get; set; }
        //public bool? ОтветственноеХранениеДоВостребования { get; set; }
        //public string ОсобыеОтметки { get; set; }
        //public string УсловияХраненияТоваров { get; set; }
        //public bool? ЦеховаяКладовая { get; set; }
        //public bool Доброга_СкладОтгрузки { get; set; }
        //public string Доброга_НаименованиеПолное { get; set; }
        //public string Б_Идентификатор { get; set; }
        //public string Б_НомерВерсии { get; set; }
        //public Контактнаяинформация[] КонтактнаяИнформация { get; set; }
        //public object[] ДополнительныеРеквизиты { get; set; }
        //public bool Predefined { get; set; }
        //public string PredefinedDataName { get; set; }        
    }

    //public class Контактнаяинформация
    //{
    //    public string Ref_Key { get; set; }
    //    public string LineNumber { get; set; }
    //    public string Тип { get; set; }
    //    public string Вид_Key { get; set; }
    //    public string Представление { get; set; }
    //    public string ЗначенияПолей { get; set; }
    //    public string Страна { get; set; }
    //    public string Регион { get; set; }
    //    public string Город { get; set; }
    //    public string АдресЭП { get; set; }
    //    public string ДоменноеИмяСервера { get; set; }
    //    public string НомерТелефона { get; set; }
    //    public string НомерТелефонаБезКодов { get; set; }
    //    public string ВидДляСписка_Key { get; set; }
    //    public string Значение { get; set; }
    //}
}
