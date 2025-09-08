using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace WH.Domain.Models.Document
{
    public class DocumentРасходныйОрдерНаТовары : Entity, IHaveDate
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Number { get; set; }
        [Column(TypeName = nameof(SqlDbType.Date))] public DateTime Date { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Склад_Key { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? СкладскаяОперация { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Получатель { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Получатель_Type { get; set; }
        //[MaxLength(AppSettings.VALUE)] public string? Комментарий { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Статус { get; set; }
        public int ВсегоМест { get; set; }
        [Column(TypeName = nameof(SqlDbType.Date))] public DateTime ДатаОтгрузки { get; set; }

        //public string DataVersion { get; set; }
        //public bool DeletionMark { get; set; }
        //public bool Posted { get; set; }
        //public string ЗаданиеНаПеревозку_Key { get; set; }
        //public string ЗонаОтгрузки_Key { get; set; }
        //public string Контролер_Key { get; set; }
        //public string Ответственный_Key { get; set; }
        //public bool ОтгрузкаПоЗаданиюНаПеревозку { get; set; }
        //public string Помещение_Key { get; set; }
        //public string ПорядокДоставки { get; set; }
        //public string Приоритет_Key { get; set; }
        //public int РежимПросмотраПоТоварам { get; set; }
        //public string Доброга_ТипОчереди { get; set; }
        //public DateTime Доброга_ПланируемаяДатаОтгрузки { get; set; }
        //public string Доброга_НаправлениеДоставки_Key { get; set; }
        //public string Доброга_ЗаданиеДляКладовщика { get; set; }
        //public ТоварыПоРаспоряжениям[] ТоварыПоРаспоряжениям { get; set; }
        //public ОтгружаемыеТовары[] ОтгружаемыеТовары { get; set; }
        //public object[] ДополнительныеРеквизиты { get; set; }       
    }

    //public class ТоварыПоРаспоряжениям
    //{
    //    public string Ref_Key { get; set; }
    //    public string LineNumber { get; set; }
    //    public string Номенклатура_Key { get; set; }
    //    public string Характеристика_Key { get; set; }
    //    public string Назначение_Key { get; set; }
    //    public string Серия_Key { get; set; }
    //    public int СтатусУказанияСерий { get; set; }
    //    public string Распоряжение { get; set; }
    //    public string Распоряжение_Type { get; set; }
    //    public float Количество { get; set; }
    //}

    //public class ОтгружаемыеТовары
    //{
    //    public string Ref_Key { get; set; }
    //    public string LineNumber { get; set; }
    //    public string Номенклатура_Key { get; set; }
    //    public string Характеристика_Key { get; set; }
    //    public string Назначение_Key { get; set; }
    //    public string Серия_Key { get; set; }
    //    public int СтатусУказанияСерий { get; set; }
    //    public bool ЭтоУпаковочныйЛист { get; set; }
    //    public int ЭтоСлужебнаяСтрокаПустогоУпаковочногоЛиста { get; set; }
    //    public string УпаковочныйЛистРодитель_Key { get; set; }
    //    public string УпаковочныйЛист_Key { get; set; }
    //    public string Упаковка_Key { get; set; }
    //    public float Количество { get; set; }
    //    public float КоличествоУпаковок { get; set; }
    //    public string Действие { get; set; }
    //}
}
