namespace WH.Api.OData.ODataParameters.AccumulationRegister
{
    public interface IAccumulationRegisterГрафикПоступленияТоваровRecordTypeParameters : IODataParameters
    { }

    public class AccumulationRegisterГрафикПоступленияТоваровRecordTypeParameters : IAccumulationRegisterГрафикПоступленияТоваровRecordTypeParameters
    {
        public int? Top => 5000;

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = "AccumulationRegister_ГрафикПоступленияТоваров_RecordType/$count" +
                        $"?$filter=Active eq true and Period ge datetime'{begin:s}' and Period lt datetime'{end:s}'";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = "AccumulationRegister_ГрафикПоступленияТоваров_RecordType" +
                         $"?$filter=Active eq true and Period ge datetime'{begin:s}' and Period lt datetime'{end:s}'" +
                          "&$select=Period,Recorder,Recorder_Type,LineNumber,Номенклатура_Key,Склад_Key,ДатаСобытия,КоличествоИзЗаказов,КоличествоПодЗаказ,КоличествоИзЗаказовСНеподтвержденными,КоличествоПодЗаказСНеподтвержденными" +
                         $"&$skip={Top * iteration}" +
                         $"&$top={Top}" +
                          "&$orderby=Recorder,LineNumber" +
                          "&$format=json" +
                          "&$inlinecount=allpages";
            return uri;
        }
    }
}
