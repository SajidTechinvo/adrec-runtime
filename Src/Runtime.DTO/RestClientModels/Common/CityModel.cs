using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.Common
{
    public class CityResponse
    {
        [JsonPropertyName("adsicId")]
        public int? AdsicId { get; set; }

        [JsonPropertyName("cityId")]
        public int CityId { get; set; }

        [JsonPropertyName("cityNameA")]
        public string CityNameA { get; set; }

        [JsonPropertyName("cityNameE")]
        public string CityNameE { get; set; }

        [JsonPropertyName("cityNumber")]
        public string CityNumber { get; set; }

        [JsonPropertyName("emirateId")]
        public int? EmirateId { get; set; }

        [JsonPropertyName("isRemoteArea")]
        public int? IsRemoteArea { get; set; }

        [JsonPropertyName("migNote")]
        public double? MigNote { get; set; }

        [JsonPropertyName("migNoteL")]
        public string MigNoteL { get; set; }

        [JsonPropertyName("migNoteLm")]
        public string MigNoteLm { get; set; }

        [JsonPropertyName("municipalityId")]
        public int? MunicipalityId { get; set; }

        [JsonPropertyName("referenceNo")]
        public int? ReferenceNo { get; set; }

        [JsonPropertyName("sortOrder")]
        public double? SortOrder { get; set; }

        [JsonPropertyName("tawCode")]
        public object TawCode { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}