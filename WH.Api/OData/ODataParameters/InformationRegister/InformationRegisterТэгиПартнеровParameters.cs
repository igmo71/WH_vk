
namespace WH.Api.OData.ODataParameters.InformationRegister
{
    public interface IInformationRegisterТэгиПартнеровParameters : IODataParameters
    { }

    public class InformationRegisterТэгиПартнеровParameters : IInformationRegisterТэгиПартнеровParameters
    {
        public int? Top => 10000;

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = "InformationRegister_ТП_ТэгиПартнеров/$count";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = "InformationRegister_ТП_ТэгиПартнеров" +
                          "?$select=Партнер_Key,Тэг_Key" +
                          "&$orderby=Партнер_Key,Тэг_Key" +
                          "&$format=json" +
                          "&$inlinecount=allpages";
            return uri;
        }
    }
}
