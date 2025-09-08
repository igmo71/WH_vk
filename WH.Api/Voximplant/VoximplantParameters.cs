namespace WH.Api.Voximplant
{
    public interface IVoximplantParameters
    {
        string GetUri(DateTime date, int skip);
    }

    public class VoximplantParameters : IVoximplantParameters
    {
        public string? CALL_START_DATE { get; set; }
        public string? CALL_END_DATE { get; set; }
        public int SKIP { get; set; }
        public int MIN_DURATION_SEC { get; set; } = 1;

        public string GetUri(DateTime date, int skip)
        {
            string uri = $"voximplant?CALL_START_DATE={date}&CALL_END_DATE={date.AddDays(1)}&SKIP={skip}&MIN_DURATION_SEC=1";
            return uri;
        }
    }
}
