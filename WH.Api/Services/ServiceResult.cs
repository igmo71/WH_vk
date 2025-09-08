namespace WH.Api.Services
{
    public class ServiceResult
    {
        public ServiceResult()
        {
            Values = new Dictionary<string, object>();
        }

        public Dictionary<string, object> Values { get; set; }
    }
}
