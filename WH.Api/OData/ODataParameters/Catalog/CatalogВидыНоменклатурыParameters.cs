
namespace WH.Api.OData.ODataParameters.Catalog
{
    public interface ICatalogВидыНоменклатурыParameters : IODataParameters
    { }

    public class CatalogВидыНоменклатурыParameters : ICatalogВидыНоменклатурыParameters
    {
        public int? Top => 1000;

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = "Catalog_ВидыНоменклатуры/$count";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = "Catalog_ВидыНоменклатуры" +
                         $"?$skip={Top * iteration}" +
                         $"&$top={Top}" +
                          "&$select=Ref_Key,DeletionMark,Parent_Key,IsFolder,Description" +
                          "&$orderby=Ref_Key" +
                          "&$format=json" +
                          "&$inlinecount=allpages";
            return uri;
        }
    }
}
