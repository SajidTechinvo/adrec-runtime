using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.Lookup
{
    public class DistrictResponse
    {
        [JsonPropertyName("businessFlags")]
        public object BusinessFlags { get; set; }

        [JsonPropertyName("districtId")]
        public int DistrictId { get; set; }

        [JsonPropertyName("districtNameA")]
        public string DistrictNameA { get; set; }

        [JsonPropertyName("districtNameE")]
        public string DistrictNameE { get; set; }

        [JsonPropertyName("districtNumber")]
        public string DistrictNumber { get; set; }

        [JsonPropertyName("migNote")]
        public double? MigNote { get; set; }

        [JsonPropertyName("municipalityId")]
        public int MunicipalityId { get; set; }

        [JsonPropertyName("zoneId")]
        public double? ZoneId { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}