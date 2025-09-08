using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Text.Json.Serialization;

namespace WH.Domain.Models.Document
{
    public class DocumentУстановкаЦенНоменклатуры : Entity, IHaveDate
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Number { get; set; }
        [Column(TypeName = nameof(SqlDbType.Date))] public DateTime Date { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Ответственный_Key { get; set; }
        public bool Согласован { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ДокументОснование { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? ДокументОснование_Type { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Статус { get; set; }

        [JsonPropertyName("Товары2_5")]
        public List<DocumentУстановкаЦенНоменклатурыТовары>? Товары { get; set; }

        //public string DataVersion { get; set; }
        //public bool DeletionMark { get; set; }
        //public bool Posted { get; set; }
        //public string Комментарий { get; set; }
        //public Видыцен[] ВидыЦен { get; set; }
        //public Наборызначенийдоступа[] НаборыЗначенийДоступа { get; set; }
        //public object[] ДополнительныеРеквизиты { get; set; }
    }

    public class DocumentУстановкаЦенНоменклатурыТовары
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        public int LineNumber { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Номенклатура_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Упаковка_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ВидЦены_Key { get; set; }
        public double Цена { get; set; }
        public bool ЦенаИзмененаВручную { get; set; }

        //public string Характеристика_Key { get; set; }
    }

    //public class Видыцен
    //{
    //    public string Ref_Key { get; set; }
    //    public string LineNumber { get; set; }
    //    public string ВидЦены_Key { get; set; }
    //    public string НастройкиКомпоновкиДанных_Type { get; set; }
    //    public string НастройкиКомпоновкиДанных_Base64Data { get; set; }
    //}

    //public class Наборызначенийдоступа
    //{
    //    public string Ref_Key { get; set; }
    //    public string LineNumber { get; set; }
    //    public int НомерНабора { get; set; }
    //    public string ЗначениеДоступа { get; set; }
    //    public string ЗначениеДоступа_Type { get; set; }
    //    public string Уточнение_Key { get; set; }
    //    public bool Чтение { get; set; }
    //    public bool Изменение { get; set; }
    //}
}
