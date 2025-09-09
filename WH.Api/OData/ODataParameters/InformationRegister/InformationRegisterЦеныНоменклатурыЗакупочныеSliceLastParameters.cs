namespace WH.Api.OData.ODataParameters.InformationRegister
{
    public interface IInformationRegisterЦеныНоменклатурыЗакупочныеSliceLastParameters
    {
        string GetUri(DateTime? period);
    }

    public class InformationRegisterЦеныНоменклатурыЗакупочныеSliceLastParameters : IInformationRegisterЦеныНоменклатурыЗакупочныеSliceLastParameters
    {
        public string GetUri(DateTime? period)
        {
            if (period == null)
                return string.Empty;

            string uri = "InformationRegister_ЦеныНоменклатуры25_RecordType" +
                        $"/SliceLast(Period='{((DateTime)period).AddHours(23).AddMinutes(59).AddSeconds(59):s}')" +
                         "?$filter=ВидЦены_Key eq guid'19691144-7da9-11f0-ba88-00155d013e14'" +
                         "&$select=Period,Номенклатура_Key,Цена" +
                         "&$format=json";
            return uri;
        }
    }
}
