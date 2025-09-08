using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WH.Domain.Models.Call
{
    public class Voximplant
    {
        [JsonPropertyName("total")] public int Total { get; set; }
        [JsonPropertyName("time")] public Time? Time { get; set; }
        [JsonPropertyName("items")] public CallItem[]? CallItems { get; set; }
    }

    public class Time
    {
        [JsonPropertyName("start")] public double Start { get; set; }
        [JsonPropertyName("finish")] public double Finish { get; set; }
        [JsonPropertyName("duration")] public double Duration { get; set; }
        [JsonPropertyName("processing")] public double Processing { get; set; }
        [JsonPropertyName("date_start")] public DateTime DateStart { get; set; }
        [JsonPropertyName("date_finish")] public DateTime DateFinish { get; set; }
    }

    public class CallItem
    {
        [MaxLength(AppSettings.GUID)] public Guid Id { get; set; }

        [JsonPropertyName("LOGIN")][MaxLength(AppSettings.GUID)] public string? Login { get; set; }

        [JsonPropertyName("CALL_START_DATE")][MaxLength(AppSettings.GUID)] public DateTime CallStartDate { get; set; }

        [JsonPropertyName("PORTAL_USER_ID")][MaxLength(AppSettings.GUID)] public int PortalUserId { get; set; }

        [JsonPropertyName("CALL_DURATION")][MaxLength(AppSettings.GUID)] public int CallDuration { get; set; }

        [JsonPropertyName("CALL_TYPE")][MaxLength(AppSettings.GUID)] public string? CallType { get; set; }
    }
}
