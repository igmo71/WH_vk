using System.ComponentModel.DataAnnotations;

namespace WH.Domain.Models.Wms
{
    public class CatalogЯчейки : Entity
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Parent_Key { get; set; }
        public bool IsFolder { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Code { get; set; }
        [MaxLength(AppSettings.DESCRIPTION)] public string? Description { get; set; }
        public double? Вес { get; set; }
        public double? Длина { get; set; }
        public double? Ширина { get; set; }
        public double? Высота { get; set; }
        public double? Объем { get; set; }
        public double? ВместимостьПаллет { get; set; }
        public double? ДопустимаяСтепеньЗаполненности { get; set; }
        [MaxLength(AppSettings.GUID)] public string? КлассABC { get; set; }
        [MaxLength(AppSettings.GUID)] public string? КлассXYZ { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Артикул { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Поставщик_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Покупатель_Key { get; set; }
        public bool? РазмещениеПогрузчиком { get; set; }
        [MaxLength(AppSettings.GUID)] public string? СерияТовараВЯчейке_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ВидЯчейки { get; set; }
        public int? Помещение { get; set; }
        public int? Ряд { get; set; }
        public int? Стойка { get; set; }
        public int? Глубина { get; set; }
        public int? Полка { get; set; }
        public int? ПриоритетВыборки { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Склад_Key { get; set; }
        public DateTime? СрокГодностиТовараВЯчейке { get; set; }
        public bool? Резерв { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ТипЯчейки { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ТипХранения { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ЗонаСклада_Key { get; set; }
        public bool? Распечатан { get; set; }
        public bool? ТестовыйРежим_МножественноеРазмещение { get; set; }
        public bool? ПередаватьРезультатыИнвентаризации { get; set; }
        [MaxLength(AppSettings.FULL_NAME)] public string? Комментарий { get; set; }
        public bool? Заблокированна { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ТранспортнаяКомпания_Key { get; set; }
        public List<CatalogЯчейкиНоменклатураЯчейки>? НоменклатураЯчейки { get; set; }

        //public string DataVersion { get; set; }
        //public bool DeletionMark { get; set; }
        //public bool Predefined { get; set; }
        //public string PredefinedDataName { get; set; }
    }

    public class CatalogЯчейкиНоменклатураЯчейки
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        public int LineNumber { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Номенклатура_Key { get; set; }
    }
}
