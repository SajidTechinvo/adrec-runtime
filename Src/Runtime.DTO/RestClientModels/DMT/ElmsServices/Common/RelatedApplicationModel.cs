using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.ElmsServices.Common
{
    public class RelatedApplicationResponse
    {
        [JsonPropertyName("applicationInstanceId")]
        public int? ApplicationInstanceId { get; set; }

        [JsonPropertyName("applicationNumber")]
        public string ApplicationNumber { get; set; }

        [JsonPropertyName("applicationProgressStatus")]
        public object ApplicationProgressStatus { get; set; }

        [JsonPropertyName("baseMunicipalityId")]
        public int? BaseMunicipalityId { get; set; }

        [JsonPropertyName("businessFlags")]
        public int? BusinessFlags { get; set; }

        [JsonPropertyName("cancelByUserId")]
        public object CancelByUserId { get; set; }

        [JsonPropertyName("cancelComments")]
        public string CancelComments { get; set; }

        [JsonPropertyName("cancelDate")]
        public object CancelDate { get; set; }

        [JsonPropertyName("carrierRequestDate")]
        public object CarrierRequestDate { get; set; }

        [JsonPropertyName("carrierRequestNumber")]
        public string CarrierRequestNumber { get; set; }

        [JsonPropertyName("endByUserId")]
        public object EndByUserId { get; set; }

        [JsonPropertyName("endDate")]
        public object EndDate { get; set; }

        [JsonPropertyName("finalApproveByUserId")]
        public object FinalApproveByUserId { get; set; }

        [JsonPropertyName("finalApproveDate")]
        public object FinalApproveDate { get; set; }

        [JsonPropertyName("isDari")]
        public bool IsDari { get; set; }

        [JsonPropertyName("isOnHold")]
        public bool? IsOnHold { get; set; }

        [JsonPropertyName("isStartedOnline")]
        public bool IsStartedOnline { get; set; }

        [JsonPropertyName("migNote")]
        public object MigNote { get; set; }

        [JsonPropertyName("migNoteL")]
        public string MigNoteL { get; set; }

        [JsonPropertyName("migNoteLm")]
        public string MigNoteLm { get; set; }

        [JsonPropertyName("municipalityBranchId")]
        public int MunicipalityBranchId { get; set; }

        [JsonPropertyName("municipalityId")]
        public int MunicipalityId { get; set; }

        [JsonPropertyName("ownerAddressId")]
        public object OwnerAddressId { get; set; }

        [JsonPropertyName("ownerDeliveryAddressId")]
        public object OwnerDeliveryAddressId { get; set; }

        [JsonPropertyName("primaryEntityGuid")]
        public string PrimaryEntityGuid { get; set; }

        [JsonPropertyName("referenceNumber")]
        public string ReferenceNumber { get; set; }

        [JsonPropertyName("requesterId")]
        public object RequesterId { get; set; }

        [JsonPropertyName("secondaryEntityGuid")]
        public string SecondaryEntityGuid { get; set; }

        [JsonPropertyName("smarthubApplicationNumber")]
        public string SmarthubApplicationNumber { get; set; }

        [JsonPropertyName("spsApplicationNumber")]
        public string SpsApplicationNumber { get; set; }

        [JsonPropertyName("updateComments")]
        public string UpdateComments { get; set; }

        [JsonPropertyName("workflowId")]
        public int WorkflowId { get; set; }

        [JsonPropertyName("workflowRejectReasonId")]
        public object WorkflowRejectReasonId { get; set; }

        [JsonPropertyName("workflowRequestReasonDesc")]
        public string WorkflowRequestReasonDesc { get; set; }

        [JsonPropertyName("workflowRequestReasonId")]
        public object WorkflowRequestReasonId { get; set; }

        [JsonPropertyName("applicationEntities")]
        public object ApplicationEntities { get; set; }

        [JsonPropertyName("payments")]
        public object Payments { get; set; }

        [JsonPropertyName("applicationAgents")]
        public object ApplicationAgents { get; set; }

        [JsonPropertyName("workflowConst")]
        public string WorkflowConst { get; set; }

        [JsonPropertyName("workflowNameA")]
        public string WorkflowNameA { get; set; }

        [JsonPropertyName("workflowNameE")]
        public string WorkflowNameE { get; set; }

        [JsonPropertyName("currentStepNameA")]
        public string CurrentStepNameA { get; set; }

        [JsonPropertyName("currentStepNameE")]
        public string CurrentStepNameE { get; set; }

        [JsonPropertyName("municipalityNameA")]
        public string MunicipalityNameA { get; set; }

        [JsonPropertyName("municipalityNameE")]
        public string MunicipalityNameE { get; set; }

        [JsonPropertyName("startedByEmployeeNameA")]
        public object StartedByEmployeeNameA { get; set; }

        [JsonPropertyName("startedByEmployeeNamE")]
        public string StartedByEmployeeNamE { get; set; }

        [JsonPropertyName("startedOn")]
        public DateTime StartedOn { get; set; }

        [JsonPropertyName("canViewApplication")]
        public bool CanViewApplication { get; set; }

        [JsonPropertyName("plotId")]
        public object PlotId { get; set; }

        [JsonPropertyName("ownerId")]
        public object OwnerId { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}