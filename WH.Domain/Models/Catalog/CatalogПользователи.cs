using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WH.Domain.Models.Catalog
{
    public class CatalogПользователи : Entity
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        public bool DeletionMark { get; set; }
        [MaxLength(AppSettings.DESCRIPTION)] public string? Description { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Подразделение_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Доброга_СхемаПредприятия_Key { get; set; }

        [JsonPropertyName("Доброга_Должность")]
        [MaxLength(AppSettings.VALUE)] public string? Должность { get; set; }

        //public string DataVersion { get; set; }
        //public bool Недействителен { get; set; }
        //public string ФизическоеЛицо_Key { get; set; }
        //public string Комментарий { get; set; }
        //public bool Служебный { get; set; }
        //public bool Подготовлен { get; set; }
        //public string ИдентификаторПользователяИБ { get; set; }
        //public string ИдентификаторПользователяСервиса { get; set; }
        //public string СвойстваПользователяИБ_Type { get; set; }
        //public string СвойстваПользователяИБ_Base64Data { get; set; }
        //public Дополнительныереквизиты[] ДополнительныеРеквизиты { get; set; }
        //public Контактнаяинформация[] КонтактнаяИнформация { get; set; }
        //public bool Predefined { get; set; }
        //public string PredefinedDataName { get; set; }

    }

    //public class Дополнительныереквизиты
    //{
    //    public string Ref_Key { get; set; }
    //    public string LineNumber { get; set; }
    //    public string Свойство_Key { get; set; }
    //    public object Значение { get; set; }
    //    public string Значение_Type { get; set; }
    //    public string ТекстоваяСтрока { get; set; }
    //}

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
