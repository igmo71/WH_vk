using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace WH.Domain.Models.Document
{
    public class DocumentОтчетОРозничныхПродажах : Entity, IHaveDate
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Number { get; set; }
        [Column(TypeName = nameof(SqlDbType.Date))] public DateTime Date { get; set; }
        public double СуммаДокумента { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Подразделение_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Ответственный_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Склад_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ВидЦены_Key { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? НалогообложениеНДС { get; set; }
        public bool ЦенаВключаетНДС { get; set; }
        public List<DocumentОтчетОРозничныхПродажахТовары>? Товары { get; set; }

        //public bool Posted { get; set; }
        //public string DataVersion { get; set; }
        //public bool DeletionMark { get; set; }
        //public string Валюта_Key { get; set; }
        //public string КассаККМ_Key { get; set; }
        //public string Комментарий { get; set; }
        //public string Организация_Key { get; set; }
        //public bool ПоРезультатамИнвентаризации { get; set; }
        //public string Руководитель_Key { get; set; }
        //public string ГлавныйБухгалтер_Key { get; set; }
        //public bool ВидыЗапасовУказаныВручную { get; set; }
        //public bool ЕстьМаркируемаяПродукцияГИСМ { get; set; }
        //public bool УдалитьЕстьАлкогольнаяПродукцияДляСписанияЕГАИС { get; set; }
        //public string КассоваяСмена_Key { get; set; }
        //public string ОрганизацияЕГАИС_Key { get; set; }
        //public Оплатаплатежнымикартами[] ОплатаПлатежнымиКартами { get; set; }
        //public Видызапасов[] ВидыЗапасов { get; set; }
        //public object[] Серии { get; set; }
        //public object[] ПодарочныеСертификаты { get; set; }
        //public object[] НачислениеБонусныхБаллов { get; set; }
        //public object[] ОплатаБонуснымиБаллами { get; set; }
        //public object[] АкцизныеМарки { get; set; }
        //public string ВалютаnavigationLinkUrl { get; set; }
        //public string ВидЦеныnavigationLinkUrl { get; set; }
        //public string КассаККМnavigationLinkUrl { get; set; }
        //public string ОрганизацияnavigationLinkUrl { get; set; }
        //public string ОтветственныйnavigationLinkUrl { get; set; }
        //public string ПодразделениеnavigationLinkUrl { get; set; }
        //public string СкладnavigationLinkUrl { get; set; }
        //public string РуководительnavigationLinkUrl { get; set; }
        //public string ГлавныйБухгалтерnavigationLinkUrl { get; set; }
        //public string КассоваяСменаnavigationLinkUrl { get; set; }
    }

    public class DocumentОтчетОРозничныхПродажахТовары
    {
        [MaxLength(AppSettings.GUID)] public required string ИдентификаторСтроки { get; set; }
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        public int LineNumber { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Номенклатура_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Упаковка_Key { get; set; }
        public double КоличествоУпаковок { get; set; }
        public double Количество { get; set; }
        public double Цена { get; set; }
        public double Сумма { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? СтавкаНДС { get; set; }
        public double СуммаНДС { get; set; }
        public double СуммаРучнойСкидки { get; set; }
        public double ПроцентРучнойСкидки { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Партнер_Key { get; set; }

        //public string Характеристика_Key { get; set; }
        //public int КоличествоУпаковокФакт { get; set; }
        //public int КоличествоУпаковокУчет { get; set; }
        //public int СтатусУказанияСерий { get; set; }
        //public string Продавец_Key { get; set; }
        //public string Помещение_Key { get; set; }
        //public string Серия_Key { get; set; }
        //public string АналитикаУчетаНоменклатуры_Key { get; set; }
        //public string НоменклатураНабора_Key { get; set; }
        //public string ХарактеристикаНабора_Key { get; set; }
        //public string АналитикаУчетаНаборов_Key { get; set; }
    }

    //public class Оплатаплатежнымикартами
    //{
    //    public string Ref_Key { get; set; }
    //    public string LineNumber { get; set; }
    //    public string ЭквайринговыйТерминал_Key { get; set; }
    //    public string КодАвторизации { get; set; }
    //    public string НомерПлатежнойКарты { get; set; }
    //    public float Сумма { get; set; }
    //    public string ИдентификаторСтроки { get; set; }
    //}

    //public class Видызапасов
    //{
    //    public string Ref_Key { get; set; }
    //    public string LineNumber { get; set; }
    //    public string АналитикаУчетаНоменклатуры_Key { get; set; }
    //    public string ВидЗапасов_Key { get; set; }
    //    public string НомерГТД_Key { get; set; }
    //    public float Количество { get; set; }
    //    public float СуммаСНДС { get; set; }
    //    public string СтавкаНДС { get; set; }
    //    public int СуммаНДС { get; set; }
    //    public string Партнер_Key { get; set; }
    //    public string ИдентификаторСтроки { get; set; }
    //    public string Продавец_Key { get; set; }
    //    public int СуммаРучнойСкидки { get; set; }
    //    public string АналитикаУчетаНаборов_Key { get; set; }
    //}
}
