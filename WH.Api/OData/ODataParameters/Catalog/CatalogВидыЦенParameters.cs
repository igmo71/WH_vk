
namespace WH.Api.OData.ODataParameters.Catalog
{
    public interface ICatalogВидыЦенParameters : IODataParameters
    { }

    public class CatalogВидыЦенParameters : ICatalogВидыЦенParameters
    {
        public int? Top => 100;

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = "Catalog_ВидыЦен/$count";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = "Catalog_ВидыЦен" +
                         $"?$skip={Top * iteration}" +
                         $"&$top={Top}" +
                          //"&$select=Ref_Key,DeletionMark,Parent_Key,IsFolder,Description,БазовыйВидЦены_Key,Наценка,СпособЗаданияЦены,Формула,ПорогСрабатывания,Округлять,ВариантОкругления,ТочностьОкругления,ОкруглятьВБольшуюСторону,ЦенаВключаетНДС,Статус,РеквизитДопУпорядочивания,УстанавливатьЦенуПриВводеНаОсновании,ИспользоватьПриПродаже,ИспользоватьПриПередачеМеждуОрганизациями,ИспользоватьПриВыпускеПродукции,ИспользоватьПриПередачеПродукцииДавальцу" +
                          "&$orderby=Ref_Key" +
                          "&$format=json" +
                          "&$inlinecount=allpages";
            return uri;
        }
    }
}
