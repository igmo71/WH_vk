using System.ComponentModel.DataAnnotations;

namespace WH.Domain.Models.Catalog
{
    public class CatalogСхемаПредприятия : Entity
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        public bool DeletionMark { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Parent_Key { get; set; }
        [MaxLength(AppSettings.DESCRIPTION)] public string? Description { get; set; }

        //public string DataVersion { get; set; }
        //public string Code { get; set; }
        //public bool Predefined { get; set; }
        //public string PredefinedDataName { get; set; }
        //public string ParentnavigationLinkUrl { get; set; }
    }

}
