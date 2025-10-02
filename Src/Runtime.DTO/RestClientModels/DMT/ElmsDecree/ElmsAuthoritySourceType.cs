using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.ElmsDecree
{
    public class ElmsAuthoritySourceType
    {
        [JsonPropertyName("authoritySourceTypeId")]
        public int AuthoritySourceTypeId { get; set; }

        [JsonPropertyName("authoritySourceTypeNameA")]
        public string AuthoritySourceTypeNameA { get; set; }

        [JsonPropertyName("authoritySourceTypeNameE")]
        public string AuthoritySourceTypeNameE { get; set; }

        [JsonPropertyName("migNote")]
        public double MigNote { get; set; }

        [JsonPropertyName("migNoteL")]
        public string MigNoteL { get; set; }

        [JsonPropertyName("migNoteLm")]
        public string MigNoteLm { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }
}