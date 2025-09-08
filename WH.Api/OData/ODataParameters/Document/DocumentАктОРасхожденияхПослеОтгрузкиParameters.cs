
namespace WH.Api.OData.ODataParameters.Document
{
    public interface IDocumentАктОРасхожденияхПослеОтгрузкиParameters : IODataParameters
    { }

    public class DocumentАктОРасхожденияхПослеОтгрузкиParameters : IDocumentАктОРасхожденияхПослеОтгрузкиParameters
    {
        public int? Top => throw new NotImplementedException();

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = "Document_АктОРасхожденияхПослеОтгрузки/$count" +
                         $"?$filter=DeletionMark eq false and Posted eq true and Date ge datetime'{begin:s}' and Date lt datetime'{end:s}'";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = "Document_АктОРасхожденияхПослеОтгрузки" +
                          "?$select=Ref_Key,Number,Date,Партнер_Key,Менеджер_Key,МассаБруттоПоФакту,МассаНеттоПоФакту,Товары" +
                         $"&$filter=DeletionMark eq false and Posted eq true and Date ge datetime'{begin:s}' and Date lt datetime'{end:s}'" +
                          "&$format=json" +
                          "&$inlinecount=allpages";
            return uri;
        }
    }
}
