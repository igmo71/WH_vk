
namespace WH.Api.OData.ODataParameters.Catalog
{
    public interface ICatalogПартнерыParameters : IODataParameters
    { }

    public class CatalogПартнерыParameters : ICatalogПартнерыParameters
    {
        public int? Top => 5000;

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = "Catalog_Партнеры/$count";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = "Catalog_Партнеры" +
                         $"?$skip={Top * iteration}" +
                         $"&$top={Top}" +
                          "&$select=Ref_Key,DeletionMark,Parent_Key,Description,БизнесРегион_Key,ОсновнойМенеджер_Key,ДатаРегистрации,ЮрФизЛицо,Клиент,Поставщик,Конкурент,ПрочиеОтношения,Перевозчик" +
                          "&$orderby=Ref_Key" +
                          "&$format=json" +
                          "&$inlinecount=allpages";
            return uri;
        }
    }
}
