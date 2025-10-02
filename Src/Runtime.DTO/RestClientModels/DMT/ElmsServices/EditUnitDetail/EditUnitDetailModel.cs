using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ADREC.DTO.RestClientModels.DMT.Plots;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.Common;
using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.ElmsServices.EditUnitDetail
{
    public class EditUnitDetailResponse
    {
        [JsonPropertyName("plot")]
        public PlotDetailResponse Plot { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("workflowId")]
        public int WorkflowId { get; set; }

        [JsonPropertyName("workflowStepId")]
        public int WorkflowStepId { get; set; }

        [JsonPropertyName("workflowConst")]
        public string WorkflowConst { get; set; }

        [JsonPropertyName("workflowNameA")]
        public string WorkflowNameA { get; set; }

        [JsonPropertyName("workflowNameE")]
        public string WorkflowNameE { get; set; }

        [JsonPropertyName("workflowTypeId")]
        public int WorkflowTypeId { get; set; }

        [JsonPropertyName("workflowTypeConst")]
        public object WorkflowTypeConst { get; set; }

        [JsonPropertyName("workflowTypeNameA")]
        public object WorkflowTypeNameA { get; set; }

        [JsonPropertyName("workflowTypeNameE")]
        public object WorkflowTypeNameE { get; set; }

        [JsonPropertyName("workflowStepConst")]
        public string WorkflowStepConst { get; set; }

        [JsonPropertyName("workflowStepNameA")]
        public string WorkflowStepNameA { get; set; }

        [JsonPropertyName("workflowStepNameE")]
        public string WorkflowStepNameE { get; set; }

        [JsonPropertyName("applicationNumber")]
        public string ApplicationNumber { get; set; }

        [JsonPropertyName("appVersionNumber")]
        public int AppVersionNumber { get; set; }

        [JsonPropertyName("workflowStatusConst")]
        public string WorkflowStatusConst { get; set; }

        [JsonPropertyName("workflowOnlineViewPath")]
        public object WorkflowOnlineViewPath { get; set; }

        [JsonPropertyName("workflowBackOfficeViewPath")]
        public object WorkflowBackOfficeViewPath { get; set; }

        [JsonPropertyName("startDate")]
        public DateTime StartDate { get; set; }

        [JsonPropertyName("changeDraftStatusDate")]
        public object ChangeDraftStatusDate { get; set; }

        [JsonPropertyName("assignedCustomerNameA")]
        public string AssignedCustomerNameA { get; set; }

        [JsonPropertyName("assignedCustomerNameE")]
        public string AssignedCustomerNameE { get; set; }

        [JsonPropertyName("assignedCustomerEmail")]
        public string AssignedCustomerEmail { get; set; }

        [JsonPropertyName("hasEditPermission")]
        public bool HasEditPermission { get; set; }

        [JsonPropertyName("hasReadPermission")]
        public bool HasReadPermission { get; set; }

        [JsonPropertyName("hasStatusPermission")]
        public bool HasStatusPermission { get; set; }

        [JsonPropertyName("hasDocuments")]
        public bool HasDocuments { get; set; }

        [JsonPropertyName("hasInputDocuments")]
        public bool HasInputDocuments { get; set; }

        [JsonPropertyName("startUserDisplayNameA")]
        public string StartUserDisplayNameA { get; set; }

        [JsonPropertyName("startUserDisplayNameE")]
        public string StartUserDisplayNameE { get; set; }

        [JsonPropertyName("startUserEmail")]
        public string StartUserEmail { get; set; }

        [JsonPropertyName("startUserMobile")]
        public string StartUserMobile { get; set; }

        [JsonPropertyName("domainCustomerNameA")]
        public string DomainCustomerNameA { get; set; }

        [JsonPropertyName("domainCustomerNameE")]
        public string DomainCustomerNameE { get; set; }

        [JsonPropertyName("backOfficeResponse")]
        public object BackOfficeResponse { get; set; }

        [JsonPropertyName("assignedInboxNameA")]
        public string AssignedInboxNameA { get; set; }

        [JsonPropertyName("assignedInboxNameE")]
        public string AssignedInboxNameE { get; set; }

        [JsonPropertyName("businessEntities")]
        public List<BusinessEntityResponse> BusinessEntities { get; set; }

        [JsonPropertyName("wfiStepList")]
        public List<WfiStepListResponse> WfiStepList { get; set; }

        [JsonPropertyName("wfiNoteList")]
        public List<object> WfiNoteList { get; set; }

        [JsonPropertyName("relatedApplications")]
        public List<object> RelatedApplications { get; set; }

        [JsonPropertyName("multiPartyApprovalList")]
        public List<object> MultiPartyApprovalList { get; set; }

        [JsonPropertyName("workflowVersions")]
        public List<WorkflowVersionResponse> WorkflowVersions { get; set; }

        [JsonPropertyName("payments")]
        public List<object> Payments { get; set; }

        [JsonPropertyName("gatewayPayments")]
        public object GatewayPayments { get; set; }

        [JsonPropertyName("gcsPayments")]
        public List<object> GcsPayments { get; set; }

        [JsonPropertyName("isCompleted")]
        public bool IsCompleted { get; set; }

        [JsonPropertyName("isDraft")]
        public bool IsDraft { get; set; }

        [JsonPropertyName("draftAutoCancelPeriod")]
        public object DraftAutoCancelPeriod { get; set; }

        [JsonPropertyName("startUser")]
        public ElmsUserResponse StartUser { get; set; }

        [JsonPropertyName("currentUser")]
        public object CurrentUser { get; set; }

        [JsonPropertyName("domainCustomer")]
        public object DomainCustomer { get; set; }

        [JsonPropertyName("stepOrganizationUnitNameA")]
        public object StepOrganizationUnitNameA { get; set; }

        [JsonPropertyName("stepOrganizationUnitNameE")]
        public object StepOrganizationUnitNameE { get; set; }

        [JsonPropertyName("isWorkflowRated")]
        public bool IsWorkflowRated { get; set; }

        [JsonPropertyName("companyCustomer")]
        public object CompanyCustomer { get; set; }

        [JsonPropertyName("cdpProviderAuthType")]
        public object CdpProviderAuthType { get; set; }

        [JsonPropertyName("showWalletOption")]
        public bool ShowWalletOption { get; set; }

        [JsonPropertyName("resultTextE")]
        public object ResultTextE { get; set; }

        [JsonPropertyName("onwaniAddress")]
        public OnwaniAddressResponse OnwaniAddress { get; set; }

        [JsonPropertyName("selectedOnwaniPlot")]
        public object SelectedOnwaniPlot { get; set; }

        [JsonPropertyName("locationAddresslink")]
        public object LocationAddresslink { get; set; }

        [JsonPropertyName("tammUrlAr")]
        public object TammUrlAr { get; set; }

        [JsonPropertyName("tammUrlEn")]
        public object TammUrlEn { get; set; }

        [JsonPropertyName("isEnableRedirection")]
        public bool IsEnableRedirection { get; set; }

        [JsonPropertyName("workflowStatusNameA")]
        public string WorkflowStatusNameA { get; set; }

        [JsonPropertyName("workflowStatusNameE")]
        public string WorkflowStatusNameE { get; set; }

        [JsonPropertyName("sourceSystemConst")]
        public string SourceSystemConst { get; set; }

        [JsonPropertyName("sourceSystemNameA")]
        public object SourceSystemNameA { get; set; }

        [JsonPropertyName("sourceSystemNameE")]
        public object SourceSystemNameE { get; set; }

        [JsonPropertyName("distanceInMeter")]
        public double DistanceInMeter { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }
}