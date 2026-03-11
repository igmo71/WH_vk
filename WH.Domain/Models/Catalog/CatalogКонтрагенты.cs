using System.ComponentModel.DataAnnotations;

namespace WH.Domain.Models.Catalog
{
    public class CatalogКонтрагенты : Entity
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        public bool DeletionMark { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ГоловнойКонтрагент_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Партнер_Key { get; set; }
        [MaxLength(AppSettings.DESCRIPTION)] public string? Description { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ИНН { get; set; }
    }
}
