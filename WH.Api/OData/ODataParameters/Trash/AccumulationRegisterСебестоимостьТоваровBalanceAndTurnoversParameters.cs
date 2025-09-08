namespace WH.Api.OData.ODataParameters.Trash
{
    public interface IAccumulationRegisterСебестоимостьТоваровBalanceAndTurnoversParameters : IODataParameters
    { }

    public class AccumulationRegisterСебестоимостьТоваровBalanceAndTurnoversParameters
        : IAccumulationRegisterСебестоимостьТоваровBalanceAndTurnoversParameters
    {
        public int? Top => 20000;

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = $"AccumulationRegister_СебестоимостьТоваров" +
                         $"/BalanceAndTurnovers(StartPeriod=datetime'{begin:s}',EndPeriod=datetime'{((DateTime)end!).AddSeconds(-1):s}')/$count" +
                          "?$filter=(Партия_Type ne 'StandardODATA.Document_ПередачаТоваровМеждуОрганизациями') and (КоличествоTurnover ne 0)";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = $"AccumulationRegister_СебестоимостьТоваров" +
                         $"/BalanceAndTurnovers(StartPeriod=datetime'{begin:s}',EndPeriod=datetime'{((DateTime)end!).AddSeconds(-1):s}')" +
                          "?$expand=АналитикаУчетаНоменклатуры" +
                          "&$select=АналитикаУчетаНоменклатуры/Номенклатура_Key,Партия,Партия_Type,КоличествоOpeningBalance,КоличествоTurnover,КоличествоReceipt,КоличествоExpense,КоличествоClosingBalance,СтоимостьOpeningBalance,СтоимостьTurnover,СтоимостьReceipt,СтоимостьExpense,СтоимостьClosingBalance" +
                          "&$filter=(Партия_Type ne 'StandardODATA.Document_ПередачаТоваровМеждуОрганизациями') and (КоличествоTurnover ne 0)" +
                          "&$orderby=Партия,Партия_Type,АналитикаУчетаНоменклатуры/Номенклатура_Key" +
                         $"&$skip={Top * iteration}" +
                         $"&$top={Top}" +
                          "&$format=json" //+
                                          //"&$inlinecount=allpages"
                          ;
            return uri;
        }
    }
}
