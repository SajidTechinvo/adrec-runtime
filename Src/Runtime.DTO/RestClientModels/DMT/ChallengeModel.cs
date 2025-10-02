using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT
{
    public class ChallengeResponse
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("type")]
        public int Type { get; set; }

        [JsonPropertyName("value")]
        public double Value { get; set; }

        [JsonPropertyName("badge")]
        public string Badge { get; set; }
    }
}