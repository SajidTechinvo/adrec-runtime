using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.ElmsDecree
{
    public class DecreeResponse
    {
        [JsonPropertyName("comments")]
        public string Comments { get; set; }

        [JsonPropertyName("decreeDate")]
        public DateTime DecreeDate { get; set; }

        [JsonPropertyName("decreeId")]
        public int DecreeId { get; set; }

        [JsonPropertyName("decreeNumber")]
        public string DecreeNumber { get; set; }

        [JsonPropertyName("decreePaperDocumentId")]
        public object DecreePaperDocumentId { get; set; }

        [JsonPropertyName("decreeSourceId")]
        public int DecreeSourceId { get; set; }

        [JsonPropertyName("documentId")]
        public object DocumentId { get; set; }

        [JsonPropertyName("migNote")]
        public double? MigNote { get; set; }

        [JsonPropertyName("migNoteL")]
        public string MigNoteL { get; set; }

        [JsonPropertyName("migNoteLm")]
        public string MigNoteLm { get; set; }

        [JsonPropertyName("otherSourceName")]
        public string OtherSourceName { get; set; }

        [JsonPropertyName("referenceNumber")]
        public string ReferenceNumber { get; set; }

        [JsonPropertyName("tableName")]
        public string TableName { get; set; }

        [JsonPropertyName("elmsAuthoritySourceType")]
        public ElmsAuthoritySourceType ElmsAuthoritySourceType { get; set; }

        [JsonPropertyName("authoritySource")]
        public DecreeAuthoritySourceResponse AuthoritySource { get; set; }

        [JsonPropertyName("decreeDateFormat")]
        public string DecreeDateFormat { get; set; }

        [JsonPropertyName("decreeSourceNameA")]
        public string DecreeSourceNameA { get; set; }

        [JsonPropertyName("decreeSourceNameE")]
        public string DecreeSourceNameE { get; set; }

        [JsonPropertyName("decreeSourceTypeId")]
        public int DecreeSourceTypeId { get; set; }

        [JsonPropertyName("decreeSourceTypeNameA")]
        public string DecreeSourceTypeNameA { get; set; }

        [JsonPropertyName("decreeSourceTypeNameE")]
        public string DecreeSourceTypeNameE { get; set; }

        [JsonPropertyName("otherSourceName_Visible")]
        public bool OtherSourceNameVisible { get; set; }

        [JsonPropertyName("isNew")]
        public bool IsNew { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }
}