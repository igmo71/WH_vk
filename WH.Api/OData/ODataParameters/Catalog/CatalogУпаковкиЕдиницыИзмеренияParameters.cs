
namespace WH.Api.OData.ODataParameters.Catalog
{
    public interface ICatalogУпаковкиЕдиницыИзмеренияParameters : IODataParameters
    { }

    public class CatalogУпаковкиЕдиницыИзмеренияParameters : ICatalogУпаковкиЕдиницыИзмеренияParameters
    {
        public int? Top => 10000;

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = "Catalog_УпаковкиЕдиницыИзмерения/$count";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = "Catalog_УпаковкиЕдиницыИзмерения" +
                         $"?$skip={Top * iteration}" +
                         $"&$top={Top}" +
                          "&$select=Ref_Key,DeletionMark,Owner,Owner_Type,Parent_Key,Description,Вес,ВесЕдиницаИзмерения_Key,ЕдиницаИзмерения_Key,Числитель,Знаменатель,КоличествоУпаковок,ТипУпаковки,Безразмерная" +
                          "&$orderby=Ref_Key" +
                          "&$format=json" +
                          "&$inlinecount=allpages";
            return uri;
        }
    }
}
