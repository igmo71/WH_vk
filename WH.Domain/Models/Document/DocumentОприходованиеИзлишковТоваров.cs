using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace WH.Domain.Models.Document
{
    public class DocumentОприходованиеИзлишковТоваров : Entity, IHaveDate
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Number { get; set; }
        [Column(TypeName = nameof(SqlDbType.Date))] public DateTime Date { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Ответственный_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Подразделение_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Склад_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ВидЦены_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ПересчетТоваров_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Основание { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Основание_Type { get; set; }
        public List<DocumentОприходованиеИзлишковТоваровТовары>? Товары { get; set; }

        //public string DataVersion { get; set; }
        //public bool DeletionMark { get; set; }
        //public bool Posted { get; set; }
        //public string СтатьяДоходов_Key { get; set; }
        //public string АналитикаДоходов { get; set; }
        //public string АналитикаДоходов_Type { get; set; }
        //public string Комментарий { get; set; }
        //public string Организация_Key { get; set; }
        //public string НаправлениеДеятельности_Key { get; set; }
        //public object[] ДополнительныеРеквизиты { get; set; }    
        //public bool УдалитьЕстьАлкогольнаяПродукцияДляПостановкиНаБалансЕГАИС { get; set; }
        //public string Валюта_Key { get; set; }
    }

    public class DocumentОприходованиеИзлишковТоваровТовары
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        public int LineNumber { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Номенклатура_Key { get; set; }
        public double Количество { get; set; }
        public double Цена { get; set; }
        public double Сумма { get; set; }

        //public string Характеристика_Key { get; set; }
        //public string Назначение_Key { get; set; }
        //public string НомерГТД_Key { get; set; }
        //public string ВидЗапасов_Key { get; set; }
        //public string УдалитьАналитикаУчетаПартий_Key { get; set; }
        //public string ИдентификаторСтроки { get; set; }
        //public string Серия_Key { get; set; }
        //public int СтатусУказанияСерий { get; set; }
        //public string АналитикаУчетаНоменклатуры_Key { get; set; }
    }

}
