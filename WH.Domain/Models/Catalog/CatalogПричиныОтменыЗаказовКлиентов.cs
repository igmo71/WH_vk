using System.ComponentModel.DataAnnotations;

namespace WH.Domain.Models.Catalog
{
    public class CatalogПричиныОтменыЗаказовКлиентов : Entity
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        public bool DeletionMark { get; set; }
        [MaxLength(AppSettings.DESCRIPTION)] public string? Description { get; set; }

        //public string DataVersion { get; set; }
        //public string Описание { get; set; }
        //public bool ДоступнаДляУказанияКлиентом { get; set; }
        //public bool Доброга_КорректироватьРасходныйОрдерНаТовары { get; set; }
        //public bool Доброга_ОшибкаСклада { get; set; }
        //public bool Predefined { get; set; }
        //public string PredefinedDataName { get; set; }
    }
}
