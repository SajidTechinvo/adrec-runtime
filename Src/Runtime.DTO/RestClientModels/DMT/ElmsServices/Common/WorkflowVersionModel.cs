using System.Text.Json.Serialization;

namespace ADREC.DTO.RestClientModels.DMT.ElmsServices.Common
{
    public class WorkflowVersionResponse
    {
        [JsonPropertyName("workflowId")]
        public int WorkflowId { get; set; }

        [JsonPropertyName("workflowStepId")]
        public int WorkflowStepId { get; set; }

        [JsonPropertyName("workflowConst")]
        public string WorkflowConst { get; set; }

        [JsonPropertyName("workflowStepConst")]
        public object WorkflowStepConst { get; set; }

        [JsonPropertyName("workflowStatusConst")]
        public object WorkflowStatusConst { get; set; }

        [JsonPropertyName("applicationNumber")]
        public string ApplicationNumber { get; set; }

        [JsonPropertyName("appVersionNumber")]
        public int AppVersionNumber { get; set; }

        [JsonPropertyName("workflowCreationTime")]
        public DateTime WorkflowCreationTime { get; set; }

        [JsonPropertyName("workflowEndTime")]
        public object WorkflowEndTime { get; set; }

        [JsonPropertyName("workflowSubmissionTime")]
        public object WorkflowSubmissionTime { get; set; }

        [JsonPropertyName("startByCustomerNameA")]
        public string StartByCustomerNameA { get; set; }

        [JsonPropertyName("startByCustomerNameE")]
        public string StartByCustomerNameE { get; set; }

        [JsonPropertyName("rejectionNoteA")]
        public object RejectionNoteA { get; set; }

        [JsonPropertyName("rejectionNoteE")]
        public object RejectionNoteE { get; set; }

        [JsonPropertyName("backOfficeResponse")]
        public string BackOfficeResponse { get; set; }

        [JsonPropertyName("stepAssignedCustomerNameA")]
        public object StepAssignedCustomerNameA { get; set; }

        [JsonPropertyName("stepAssignedCustomerNameE")]
        public object StepAssignedCustomerNameE { get; set; }

        [JsonPropertyName("courtCaseNumber")]
        public object CourtCaseNumber { get; set; }

        [JsonPropertyName("currentStepNameA")]
        public string CurrentStepNameA { get; set; }

        [JsonPropertyName("currentStepNameE")]
        public string CurrentStepNameE { get; set; }

        [JsonPropertyName("currentStepConst")]
        public object CurrentStepConst { get; set; }

        [JsonPropertyName("workflowStatusNameA")]
        public object WorkflowStatusNameA { get; set; }

        [JsonPropertyName("workflowStatusNameE")]
        public object WorkflowStatusNameE { get; set; }

        [JsonPropertyName("assignedUserNameA")]
        public object AssignedUserNameA { get; set; }

        [JsonPropertyName("assignedUserNameE")]
        public object AssignedUserNameE { get; set; }

        [JsonPropertyName("isCompleted")]
        public bool IsCompleted { get; set; }

        [JsonPropertyName("workflowNameE")]
        public object WorkflowNameE { get; set; }

        [JsonPropertyName("workflowNameA")]
        public object WorkflowNameA { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }
}