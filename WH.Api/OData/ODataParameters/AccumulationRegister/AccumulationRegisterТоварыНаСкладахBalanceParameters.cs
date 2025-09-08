namespace WH.Api.OData.ODataParameters.AccumulationRegister
{
    public interface IAccumulationRegisterТоварыНаСкладахBalanceParameters
    {
        string GetUri(DateTime? period);
    }

    public class AccumulationRegisterТоварыНаСкладахBalanceParameters : IAccumulationRegisterТоварыНаСкладахBalanceParameters
    {
        public string GetUri(DateTime? period)
        {
            string uri = "AccumulationRegister_ТоварыНаСкладах" +
                        $"/Balance(Period=datetime'{((DateTime)period!).AddDays(1).AddSeconds(-1):s}.999')" +
                         "?$select=Номенклатура_Key,Склад_Key,ВНаличииBalance" +
                         "&$format=json";
            return uri;
        }
    }
}
