
namespace WH.Api.OData.ODataParameters.Catalog
{
    public interface ICatalogСоглашенияСКлиентамиParameters : IODataParameters
    { }

    public class CatalogСоглашенияСКлиентамиParameters : ICatalogСоглашенияСКлиентамиParameters
    {
        public int? Top => 5000;

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = "Catalog_СоглашенияСКлиентами/$count";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = "Catalog_СоглашенияСКлиентами" +
                         $"?$skip={Top * iteration}" +
                         $"&$top={Top}" +
                          "&$select=Ref_Key,DeletionMark,Description,Номер,Партнер_Key,Соглашение_Key,Статус" +
                          "&$orderby=Ref_Key" +
                          "&$format=json" +
                          "&$inlinecount=allpages";
            return uri;
        }
    }
}
