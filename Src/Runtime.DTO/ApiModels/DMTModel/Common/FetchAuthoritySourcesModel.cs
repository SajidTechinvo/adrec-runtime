using System.Text.Json.Serialization;

namespace ADREC.DTO.ApiModels.DMTModel.Common
{
    public class FetchAuthoritySourcesByAuthoritySourceTypeIdRequest
    {
        [JsonPropertyName("requestId")]
        public int RequestId { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}