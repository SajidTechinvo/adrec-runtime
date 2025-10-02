using System.Text.Json.Serialization;

namespace ADREC.DTO.RestClientModels.DMT.Lookup
{
    public class FetchAuthoritySourceTypeResponse
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
        public object UrlArgs { get; set; }
    }
}