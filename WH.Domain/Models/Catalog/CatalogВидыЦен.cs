using System.ComponentModel.DataAnnotations;

namespace WH.Domain.Models.Catalog
{
    public class CatalogВидыЦен : Entity
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        public bool DeletionMark { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Parent_Key { get; set; }
        public bool IsFolder { get; set; }
        [MaxLength(AppSettings.DESCRIPTION)] public string? Description { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Идентификатор { get; set; }
        [MaxLength(AppSettings.GUID)] public string? БазовыйВидЦены_Key { get; set; }
        public double Наценка { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? СпособЗаданияЦены { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Формула { get; set; }
        public double ПорогСрабатывания { get; set; }
        public bool Округлять { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? ВариантОкругления { get; set; }
        public double ТочностьОкругления { get; set; }
        public bool ОкруглятьВБольшуюСторону { get; set; }
        public bool ЦенаВключаетНДС { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Статус { get; set; }
        public int РеквизитДопУпорядочивания { get; set; }
        public bool УстанавливатьЦенуПриВводеНаОсновании { get; set; }
        public bool ИспользоватьПриПродаже { get; set; }
        public bool ИспользоватьПриПередачеМеждуОрганизациями { get; set; }
        public bool ИспользоватьПриВыпускеПродукции { get; set; }
        public bool ИспользоватьПриПередачеПродукцииДавальцу { get; set; }
        //public string DataVersion { get; set; }
        //public string ВалютаЦены_Key { get; set; }
        //public string СхемаКомпоновкиДанных { get; set; }
        //public string ХранилищеСхемыКомпоновкиДанных_Type { get; set; }
        //public string ХранилищеСхемыКомпоновкиДанных_Base64Data { get; set; }
        //public string ХранилищеНастроекКомпоновкиДанных_Type { get; set; }
        //public string ХранилищеНастроекКомпоновкиДанных_Base64Data { get; set; }
        //public bool Доброга_УсловныеНаценки { get; set; }
        //public string Б_Идентификатор { get; set; }
        //public string Б_НомерВерсии { get; set; }
        //public Влияющиевидыцен[] ВлияющиеВидыЦен { get; set; }
        //public Ценовыегруппы[] ЦеновыеГруппы { get; set; }
        //public object[] ПравилаОкругленияЦены { get; set; }
        //public Порогисрабатывания[] ПорогиСрабатывания { get; set; }
        //public object[] ДополнительныеРеквизиты { get; set; }
        //public bool Predefined { get; set; }
        //public string PredefinedDataName { get; set; }
    }

    //public class Влияющиевидыцен
    //{
    //    public string Ref_Key { get; set; }
    //    public string LineNumber { get; set; }
    //    public string ВлияющийВидЦен_Key { get; set; }
    //}

    //public class Ценовыегруппы
    //{
    //    public string Ref_Key { get; set; }
    //    public string LineNumber { get; set; }
    //    public string ЦеноваяГруппа_Key { get; set; }
    //    public string Формула { get; set; }
    //    public string БазовыйВидЦены_Key { get; set; }
    //    public float Наценка { get; set; }
    //}

    //public class Порогисрабатывания
    //{
    //    public string Ref_Key { get; set; }
    //    public string LineNumber { get; set; }
    //    public string ЦеноваяГруппа_Key { get; set; }
    //    public int ПорогСрабатывания { get; set; }
    //}
}
