using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ADREC.DTO.RestClientModels.DMT.Plots;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.Common;
using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.ElmsServices.PropertyMortgageRedemption
{
    public class Contract
    {
        [JsonPropertyName("annualAmount")]
        public object AnnualAmount { get; set; }

        [JsonPropertyName("annualAmountPerUnit")]
        public object AnnualAmountPerUnit { get; set; }

        [JsonPropertyName("closeByUserId")]
        public object CloseByUserId { get; set; }

        [JsonPropertyName("closeDate")]
        public object CloseDate { get; set; }

        [JsonPropertyName("contractAmount")]
        public double ContractAmount { get; set; }

        [JsonPropertyName("contractDate")]
        public DateTime ContractDate { get; set; }

        [JsonPropertyName("contractEndDate")]
        public DateTime ContractEndDate { get; set; }

        [JsonPropertyName("contractId")]
        public int ContractId { get; set; }

        [JsonPropertyName("contractNumber")]
        public string ContractNumber { get; set; }

        [JsonPropertyName("contractNumberOfYears")]
        public object ContractNumberOfYears { get; set; }

        [JsonPropertyName("contractStartDate")]
        public DateTime ContractStartDate { get; set; }

        [JsonPropertyName("contractTermFlags")]
        public object ContractTermFlags { get; set; }

        [JsonPropertyName("contractTypeId")]
        public int ContractTypeId { get; set; }

        [JsonPropertyName("isRenew")]
        public int IsRenew { get; set; }

        [JsonPropertyName("isWithMortgage")]
        public int IsWithMortgage { get; set; }

        [JsonPropertyName("parentContractId")]
        public object ParentContractId { get; set; }

        [JsonPropertyName("referenceNumber")]
        public string ReferenceNumber { get; set; }

        [JsonPropertyName("remarks")]
        public string Remarks { get; set; }

        [JsonPropertyName("tenancyContractId")]
        public object TenancyContractId { get; set; }

        [JsonPropertyName("terminateDate")]
        public object TerminateDate { get; set; }

        [JsonPropertyName("terminateUserId")]
        public object TerminateUserId { get; set; }

        [JsonPropertyName("plotId")]
        public object PlotId { get; set; }

        [JsonPropertyName("contractClass")]
        public object ContractClass { get; set; }

        [JsonPropertyName("contractType")]
        public ContractType ContractType { get; set; }

        [JsonPropertyName("statusA")]
        public string StatusA { get; set; }

        [JsonPropertyName("statusE")]
        public string StatusE { get; set; }

        [JsonPropertyName("partyNameA")]
        public string PartyNameA { get; set; }

        [JsonPropertyName("partyNameE")]
        public string PartyNameE { get; set; }

        [JsonPropertyName("amount")]
        public object Amount { get; set; }

        [JsonPropertyName("parties")]
        public List<Party> Parties { get; set; }

        [JsonPropertyName("offPlanContracts")]
        public object OffPlanContracts { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }

    public class ContractType
    {
        [JsonPropertyName("acquisitionTypeNameA")]
        public string AcquisitionTypeNameA { get; set; }

        [JsonPropertyName("acquisitionTypeNameE")]
        public string AcquisitionTypeNameE { get; set; }

        [JsonPropertyName("contractTypeId")]
        public int ContractTypeId { get; set; }

        [JsonPropertyName("elmsContractTypeConst")]
        public string ElmsContractTypeConst { get; set; }

        [JsonPropertyName("nameA")]
        public string NameA { get; set; }

        [JsonPropertyName("nameE")]
        public string NameE { get; set; }

        [JsonPropertyName("rightsholdTypeNameA")]
        public string RightsholdTypeNameA { get; set; }

        [JsonPropertyName("rightsholdTypeNameE")]
        public string RightsholdTypeNameE { get; set; }

        [JsonPropertyName("serialTypeId")]
        public int SerialTypeId { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }

    public class Party
    {
        [JsonPropertyName("contractId")]
        public int ContractId { get; set; }

        [JsonPropertyName("contractPartyId")]
        public int ContractPartyId { get; set; }

        [JsonPropertyName("mergeComments")]
        public string MergeComments { get; set; }

        [JsonPropertyName("ownerId")]
        public int OwnerId { get; set; }

        [JsonPropertyName("partyType")]
        public int PartyType { get; set; }

        [JsonPropertyName("owner")]
        public OwnerListResponse Owner { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }

    public class PropertyMortgageRedemptionStepInfo
    {
        [JsonPropertyName("elmsApplicationNumber")]
        public string ElmsApplicationNumber { get; set; }

        [JsonPropertyName("elmsApplicationDate")]
        public DateTime ElmsApplicationDate { get; set; }

        [JsonPropertyName("mortgageContractNumber")]
        public string MortgageContractNumber { get; set; }

        [JsonPropertyName("issueDate")]
        public DateTime IssueDate { get; set; }

        [JsonPropertyName("mortgageAmount")]
        public double MortgageAmount { get; set; }

        [JsonPropertyName("mortgageAmountInWordsA")]
        public string MortgageAmountInWordsA { get; set; }

        [JsonPropertyName("mortgageAmountInWordsE")]
        public string MortgageAmountInWordsE { get; set; }

        [JsonPropertyName("bankA")]
        public string BankA { get; set; }

        [JsonPropertyName("bankE")]
        public string BankE { get; set; }

        [JsonPropertyName("branchA")]
        public string BranchA { get; set; }

        [JsonPropertyName("branchE")]
        public string BranchE { get; set; }

        [JsonPropertyName("authorizedEmployeeA")]
        public string AuthorizedEmployeeA { get; set; }

        [JsonPropertyName("authorizedEmployeeE")]
        public string AuthorizedEmployeeE { get; set; }

        [JsonPropertyName("bankSignature")]
        public string BankSignature { get; set; }

        [JsonPropertyName("mortgageTypeA")]
        public string MortgageTypeA { get; set; }

        [JsonPropertyName("mortgageTypeE")]
        public string MortgageTypeE { get; set; }

        [JsonPropertyName("isVideoAuthenticated")]
        public bool IsVideoAuthenticated { get; set; }

        [JsonPropertyName("isVideoAuthenticatedA")]
        public string IsVideoAuthenticatedA { get; set; }

        [JsonPropertyName("isVideoAuthenticatedE")]
        public string IsVideoAuthenticatedE { get; set; }

        [JsonPropertyName("videoURL")]
        public string VideoURL { get; set; }

        [JsonPropertyName("plotMortgage")]
        public object PlotMortgage { get; set; }

        [JsonPropertyName("plots")]
        public List<PlotDetailResponse> Plots { get; set; }

        [JsonPropertyName("releasePlots")]
        public List<object> ReleasePlots { get; set; }

        [JsonPropertyName("contracts")]
        public List<Contract> Contracts { get; set; }

        [JsonPropertyName("offPlanContracts")]
        public List<object> OffPlanContracts { get; set; }

        [JsonPropertyName("applicationPayments")]
        public List<object> ApplicationPayments { get; set; }

        [JsonPropertyName("isMortgageReleased")]
        public bool IsMortgageReleased { get; set; }

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