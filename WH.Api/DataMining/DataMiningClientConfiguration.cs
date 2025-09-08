namespace WH.Api.DataMining
{
    public class DataMiningClientConfiguration
    {
        public const string Section = "DataMining";

        public required string BaseAddress { get; set; }
        public required string Uri { get; set; }
        public string[]? Structures { get; set; }
    }
}
