namespace WH.Api.OData.ODataParameters.Trash
{
    public interface IAccumulationRegisterСебестоимостьТоваровRecordTypeParameters : IODataParameters
    {

    }

    public class AccumulationRegisterСебестоимостьТоваровRecordTypeParameters : IAccumulationRegisterСебестоимостьТоваровRecordTypeParameters
    {
        public int? Top => 10000;

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = "AccumulationRegister_СебестоимостьТоваров_RecordType/$count" +
                        $"?$filter=Active eq true and Period ge datetime'{begin:s}' and Period lt datetime'{end:s}'";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = "AccumulationRegister_СебестоимостьТоваров_RecordType" +
                         $"?$filter=Active eq true and Period ge datetime'{begin:s}' and Period lt datetime'{end:s}'" +
                          "&$expand=АналитикаУчетаНоменклатуры,АналитикаУчетаПоПартнерам" +
                         $"&$skip={Top * iteration}" +
                         $"&$top={Top}" +
                          "&$orderby=Recorder,LineNumber" +
                          "&$format=json" +
                          "&$inlinecount=allpages";
            return uri;
        }
    }
}
