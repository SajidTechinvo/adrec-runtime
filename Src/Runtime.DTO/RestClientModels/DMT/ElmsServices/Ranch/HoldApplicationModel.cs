using System.Text.Json.Serialization;

namespace ADREC.DTO.RestClientModels.DMT.ElmsServices.Ranch
{
    public class HoldApplicationResponse
    {
        [JsonPropertyName("result")]
        public object Result { get; set; }

        [JsonPropertyName("targetUrl")]
        public object TargetUrl { get; set; }

        [JsonPropertyName("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonPropertyName("__app")]
        public bool App { get; set; }

        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("error")]
        public object Error { get; set; }
    }
}