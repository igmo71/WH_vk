namespace WH.Api.OData.ODataParameters.AccumulationRegister
{
    public interface IAccumulationRegisterТоварыНаСкладахBalanceAndTurnoversParameters : IODataParameters
    {
        string GetClosingBalance(DateTime date);
    }

    public class AccumulationRegisterТоварыНаСкладахBalanceAndTurnoversParameters : IAccumulationRegisterТоварыНаСкладахBalanceAndTurnoversParameters
    {
        public int? Top => throw new NotImplementedException();

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = $"AccumulationRegister_ТоварыНаСкладах" +
                         $"/BalanceAndTurnovers(StartPeriod=datetime'{begin:s}',EndPeriod=datetime'{((DateTime)end!).AddSeconds(-1):s}')/$count";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = $"AccumulationRegister_ТоварыНаСкладах" +
                         $"/BalanceAndTurnovers(StartPeriod=datetime'{begin:s}',EndPeriod=datetime'{((DateTime)end!).AddSeconds(-1):s}')" +
                          "?$select=Номенклатура_Key,Склад_Key,ВНаличииOpeningBalance,ВНаличииTurnover,ВНаличииReceipt,ВНаличииExpense,ВНаличииClosingBalance,КОтгрузкеOpeningBalance,КОтгрузкеTurnover,КОтгрузкеReceipt,КОтгрузкеExpense,КОтгрузкеClosingBalance" +
                          "&$format=json" +
                          "&$inlinecount=allpages";
            return uri;
        }

        public string GetClosingBalance(DateTime date)
        {
            string uri = $"AccumulationRegister_ТоварыНаСкладах" +
                         $"/BalanceAndTurnovers(StartPeriod=datetime'{date:s}',EndPeriod=datetime'{date.AddDays(1).AddSeconds(-1):s}')" +
                          "?$select=ВНаличииClosingBalance" +
                          "&$format=json" +
                          "&$inlinecount=allpages";
            return uri;
        }
    }
}
