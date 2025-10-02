using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.Lookup
{
    public class FetchCommentTypeResponse
    {
        [JsonPropertyName("commentTypeId")]
        public int CommentTypeId { get; set; }

        [JsonPropertyName("nameA")]
        public string NameA { get; set; }

        [JsonPropertyName("nameE")]
        public string NameE { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}