using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace WH.Domain.Models.Catalog
{
    public class CatalogПартнеры : Entity
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        public bool DeletionMark { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Parent_Key { get; set; }
        [MaxLength(AppSettings.DESCRIPTION)] public string? Description { get; set; }
        [MaxLength(AppSettings.GUID)] public string? БизнесРегион_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ОсновнойМенеджер_Key { get; set; }
        [Column(TypeName = nameof(SqlDbType.Date))] public DateTime ДатаРегистрации { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? ЮрФизЛицо { get; set; }
        public bool Клиент { get; set; }
        public bool Поставщик { get; set; }
        public bool Конкурент { get; set; }
        public bool ПрочиеОтношения { get; set; }
        public bool Перевозчик { get; set; }

        //public List<CatalogПартнерыДополнительныеРеквизиты>? ДополнительныеРеквизиты { get; set; }
        //[MaxLength(AppSettings.VALUE)] public string? Доброга_ЕмкостьПотенциальная { get; set; }
        //[MaxLength(AppSettings.FULL_NAME)] public string? НаименованиеПолное { get; set; }
        //public string? Code { get; set; }
        //public string ГруппаДоступа_Key { get;
        //public string DataVersion { get; set; } set; }
        //public bool ОбслуживаетсяТорговымиПредставителями { get; set; }
        //public string ДополнительнаяИнформация { get; set; }
        //public string ШаблонЭтикетки_Key { get; set; }
        //public string Комментарий { get; set; }
        //public string Пол { get; set; }
        //public DateTime ДатаРождения { get; set; }
        //public string НазначениеПереработчика_Key { get; set; }
        //public string ВариантОтправкиЭлектронногоЧека { get; set; }
        //public bool Доброга_Заполнено { get; set; }
        //public string Б_Идентификатор { get; set; }
        //public string Б_НомерВерсии { get; set; }
        //public Дополнительныереквизиты[] ДополнительныеРеквизиты { get; set; }
        //public Контактнаяинформация[] КонтактнаяИнформация { get; set; }
        //public bool Predefined { get; set; }
        //public string PredefinedDataName { get; set; }
    }

    public class CatalogПартнерыВидыДеятельности
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        public int LineNumber { get; set; }
        [MaxLength(AppSettings.GUID)] public required string ВидДеятельности_Key { get; set; }
    }

    public class CatalogПартнерыДополнительныеРеквизиты
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        public int LineNumber { get; set; }
        [MaxLength(AppSettings.GUID)] public required string Свойство_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public required string Значение { get; set; }

        //public string Значение_Type { get; set; }
        //public string ТекстоваяСтрока { get; set; }
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
