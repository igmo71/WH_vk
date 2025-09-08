
namespace WH.Api.OData.ODataParameters.Document
{
    public interface IDocumentСборкаТоваровParameters : IODataParameters
    { }

    public class DocumentСборкаТоваровParameters : IDocumentСборкаТоваровParameters
    {
        public int? Top => throw new NotImplementedException();

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = "Document_СборкаТоваров/$count" +
                         $"?$filter=DeletionMark eq false and Posted eq true and Date ge datetime'{begin:s}' and Date lt datetime'{end:s}'";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = "Document_СборкаТоваров" +
                          "?$select=Ref_Key,Number,Date,ЗаказНаСборку_Key,Количество,КоличествоУпаковок,Номенклатура_Key,Ответственный_Key,Упаковка_Key,Склад_Key,Подразделение_Key,Статус,СборкаПодДеятельность,ХозяйственнаяОперация,ВариантПриемкиТоваров,ВариантКомплектации_Key,НоменклатураОсновногоКомпонента_Key,Товары" +
                         $"&$filter=DeletionMark eq false and Posted eq true and Date ge datetime'{begin:s}' and Date lt datetime'{end:s}'" +
                          "&$format=json" +
                          "&$inlinecount=allpages";
            return uri;
        }
    }
}
