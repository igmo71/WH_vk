
namespace WH.Api.OData.ODataParameters.Catalog
{
    public interface ICatalogМаркиParameters : IODataParameters
    { }

    public class CatalogМаркиParameters : ICatalogМаркиParameters
    {
        public int? Top => 1000;

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = "Catalog_Марки/$count";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = "Catalog_Марки" +
                         $"?$skip={Top * iteration}" +
                         $"&$top={Top}" +
                          "&$select=Ref_Key,DeletionMark,Parent_Key,IsFolder,Description,Производитель_Key" +
                          "&$orderby=Ref_Key" +
                          "&$format=json" +
                          "&$inlinecount=allpages";
            return uri;
        }
    }
}
