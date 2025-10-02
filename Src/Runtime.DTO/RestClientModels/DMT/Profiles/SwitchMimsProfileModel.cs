using Runtime.DTO.RestClientModels.Common;
using System.Net;
using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.Profiles
{
    public class SwitchMimsProfileResponse
    {
        public DmtResponseWrapper<SwitchMimsProfileModel> Response { get; set; }
        public List<Cookie> Cookies { get; set; }
    }

    public class SwitchMimsProfileModel
    {
        [JsonPropertyName("displayNameA")]
        public string DisplayNameA { get; set; }

        [JsonPropertyName("displayNameE")]
        public string DisplayNameE { get; set; }

        [JsonPropertyName("applicationInboxNameA")]
        public string ApplicationInboxNameA { get; set; }

        [JsonPropertyName("applicationInboxNameE")]
        public string ApplicationInboxNameE { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }

        [JsonPropertyName("authCode")]
        public string AuthCode { get; set; }

        [JsonPropertyName("userId")]
        public int UserId { get; set; }

        [JsonPropertyName("customerId")]
        public int CustomerId { get; set; }
    }
}