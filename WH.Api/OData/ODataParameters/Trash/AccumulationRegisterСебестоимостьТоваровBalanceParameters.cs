namespace WH.Api.OData.ODataParameters.Trash
{
    public interface IAccumulationRegisterСебестоимостьТоваровBalanceParameters
    {
        string GetUri(DateTime? date = null);
    }

    public class AccumulationRegisterСебестоимостьТоваровBalanceParameters : IAccumulationRegisterСебестоимостьТоваровBalanceParameters
    {
        public int? Top => throw new NotImplementedException();

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            throw new NotImplementedException();
        }

        public string GetUri(DateTime? date = null)
        {
            string uri = "AccumulationRegister_СебестоимостьТоваров/Balance";

            if (date != null)
            {
                uri += $"(Period=datetime'{date:s}')";
            }

            uri += "?$expand=АналитикаУчетаНоменклатуры" +
                   "&$select=АналитикаУчетаНоменклатуры/Номенклатура_Key,Партия,Партия_Type,КоличествоBalance,СтоимостьBalance" +
                   "&$format=json";

            return uri;
        }
    }
}
