namespace WH.Api.OData.ODataParameters.InformationRegister
{
    public interface IInformationRegisterЦеныНоменклатурыПоставкиSliceLastParameters
    {
        string GetUri(DateTime? period);
    }

    public class InformationRegisterЦеныНоменклатурыПоставкиSliceLastParameters : IInformationRegisterЦеныНоменклатурыПоставкиSliceLastParameters
    {
        public string GetUri(DateTime? period)
        {
            if (period == null)
                return string.Empty;

            string uri = "InformationRegister_ЦеныНоменклатуры25_RecordType" +
                        $"/SliceLast(Period='{((DateTime)period).AddHours(23).AddMinutes(59).AddSeconds(59):s}')" +
                         "?$filter=ВидЦены_Key eq guid'3c7369cb-3272-11e8-80ed-0cc47adeb013'" +
                         "&$select=Period,Номенклатура_Key,Цена" +
                         "&$format=json";
            return uri;
        }
    }
}
