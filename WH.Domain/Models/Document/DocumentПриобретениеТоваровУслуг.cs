using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace WH.Domain.Models.Document
{
    public class DocumentПриобретениеТоваровУслуг : Entity, IHaveDate
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Number { get; set; }
        [Column(TypeName = nameof(SqlDbType.Date))] public DateTime Date { get; set; }
        public double СуммаДокумента { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Подразделение_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Менеджер_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Склад_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Партнер_Key { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? ХозяйственнаяОперация { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ЗаказПоставщику_Key { get; set; }
        public bool ПоступлениеПоЗаказам { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Валюта_Key { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? НалогообложениеНДС { get; set; }
        public bool ЦенаВключаетНДС { get; set; }
        public bool Согласован { get; set; }
        public List<DocumentПриобретениеТоваровУслугТовары>? Товары { get; set; }

        //public string DataVersion { get; set; }
        //public bool DeletionMark { get; set; }
        //public bool Posted { get; set; }
        //public string Контрагент_Key { get; set; }
        //public double СуммаВзаиморасчетовПоЗаказу { get; set; }
        //public string ПодотчетноеЛицо_Key { get; set; }
        //public string ВалютаВзаиморасчетов_Key { get; set; }
        //public string Комментарий { get; set; }
        //public DateTime УдалитьДатаПлатежа { get; set; }
        //public string ЗакупкаПодДеятельность { get; set; }
        //public string ФормаОплаты { get; set; }
        //public float СуммаВзаиморасчетов { get; set; }
        //public string БанковскийСчетОрганизации_Key { get; set; }
        //public string НомерВходящегоДокумента { get; set; }
        //public DateTime ДатаВходящегоДокумента { get; set; }
        //public string Грузоотправитель_Key { get; set; }
        //public string БанковскийСчетКонтрагента_Key { get; set; }
        //public string БанковскийСчетГрузоотправителя_Key { get; set; }
        //public string Сделка_Key { get; set; }
        //public string Принял_Key { get; set; }
        //public string ПринялДолжность { get; set; }
        //public string ГруппаФинансовогоУчета_Key { get; set; }
        //public bool РегистрироватьЦеныПоставщика { get; set; }
        //public string Договор_Key { get; set; }
        //public string Автор_Key { get; set; }
        //public string Руководитель_Key { get; set; }
        //public string ПорядокРасчетов { get; set; }
        //public bool ВернутьМногооборотнуюТару { get; set; }
        //public DateTime ДатаВозвратаМногооборотнойТары { get; set; }
        //public string СостояниеЗаполненияМногооборотнойТары { get; set; }
        //public bool ТребуетсяЗалогЗаТару { get; set; }
        //public string ДопоступлениеПоДокументу { get; set; }
        //public string ДопоступлениеПоДокументу_Type { get; set; }
        //public string НазначениеАванса { get; set; }
        //public string КоличествоДокументов { get; set; }
        //public string КоличествоЛистов { get; set; }
        //public string ГлавныйБухгалтер_Key { get; set; }
        //public string СтатьяДвиженияДенежныхСредств_Key { get; set; }
        //public string СпособДоставки { get; set; }
        //public string ПеревозчикПартнер_Key { get; set; }
        //public string ЗонаДоставки_Key { get; set; }
        //public DateTime ВремяДоставкиС { get; set; }
        //public DateTime ВремяДоставкиПо { get; set; }
        //public string АдресДоставки { get; set; }
        //public string АдресДоставкиЗначенияПолей { get; set; }
        //public string ДополнительнаяИнформацияПоДоставке { get; set; }
        //public string АдресДоставкиПеревозчика { get; set; }
        //public string АдресДоставкиПеревозчикаЗначенияПолей { get; set; }
        //public bool ОсобыеУсловияПеревозки { get; set; }
        //public string ОсобыеУсловияПеревозкиОписание { get; set; }
        //public string НаправлениеДеятельности_Key { get; set; }
        //public string УдалитьТоварноТранспортнаяНакладнаяЕГАИС_Key { get; set; }
        //public bool ЕстьАлкогольнаяПродукция { get; set; }
        //public string Соглашение_Key { get; set; }
        //public string Организация_Key { get; set; }
        //public int Курс { get; set; }
        //public string Кратность { get; set; }
        //public string ПорядокОплаты { get; set; }
        //public bool ЕстьМаркируемаяПродукцияГИСМ { get; set; }
        //public bool ЕстьКиЗГИСМ { get; set; }
        //public string ВариантПриемкиТоваров { get; set; }
        //public int СуммаВзаиморасчетовПоТаре { get; set; }
        //public bool НетДокументов { get; set; }
        //public DateTime Доброга_ЖелаемаяДатаДоставки { get; set; }
        //public string Доброга_ДоставкаКонтактноеЛицо { get; set; }
        //public string Доброга_ДоставкаТелефон { get; set; }
        //public object[] ДополнительныеРеквизиты { get; set; }
        //public Расшифровкаплатежа[] РасшифровкаПлатежа { get; set; }
        //public object[] Серии { get; set; }
        //public object[] ВидыЗапасов { get; set; }
        //public Этапыграфикаоплаты[] ЭтапыГрафикаОплаты { get; set; }        
    }

    public class DocumentПриобретениеТоваровУслугТовары
    {
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
        public double СуммаСНДС { get; set; }
        public double СуммаРучнойСкидки { get; set; }
        public double ПроцентРучнойСкидки { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Склад_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ЗаказПоставщику_Key { get; set; }

        //public string НоменклатураПоставщика_Key { get; set; }
        //public string Характеристика_Key { get; set; }
        //public string ВидЦеныПоставщика_Key { get; set; }
        //public string СтатьяРасходов_Key { get; set; }
        //public string АналитикаРасходов { get; set; }
        //public string АналитикаРасходов_Type { get; set; }
        //public string КодСтроки { get; set; }
        //public string НомерГТД_Key { get; set; }
        //public string УдалитьНомерСтрокиДокументаПоставщика { get; set; }
        //public string Сертификат { get; set; }
        //public string НомерПаспорта { get; set; }
        //public int СтатусУказанияСерий { get; set; }
        //public int УдалитьСтатусУказанияСерийНаСкладах { get; set; }
        //public int УдалитьСтатусУказанияСерийТоварыУПартнеров { get; set; }
        //public string Сделка_Key { get; set; }
        //public float СуммаВзаиморасчетов { get; set; }
        //public float СуммаНДСВзаиморасчетов { get; set; }
        //public string ВидЗапасов_Key { get; set; }
        //public string ИдентификаторСтроки { get; set; }
        //public string УдалитьАналитикаУчетаПартий_Key { get; set; }
        //public string Назначение_Key { get; set; }
        //public string Серия_Key { get; set; }
        //public string АналитикаУчетаНоменклатуры_Key { get; set; }
        //public string УдалитьАналитикаУчетаНоменклатурыТоварыУПартнеров_Key { get; set; }
        //public string Подразделение_Key { get; set; }
        //public bool СписатьНаРасходы { get; set; }
    }

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

    //public class Этапыграфикаоплаты
    //{
    //    public string Ref_Key { get; set; }
    //    public string LineNumber { get; set; }
    //    public string Заказ_Key { get; set; }
    //    public bool СверхЗаказа { get; set; }
    //    public string ВариантОплаты { get; set; }
    //    public DateTime ДатаПлатежа { get; set; }
    //    public string Сдвиг { get; set; }
    //    public int ПроцентПлатежа { get; set; }
    //    public float СуммаПлатежа { get; set; }
    //    public int ПроцентЗалогаЗаТару { get; set; }
    //    public int СуммаЗалогаЗаТару { get; set; }
    //    public float СуммаВзаиморасчетов { get; set; }
    //    public int СуммаВзаиморасчетовПоТаре { get; set; }
    //}
}
