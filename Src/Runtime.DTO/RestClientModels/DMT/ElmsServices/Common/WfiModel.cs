using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.ElmsServices.Common
{
    public class WfiStepListResponse
    {
        [JsonPropertyName("wfiStepId")]
        public int WfiStepId { get; set; }

        [JsonPropertyName("parentWfiStepId")]
        public object ParentWfiStepId { get; set; }

        [JsonPropertyName("previousWfiStepId")]
        public object PreviousWfiStepId { get; set; }

        [JsonPropertyName("stepConst")]
        public string StepConst { get; set; }

        [JsonPropertyName("actionConst")]
        public object ActionConst { get; set; }

        [JsonPropertyName("assignedToUserId")]
        public int? AssignedToUserId { get; set; }

        [JsonPropertyName("assignedToCustomerNameA")]
        public string AssignedToCustomerNameA { get; set; }

        [JsonPropertyName("assignedToCustomerNameE")]
        public string AssignedToCustomerNameE { get; set; }

        [JsonPropertyName("assignedToInboxId")]
        public int AssignedToInboxId { get; set; }

        [JsonPropertyName("assignedToInboxNameA")]
        public string AssignedToInboxNameA { get; set; }

        [JsonPropertyName("assignedToInboxNameE")]
        public string AssignedToInboxNameE { get; set; }

        [JsonPropertyName("completedByUserId")]
        public object CompletedByUserId { get; set; }

        [JsonPropertyName("completedByCustomerNameA")]
        public object CompletedByCustomerNameA { get; set; }

        [JsonPropertyName("completedByCustomerNameE")]
        public object CompletedByCustomerNameE { get; set; }

        [JsonPropertyName("startDate")]
        public DateTime StartDate { get; set; }

        [JsonPropertyName("completeDate")]
        public object CompleteDate { get; set; }

        [JsonPropertyName("comments")]
        public string Comments { get; set; }

        [JsonPropertyName("backOfficeResponse")]
        public string BackOfficeResponse { get; set; }

        [JsonPropertyName("isCurrent")]
        public bool IsCurrent { get; set; }

        [JsonPropertyName("isBackOffice")]
        public bool IsBackOffice { get; set; }

        [JsonPropertyName("isEnd")]
        public bool IsEnd { get; set; }

        [JsonPropertyName("businessStatus")]
        public object BusinessStatus { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }

    public class WfiDocumentAttachmentResponse
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
        public int? WorkflowStatusId { get; set; }

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
        public string LocationCoordinate { get; set; }

        [JsonPropertyName("filePath")]
        public object FilePath { get; set; }

        [JsonPropertyName("documentConst")]
        public object DocumentConst { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }

    public class WfiDocumentList
    {
        [JsonPropertyName("isOutput")]
        public bool IsOutput { get; set; }

        [JsonPropertyName("isInput")]
        public bool IsInput { get; set; }

        [JsonPropertyName("isSigned")]
        public bool IsSigned { get; set; }

        [JsonPropertyName("isHidden")]
        public bool IsHidden { get; set; }

        [JsonPropertyName("allowMultiAttachment")]
        public bool AllowMultiAttachment { get; set; }

        [JsonPropertyName("wfiDocumentId")]
        public int WfiDocumentId { get; set; }

        [JsonPropertyName("documentTypeId")]
        public int DocumentTypeId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("isRequired")]
        public bool IsRequired { get; set; }

        [JsonPropertyName("uploadUrl")]
        public string UploadUrl { get; set; }

        [JsonPropertyName("validExtensions")]
        public string ValidExtensions { get; set; }

        [JsonPropertyName("workflowDocumentGroup")]
        public string WorkflowDocumentGroup { get; set; }

        [JsonPropertyName("isRequiredLabel")]
        public string IsRequiredLabel { get; set; }

        [JsonPropertyName("showBlockDocumentOption")]
        public bool ShowBlockDocumentOption { get; set; }

        [JsonPropertyName("isDocumentBlocked")]
        public bool IsDocumentBlocked { get; set; }

        [JsonPropertyName("tooltipA")]
        public string TooltipA { get; set; }

        [JsonPropertyName("tooltipE")]
        public string TooltipE { get; set; }

        [JsonPropertyName("wfiBusinessEntityId")]
        public int WfiBusinessEntityId { get; set; }

        [JsonPropertyName("wfiDocumentAttachmentList")]
        public List<WfiDocumentAttachmentResponse> WfiDocumentAttachmentList { get; set; }

        [JsonPropertyName("documentTypeNameA")]
        public string DocumentTypeNameA { get; set; }

        [JsonPropertyName("documentTypeNameE")]
        public string DocumentTypeNameE { get; set; }

        [JsonPropertyName("nonComplyNotes")]
        public object NonComplyNotes { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}