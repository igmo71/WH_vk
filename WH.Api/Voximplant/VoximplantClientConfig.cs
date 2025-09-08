namespace WH.Api.Voximplant
{
    public class VoximplantClientConfig
    {
        public const string Section = "VoximplantClient";

        public required string BaseAddress { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
    }
}
