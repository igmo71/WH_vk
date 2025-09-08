
namespace WH.Api.OData.ODataParameters.Catalog
{
    public interface ICatalogПодвидыНоменклатурыParameters : IODataParameters
    {
        string Owner_Key { get; }
    }

    public class CatalogПодвидыНоменклатурыParameters : ICatalogПодвидыНоменклатурыParameters
    {
        public int? Top => 1000;
        public string Owner_Key => "66ee3432-6206-11eb-ba9f-00155d01d106";

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = "Catalog_ЗначенияСвойствОбъектов/$count" +
                         $"?$filter=Owner_Key eq guid'{Owner_Key}'";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = "Catalog_ЗначенияСвойствОбъектов" +
                         $"?$skip={Top * iteration}" +
                         $"&$top={Top}" +
                          "&$select=Ref_Key,DeletionMark,Parent_Key,IsFolder,Description" +
                         $"&$filter=Owner_Key eq guid'{Owner_Key}'" +
                          "&$orderby=Ref_Key" +
                          "&$format=json" +
                          "&$inlinecount=allpages";
            return uri;
        }
    }
}
