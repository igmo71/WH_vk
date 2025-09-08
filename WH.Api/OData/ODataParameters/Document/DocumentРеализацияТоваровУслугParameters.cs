namespace WH.Api.OData.ODataParameters.Document
{
    public interface IDocumentРеализацияТоваровУслугParameters : IODataParameters
    { }

    public class DocumentРеализацияТоваровУслугParameters : IDocumentРеализацияТоваровУслугParameters
    {
        public int? Top => throw new NotImplementedException();

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = "Document_РеализацияТоваровУслуг/$count" +
                         $"?$filter=DeletionMark eq false and Posted eq true and Date ge datetime'{begin:s}' and Date lt datetime'{end:s}'";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = "Document_РеализацияТоваровУслуг" +
                          "?$select=Ref_Key,Number,Date,СуммаДокумента,Подразделение_Key,Менеджер_Key,Склад_Key,Партнер_Key,ЗаказКлиента,ЗаказКлиента_Type,РеализацияПоЗаказам,ХозяйственнаяОперация,Статус,НалогообложениеНДС,ЦенаВключаетНДС,Согласован,СкидкиРассчитаны,Товары" + // Доброга_ИсточникЗаявки_Key
                         $"&$filter=DeletionMark eq false and Posted eq true and Date ge datetime'{begin:s}' and Date lt datetime'{end:s}'" +
                          "&$format=json" +
                          "&$inlinecount=allpages";
            return uri;
        }
    }
}
