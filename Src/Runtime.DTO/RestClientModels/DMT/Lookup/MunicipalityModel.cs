using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.Lookup
{
    public class MunicipalityResponse
    {
        [JsonPropertyName("adgeId")]
        public string AdgeId { get; set; }

        [JsonPropertyName("applicationFlags")]
        public object ApplicationFlags { get; set; }

        [JsonPropertyName("customerId")]
        public int CustomerId { get; set; }

        [JsonPropertyName("evaluatorTradeLicenseNumber")]
        public string EvaluatorTradeLicenseNumber { get; set; }

        [JsonPropertyName("genericGcsCodeId")]
        public string GenericGcsCodeId { get; set; }

        [JsonPropertyName("inboxId")]
        public int InboxId { get; set; }

        [JsonPropertyName("isDisableEmailNotification")]
        public bool IsDisableEmailNotification { get; set; }

        [JsonPropertyName("mailBoxTradeLicenseNumber")]
        public string MailBoxTradeLicenseNumber { get; set; }

        [JsonPropertyName("municipalityConst")]
        public string MunicipalityConst { get; set; }

        [JsonPropertyName("municipalityFlagIndex")]
        public int MunicipalityFlagIndex { get; set; }

        [JsonPropertyName("municipalityId")]
        public int MunicipalityId { get; set; }

        [JsonPropertyName("municipalityNameA")]
        public string MunicipalityNameA { get; set; }

        [JsonPropertyName("municipalityNameE")]
        public string MunicipalityNameE { get; set; }

        [JsonPropertyName("profLicenseDepEmail")]
        public string ProfLicenseDepEmail { get; set; }

        [JsonPropertyName("isAreaNeeded")]
        public bool IsAreaNeeded { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}