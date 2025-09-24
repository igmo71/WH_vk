namespace WH.Api.OData.ODataParameters.InformationRegister
{
    // Закупочная ВоронежКреп
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
                         "?$filter=ВидЦены_Key eq guid'4ca658b6-9859-11f0-ba8a-00155d013e14'" +
                         "&$select=Period,Номенклатура_Key,Цена" +
                         "&$format=json";
            return uri;
        }
    }
}
