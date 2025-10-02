using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.ElmsDecree
{
    public class DecreeAuthoritySourceResponse
    {
        [JsonPropertyName("authorityClassifications")]
        public int AuthorityClassifications { get; set; }

        [JsonPropertyName("authorityNameId")]
        public int AuthorityNameId { get; set; }

        [JsonPropertyName("authorityNameNameA")]
        public string AuthorityNameNameA { get; set; }

        [JsonPropertyName("authorityNameNameE")]
        public string AuthorityNameNameE { get; set; }

        [JsonPropertyName("authorityOwnerId")]
        public int AuthorityOwnerId { get; set; }

        [JsonPropertyName("authoritySourceTypeId")]
        public int AuthoritySourceTypeId { get; set; }

        [JsonPropertyName("isAllotmentAuthority")]
        public int IsAllotmentAuthority { get; set; }

        [JsonPropertyName("mergeComments")]
        public string MergeComments { get; set; }

        [JsonPropertyName("migNote")]
        public double? MigNote { get; set; }

        [JsonPropertyName("migNoteL")]
        public string MigNoteL { get; set; }

        [JsonPropertyName("migNoteLm")]
        public string MigNoteLm { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }
}