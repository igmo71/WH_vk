
namespace WH.Api.OData.ODataParameters.Catalog
{
    public interface ICatalogГруппыПользователейParameters : IODataParameters
    { }

    public class CatalogГруппыПользователейParameters : ICatalogГруппыПользователейParameters
    {
        public int? Top => 5000;

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = "Catalog_ГруппыПользователей/$count";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = "Catalog_ГруппыПользователей" +
                         $"?$skip={Top * iteration}" +
                         $"&$top={Top}" +
                          "&$select=Ref_Key,DeletionMark,Parent_Key,Description,Состав" +
                          "&$orderby=Ref_Key" +
                          "&$format=json" +
                          "&$inlinecount=allpages";
            return uri;
        }
    }
}
