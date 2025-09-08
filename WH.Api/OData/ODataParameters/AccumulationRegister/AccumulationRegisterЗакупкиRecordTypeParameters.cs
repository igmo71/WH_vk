
namespace WH.Api.OData.ODataParameters.AccumulationRegister
{
    public interface IAccumulationRegisterЗакупкиRecordTypeParameters : IODataParameters
    { }

    public class AccumulationRegisterЗакупкиRecordTypeParameters : IAccumulationRegisterЗакупкиRecordTypeParameters
    {
        public int? Top => 5000;

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = "AccumulationRegister_Закупки_RecordType/$count" +
                        $"?$filter=Active eq true and Period ge datetime'{begin:s}' and Period lt datetime'{end:s}'";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = "AccumulationRegister_Закупки_RecordType" +
                         $"?$filter=Active eq true and Period ge datetime'{begin:s}' and Period lt datetime'{end:s}'" +
                          "&$expand=АналитикаУчетаНоменклатуры" +
                         //"&$select=Period,Recorder,Recorder_Type,LineNumber,Организация_Key,Подразделение_Key,Менеджер_Key,Склад,Склад_Type,ХозяйственнаяОперация,ТипЗапасов,ВидЗапасов_Key,Партнер_Key,РасчетСебестоимости,Количество,Сумма,СуммаБезНДС,Стоимость,СтоимостьБезНДС,СуммаДопРасходов,СуммаДопРасходовБезНДС,СуммаСкидки,АналитикаУчетаНоменклатуры/Номенклатура_Key" +
                         $"&$skip={Top * iteration}" +
                         $"&$top={Top}" +
                          "&$orderby=Recorder,LineNumber" +
                          "&$format=json" +
                          "&$inlinecount=allpages";
            return uri;
        }
    }
}
