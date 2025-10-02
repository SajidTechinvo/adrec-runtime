using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.Lookup
{
    public class NationalityResponse
    {
        [JsonPropertyName("countryNameA")]
        public string CountryNameA { get; set; }

        [JsonPropertyName("countryNameE")]
        public string CountryNameE { get; set; }

        [JsonPropertyName("desriptionA")]
        public string DesriptionA { get; set; }

        [JsonPropertyName("desriptionE")]
        public string DesriptionE { get; set; }

        [JsonPropertyName("migNote")]
        public double? MigNote { get; set; }

        [JsonPropertyName("migNoteL")]
        public string MigNoteL { get; set; }

        [JsonPropertyName("migNoteLm")]
        public string MigNoteLm { get; set; }

        [JsonPropertyName("moiId")]
        public int? MoiId { get; set; }

        [JsonPropertyName("nationalityId")]
        public int NationalityId { get; set; }

        [JsonPropertyName("nationalityNameA")]
        public string NationalityNameA { get; set; }

        [JsonPropertyName("nationalityNameE")]
        public string NationalityNameE { get; set; }

        [JsonPropertyName("nationalityType")]
        public int NationalityType { get; set; }

        [JsonPropertyName("sortOrder")]
        public double SortOrder { get; set; }

        [JsonPropertyName("tawCode")]
        public int? TawCode { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}