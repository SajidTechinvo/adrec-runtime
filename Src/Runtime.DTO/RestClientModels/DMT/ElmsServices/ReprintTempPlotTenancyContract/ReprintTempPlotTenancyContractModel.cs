using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ADREC.DTO.RestClientModels.DMT.Plots;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.Common;
using Runtime.DTO.RestClientModels.DMT.ElmsTenancy;
using Runtime.DTO.RestClientModels.DMT.Lookup;
using Runtime.DTO.RestClientModels.DMT.Owners;
using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.ElmsServices.ReprintTempPlotTenancyContract
{
    public class FirstTransferTransaction
    {
        [JsonPropertyName("evaluationAmount")]
        public object EvaluationAmount { get; set; }

        [JsonPropertyName("ownershipTransferId")]
        public int OwnershipTransferId { get; set; }

        [JsonPropertyName("ownershipTransferTransactionId")]
        public int OwnershipTransferTransactionId { get; set; }

        [JsonPropertyName("plotEvaluationId")]
        public object PlotEvaluationId { get; set; }

        [JsonPropertyName("plotId")]
        public int PlotId { get; set; }

        [JsonPropertyName("plotTransactionId")]
        public object PlotTransactionId { get; set; }

        [JsonPropertyName("propertyActivePtId")]
        public int PropertyActivePtId { get; set; }

        [JsonPropertyName("propertyActiveVersionId")]
        public int PropertyActiveVersionId { get; set; }

        [JsonPropertyName("plotTransaction")]
        public object PlotTransaction { get; set; }

        [JsonPropertyName("ownershipTransferEntities")]
        public List<OwnershipTransferEntity> OwnershipTransferEntities { get; set; }

        [JsonPropertyName("recipients")]
        public List<object> Recipients { get; set; }

        [JsonPropertyName("transferrers")]
        public List<PlotOwnerResponse> Transferrers { get; set; }

        [JsonPropertyName("plot")]
        public PlotDetailResponse Plot { get; set; }

        [JsonPropertyName("transferredEntities")]
        public List<TransferredEntity> TransferredEntities { get; set; }

        [JsonPropertyName("receivedEntities")]
        public List<object> ReceivedEntities { get; set; }

        [JsonPropertyName("totalTransferedAmount2")]
        public double TotalTransferedAmount2 { get; set; }

        [JsonPropertyName("totalReceievedAmount")]
        public double TotalReceievedAmount { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }

    public class OwnershipTransfer
    {
        [JsonPropertyName("allotmentNameId")]
        public object AllotmentNameId { get; set; }

        [JsonPropertyName("alternativePlotId")]
        public object AlternativePlotId { get; set; }

        [JsonPropertyName("comments")]
        public string Comments { get; set; }

        [JsonPropertyName("contractDate")]
        public object ContractDate { get; set; }

        [JsonPropertyName("courtReferenceNumber")]
        public string CourtReferenceNumber { get; set; }

        [JsonPropertyName("courtReferenceType")]
        public object CourtReferenceType { get; set; }

        [JsonPropertyName("decreeId")]
        public object DecreeId { get; set; }

        [JsonPropertyName("evaluationAmount")]
        public object EvaluationAmount { get; set; }

        [JsonPropertyName("isRegardless")]
        public object IsRegardless { get; set; }

        [JsonPropertyName("isRetired")]
        public object IsRetired { get; set; }

        [JsonPropertyName("isSocialCase")]
        public int IsSocialCase { get; set; }

        [JsonPropertyName("isVideoAuthenticated")]
        public object IsVideoAuthenticated { get; set; }

        [JsonPropertyName("isWithLock")]
        public int IsWithLock { get; set; }

        [JsonPropertyName("isWithMortgage")]
        public int IsWithMortgage { get; set; }

        [JsonPropertyName("isWithReleaseMortage")]
        public int IsWithReleaseMortage { get; set; }

        [JsonPropertyName("ownershipTransferGuid")]
        public string OwnershipTransferGuid { get; set; }

        [JsonPropertyName("ownershipTransferId")]
        public int OwnershipTransferId { get; set; }

        [JsonPropertyName("ranchAllotmentRequestType")]
        public object RanchAllotmentRequestType { get; set; }

        [JsonPropertyName("randomAllotmentSetId")]
        public object RandomAllotmentSetId { get; set; }

        [JsonPropertyName("recipientUnit")]
        public object RecipientUnit { get; set; }

        [JsonPropertyName("releaseMortgageComment")]
        public string ReleaseMortgageComment { get; set; }

        [JsonPropertyName("requestedLanduseId")]
        public object RequestedLanduseId { get; set; }

        [JsonPropertyName("requestedRanchCamelCount")]
        public object RequestedRanchCamelCount { get; set; }

        [JsonPropertyName("requestedRanchCowCount")]
        public object RequestedRanchCowCount { get; set; }

        [JsonPropertyName("requestedRanchSheepCount")]
        public object RequestedRanchSheepCount { get; set; }

        [JsonPropertyName("requestLandClassificationId")]
        public object RequestLandClassificationId { get; set; }

        [JsonPropertyName("requestorFamilyCount")]
        public object RequestorFamilyCount { get; set; }

        [JsonPropertyName("requestorIncome")]
        public object RequestorIncome { get; set; }

        [JsonPropertyName("tenancyActivityTypeA")]
        public string TenancyActivityTypeA { get; set; }

        [JsonPropertyName("tenancyContractId")]
        public int TenancyContractId { get; set; }

        [JsonPropertyName("transactionAmount")]
        public object TransactionAmount { get; set; }

        [JsonPropertyName("transfererUnit")]
        public object TransfererUnit { get; set; }

        [JsonPropertyName("txnAmountPaidByOwnerId")]
        public object TxnAmountPaidByOwnerId { get; set; }

        [JsonPropertyName("txnAmountPaymentType")]
        public string TxnAmountPaymentType { get; set; }

        [JsonPropertyName("videoUrl")]
        public string VideoUrl { get; set; }

        [JsonPropertyName("ownershipTransferTransactions")]
        public List<OwnershipTransferTransaction> OwnershipTransferTransactions { get; set; }

        [JsonPropertyName("allotmentOrder")]
        public object AllotmentOrder { get; set; }

        [JsonPropertyName("firstTransferTransaction")]
        public FirstTransferTransaction FirstTransferTransaction { get; set; }

        [JsonPropertyName("firstPlot")]
        public PlotDetailResponse FirstPlot { get; set; }

        [JsonPropertyName("transfererOwnershipItems")]
        public object TransfererOwnershipItems { get; set; }

        [JsonPropertyName("recipientOwnershipItems")]
        public object RecipientOwnershipItems { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }

    public class OwnershipTransferEntity
    {
        [JsonPropertyName("amountInTotalPercentage")]
        public double AmountInTotalPercentage { get; set; }

        [JsonPropertyName("amountInUnit")]
        public string AmountInUnit { get; set; }

        [JsonPropertyName("comments")]
        public string Comments { get; set; }

        [JsonPropertyName("entityType")]
        public string EntityType { get; set; }

        [JsonPropertyName("mergeComments")]
        public string MergeComments { get; set; }

        [JsonPropertyName("ownerId")]
        public int OwnerId { get; set; }

        [JsonPropertyName("ownershipTransferEntityId")]
        public int OwnershipTransferEntityId { get; set; }

        [JsonPropertyName("ownershipTransferTransactionId")]
        public int OwnershipTransferTransactionId { get; set; }

        [JsonPropertyName("ownersRelationTypeId")]
        public object OwnersRelationTypeId { get; set; }

        [JsonPropertyName("plotTransactionOwnerId")]
        public int PlotTransactionOwnerId { get; set; }

        [JsonPropertyName("plotTransactionTypeId")]
        public int PlotTransactionTypeId { get; set; }

        [JsonPropertyName("priorityValue")]
        public object PriorityValue { get; set; }

        [JsonPropertyName("rightsHoldTypeId")]
        public int RightsHoldTypeId { get; set; }

        [JsonPropertyName("owner")]
        public PlotOwnerResponse Owner { get; set; }

        [JsonPropertyName("rightsHoldType")]
        public RightsHoldTypeResponse RightsHoldType { get; set; }

        [JsonPropertyName("acquisitionType")]
        public AcquisitionTypeResponse AcquisitionType { get; set; }

        [JsonPropertyName("sourcePlotOwnerShare")]
        public SourcePlotOwnerShare SourcePlotOwnerShare { get; set; }

        [JsonPropertyName("share")]
        public string Share { get; set; }

        [JsonPropertyName("remainingAmount")]
        public double RemainingAmount { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }

    public class OwnershipTransferTransaction
    {
        [JsonPropertyName("evaluationAmount")]
        public object EvaluationAmount { get; set; }

        [JsonPropertyName("ownershipTransferId")]
        public int OwnershipTransferId { get; set; }

        [JsonPropertyName("ownershipTransferTransactionId")]
        public int OwnershipTransferTransactionId { get; set; }

        [JsonPropertyName("plotEvaluationId")]
        public object PlotEvaluationId { get; set; }

        [JsonPropertyName("plotId")]
        public int PlotId { get; set; }

        [JsonPropertyName("plotTransactionId")]
        public object PlotTransactionId { get; set; }

        [JsonPropertyName("propertyActivePtId")]
        public int PropertyActivePtId { get; set; }

        [JsonPropertyName("propertyActiveVersionId")]
        public int PropertyActiveVersionId { get; set; }

        [JsonPropertyName("plotTransaction")]
        public object PlotTransaction { get; set; }

        [JsonPropertyName("ownershipTransferEntities")]
        public List<OwnershipTransferEntity> OwnershipTransferEntities { get; set; }

        [JsonPropertyName("recipients")]
        public List<object> Recipients { get; set; }

        [JsonPropertyName("transferrers")]
        public List<PlotOwnerResponse> Transferrers { get; set; }

        [JsonPropertyName("plot")]
        public PlotDetailResponse Plot { get; set; }

        [JsonPropertyName("transferredEntities")]
        public List<TransferredEntity> TransferredEntities { get; set; }

        [JsonPropertyName("receivedEntities")]
        public List<object> ReceivedEntities { get; set; }

        [JsonPropertyName("totalTransferedAmount2")]
        public double TotalTransferedAmount2 { get; set; }

        [JsonPropertyName("totalReceievedAmount")]
        public double TotalReceievedAmount { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }

    public class ReprintTempPlotTenancyContractResponse
    {
        [JsonPropertyName("isSkipPayment")]
        public bool IsSkipPayment { get; set; }

        [JsonPropertyName("plotTransaction")]
        public object PlotTransaction { get; set; }

        [JsonPropertyName("plot")]
        public PlotDetailResponse Plot { get; set; }

        [JsonPropertyName("owners")]
        public List<PlotOwnerResponse> Owners { get; set; }

        [JsonPropertyName("lessor")]
        public string Lessor { get; set; }

        [JsonPropertyName("tenants")]
        public object Tenants { get; set; }

        [JsonPropertyName("municipality")]
        public MunicipalityResponse Municipality { get; set; }

        [JsonPropertyName("tenancyContract")]
        public TenancyContractResponse TenancyContract { get; set; }

        [JsonPropertyName("ownershipTransfer")]
        public OwnershipTransfer OwnershipTransfer { get; set; }

        [JsonPropertyName("elmsPayment")]
        public object ElmsPayment { get; set; }

        [JsonPropertyName("isApplicationOnHold")]
        public bool IsApplicationOnHold { get; set; }

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
        public string SourceSystemNameA { get; set; }

        [JsonPropertyName("sourceSystemNameE")]
        public string SourceSystemNameE { get; set; }

        [JsonPropertyName("distanceInMeter")]
        public double? DistanceInMeter { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }

    public class SourcePlotOwnerShare
    {
        [JsonPropertyName("approveByUserId")]
        public int ApproveByUserId { get; set; }

        [JsonPropertyName("approveComments")]
        public string ApproveComments { get; set; }

        [JsonPropertyName("approveDate")]
        public DateTime ApproveDate { get; set; }

        [JsonPropertyName("isHistory")]
        public object IsHistory { get; set; }

        [JsonPropertyName("landFileNumber")]
        public string LandFileNumber { get; set; }

        [JsonPropertyName("mergeComments")]
        public string MergeComments { get; set; }

        [JsonPropertyName("migNote")]
        public object MigNote { get; set; }

        [JsonPropertyName("migNoteL")]
        public string MigNoteL { get; set; }

        [JsonPropertyName("migNoteLm")]
        public string MigNoteLm { get; set; }

        [JsonPropertyName("ownerId")]
        public int OwnerId { get; set; }

        [JsonPropertyName("percentOwnership")]
        public double PercentOwnership { get; set; }

        [JsonPropertyName("plotPartitionId")]
        public object PlotPartitionId { get; set; }

        [JsonPropertyName("plotTransactionId")]
        public int PlotTransactionId { get; set; }

        [JsonPropertyName("plotTransactionTypeId")]
        public int PlotTransactionTypeId { get; set; }

        [JsonPropertyName("plotTransactionUserOwnerId")]
        public int PlotTransactionUserOwnerId { get; set; }

        [JsonPropertyName("priorityValue")]
        public int PriorityValue { get; set; }

        [JsonPropertyName("remarks")]
        public string Remarks { get; set; }

        [JsonPropertyName("removeByUserId")]
        public object RemoveByUserId { get; set; }

        [JsonPropertyName("removeDate")]
        public object RemoveDate { get; set; }

        [JsonPropertyName("rightsHoldTypeId")]
        public int RightsHoldTypeId { get; set; }

        [JsonPropertyName("shareSign")]
        public object ShareSign { get; set; }

        [JsonPropertyName("shareStatus")]
        public int ShareStatus { get; set; }

        [JsonPropertyName("updateComments")]
        public string UpdateComments { get; set; }

        [JsonPropertyName("rightsHoldTypeNameA")]
        public object RightsHoldTypeNameA { get; set; }

        [JsonPropertyName("rightsHoldTypeNameE")]
        public object RightsHoldTypeNameE { get; set; }

        [JsonPropertyName("plotTransactionTypeNameA")]
        public object PlotTransactionTypeNameA { get; set; }

        [JsonPropertyName("plotTransactionTypeNameE")]
        public object PlotTransactionTypeNameE { get; set; }

        [JsonPropertyName("rightsHoldType")]
        public object RightsHoldType { get; set; }

        [JsonPropertyName("acquisitionType")]
        public object AcquisitionType { get; set; }

        [JsonPropertyName("share")]
        public object Share { get; set; }

        [JsonPropertyName("shareComments")]
        public object ShareComments { get; set; }

        [JsonPropertyName("priority")]
        public int Priority { get; set; }

        [JsonPropertyName("totalPercentOwnership")]
        public double TotalPercentOwnership { get; set; }

        [JsonPropertyName("totalPercentOwnershipString")]
        public object TotalPercentOwnershipString { get; set; }

        [JsonPropertyName("owner")]
        public object Owner { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }

    public class TransferredEntity
    {
        [JsonPropertyName("amountInTotalPercentage")]
        public double AmountInTotalPercentage { get; set; }

        [JsonPropertyName("amountInUnit")]
        public string AmountInUnit { get; set; }

        [JsonPropertyName("comments")]
        public string Comments { get; set; }

        [JsonPropertyName("entityType")]
        public string EntityType { get; set; }

        [JsonPropertyName("mergeComments")]
        public string MergeComments { get; set; }

        [JsonPropertyName("ownerId")]
        public int OwnerId { get; set; }

        [JsonPropertyName("ownershipTransferEntityId")]
        public int OwnershipTransferEntityId { get; set; }

        [JsonPropertyName("ownershipTransferTransactionId")]
        public int OwnershipTransferTransactionId { get; set; }

        [JsonPropertyName("ownersRelationTypeId")]
        public object OwnersRelationTypeId { get; set; }

        [JsonPropertyName("plotTransactionOwnerId")]
        public int PlotTransactionOwnerId { get; set; }

        [JsonPropertyName("plotTransactionTypeId")]
        public int PlotTransactionTypeId { get; set; }

        [JsonPropertyName("priorityValue")]
        public object PriorityValue { get; set; }

        [JsonPropertyName("rightsHoldTypeId")]
        public int RightsHoldTypeId { get; set; }

        [JsonPropertyName("owner")]
        public PlotOwnerResponse Owner { get; set; }

        [JsonPropertyName("rightsHoldType")]
        public RightsHoldTypeResponse RightsHoldType { get; set; }

        [JsonPropertyName("acquisitionType")]
        public AcquisitionTypeResponse AcquisitionType { get; set; }

        [JsonPropertyName("sourcePlotOwnerShare")]
        public SourcePlotOwnerShare SourcePlotOwnerShare { get; set; }

        [JsonPropertyName("share")]
        public string Share { get; set; }

        [JsonPropertyName("remainingAmount")]
        public double RemainingAmount { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}