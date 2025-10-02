using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.Profiles
{
    public class ProfileResponse
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("desigantion")]
        public string Desigantion { get; set; }

        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("on_time")]
        public int OnTime { get; set; }

        [JsonPropertyName("delays")]
        public int Delays { get; set; }

        [JsonPropertyName("one_time")]
        public int OneTime { get; set; }
    }
}