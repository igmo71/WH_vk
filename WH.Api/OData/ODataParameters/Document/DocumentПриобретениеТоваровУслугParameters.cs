
namespace WH.Api.OData.ODataParameters.Document
{
    public interface IDocumentПриобретениеТоваровУслугParameters : IODataParameters
    { }

    public class DocumentПриобретениеТоваровУслугParameters : IDocumentПриобретениеТоваровУслугParameters
    {
        public int? Top => throw new NotImplementedException();

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = "Document_ПриобретениеТоваровУслуг/$count" +
                         $"?$filter=DeletionMark eq false and Posted eq true and Date ge datetime'{begin:s}' and Date lt datetime'{end:s}'";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = "Document_ПриобретениеТоваровУслуг" +
                          "?$select=Ref_Key,Number,Date,СуммаДокумента,Подразделение_Key,Менеджер_Key,Склад_Key,Партнер_Key,ХозяйственнаяОперация,ЗаказПоставщику_Key,ПоступлениеПоЗаказам,Валюта_Key,НалогообложениеНДС,ЦенаВключаетНДС,Согласован,Товары" +
                         $"&$filter=DeletionMark eq false and Posted eq true and Date ge datetime'{begin:s}' and Date lt datetime'{end:s}'" +
                          "&$format=json" +
                          "&$inlinecount=allpages";
            return uri;
        }
    }
}
