using System.ComponentModel.DataAnnotations;

namespace WH.Domain.Models.Catalog
{
    public class CatalogГруппыПользователей : Entity
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        public bool DeletionMark { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Parent_Key { get; set; }
        [MaxLength(AppSettings.DESCRIPTION)] public string? Description { get; set; }
        [MaxLength(AppSettings.DESCRIPTION)] public string? Комментарий { get; set; }
        public List<CatalogГруппыПользователейСостав>? Состав { get; set; }

        //public string DataVersion { get; set; }
        //public string ОтредактированныеПредопределенныеРеквизиты { get; set; }
        //public bool Predefined { get; set; }
        //public string PredefinedDataName { get; set; }
        //public string ParentnavigationLinkUrl { get; set; }
    }

    public class CatalogГруппыПользователейСостав
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        public int LineNumber { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Пользователь_Key { get; set; }
    }

}
