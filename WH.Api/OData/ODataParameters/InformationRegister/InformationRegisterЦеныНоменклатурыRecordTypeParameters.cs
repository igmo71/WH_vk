
namespace WH.Api.OData.ODataParameters.InformationRegister
{
    public interface IInformationRegisterЦеныНоменклатурыRecordTypeParameters : IODataParameters
    { }

    public class InformationRegisterЦеныНоменклатурыRecordTypeParameters : IInformationRegisterЦеныНоменклатурыRecordTypeParameters
    {
        public int? Top => 10000;

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = "InformationRegister_ЦеныНоменклатуры25_RecordType/$count" +
                        $"?$filter=Active eq true and Period ge datetime'{begin:s}' and Period lt datetime'{end:s}'";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = "InformationRegister_ЦеныНоменклатуры25_RecordType" +
                         $"?$filter=Active eq true and Period ge datetime'{begin:s}' and Period lt datetime'{end:s}'" +
                          "&$select=Period,Recorder,Recorder_Type,LineNumber,Номенклатура_Key,Упаковка_Key,ВидЦены_Key,Цена" +
                         $"&$skip={Top * iteration}" +
                         $"&$top={Top}" +
                          "&$orderby=Recorder,LineNumber" +
                          "&$format=json" +
                          "&$inlinecount=allpages";
            return uri;
        }
    }
}
