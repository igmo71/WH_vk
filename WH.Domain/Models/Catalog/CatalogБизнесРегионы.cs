using System.ComponentModel.DataAnnotations;

namespace WH.Domain.Models.Catalog
{
    public class CatalogБизнесРегионы : Entity
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        public bool DeletionMark { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Parent_Key { get; set; }
        [MaxLength(AppSettings.DESCRIPTION)] public string? Description { get; set; }

        //public string ОсновнойМенеджер_Key { get; set; }
        //public string ЗначениеГеографическогоРегиона { get; set; }
        //public string ЗначениеГеографическогоРегиона_Type { get; set; }
        //public string ГеографическийРегион { get; set; }
        //public string СезоннаяГруппа_Key { get; set; }
        //public string DataVersion { get; set; }
        //public object[] ДополнительныеРеквизиты { get; set; }
        //public bool Predefined { get; set; }
        //public string PredefinedDataName { get; set; }
    }
}
