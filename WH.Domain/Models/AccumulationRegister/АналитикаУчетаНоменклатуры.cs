using System.ComponentModel.DataAnnotations;

namespace WH.Domain.Models.AccumulationRegister
{
    public class АналитикаУчетаНоменклатуры
    {
        [MaxLength(AppSettings.GUID)] public required string Номенклатура_Key { get; set; }
        //public string Ref_Key { get; set; }
        //public string Характеристика_Key { get; set; }
        //public string Серия_Key { get; set; }
        //public string Назначение_Key { get; set; }
        //public bool Predefined { get; set; }
        //public string PredefinedDataName { get; set; }
        //public string Склад { get; set; }
        //public string Склад_Type { get; set; }
        //public string DataVersion { get; set; }
        //public string Description { get; set; }
        //public bool DeletionMark { get; set; }
        //public string СтатьяКалькуляции { get; set; }
        //public string НоменклатураnavigationLinkUrl { get; set; }
    }
}
