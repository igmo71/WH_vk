using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Text.Json.Serialization;

namespace WH.Domain.Models.Document
{
    public class DocumentВозвратТоваровОтКлиента : Entity, IHaveDate
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Number { get; set; }
        [Column(TypeName = nameof(SqlDbType.Date))] public DateTime Date { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Партнер_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Менеджер_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Склад_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ДокументРеализации { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? ДокументРеализации_Type { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ПричинаВозврата { get; set; }
        public double СуммаДокумента { get; set; }
        public List<DocumentВозвратТоваровОтКлиентаТовары>? Товары { get; set; }

        //public string DataVersion { get; set; }
        //public bool DeletionMark { get; set; }
        //public bool Posted { get; set; }
        //public bool ЦенаВключаетНДС { get; set; }
        //public string Организация_Key { get; set; }
        //public string Комментарий { get; set; }
        //public string Подразделение_Key { get; set; }
        //public string Соглашение_Key { get; set; }
        //public string Сделка_Key { get; set; }
        //public string Валюта_Key { get; set; }
        //public string НалогообложениеНДС { get; set; }
        //public string ХозяйственнаяОперация { get; set; }
        //public string ЧекККМ_Key { get; set; }
        //public string ЗаявкаНаВозвратТоваровОтКлиента_Key { get; set; }
        //public string НомерВходящегоДокумента { get; set; }
        //public DateTime ДатаВходящегоДокумента { get; set; }
        //public bool ВыданыДенежныеСредства { get; set; }
        //public string НомерРасходногоКассовогоОрдера { get; set; }
        //public DateTime ДатаРасходногоКассовогоОрдера { get; set; }
        //public bool ВозвратПорчи { get; set; }
        //public string Договор_Key { get; set; }
        //public string ВидДокументаПокупателя_Key { get; set; }
        //public string СерияДокументаПокупателя { get; set; }
        //public string НомерДокументаПокупателя { get; set; }
        //public DateTime ДатаВыдачиДокументаПокупателя { get; set; }
        //public DateTime СрокДействияДокументаПокупателя { get; set; }
        //public string КемВыданДокументПокупателя { get; set; }
        //public string КодПодразделенияДокументаПокупателя { get; set; }
        //public DateTime ДатаРожденияПокупателя { get; set; }
        //public string Покупатель { get; set; }
        //public string ГруппаФинансовогоУчета_Key { get; set; }
        //public string УдалитьРуководитель_Key { get; set; }
        //public bool ВозвратПереданнойМногооборотнойТары { get; set; }
        //public string СостояниеЗаполненияМногооборотнойТары { get; set; }
        //public bool ВидыЗапасовУказаныВручную { get; set; }
        //public bool ПредусмотренЗалогЗаТару { get; set; }
        //public string СпособКомпенсации { get; set; }
        //public string ПорядокРасчетов { get; set; }
        //public string КонтактноеЛицо_Key { get; set; }
        //public bool ПокупательНеПлательщикНДС { get; set; }
        //public string ДовозвратПоВозврату { get; set; }
        //public string ДовозвратПоВозврату_Type { get; set; }
        //public string НаправлениеДеятельности_Key { get; set; }
        //public string УдалитьАдресЧекаЕГАИС { get; set; }
        //public string УдалитьПодписьЧекаЕГАИС { get; set; }
        //public string Контрагент_Key { get; set; }
        //public string ПорядокОплаты { get; set; }
        //public bool ЕстьМаркируемаяПродукцияГИСМ { get; set; }
        //public bool УдалитьЕстьАлкогольнаяПродукцияДляРеализацииРозницаЕГАИС { get; set; }
        //public string ВариантПриемкиТоваров { get; set; }
        //public Видызапасов[] ВидыЗапасов { get; set; }
        //public Расшифровкаплатежа[] РасшифровкаПлатежа { get; set; }
        //public object[] Серии { get; set; }
        //public object[] НачислениеБонусныхБаллов { get; set; }
        //public object[] ОплатаБонуснымиБаллами { get; set; }
        //public object[] АкцизныеМарки { get; set; }

    }

    public class DocumentВозвратТоваровОтКлиентаТовары
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        public int LineNumber { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Номенклатура_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ДокументРеализации { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? ДокументРеализации_Type { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Упаковка_Key { get; set; }
        public double КоличествоУпаковок { get; set; }
        public double Количество { get; set; }
        public double Цена { get; set; }
        public double Сумма { get; set; }

        [JsonPropertyName("Доброга_ПричинаВозврата_Key")]
        [MaxLength(AppSettings.GUID)] public string? ПричинаВозвратаKey { get; set; }

        //public string НоменклатураОприходование_Key { get; set; }
        //public string Характеристика_Key { get; set; }
        //public string ХарактеристикаОприходование_Key { get; set; }
        //public string СтавкаНДС { get; set; }
        //public int СуммаНДС { get; set; }
        //public float СуммаСНДС { get; set; }
        //public string КодСтроки { get; set; }
        //public bool Порча { get; set; }
        //public int СтатусУказанияСерий { get; set; }
        //public string Серия_Key { get; set; }
        //public string АналитикаУчетаНоменклатуры_Key { get; set; }
        //public string НоменклатураНабора_Key { get; set; }
        //public string ХарактеристикаНабора_Key { get; set; }
        //public string АналитикаУчетаНаборов_Key { get; set; }
        //public string Штрихкод { get; set; }
        //public string ИдентификаторСтроки { get; set; }
        //public string НоменклатураЕГАИС_Key { get; set; }
        //public string СпособОпределенияСебестоимости { get; set; }
        //public int Себестоимость { get; set; }
        //public int СебестоимостьБезНДС { get; set; }
        //public int СебестоимостьРегл { get; set; }
        //public int СебестоимостьПР { get; set; }
        //public int СебестоимостьВР { get; set; }
        //public string ВидЦеныСебестоимости_Key { get; set; }
        //public DateTime ДатаЗаполненияСебестоимостиПоВидуЦены { get; set; }
        //public string Назначение_Key { get; set; }
    }

    //public class Видызапасов
    //{
    //    public string Ref_Key { get; set; }
    //    public string LineNumber { get; set; }
    //    public string ВидЗапасов_Key { get; set; }
    //    public string НомерГТД_Key { get; set; }
    //    public float Количество { get; set; }
    //    public float СуммаСНДС { get; set; }
    //    public string СтавкаНДС { get; set; }
    //    public int СуммаНДС { get; set; }
    //    public string УдалитьСкладОтгрузки_Key { get; set; }
    //    public string НоменклатураОприходование_Key { get; set; }
    //    public string ХарактеристикаОприходование_Key { get; set; }
    //    public string ВидЗапасовОтгрузки_Key { get; set; }
    //    public string ДокументРеализации { get; set; }
    //    public string ДокументРеализации_Type { get; set; }
    //    public string ИдентификаторСтроки { get; set; }
    //    public string УдалитьАналитикаУчетаПартий_Key { get; set; }
    //    public string Серия_Key { get; set; }
    //    public string АналитикаУчетаНоменклатуры_Key { get; set; }
    //    public string АналитикаУчетаНаборов_Key { get; set; }
    //    public int Себестоимость { get; set; }
    //    public int СебестоимостьБезНДС { get; set; }
    //    public int СебестоимостьРегл { get; set; }
    //    public int СебестоимостьПР { get; set; }
    //    public int СебестоимостьВР { get; set; }
    //    public string СпособОпределенияСебестоимости { get; set; }
    //    public string АналитикаУчетаНоменклатурыОтгрузки_Key { get; set; }
    //}

    //public class Расшифровкаплатежа
    //{
    //    public string Ref_Key { get; set; }
    //    public string LineNumber { get; set; }
    //    public string Заказ { get; set; }
    //    public string Заказ_Type { get; set; }
    //    public float Сумма { get; set; }
    //    public string ВалютаВзаиморасчетов_Key { get; set; }
    //    public float СуммаВзаиморасчетов { get; set; }
    //}
}
