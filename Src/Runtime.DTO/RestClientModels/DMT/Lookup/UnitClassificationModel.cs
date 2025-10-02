using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.Lookup
{
    public class UnitClassificationResponse
    {
        [JsonPropertyName("businessFlags")]
        public int? BusinessFlags { get; set; }

        [JsonPropertyName("nameA")]
        public string NameA { get; set; }

        [JsonPropertyName("nameE")]
        public string NameE { get; set; }

        [JsonPropertyName("tawPropertyCode")]
        public string TawPropertyCode { get; set; }

        [JsonPropertyName("tawUnitCode")]
        public string TawUnitCode { get; set; }

        [JsonPropertyName("unifiedUnitClassNameA")]
        public string UnifiedUnitClassNameA { get; set; }

        [JsonPropertyName("unifiedUnitClassNameE")]
        public string UnifiedUnitClassNameE { get; set; }

        [JsonPropertyName("unitClassificationId")]
        public int UnitClassificationId { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }
}