
namespace WH.Api.OData.ODataParameters.Catalog
{
    public interface ICatalogСтруктураПредприятияParameters : IODataParameters
    { }

    public class CatalogСтруктураПредприятияParameters : ICatalogСтруктураПредприятияParameters
    {
        public int? Top => 1000;

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = "Catalog_СтруктураПредприятия/$count";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = "Catalog_СтруктураПредприятия" +
                         $"?$skip={Top * iteration}" +
                         $"&$top={Top}" +
                          "&$select=Ref_Key,DeletionMark,Parent_Key,Code,Description" +
                          "&$orderby=Ref_Key" +
                          "&$format=json" +
                          "&$inlinecount=allpages";
            return uri;
        }
    }
}
