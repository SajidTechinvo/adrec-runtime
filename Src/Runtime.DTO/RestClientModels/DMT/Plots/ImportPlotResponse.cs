using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ADREC.DTO.RestClientModels.DMT.Plots;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.Common;
using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.Plots
{
    public class StepImportPlotResponse
    {
        [JsonPropertyName("plot")]
        public PlotResponse Plot { get; set; }

        [JsonPropertyName("transactionData")]
        public TransactionData TransactionData { get; set; }

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
        public List<RelatedApplicationResponse> RelatedApplications { get; set; }

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

    public class TransactionData
    {
        [JsonPropertyName("appraisalValueTypeId")]
        public object AppraisalValueTypeId { get; set; }

        [JsonPropertyName("archiveFileNumber")]
        public string ArchiveFileNumber { get; set; }

        [JsonPropertyName("communityId")]
        public object CommunityId { get; set; }

        [JsonPropertyName("constructionDate")]
        public object ConstructionDate { get; set; }

        [JsonPropertyName("dimensionDescription")]
        public string DimensionDescription { get; set; }

        [JsonPropertyName("estimatedArea")]
        public object EstimatedArea { get; set; }

        [JsonPropertyName("evaluationAmount")]
        public object EvaluationAmount { get; set; }

        [JsonPropertyName("flatNumber")]
        public string FlatNumber { get; set; }

        [JsonPropertyName("isAuditApproved")]
        public object IsAuditApproved { get; set; }

        [JsonPropertyName("isServiceCondition")]
        public object IsServiceCondition { get; set; }

        [JsonPropertyName("isSquareMeters")]
        public object IsSquareMeters { get; set; }

        [JsonPropertyName("isTemporaryPlot")]
        public object IsTemporaryPlot { get; set; }

        [JsonPropertyName("isWithDeleteOwner")]
        public object IsWithDeleteOwner { get; set; }

        [JsonPropertyName("landuseClassificationId")]
        public object LanduseClassificationId { get; set; }

        [JsonPropertyName("landuseId")]
        public object LanduseId { get; set; }

        [JsonPropertyName("legalRemarks")]
        public string LegalRemarks { get; set; }

        [JsonPropertyName("municipalityId")]
        public int MunicipalityId { get; set; }

        [JsonPropertyName("plotAllocationTypeId")]
        public object PlotAllocationTypeId { get; set; }

        [JsonPropertyName("plotBuildingsArea")]
        public object PlotBuildingsArea { get; set; }

        [JsonPropertyName("plotClassificationId")]
        public object PlotClassificationId { get; set; }

        [JsonPropertyName("plotDetailsTransactionGuid")]
        public string PlotDetailsTransactionGuid { get; set; }

        [JsonPropertyName("plotDetailsTransactionId")]
        public int PlotDetailsTransactionId { get; set; }

        [JsonPropertyName("plotId")]
        public object PlotId { get; set; }

        [JsonPropertyName("plotNumber")]
        public string PlotNumber { get; set; }

        [JsonPropertyName("plotOriginTypeId")]
        public object PlotOriginTypeId { get; set; }

        [JsonPropertyName("plotTransactionId")]
        public object PlotTransactionId { get; set; }

        [JsonPropertyName("plotTransactionTypeId")]
        public object PlotTransactionTypeId { get; set; }

        [JsonPropertyName("publicHouseClassificationId")]
        public object PublicHouseClassificationId { get; set; }

        [JsonPropertyName("publicHouseNumber")]
        public string PublicHouseNumber { get; set; }

        [JsonPropertyName("remarks")]
        public string Remarks { get; set; }

        [JsonPropertyName("roadId")]
        public object RoadId { get; set; }

        [JsonPropertyName("tpdPlotId")]
        public double TpdPlotId { get; set; }

        [JsonPropertyName("utm")]
        public string Utm { get; set; }

        [JsonPropertyName("appraisalValueTypeNameE")]
        public object AppraisalValueTypeNameE { get; set; }

        [JsonPropertyName("appraisalValueTypeNameA")]
        public object AppraisalValueTypeNameA { get; set; }

        [JsonPropertyName("plotAllocationTypeNameA")]
        public object PlotAllocationTypeNameA { get; set; }

        [JsonPropertyName("plotAllocationTypeNameE")]
        public object PlotAllocationTypeNameE { get; set; }

        [JsonPropertyName("areaUnitNameA")]
        public object AreaUnitNameA { get; set; }

        [JsonPropertyName("areaUnitNameE")]
        public object AreaUnitNameE { get; set; }

        [JsonPropertyName("landuseNameA")]
        public object LanduseNameA { get; set; }

        [JsonPropertyName("landuseNameE")]
        public object LanduseNameE { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}