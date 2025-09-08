using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Text.Json.Serialization;

namespace WH.Domain.Models.AccumulationRegister
{
    public class AccumulationRegisterЗакупкиRecordType : Entity, IHaveDate, IHaveId
    {
        [MaxLength(AppSettings.GUID)] public string? Id { get; set; }

        [Column(TypeName = nameof(SqlDbType.Date))]
        [JsonPropertyName("Period")] public DateTime Date { get; set; }

        [MaxLength(AppSettings.GUID)] public string? Recorder { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Recorder_Type { get; set; }
        public int LineNumber { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Номенклатура_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Организация_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Подразделение_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Менеджер_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Склад { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Склад_Type { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? ХозяйственнаяОперация { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? ТипЗапасов { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ВидЗапасов_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Партнер_Key { get; set; }
        public bool РасчетСебестоимости { get; set; }
        public double Количество { get; set; }
        public double Сумма { get; set; }
        public double СуммаБезНДС { get; set; }
        public double Стоимость { get; set; }
        public double СтоимостьБезНДС { get; set; }
        public double СуммаДопРасходов { get; set; }
        public double СуммаДопРасходовБезНДС { get; set; }
        public double СуммаСкидки { get; set; }

        [NotMapped]
        public АналитикаУчетаНоменклатуры? АналитикаУчетаНоменклатуры { get; set; }

        //public bool Active { get; set; }
        //public string Контрагент { get; set; }
        //public string Контрагент_Type { get; set; }
        //public string Соглашение_Key { get; set; }
        //public string Договор { get; set; }
        //public string Договор_Type { get; set; }
        //public string Заказ { get; set; }
        //public string Заказ_Type { get; set; }
        //public string НаправлениеДеятельностиНоменклатуры_Key { get; set; }
        //public string НаправлениеДеятельностиКонтрагента_Key { get; set; }
        //public string ПодотчетноеЛицо_Key { get; set; }
        //public float СтоимостьРегл { get; set; }
        //public float СуммаРегл { get; set; }
        //public float СуммаРеглБезНДС { get; set; }
        //public string ВалютаДокумента_Key { get; set; }
        //public float СуммаВВалютеДокумента { get; set; }
        //public float СуммаБезНДСВВалютеДокумента { get; set; }
        //public string ВалютаВзаиморасчетов_Key { get; set; }
        //public float СуммаВВалютеВзаиморасчетов { get; set; }
        //public float СуммаБезНДСВВалютеВзаиморасчетов { get; set; }
        //public string ИсточникГФУНоменклатуры { get; set; }
        //public string ИсточникГФУНоменклатуры_Type { get; set; }
        //public string ИсточникГФУРасчетов { get; set; }
        //public string ИсточникГФУРасчетов_Type { get; set; }
        //public string ДокументДвижения { get; set; }
        //public string ДокументДвижения_Type { get; set; }
    }

}
