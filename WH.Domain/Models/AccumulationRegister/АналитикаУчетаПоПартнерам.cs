using System.ComponentModel.DataAnnotations;

namespace WH.Domain.Models.AccumulationRegister
{
    public class АналитикаУчетаПоПартнерам
    {
        [MaxLength(AppSettings.GUID)] public required string Партнер_Key { get; set; }
        //public string Ref_Key { get; set; }
        //public string Организация_Key { get; set; }
        //public string НаправлениеДеятельности_Key { get; set; }
        //public string Договор { get; set; }
        //public string Договор_Type { get; set; }
        //public string Description { get; set; }
        //public string DataVersion { get; set; }
        //public string PredefinedDataName { get; set; }
        //public bool DeletionMark { get; set; }
        //public bool Predefined { get; set; }
        //public string Контрагент { get; set; }
        //public string Контрагент_Type { get; set; }
        //public string ПартнерnavigationLinkUrl { get; set; }
        //public string ОрганизацияnavigationLinkUrl { get; set; }
    }
}
