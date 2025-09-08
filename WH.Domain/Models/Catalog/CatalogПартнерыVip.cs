using System.ComponentModel.DataAnnotations;

namespace WH.Domain.Models.Catalog
{
    public class CatalogПартнерыVip : Entity
    {
        [MaxLength(AppSettings.GUID)] public required string Партнер_Key { get; set; }
    }
}
