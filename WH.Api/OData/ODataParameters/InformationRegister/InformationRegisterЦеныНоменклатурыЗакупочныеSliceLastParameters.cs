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
                         "?$filter=ВидЦены_Key eq guid'4c912650-0e95-11e0-ad48-000c29dcd88a'" +
                         "&$select=Period,Номенклатура_Key,Цена" +
                         "&$format=json";
            return uri;
        }
    }
}
