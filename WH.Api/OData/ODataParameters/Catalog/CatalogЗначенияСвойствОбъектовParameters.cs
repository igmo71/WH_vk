
namespace WH.Api.OData.ODataParameters.Catalog
{
    public interface ICatalogЗначенияСвойствОбъектовParameters : IODataParameters
    { }

    public class CatalogЗначенияСвойствОбъектовParameters : ICatalogЗначенияСвойствОбъектовParameters
    {
        public int? Top => 5000;

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = "Catalog_ЗначенияСвойствОбъектов/$count";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = "Catalog_ЗначенияСвойствОбъектов" +
                         $"?$skip={Top * iteration}" +
                         $"&$top={Top}" +
                          "&$select=Ref_Key,DeletionMark,Owner_Key,Parent_Key,IsFolder,Description" +
                          "&$orderby=Ref_Key" +
                          "&$format=json" +
                          "&$inlinecount=allpages";
            return uri;
        }
    }
}
