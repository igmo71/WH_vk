namespace WH.Api.OData.ODataParameters.Trash
{
    public interface ICatalogИсточникиЗаявокParameters : IODataParameters
    { }

    public class CatalogИсточникиЗаявокParameters : ICatalogИсточникиЗаявокParameters
    {
        public int? Top => 100;

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = "Catalog_Доброга_ИсточникиЗаявок/$count";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = "Catalog_Доброга_ИсточникиЗаявок" +
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
