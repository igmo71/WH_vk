using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace WH.Domain.Models.Document
{
    public class DocumentЗаказНаПеремещение : Entity, IHaveDate
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Number { get; set; }
        [Column(TypeName = nameof(SqlDbType.Date))] public DateTime Date { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Организация_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ОрганизацияПолучатель_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Подразделение_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? СкладОтправитель_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? СкладПолучатель_Key { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Статус { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? ХозяйственнаяОперация { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ДокументОснование { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? ДокументОснование_Type { get; set; }
        public List<DocumentЗаказНаПеремещениеТовары>? Товары { get; set; }

        //public string Ответственный_Key { get; set; }
        //public string DataVersion { get; set; }
        //public bool DeletionMark { get; set; }
        //public bool Posted { get; set; }
        //public int ДлительностьПеремещения { get; set; }
        //public DateTime ЖелаемаяДатаПоступления { get; set; }
        //public string Комментарий { get; set; }
        //public string МаксимальныйКодСтроки { get; set; }        
        //public string Сделка_Key { get; set; }       
        //public string Назначение_Key { get; set; }
        //public string СостояниеЗаполненияМногооборотнойТары { get; set; }
        //public string СпособДоставки { get; set; }
        //public string ПеревозчикПартнер_Key { get; set; }
        //public string ЗонаДоставки_Key { get; set; }
        //public DateTime ВремяДоставкиС { get; set; }
        //public DateTime ВремяДоставкиПо { get; set; }
        //public string АдресДоставкиПеревозчика { get; set; }
        //public string АдресДоставкиЗначенияПолей { get; set; }
        //public string АдресДоставкиПеревозчикаЗначенияПолей { get; set; }
        //public string ДополнительнаяИнформацияПоДоставке { get; set; }
        //public string АдресДоставки { get; set; }
        //public bool ОсобыеУсловияПеревозки { get; set; }
        //public string ОсобыеУсловияПеревозкиОписание { get; set; }
        //public string НаправлениеДеятельности_Key { get; set; }
        //public bool ИспользоватьДлительностьПеремещения { get; set; }
        //public string ПеремещениеПодДеятельность { get; set; }
        //public bool ОбосабливатьПоНазначениюЗаказа { get; set; }
        //public string ВариантПриемкиТоваров { get; set; }
        //public string Приоритет_Key { get; set; }
        //public string Автор_Key { get; set; }
        //public string АдресДоставкиЗначение { get; set; }
        //public string АдресДоставкиПеревозчикаЗначение { get; set; }
        //public object[] ДополнительныеРеквизиты { get; set; }        
    }

    public class DocumentЗаказНаПеремещениеТовары
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        public int LineNumber { get; set; }
        public double Количество { get; set; }
        public double КоличествоУпаковок { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Номенклатура_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Упаковка_Key { get; set; }
        public bool Отменено { get; set; }
        [MaxLength(AppSettings.GUID)] public string? КодСтроки { get; set; }
        [MaxLength(AppSettings.DESCRIPTION)] public string? ЗНП_Комментарий { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? ЗНП_ПричинаОтмены_Key { get; set; }

        //public string ВариантОбеспечения { get; set; }
        //public DateTime НачалоОтгрузки { get; set; }
        //public DateTime ОкончаниеПоступления { get; set; }
        //public string Характеристика_Key { get; set; }
        //public string Назначение_Key { get; set; }
        //public string Серия_Key { get; set; }
        //public int СтатусУказанияСерий { get; set; }
        //public bool Обособленно { get; set; }
        //public string НоменклатураНабора_Key { get; set; }
        //public string ХарактеристикаНабора_Key { get; set; }
    }
}
