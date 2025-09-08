
namespace WH.Api.OData.ODataParameters.Wms
{
    public interface ICatalogЯчейкиParameters : IODataParameters
    { }

    public class CatalogЯчейкиParameters : ICatalogЯчейкиParameters
    {
        public int? Top => 1000;

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = "Catalog_Ячейки/$count";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = "Catalog_Ячейки" +
                         $"?$skip={Top * iteration}" +
                         $"&$top={Top}" +
                          //"&$select=Ref_Key,DeletionMark,Parent_Key,IsFolder,Description,Производитель_Key" +
                          "&$orderby=Ref_Key" +
                          "&$format=json" +
                          "&$inlinecount=allpages";
            return uri;
        }
    }
}
