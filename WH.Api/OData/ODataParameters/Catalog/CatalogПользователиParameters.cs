
namespace WH.Api.OData.ODataParameters.Catalog
{
    public interface ICatalogПользователиParameters : IODataParameters
    { }

    public class CatalogПользователиParameters : ICatalogПользователиParameters
    {
        public int? Top => 1000;

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = "Catalog_Пользователи/$count";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = "Catalog_Пользователи" +
                         $"?$skip={Top * iteration}" +
                         $"&$top={Top}" +
                          "&$select=Ref_Key,DeletionMark,Description,Подразделение_Key" +
                          "&$orderby=Ref_Key" +
                          "&$format=json" +
                          "&$inlinecount=allpages";
            return uri;
        }
    }
}
