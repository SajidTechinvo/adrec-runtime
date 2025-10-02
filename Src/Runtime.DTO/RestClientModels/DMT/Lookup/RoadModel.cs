using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.Lookup
{
    public class RoadResponse
    {
        [JsonPropertyName("municipalityId")]
        public int MunicipalityId { get; set; }

        [JsonPropertyName("roadId")]
        public int RoadId { get; set; }

        [JsonPropertyName("roadNameA")]
        public string RoadNameA { get; set; }

        [JsonPropertyName("roadNameE")]
        public string RoadNameE { get; set; }

        [JsonPropertyName("roadNumber")]
        public string RoadNumber { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }
}