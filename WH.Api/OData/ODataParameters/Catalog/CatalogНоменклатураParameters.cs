
namespace WH.Api.OData.ODataParameters.Catalog
{
    public interface ICatalogНоменклатураParameters : IODataParameters
    {
        string ПодвидНоменклатуры_Key { get; }
        string БазоваяНоменклатура_Key { get; }
        string ТипУпаковки_Key { get; }
    }

    public class CatalogНоменклатураParameters : ICatalogНоменклатураParameters
    {
        public int? Top => 5000;
        public string ПодвидНоменклатуры_Key => "59b20642-88d8-11f0-ba8a-00155d013e14";
        public string БазоваяНоменклатура_Key => "be45e4c2-6719-11ec-baa9-00155d01d102";
        public string ТипУпаковки_Key => "1bbce310-8af6-11eb-ba9f-00155d01d106";

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = "Catalog_Номенклатура/$count";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = "Catalog_Номенклатура" +
                         $"?$skip={Top * iteration}" +
                         $"&$top={Top}" +
                          "&$select=Ref_Key,DeletionMark,Parent_Key,IsFolder,Code,Артикул,Description,ВидНоменклатуры_Key,ТипНоменклатуры,Производитель_Key,Марка_Key,ЦеноваяГруппа_Key,ВесЧислитель,ВесЗнаменатель,ДополнительныеРеквизиты/Свойство_Key,ДополнительныеРеквизиты/Значение" +
                          "&$orderby=Ref_Key" +
                          "&$format=json" +
                          "&$inlinecount=allpages";
            return uri;
        }
    }
}
