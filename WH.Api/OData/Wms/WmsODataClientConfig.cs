namespace WH.Api.OData.Wms
{
    public class WmsODataClientConfig
    {
        public const string Section = "WmsODataClient";

        public required string BaseAddress { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
    }
}
