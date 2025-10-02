using Runtime.DTO.RestClientModels.DMT.ElmsServices.Common;
using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.Common
{
    public class BusinessEntityResponse
    {
        [JsonPropertyName("wfiBusinessEntityId")]
        public int WfiBusinessEntityId { get; set; }

        [JsonPropertyName("wfiBusinessEntityReferenceId")]
        public int WfiBusinessEntityReferenceId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("wfiDocumentList")]
        public List<WfiDocumentList> WfiDocumentList { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}