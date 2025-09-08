
namespace WH.Api.OData.ODataParameters.Catalog
{
    public interface ICatalogПартнерыVipParameters : IODataParameters
    {
        public string СегментVip { get; }
    }

    public class CatalogПартнерыVipParameters : ICatalogПартнерыVipParameters
    {
        public int? Top => 5000;

        public string СегментVip => "566f3b70-5cf9-11ee-bab6-00155d01d106";

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = $"InformationRegister_ПартнерыСегмента/$count?$format=json&$filter=Сегмент_Key eq guid'{СегментVip}'&$select=Партнер_Key";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = $"InformationRegister_ПартнерыСегмента?$format=json&$filter=Сегмент_Key eq guid'{СегментVip}'&$select=Партнер_Key";
            return uri;
        }
    }
}
