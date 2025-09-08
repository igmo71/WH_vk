
namespace WH.Api.OData.ODataParameters.Document
{
    public interface IDocumentРасходныйОрдерНаТоварыParameters : IODataParameters
    { }

    public class DocumentРасходныйОрдерНаТоварыParameters : IDocumentРасходныйОрдерНаТоварыParameters
    {
        public int? Top => throw new NotImplementedException();

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = "Document_РасходныйОрдерНаТовары/$count" +
                         $"?$filter=DeletionMark eq false and Posted eq true and Date ge datetime'{begin:s}' and Date lt datetime'{end:s}'";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = "Document_РасходныйОрдерНаТовары" +
                          "?$select=Ref_Key,Number,Date,Склад_Key,СкладскаяОперация,Получатель,Получатель_Type,Комментарий,Статус,ВсегоМест,ДатаОтгрузки" +
                         $"&$filter=DeletionMark eq false and Posted eq true and Date ge datetime'{begin:s}' and Date lt datetime'{end:s}'" +
                          "&$format=json" +
                          "&$inlinecount=allpages";
            return uri;
        }
    }
}
