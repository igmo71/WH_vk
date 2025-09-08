using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace WH.Domain.Models.Document
{
    public class DocumentПриходныйОрдерНаТовары : Entity, IHaveDate
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Number { get; set; }
        [Column(TypeName = nameof(SqlDbType.Date))] public DateTime Date { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Склад_Key { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? СкладскаяОперация { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Отправитель { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Отправитель_Type { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Статус { get; set; }
        public int ВсегоМест { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? ХозяйственнаяОперация { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Распоряжение { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Распоряжение_Type { get; set; }

        //public string DataVersion { get; set; }
        //public bool DeletionMark { get; set; }
        //public bool Posted { get; set; }
        //[MaxLength(AppSettings.VALUE)] public string? Комментарий { get; set; }
        //public string Ответственный_Key { get; set; }
        //public string Исполнитель_Key { get; set; }
        //public string Помещение_Key { get; set; }
        //public string ЗонаПриемки_Key { get; set; }
        //public bool РаспоряжениеНаНесколькоСкладов { get; set; }
        //public DateTime ДатаВходящегоДокумента { get; set; }
        //public string НомерВходящегоДокумента { get; set; }
        //public string СостояниеЗаполненияМногооборотнойТары { get; set; }
        //public int РежимПросмотраПоТоварам { get; set; }
        //public bool ЗакрыватьГрафикПоступления { get; set; }
        //public string Доброга_ТипОчереди { get; set; }
        //public Товары[] Товары { get; set; }
    }

    //public class Товары
    //{
    //    public string Ref_Key { get; set; }
    //    public string LineNumber { get; set; }
    //    public string Номенклатура_Key { get; set; }
    //    public string Характеристика_Key { get; set; }
    //    public string Назначение_Key { get; set; }
    //    public string Упаковка_Key { get; set; }
    //    public float КоличествоУпаковок { get; set; }
    //    public float Количество { get; set; }
    //    public int СтатусУказанияСерий { get; set; }
    //    public string ДокументОтгрузки { get; set; }
    //    public string ДокументОтгрузки_Type { get; set; }
    //    public string УпаковочныйЛист_Key { get; set; }
    //    public string УпаковочныйЛистРодитель_Key { get; set; }
    //    public string Штрихкод { get; set; }
    //    public bool ЭтоУпаковочныйЛист { get; set; }
    //    public int ЭтоСлужебнаяСтрокаПустогоУпаковочногоЛиста { get; set; }
    //    public string Комментарий { get; set; }
    //    public string Серия_Key { get; set; }
    //}
}
