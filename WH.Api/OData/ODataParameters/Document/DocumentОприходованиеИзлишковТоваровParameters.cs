
namespace WH.Api.OData.ODataParameters.Document
{
    public interface IDocumentОприходованиеИзлишковТоваровParameters : IODataParameters
    { }

    public class DocumentОприходованиеИзлишковТоваровParameters : IDocumentОприходованиеИзлишковТоваровParameters
    {
        public int? Top => throw new NotImplementedException();

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = "Document_ОприходованиеИзлишковТоваров/$count" +
                         $"?$filter=DeletionMark eq false and Posted eq true and Date ge datetime'{begin:s}' and Date lt datetime'{end:s}'";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = "Document_ОприходованиеИзлишковТоваров" +
                          "?$select=Ref_Key,Number,Date,Ответственный_Key,Подразделение_Key,Склад_Key,ВидЦены_Key,ПересчетТоваров_Key,Основание,Основание_Type,Товары" +
                         $"&$filter=DeletionMark eq false and Posted eq true and Date ge datetime'{begin:s}' and Date lt datetime'{end:s}'" +
                          "&$format=json" +
                          "&$inlinecount=allpages";
            return uri;
        }
    }
}
