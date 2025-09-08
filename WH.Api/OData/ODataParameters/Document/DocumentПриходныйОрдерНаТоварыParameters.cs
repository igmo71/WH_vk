
namespace WH.Api.OData.ODataParameters.Document
{
    public interface IDocumentПриходныйОрдерНаТоварыParameters : IODataParameters
    { }

    public class DocumentПриходныйОрдерНаТоварыParameters : IDocumentПриходныйОрдерНаТоварыParameters
    {
        public int? Top => throw new NotImplementedException();

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = "Document_ПриходныйОрдерНаТовары/$count" +
                         $"?$filter=DeletionMark eq false and Posted eq true and Date ge datetime'{begin:s}' and Date lt datetime'{end:s}'";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = "Document_ПриходныйОрдерНаТовары" +
                          "?$select=Ref_Key,Number,Date,Склад_Key,СкладскаяОперация,Отправитель,Отправитель_Type,Комментарий,Статус,ВсегоМест,ХозяйственнаяОперация,Распоряжение,Распоряжение_Type" +
                         $"&$filter=DeletionMark eq false and Posted eq true and Date ge datetime'{begin:s}' and Date lt datetime'{end:s}'" +
                          "&$format=json" +
                          "&$inlinecount=allpages";
            return uri;
        }
    }
}
