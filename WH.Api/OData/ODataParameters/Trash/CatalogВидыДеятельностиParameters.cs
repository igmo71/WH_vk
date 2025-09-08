namespace WH.Api.OData.ODataParameters.Trash
{
    public interface ICatalogВидыДеятельностиParameters : IODataParameters
    { }

    public class CatalogВидыДеятельностиParameters : ICatalogВидыДеятельностиParameters
    {
        public int? Top => 1000;

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = "Catalog_Доброга_ВидыДеятельности/$count";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = "Catalog_Доброга_ВидыДеятельности" +
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
