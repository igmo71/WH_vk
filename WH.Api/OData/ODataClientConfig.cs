namespace WH.Api.OData
{
    public class ODataClientConfig
    {
        public const string Section = "ODataClient";

        public required string BaseAddress { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
    }
}

