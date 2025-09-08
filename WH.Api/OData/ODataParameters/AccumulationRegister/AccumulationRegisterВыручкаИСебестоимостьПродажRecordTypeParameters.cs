namespace WH.Api.OData.ODataParameters.AccumulationRegister
{
    public interface IAccumulationRegisterВыручкаИСебестоимостьПродажRecordTypeParameters : IODataParameters
    { }

    public class AccumulationRegisterВыручкаИСебестоимостьПродажRecordTypeParameters : IAccumulationRegisterВыручкаИСебестоимостьПродажRecordTypeParameters
    {
        public int? Top => 5000;

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = "AccumulationRegister_ВыручкаИСебестоимостьПродаж_RecordType/$count" +
                        $"?$filter=Active eq true and Period ge datetime'{begin:s}' and Period lt datetime'{end:s}'";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = "AccumulationRegister_ВыручкаИСебестоимостьПродаж_RecordType" +
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
