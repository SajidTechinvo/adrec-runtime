using System.Text.Json.Serialization;

namespace ADREC.DTO.RestClientModels.DMT.Lookup
{
    public class InsuranceCompanyResponse
    {
        [JsonPropertyName("adpCode")]
        public string AdpCode { get; set; }

        [JsonPropertyName("lookupDetailCode")]
        public string LookupDetailCode { get; set; }

        [JsonPropertyName("lookupDetailConst")]
        public string LookupDetailConst { get; set; }

        [JsonPropertyName("lookupDetailId")]
        public int LookupDetailId { get; set; }

        [JsonPropertyName("lookupDetailIndex")]
        public int LookupDetailIndex { get; set; }

        [JsonPropertyName("lookupDetailNameA")]
        public string LookupDetailNameA { get; set; }

        [JsonPropertyName("lookupDetailNameE")]
        public string LookupDetailNameE { get; set; }

        [JsonPropertyName("lookupDetailOrder")]
        public int LookupDetailOrder { get; set; }

        [JsonPropertyName("lookupMasterId")]
        public int LookupMasterId { get; set; }

        [JsonPropertyName("municipalityId")]
        public object MunicipalityId { get; set; }

        [JsonPropertyName("parentLookupDetailId")]
        public object ParentLookupDetailId { get; set; }

        [JsonPropertyName("tawCode")]
        public object TawCode { get; set; }

        [JsonPropertyName("sourceConst")]
        public object SourceConst { get; set; }

        [JsonPropertyName("sourceA")]
        public object SourceA { get; set; }

        [JsonPropertyName("sourceE")]
        public object SourceE { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }
}