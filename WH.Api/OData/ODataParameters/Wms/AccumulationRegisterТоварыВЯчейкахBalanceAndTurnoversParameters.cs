
namespace WH.Api.OData.ODataParameters.Wms
{
    public interface IAccumulationRegisterТоварыВЯчейкахBalanceAndTurnoversParameters : IODataParameters
    { }

    public class AccumulationRegisterТоварыВЯчейкахBalanceAndTurnoversParameters : IAccumulationRegisterТоварыВЯчейкахBalanceAndTurnoversParameters
    {
        public int? Top => throw new NotImplementedException();

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = $"AccumulationRegister_ТоварыВЯчейках" +
                         $"/BalanceAndTurnovers(StartPeriod=datetime'{begin:s}',EndPeriod=datetime'{((DateTime)end!).AddSeconds(-1):s}')/$count";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = $"AccumulationRegister_ТоварыВЯчейках" +
                         $"/BalanceAndTurnovers(StartPeriod=datetime'{begin:s}',EndPeriod=datetime'{((DateTime)end!).AddSeconds(-1):s}')" +
                         "?$select=Склад_Key,Ячейка_Key,Номенклатура_Key,Серия_Key,ЕдиницаИзмерения_Key,Паллет_Key,Дата,КоличествоOpeningBalance,КоличествоTurnover,КоличествоReceipt,КоличествоExpense,КоличествоClosingBalance" +
                          "&$format=json" +
                          "&$inlinecount=allpages";
            return uri;
        }
    }
}
