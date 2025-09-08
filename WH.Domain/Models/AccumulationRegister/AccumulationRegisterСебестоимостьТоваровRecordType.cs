using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Text.Json.Serialization;

namespace WH.Domain.Models.AccumulationRegister
{
    public class AccumulationRegisterСебестоимостьТоваровRecordType : Entity, IHaveDate, IHaveId
    {
        [MaxLength(AppSettings.GUID)] public string? Id { get; set; }
        [Column(TypeName = nameof(SqlDbType.Date))]
        [JsonPropertyName("Period")] public DateTime Date { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Recorder { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Recorder_Type { get; set; }
        public int LineNumber { get; set; }
        [MaxLength(AppSettings.RECORD_TYPE)] public string? RecordType { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Номенклатура_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Партнер_Key { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? РазделУчета { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ВидЗапасов_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Партия { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Партия_Type { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? ВидДеятельностиНДС { get; set; }
        public double Количество { get; set; }
        public double Стоимость { get; set; }
        public double СтоимостьБезНДС { get; set; }
        public double ДопРасходы { get; set; }
        public double ДопРасходыБезНДС { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? ХозяйственнаяОперация { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ЗаказКлиента { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? ЗаказКлиента_Type { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Подразделение_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? АналитикаРасходов { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? АналитикаРасходов_Type { get; set; }
        [MaxLength(AppSettings.GUID)] public string? СтатьяРасходовСписания_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? СтатьяДоходов_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? АналитикаДоходов { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? АналитикаДоходов_Type { get; set; }
        [Column(TypeName = nameof(SqlDbType.Date))] public DateTime ПериодПродажи { get; set; }
        [MaxLength(AppSettings.GUID)] public string? СтатьяАктивовПассивов_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? АналитикаАктивовПассивов { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? АналитикаАктивовПассивов_Type { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ДокументДвижения { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? ДокументДвижения_Type { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ГруппаПродукции_Key { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? ТипЗаписи { get; set; }
        [MaxLength(AppSettings.GUID)] public string? ДокументИсточник { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? ДокументИсточник_Type { get; set; }
        public bool РасчетПартий { get; set; }
        public bool РасчетСебестоимости { get; set; }
        public bool РасчетНеЗавершен { get; set; }

        [NotMapped]
        public АналитикаУчетаНоменклатуры? АналитикаУчетаНоменклатуры { get; set; }

        [NotMapped]
        public АналитикаУчетаПоПартнерам? АналитикаУчетаПоПартнерам { get; set; }

        //public bool Active { get; set; }
        //public string СтатьяКалькуляции { get; set; }
        //public string ИдентификаторСтроки { get; set; }
        //public string Организация_Key { get; set; }
        //public string АналитикаУчетаПартий_Key { get; set; }
        //public string АналитикаФинансовогоУчета { get; set; }
        //public string АналитикаФинансовогоУчета_Type { get; set; }
        //public int СтоимостьЗабалансовая { get; set; }
        //public int Трудозатраты { get; set; }
        //public int ПостатейныеПостоянныеСНДС { get; set; }
        //public int ПостатейныеПеременныеСНДС { get; set; }
        //public int ПостатейныеПостоянныеБезНДС { get; set; }
        //public int ПостатейныеПеременныеБезНДС { get; set; }
        //public float СтоимостьРегл { get; set; }
        //public int СтоимостьЗабалансоваяРегл { get; set; }
        //public float ДопРасходыРегл { get; set; }
        //public int ТрудозатратыРегл { get; set; }
        //public int ПостатейныеПостоянныеРегл { get; set; }
        //public int ПостатейныеПеременныеРегл { get; set; }
        //public int ПостояннаяРазница { get; set; }
        //public int ВременнаяРазница { get; set; }
        //public int СтоимостьУпр { get; set; }
        //public int ДопРасходыУпр { get; set; }
        //public int ТрудозатратыУпр { get; set; }
        //public int ПостатейныеПостоянныеУпр { get; set; }
        //public int ПостатейныеПеременныеУпр { get; set; }

        //public string КорАналитикаУчетаНоменклатуры_Key { get; set; }
        //public string КорРазделУчета { get; set; }
        //public string КорВидЗапасов_Key { get; set; }
        //public string КорОрганизация_Key { get; set; }
        //public int КорСтоимость { get; set; }
        //public float НДСРегл { get; set; }        
        //public string КорПартия { get; set; }
        //public string КорПартия_Type { get; set; }
        //public string КорАналитикаУчетаПартий_Key { get; set; }
        //public string КорАналитикаФинансовогоУчета { get; set; }
        //public string КорАналитикаФинансовогоУчета_Type { get; set; }
        //public string КорВидДеятельностиНДС { get; set; }
        //public string УдалитьАналитикаУчетаПартийПроизводства { get; set; }
        //public float НДСУпр { get; set; }
        //public string КодСтроки { get; set; }
        //public string КорНаправлениеДеятельности_Key { get; set; }
    }
}
