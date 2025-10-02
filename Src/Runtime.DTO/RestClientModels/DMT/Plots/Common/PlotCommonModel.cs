using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.Plots.Common
{
    public class ElmsOwnerDocumentResponse
    {
        [JsonPropertyName("applicationInstanceId")]
        public int? ApplicationInstanceId { get; set; }

        [JsonPropertyName("approveByUserId")]
        public int? ApproveByUserId { get; set; }

        [JsonPropertyName("approveDate")]
        public DateTime? ApproveDate { get; set; }

        [JsonPropertyName("documentExpireDate")]
        public DateTime? DocumentExpireDate { get; set; }

        [JsonPropertyName("documentId")]
        public int DocumentId { get; set; }

        [JsonPropertyName("documentIssueDate")]
        public DateTime? DocumentIssueDate { get; set; }

        [JsonPropertyName("documentReferenceNumber")]
        public string DocumentReferenceNumber { get; set; }

        [JsonPropertyName("migNote")]
        public object MigNote { get; set; }

        [JsonPropertyName("migNoteL")]
        public string MigNoteL { get; set; }

        [JsonPropertyName("migNoteLm")]
        public string MigNoteLm { get; set; }

        [JsonPropertyName("ownerDocumentId")]
        public int OwnerDocumentId { get; set; }

        [JsonPropertyName("ownerDocumenTtitle")]
        public string OwnerDocumenTtitle { get; set; }

        [JsonPropertyName("ownerId")]
        public int OwnerId { get; set; }

        [JsonPropertyName("documentTypeId")]
        public int DocumentTypeId { get; set; }

        [JsonPropertyName("elmsDocumentTypeConst")]
        public string ElmsDocumentTypeConst { get; set; }

        [JsonPropertyName("documentTypeNameA")]
        public string DocumentTypeNameA { get; set; }

        [JsonPropertyName("documentTypeNameE")]
        public string DocumentTypeNameE { get; set; }

        [JsonPropertyName("uploadDate")]
        public DateTime UploadDate { get; set; }

        [JsonPropertyName("isUploaded")]
        public bool IsUploaded { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}