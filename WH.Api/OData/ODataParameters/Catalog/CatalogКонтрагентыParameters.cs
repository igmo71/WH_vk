namespace WH.Api.OData.ODataParameters.Catalog
{
    public interface ICatalogКонтрагентыParameters : IODataParameters
    { }

    public class CatalogКонтрагентыParameters : ICatalogКонтрагентыParameters
    {
        public int? Top => 5000;

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = "Catalog_Контрагенты/$count";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = "Catalog_Контрагенты" +
                         $"?$skip={Top * iteration}" +
                         $"&$top={Top}" +
                          "&$select=Ref_Key,Description,DeletionMark,ГоловнойКонтрагент_Key,Партнер_Key,ИНН" +
                          "&$orderby=Ref_Key" +
                          "&$format=json" +
                          "&$inlinecount=allpages";
            return uri;
        }
    }
}
