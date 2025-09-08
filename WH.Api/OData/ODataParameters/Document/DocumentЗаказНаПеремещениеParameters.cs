
namespace WH.Api.OData.ODataParameters.Document
{
    public interface IDocumentЗаказНаПеремещениеParameters : IODataParameters
    { }

    public class DocumentЗаказНаПеремещениеParameters : IDocumentЗаказНаПеремещениеParameters
    {
        public int? Top => throw new NotImplementedException();

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = "Document_ЗаказНаПеремещение/$count" +
                         $"?$filter=DeletionMark eq false and Posted eq true and Date ge datetime'{begin:s}' and Date lt datetime'{end:s}'";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = "Document_ЗаказНаПеремещение" +
                          "?$select=Ref_Key,Number,Date,Организация_Key,ОрганизацияПолучатель_Key,Подразделение_Key,СкладОтправитель_Key,СкладПолучатель_Key,Статус,ХозяйственнаяОперация,ДокументОснование,ДокументОснование_Type,Товары" +
                         $"&$filter=DeletionMark eq false and Posted eq true and Date ge datetime'{begin:s}' and Date lt datetime'{end:s}'" +
                          "&$format=json" +
                          "&$inlinecount=allpages";
            return uri;
        }
    }
}
