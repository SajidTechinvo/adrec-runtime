using System.Text.Json.Serialization;

namespace ADREC.DTO.RestClientModels.DMT.Users
{
    public class InboxItem
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("workflowId")]
        public int WorkflowId { get; set; }

        [JsonPropertyName("workflowStepId")]
        public int WorkflowStepId { get; set; }

        [JsonPropertyName("hasEditPermission")]
        public bool HasEditPermission { get; set; }

        [JsonPropertyName("viewCode")]
        public object ViewCode { get; set; }

        [JsonPropertyName("applicationInboxConst")]
        public object ApplicationInboxConst { get; set; }

        [JsonPropertyName("workflowConst")]
        public string WorkflowConst { get; set; }

        [JsonPropertyName("workflowStepConst")]
        public string WorkflowStepConst { get; set; }

        [JsonPropertyName("workflowStatusConst")]
        public object WorkflowStatusConst { get; set; }

        [JsonPropertyName("applicationNumber")]
        public string ApplicationNumber { get; set; }

        [JsonPropertyName("referenceNumber")]
        public object ReferenceNumber { get; set; }

        [JsonPropertyName("appVersionNumber")]
        public int AppVersionNumber { get; set; }

        [JsonPropertyName("isOnHold")]
        public bool IsOnHold { get; set; }

        [JsonPropertyName("isAssignedToMe")]
        public bool IsAssignedToMe { get; set; }

        [JsonPropertyName("workflowCreationTime")]
        public DateTime WorkflowCreationTime { get; set; }

        [JsonPropertyName("stepCreationTime")]
        public DateTime StepCreationTime { get; set; }

        [JsonPropertyName("stepAssignedInbox")]
        public string StepAssignedInbox { get; set; }

        [JsonPropertyName("startByCustomerNameA")]
        public string StartByCustomerNameA { get; set; }

        [JsonPropertyName("startByCustomerNameE")]
        public string StartByCustomerNameE { get; set; }

        [JsonPropertyName("stepAssignedCustomerNameA")]
        public string StepAssignedCustomerNameA { get; set; }

        [JsonPropertyName("stepAssignedCustomerNameE")]
        public string StepAssignedCustomerNameE { get; set; }

        [JsonPropertyName("backOfficeResponse")]
        public object BackOfficeResponse { get; set; }

        [JsonPropertyName("startByDomainCustomerNameA")]
        public string StartByDomainCustomerNameA { get; set; }

        [JsonPropertyName("startByDomainCustomerNameE")]
        public string StartByDomainCustomerNameE { get; set; }

        [JsonPropertyName("startByDomainTradeLicNumber")]
        public object StartByDomainTradeLicNumber { get; set; }

        [JsonPropertyName("stepOrganizationUnitNameA")]
        public object StepOrganizationUnitNameA { get; set; }

        [JsonPropertyName("stepOrganizationUnitNameE")]
        public object StepOrganizationUnitNameE { get; set; }

        [JsonPropertyName("startByInboxNameA")]
        public string StartByInboxNameA { get; set; }

        [JsonPropertyName("startByInboxNameE")]
        public string StartByInboxNameE { get; set; }

        [JsonPropertyName("departmentNameA")]
        public object DepartmentNameA { get; set; }

        [JsonPropertyName("departmentNameE")]
        public object DepartmentNameE { get; set; }

        [JsonPropertyName("isDraft")]
        public bool IsDraft { get; set; }

        [JsonPropertyName("selectedApplications")]
        public object SelectedApplications { get; set; }

        [JsonPropertyName("newUserId")]
        public int NewUserId { get; set; }

        [JsonPropertyName("deadline")]
        public DateTime Deadline { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }

    public class BackOfficeInboxResponse
    {
        [JsonPropertyName("totalCount")]
        public int TotalCount { get; set; }

        [JsonPropertyName("items")]
        public List<InboxItem> Items { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}