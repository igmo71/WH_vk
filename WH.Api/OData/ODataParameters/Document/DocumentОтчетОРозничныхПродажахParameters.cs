namespace WH.Api.OData.ODataParameters.Document
{
    public interface IDocumentОтчетОРозничныхПродажахParameters : IODataParameters
    { }

    public class DocumentОтчетОРозничныхПродажахParameters : IDocumentОтчетОРозничныхПродажахParameters
    {
        public int? Top => throw new NotImplementedException();

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = "Document_ОтчетОРозничныхПродажах/$count" +
                         $"?$filter=DeletionMark eq false and Posted eq true and Date ge datetime'{begin:s}' and Date lt datetime'{end:s}'";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = "Document_ОтчетОРозничныхПродажах" +
                          "?$select=Ref_Key,Number,Date,СуммаДокумента,Подразделение_Key,Ответственный_Key,Склад_Key,ВидЦены_Key,НалогообложениеНДС,ЦенаВключаетНДС,Товары" +
                         $"&$filter=DeletionMark eq false and Posted eq true and Date ge datetime'{begin:s}' and Date lt datetime'{end:s}'" +
                          "&$format=json" +
                          "&$inlinecount=allpages";
            return uri;
        }
    }
}
