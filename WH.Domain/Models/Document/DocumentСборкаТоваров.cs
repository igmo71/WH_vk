using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace WH.Domain.Models.Document
{
    public class DocumentСборкаТоваров : Entity, IHaveDate
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Number { get; set; }
        [Column(TypeName = nameof(SqlDbType.Date))] public DateTime Date { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ЗаказНаСборку_Key { get; set; }
        public double Количество { get; set; }
        public double КоличествоУпаковок { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Номенклатура_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Ответственный_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Упаковка_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Склад_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Подразделение_Key { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Статус { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? СборкаПодДеятельность { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? ХозяйственнаяОперация { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? ВариантПриемкиТоваров { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ВариантКомплектации_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? НоменклатураОсновногоКомпонента_Key { get; set; }
        public List<DocumentСборкаТоваровТовары>? Товары { get; set; }

        //public string DataVersion { get; set; }
        //public bool DeletionMark { get; set; }
        //public bool Posted { get; set; }
        //public string Комментарий { get; set; }
        //public string Организация_Key { get; set; }
        //public string Характеристика_Key { get; set; }
        //public DateTime ДатаРаспоряжения { get; set; }
        //public string Сделка_Key { get; set; }
        //public int СтатусУказанияСерий { get; set; }
        //public string УдалитьВидЗапасов_Key { get; set; }
        //public string УдалитьНомерГТД_Key { get; set; }
        //public bool ВидыЗапасовУказаныВручную { get; set; }
        //public string Назначение_Key { get; set; }
        //public string Серия_Key { get; set; }
        //public string ХарактеристикаОсновногоКомпонента_Key { get; set; }
        //public string АналитикаУчетаНоменклатуры_Key { get; set; }
        //public string НаправлениеДеятельности_Key { get; set; }
        //public Видызапасовсписание[] ВидыЗапасовСписание { get; set; }
        //public Видызапасовоприходование[] ВидыЗапасовОприходование { get; set; }
        //public object[] Серии { get; set; }        
    }

    public class DocumentСборкаТоваровТовары
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        public int LineNumber { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Номенклатура_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Упаковка_Key { get; set; }
        public double КоличествоУпаковок { get; set; }
        public double Количество { get; set; }
        public double ДоляСтоимости { get; set; }
        public int КодСтроки { get; set; }

        //public string Характеристика_Key { get; set; }
        //public string Назначение_Key { get; set; }
        //public int СтатусУказанияСерий { get; set; }
        //public string УдалитьВидЗапасов_Key { get; set; }
        //public string УдалитьНомерГТД_Key { get; set; }
        //public string Серия_Key { get; set; }
        //public string АналитикаУчетаНоменклатуры_Key { get; set; }
        //public string ИдентификаторСтроки { get; set; }
    }

    //public class Видызапасовсписание
    //{
    //    public string Ref_Key { get; set; }
    //    public string LineNumber { get; set; }
    //    public string ВидЗапасов_Key { get; set; }
    //    public string НомерГТД_Key { get; set; }
    //    public float Количество { get; set; }
    //    public int УдалитьКоличествоКомплекта { get; set; }
    //    public string АналитикаУчетаНоменклатуры_Key { get; set; }
    //}

    //public class Видызапасовоприходование
    //{
    //    public string Ref_Key { get; set; }
    //    public string LineNumber { get; set; }
    //    public string ВидЗапасов_Key { get; set; }
    //    public string НомерГТД_Key { get; set; }
    //    public int Количество { get; set; }
    //    public string АналитикаУчетаНоменклатуры_Key { get; set; }
    //}
}
