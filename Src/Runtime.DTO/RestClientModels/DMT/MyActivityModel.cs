using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT
{
    public class MyActivityResponse
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("titleAr")]
        public string TitleAr { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("statusAr")]
        public string StatusAr { get; set; }

        [JsonPropertyName("reference")]
        public string Reference { get; set; }

        [JsonPropertyName("daysRemaining")]
        public int DaysRemaining { get; set; }

        [JsonPropertyName("progress")]
        public List<int> Progress { get; set; }

        [JsonPropertyName("action")]
        public string Action { get; set; }

        [JsonPropertyName("actionAr")]
        public string ActionAr { get; set; }
    }
}