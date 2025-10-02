using System.Text.Json.Serialization;

namespace ADREC.DTO.RestClientModels.DMT.Documents
{
    public class UploadRequest
    {
        [JsonPropertyName("wfiDocumentAttachmentId")]
        public int WfiDocumentAttachmentId { get; set; }

        [JsonPropertyName("wfiDocumentId")]
        public int WfiDocumentId { get; set; }

        [JsonPropertyName("documentId")]
        public int DocumentId { get; set; }

        [JsonPropertyName("attachmentTitle")]
        public string AttachmentTitle { get; set; }

        [JsonPropertyName("attachmentDate")]
        public DateTime AttachmentDate { get; set; }

        [JsonPropertyName("uploadByCustomerNameA")]
        public string UploadByCustomerNameA { get; set; }

        [JsonPropertyName("uploadByCustomerNameE")]
        public string UploadByCustomerNameE { get; set; }

        [JsonPropertyName("downloadUrl")]
        public string DownloadUrl { get; set; }

        [JsonPropertyName("deleteUrl")]
        public string DeleteUrl { get; set; }

        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }

        [JsonPropertyName("isStampNeeded")]
        public bool IsStampNeeded { get; set; }

        [JsonPropertyName("workflowStatusId")]
        public object WorkflowStatusId { get; set; }

        [JsonPropertyName("locationAddressId")]
        public object LocationAddressId { get; set; }

        [JsonPropertyName("insInstanceId")]
        public int InsInstanceId { get; set; }

        [JsonPropertyName("insInstanceCheckItemId")]
        public int InsInstanceCheckItemId { get; set; }

        [JsonPropertyName("documentReferenceNumber")]
        public string DocumentReferenceNumber { get; set; }

        [JsonPropertyName("documentIssueDate")]
        public object DocumentIssueDate { get; set; }

        [JsonPropertyName("documentExpireDate")]
        public object DocumentExpireDate { get; set; }

        [JsonPropertyName("contractStatusA")]
        public object ContractStatusA { get; set; }

        [JsonPropertyName("contractStatusE")]
        public object ContractStatusE { get; set; }

        [JsonPropertyName("fileSize")]
        public int FileSize { get; set; }

        [JsonPropertyName("locationCoordinate")]
        public object LocationCoordinate { get; set; }

        [JsonPropertyName("filePath")]
        public object FilePath { get; set; }

        [JsonPropertyName("documentConst")]
        public object DocumentConst { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}