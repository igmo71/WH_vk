using System.ComponentModel.DataAnnotations;

namespace WH.Domain.Models.Catalog
{
    public class CatalogСтруктураПредприятия : Entity
    {
        [MaxLength(AppSettings.GUID)] public required string Ref_Key { get; set; }
        public bool DeletionMark { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Parent_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Code { get; set; }
        [MaxLength(AppSettings.DESCRIPTION)] public string? Description { get; set; }
        //public string DataVersion { get; set; }
        //public string ТекущийРуководитель_Key { get; set; }
        //public string ВариантОбособленногоУчетаТоваров { get; set; }
        //public string Источник_Key { get; set; }
        //public bool СоответствуетСтруктуреЮридическихЛиц { get; set; }
        //public bool ПроизводственноеПодразделение { get; set; }
        //public string ГрафикРаботы_Key { get; set; }
        //public string ИнтервалПланирования { get; set; }
        //public DateTime НачалоИнтервалаПланирования { get; set; }
        //public DateTime ОкончаниеИнтервалаПланирования { get; set; }
        //public string УправлениеМаршрутнымиЛистами { get; set; }
        //public string РеквизитДопУпорядочивания { get; set; }
        //public int ЗаполнениеДоступностиДляРасписанияРЦКоличествоИнтервалов { get; set; }
        //public int ЗаполнениеДоступностиДляРасписанияРЦНапоминаниеДней { get; set; }
        //public int ЗаполнениеДоступностиДляГрафикаПроизводстваКоличествоИнтервалов { get; set; }
        //public string СпособПооперационногоУправления { get; set; }
        //public int ЗаполнениеДоступностиДляГрафикаПроизводстваНапоминаниеДней { get; set; }
        //public bool ПодразделениеДиспетчер { get; set; }
        //public bool ИспользоватьСерииНоменклатуры { get; set; }
        //public string ВремяНаРегистрациюВыполнения { get; set; }
        //public string ВремяНаРегистрациюВыполненияЕдИзм { get; set; }
        //public bool УчитыватьСебестоимостьПоСериям { get; set; }
        //public bool ПроизводствоПоЗаказам { get; set; }
        //public bool ПроизводствоБезЗаказов { get; set; }
        //public bool ИспользуетсяСписаниеЗатратНаВыпуск { get; set; }
        //public string СпособПолученияПолуфабрикатов { get; set; }
        //public bool ИспользоватьПооперационноеУправление { get; set; }
        //public bool ИспользоватьМатериалыВОперациях { get; set; }
        //public bool ИспользоватьВыходныеИзделияВОперациях { get; set; }
        //public bool ИспользоватьПооперационноеПланирование { get; set; }
        //public string ПериодичностьОформленияВыработки { get; set; }
        //public bool ИспользоватьКТУ { get; set; }
        //public bool ИспользоватьТарифныеСтавки { get; set; }
        //public bool ИспользоватьОтработанноеВремя { get; set; }
        //public bool ИспользоватьБригадныеНаряды { get; set; }
        //public bool ИспользоватьПерсональныеНаряды { get; set; }
        //public string СпособНастройкиГрафикаРаботы { get; set; }
        //public bool ИспользоватьСменныеЗадания { get; set; }
        //public bool ИспользоватьПроизводственныеУчастки { get; set; }
        //public string КодИсточника { get; set; }
        //public object[] ГрафикиРаботы { get; set; }
        //public object[] ДополнительныеРеквизиты { get; set; }
        //public bool Predefined { get; set; }
        //public string PredefinedDataName { get; set; }
        //public string ParentnavigationLinkUrl { get; set; }
    }

}
