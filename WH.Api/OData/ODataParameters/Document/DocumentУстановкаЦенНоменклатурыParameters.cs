
namespace WH.Api.OData.ODataParameters.Document
{
    public interface IDocumentУстановкаЦенНоменклатурыParameters : IODataParameters
    { }

    public class DocumentУстановкаЦенНоменклатурыParameters : IDocumentУстановкаЦенНоменклатурыParameters
    {
        public int? Top => throw new NotImplementedException();

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = "Document_УстановкаЦенНоменклатуры/$count" +
                         $"?$filter=DeletionMark eq false and Posted eq true and Date ge datetime'{begin:s}' and Date lt datetime'{end:s}'";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = "Document_УстановкаЦенНоменклатуры" +
                          "?$select=Ref_Key,Number,Date,Ответственный_Key,Согласован,ДокументОснование,ДокументОснование_Type,Статус,Товары2_5" +
                         $"&$filter=DeletionMark eq false and Posted eq true and Date ge datetime'{begin:s}' and Date lt datetime'{end:s}'" +
                          "&$format=json" +
                          "&$inlinecount=allpages";
            return uri;
        }
    }
}
