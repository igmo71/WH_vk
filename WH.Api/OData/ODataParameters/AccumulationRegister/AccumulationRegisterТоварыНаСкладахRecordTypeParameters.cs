
namespace WH.Api.OData.ODataParameters.AccumulationRegister
{
    public interface IAccumulationRegisterТоварыНаСкладахRecordTypeParameters : IODataParameters
    { }

    public class AccumulationRegisterТоварыНаСкладахRecordTypeParameters : IAccumulationRegisterТоварыНаСкладахRecordTypeParameters
    {
        public int? Top => 10000;

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = "AccumulationRegister_ТоварыНаСкладах_RecordType/$count" +
                        $"?$filter=Active eq true and Period ge datetime'{begin:s}' and Period lt datetime'{end:s}'";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = "AccumulationRegister_ТоварыНаСкладах_RecordType" +
                         $"?$filter=Active eq true and Period ge datetime'{begin:s}' and Period lt datetime'{end:s}'" +
                          "&$select=Period,Recorder,Recorder_Type,LineNumber,RecordType,Номенклатура_Key,Назначение_Key,Склад_Key,ВНаличии,КОтгрузке,КонтролироватьОстатки" +
                         $"&$skip={Top * iteration}" +
                         $"&$top={Top}" +
                          "&$orderby=Recorder,LineNumber" +
                          "&$format=json" +
                          "&$inlinecount=allpages";
            return uri;
        }
    }
}
