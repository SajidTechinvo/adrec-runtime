using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.Lookup
{
    public class EmirateResponse
    {
        [JsonPropertyName("elmsId")]
        public int ElmsId { get; set; }

        [JsonPropertyName("emirateConst")]
        public string EmirateConst { get; set; }

        [JsonPropertyName("emirateId")]
        public int EmirateId { get; set; }

        [JsonPropertyName("emirateNameA")]
        public string EmirateNameA { get; set; }

        [JsonPropertyName("emirateNameE")]
        public string EmirateNameE { get; set; }

        [JsonPropertyName("moiId")]
        public int MoiId { get; set; }

        [JsonPropertyName("sortOrder")]
        public int SortOrder { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }
}