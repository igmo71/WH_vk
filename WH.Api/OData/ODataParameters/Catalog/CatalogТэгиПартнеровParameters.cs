
namespace WH.Api.OData.ODataParameters.Catalog
{
    public interface ICatalogТэгиПартнеровParameters : IODataParameters
    { }

    public class CatalogТэгиПартнеровParameters : ICatalogТэгиПартнеровParameters
    {
        public int? Top => 1000;

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = "Catalog_ТП_ТэгиПартнеров/$count";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = "Catalog_ТП_ТэгиПартнеров" +
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
