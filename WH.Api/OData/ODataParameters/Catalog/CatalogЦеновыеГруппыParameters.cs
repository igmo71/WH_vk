
namespace WH.Api.OData.ODataParameters.Catalog
{
    public interface ICatalogЦеновыеГруппыParameters : IODataParameters
    { }

    public class CatalogЦеновыеГруппыParameters : ICatalogЦеновыеГруппыParameters
    {
        public int? Top => 5000;

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = "Catalog_ЦеновыеГруппы/$count";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = "Catalog_ЦеновыеГруппы" +
                          $"?$skip={Top * iteration}" +
                          $"&$top={Top}" +
                           "&$select=Ref_Key,DeletionMark,Description" +
                           "&$orderby=Ref_Key" +
                           "&$format=json" +
                           "&$inlinecount=allpages";
            return uri;
        }
    }
}
