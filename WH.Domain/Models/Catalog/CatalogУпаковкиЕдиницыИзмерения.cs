using System.ComponentModel.DataAnnotations;

namespace WH.Domain.Models.Catalog
{
    public class CatalogУпаковкиЕдиницыИзмерения : Entity
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        public bool DeletionMark { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Owner { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Owner_Type { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Parent_Key { get; set; }
        [MaxLength(AppSettings.DESCRIPTION)] public string? Description { get; set; }
        public double Вес { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ВесЕдиницаИзмерения_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ЕдиницаИзмерения_Key { get; set; }
        public double Числитель { get; set; }
        public double Знаменатель { get; set; }
        public int КоличествоУпаковок { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? ТипУпаковки { get; set; }
        public bool Безразмерная { get; set; }

        //[MaxLength(AppSettings.VALUE)] public string? Code { get; set; }
        //public string DataVersion { get; set; }
        //public float Высота { get; set; }
        //public string ВысотаЕдиницаИзмерения_Key { get; set; }
        //public float Глубина { get; set; }
        //public string ГлубинаЕдиницаИзмерения_Key { get; set; }
        //public float Ширина { get; set; }
        //public string ШиринаЕдиницаИзмерения_Key { get; set; }
        //public string ЛинейныеРазмерыПредставление { get; set; }
        //public float Объем { get; set; }
        //public string ОбъемЕдиницаИзмерения_Key { get; set; }
        //public string СкладскаяГруппа_Key { get; set; }
        //public string Типоразмер_Key { get; set; }
        //public bool ПоставляетсяВМногооборотнойТаре { get; set; }
        //public string НоменклатураМногооборотнаяТара_Key { get; set; }
        //public string ХарактеристикаМногооборотнаяТара_Key { get; set; }
        //public string МинимальноеКоличествоУпаковокМногооборотнойТары { get; set; }
        //public string ТипИзмеряемойВеличины { get; set; }
        //public string НаименованиеПолное { get; set; }
        //public string МеждународноеСокращение { get; set; }
        //public string Б_Идентификатор { get; set; }
        //public string Б_НомерВерсии { get; set; }
        //public bool Predefined { get; set; }
        //public string PredefinedDataName { get; set; }        
    }

}
