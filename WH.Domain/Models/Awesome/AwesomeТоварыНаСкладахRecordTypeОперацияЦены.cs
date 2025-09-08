using MassTransit;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace WH.Domain.Models.Awesome
{
    public class AwesomeТоварыНаСкладахRecordTypeОперацияЦены : Entity, IHaveDate
    {
        [MaxLength(AppSettings.GUID)] public string? Id { get; set; }

        [Column(TypeName = nameof(SqlDbType.Date))]
        public DateTime Date { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Recorder { get; set; }
        [MaxLength(AppSettings.VALUE)] public string? Recorder_Type { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Операция { get; set; }
        [MaxLength(AppSettings.RECORD_TYPE)] public string? RecordType { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Номенклатура_Key { get; set; }
        public double? ВНаличии { get; set; }
        public double? Количество { get; set; }
        public double? ЦенаЗакупки { get; set; }
        public double? ЦенаПродажи { get; set; }

        public static AwesomeТоварыНаСкладахRecordTypeОперацияЦены From(VТоварыНаСкладахRecordTypeОперацияЦеныOp recordTypeItem)
        {
            return new AwesomeТоварыНаСкладахRecordTypeОперацияЦены
            {
                Id = NewId.Next().ToString(),
                Date = recordTypeItem.Date,
                Номенклатура_Key = recordTypeItem.Номенклатура_Key,
                Recorder = recordTypeItem.Recorder,
                Recorder_Type = recordTypeItem.Recorder_Type,
                RecordType = recordTypeItem.RecordType,
                Операция = recordTypeItem.Операция,
                ВНаличии = recordTypeItem.ВНаличии,
                Количество = recordTypeItem.Количество,
                ЦенаЗакупки = recordTypeItem.ЦенаЗакупки,
                ЦенаПродажи = recordTypeItem.ЦенаПродажи
            };
        }

        public static AwesomeТоварыНаСкладахRecordTypeОперацияЦены From(VТоварыНаСкладахBalanceAndTurnoversNoWhs balanceAndTurnoversItem, double? price)
        {
            return new AwesomeТоварыНаСкладахRecordTypeОперацияЦены
            {
                Id = NewId.Next().ToString(),
                Date = balanceAndTurnoversItem.Date,
                Номенклатура_Key = balanceAndTurnoversItem.Номенклатура_Key,
                Recorder = Guid.Empty.ToString(),
                Recorder_Type = "AccumulationRegisterТоварыНаСкладахBalanceAndTurnovers",
                RecordType = "Receipt",
                Операция = "ВводНачальногоОстатка",
                ВНаличии = balanceAndTurnoversItem.ВНаличииOpeningBalance,
                Количество = balanceAndTurnoversItem.ВНаличииOpeningBalance,
                ЦенаЗакупки = price,
                ЦенаПродажи = null
            };
        }
    }
}
