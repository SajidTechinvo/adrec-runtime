using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.ElmsServices.Common
{
    public class RightsHoldTypeResponse
    {
        [JsonPropertyName("elmsRightsHoldTypeConst")]
        public string ElmsRightsHoldTypeConst { get; set; }

        [JsonPropertyName("rightsHoldTypeId")]
        public int RightsHoldTypeId { get; set; }

        [JsonPropertyName("rightsHoldTypeNameA")]
        public string RightsHoldTypeNameA { get; set; }

        [JsonPropertyName("rightsHoldTypeNameE")]
        public string RightsHoldTypeNameE { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }
}