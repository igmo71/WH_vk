using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WH.Domain.Models.AccumulationRegister
{
    public class AccumulationRegisterСебестоимостьТоваровBalance : Entity, IHaveId
    {
        [MaxLength(AppSettings.GUID)] public string? Id { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Номенклатура_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Партия { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Партия_Type { get; set; }
        public double КоличествоBalance { get; set; }
        public double СтоимостьBalance { get; set; }

        [NotMapped]
        public АналитикаУчетаНоменклатуры? АналитикаУчетаНоменклатуры { get; set; }

        //public string АналитикаУчетаПартий_Key { get; set; }
        //public string АналитикаУчетаНоменклатуры_Key { get; set; }
        //public string РазделУчета { get; set; }
        //public string ВидЗапасов_Key { get; set; }
        //public string Организация_Key { get; set; }
        //public string АналитикаФинансовогоУчета { get; set; }
        //public string АналитикаФинансовогоУчета_Type { get; set; }
        //public string ВидДеятельностиНДС { get; set; }
        //public float СтоимостьБезНДСBalance { get; set; }
        //public int СтоимостьЗабалансоваяBalance { get; set; }
        //public float ДопРасходыBalance { get; set; }
        //public float ДопРасходыБезНДСBalance { get; set; }
        //public int ТрудозатратыBalance { get; set; }
        //public int ПостатейныеПостоянныеСНДСBalance { get; set; }
        //public int ПостатейныеПеременныеСНДСBalance { get; set; }
        //public int ПостатейныеПостоянныеБезНДСBalance { get; set; }
        //public int ПостатейныеПеременныеБезНДСBalance { get; set; }
        //public float СтоимостьРеглBalance { get; set; }
        //public int СтоимостьЗабалансоваяРеглBalance { get; set; }
        //public float ДопРасходыРеглBalance { get; set; }
        //public int ТрудозатратыРеглBalance { get; set; }
        //public int ПостатейныеПостоянныеРеглBalance { get; set; }
        //public int ПостатейныеПеременныеРеглBalance { get; set; }
        //public int ПостояннаяРазницаBalance { get; set; }
        //public int ВременнаяРазницаBalance { get; set; }
        //public int СтоимостьУпрBalance { get; set; }
        //public int ДопРасходыУпрBalance { get; set; }
        //public int ТрудозатратыУпрBalance { get; set; }
        //public int ПостатейныеПостоянныеУпрBalance { get; set; }
        //public int ПостатейныеПеременныеУпрBalance { get; set; }
    }
}
