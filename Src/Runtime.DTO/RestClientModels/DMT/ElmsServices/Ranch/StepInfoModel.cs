using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ADREC.DTO.RestClientModels.DMT.Lookup;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.Common;
using Runtime.DTO.RestClientModels.DMT.ElmsTenancy;
using Runtime.DTO.RestClientModels.DMT.Lookup;
using Runtime.DTO.RestClientModels.DMT.Owners;
using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.ElmsServices.Ranch
{
    public class FamilyStatus
    {
        [JsonPropertyName("familyStatusId")]
        public int FamilyStatusId { get; set; }

        [JsonPropertyName("familyStatusNameA")]
        public string FamilyStatusNameA { get; set; }

        [JsonPropertyName("familyStatusNameE")]
        public string FamilyStatusNameE { get; set; }

        [JsonPropertyName("migNote")]
        public double MigNote { get; set; }

        [JsonPropertyName("migNoteL")]
        public string MigNoteL { get; set; }

        [JsonPropertyName("migNoteLm")]
        public string MigNoteLm { get; set; }

        [JsonPropertyName("sortOrder")]
        public double SortOrder { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }

    public class MaritalStatus
    {
        [JsonPropertyName("maritalStatusId")]
        public int MaritalStatusId { get; set; }

        [JsonPropertyName("maritalStatusNameA")]
        public string MaritalStatusNameA { get; set; }

        [JsonPropertyName("maritalStatusNameE")]
        public string MaritalStatusNameE { get; set; }

        [JsonPropertyName("migNote")]
        public double MigNote { get; set; }

        [JsonPropertyName("migNoteL")]
        public string MigNoteL { get; set; }

        [JsonPropertyName("migNoteLm")]
        public string MigNoteLm { get; set; }

        [JsonPropertyName("moiId")]
        public int MoiId { get; set; }

        [JsonPropertyName("sortOrder")]
        public double SortOrder { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }

    public class RanchResponse
    {
        [JsonPropertyName("municipality")]
        public MunicipalityResponse Municipality { get; set; }

        [JsonPropertyName("alreadyAllottedRanches")]
        public List<object> AlreadyAllottedRanches { get; set; }

        [JsonPropertyName("ownersList")]
        public List<OwnerListResponse> OwnersList { get; set; }

        [JsonPropertyName("selectedPlot")]
        public SelectedPlot SelectedPlot { get; set; }

        [JsonPropertyName("tenancyContract")]
        public TenancyContractResponse TenancyContract { get; set; }

        [JsonPropertyName("applicationPayment")]
        public object ApplicationPayment { get; set; }

        [JsonPropertyName("smsNotificationsList")]
        public List<object> SmsNotificationsList { get; set; }

        [JsonPropertyName("rentPayment")]
        public object RentPayment { get; set; }

        [JsonPropertyName("isAuthorizedOwner")]
        public bool IsAuthorizedOwner { get; set; }

        [JsonPropertyName("requestLandClassification")]
        public string RequestLandClassification { get; set; }

        [JsonPropertyName("ranchAllotmentRequestType")]
        public string RanchAllotmentRequestType { get; set; }

        [JsonPropertyName("requestorIncome")]
        public object RequestorIncome { get; set; }

        [JsonPropertyName("requestorFamilyCount")]
        public object RequestorFamilyCount { get; set; }

        [JsonPropertyName("requestedRanchCamelCount")]
        public int? RequestedRanchCamelCount { get; set; }

        [JsonPropertyName("requestedRanchCowCount")]
        public int? RequestedRanchCowCount { get; set; }

        [JsonPropertyName("requestedRanchSheepCount")]
        public int? RequestedRanchSheepCount { get; set; }

        [JsonPropertyName("isSocialCase")]
        public int? IsSocialCase { get; set; }

        [JsonPropertyName("baseMunicipalityId")]
        public int? BaseMunicipalityId { get; set; }

        [JsonPropertyName("requestLandClassificationId")]
        public int? RequestLandClassificationId { get; set; }

        [JsonPropertyName("ranchInsuranceFee")]
        public double RanchInsuranceFee { get; set; }

        [JsonPropertyName("ranchInsuranceFeeInWord")]
        public string RanchInsuranceFeeInWord { get; set; }

        [JsonPropertyName("ranchTenancyRegistrationFee")]
        public double RanchTenancyRegistrationFee { get; set; }

        [JsonPropertyName("ranchTenancyRegistrationFeeInWord")]
        public string RanchTenancyRegistrationFeeInWord { get; set; }

        [JsonPropertyName("randomAllotmentSet")]
        public bool RandomAllotmentSet { get; set; }

        [JsonPropertyName("isStartedOnline")]
        public bool IsStartedOnline { get; set; }

        [JsonPropertyName("isSeasonalRanch")]
        public bool IsSeasonalRanch { get; set; }

        [JsonPropertyName("isSweihanRanch")]
        public bool IsSweihanRanch { get; set; }

        [JsonPropertyName("requestTypeId")]
        public int? RequestTypeId { get; set; }

        [JsonPropertyName("isApplicationOnHold")]
        public bool IsApplicationOnHold { get; set; }

        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("workflowId")]
        public int? WorkflowId { get; set; }

        [JsonPropertyName("workflowStepId")]
        public int? WorkflowStepId { get; set; }

        [JsonPropertyName("workflowConst")]
        public string WorkflowConst { get; set; }

        [JsonPropertyName("workflowNameA")]
        public string WorkflowNameA { get; set; }

        [JsonPropertyName("workflowNameE")]
        public string WorkflowNameE { get; set; }

        [JsonPropertyName("workflowTypeId")]
        public int? WorkflowTypeId { get; set; }

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
        public int? AppVersionNumber { get; set; }

        [JsonPropertyName("workflowStatusConst")]
        public string WorkflowStatusConst { get; set; }

        [JsonPropertyName("workflowOnlineViewPath")]
        public object WorkflowOnlineViewPath { get; set; }

        [JsonPropertyName("workflowBackOfficeViewPath")]
        public object WorkflowBackOfficeViewPath { get; set; }

        [JsonPropertyName("startDate")]
        public DateTime StartDate { get; set; }

        [JsonPropertyName("changeDraftStatusDate")]
        public DateTime? ChangeDraftStatusDate { get; set; }

        [JsonPropertyName("assignedCustomerNameA")]
        public object AssignedCustomerNameA { get; set; }

        [JsonPropertyName("assignedCustomerNameE")]
        public object AssignedCustomerNameE { get; set; }

        [JsonPropertyName("assignedCustomerEmail")]
        public object AssignedCustomerEmail { get; set; }

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
        public string BackOfficeResponse { get; set; }

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

    public class SelectedPlot
    {
        [JsonPropertyName("accessGroups")]
        public object AccessGroups { get; set; }

        [JsonPropertyName("activePtId")]
        public int? ActivePtId { get; set; }

        [JsonPropertyName("appraisalValueTypeId")]
        public int? AppraisalValueTypeId { get; set; }

        [JsonPropertyName("archiveFileNumber")]
        public string ArchiveFileNumber { get; set; }

        [JsonPropertyName("auditByUserId")]
        public object AuditByUserId { get; set; }

        [JsonPropertyName("auditDate")]
        public object AuditDate { get; set; }

        [JsonPropertyName("auditFlags")]
        public int? AuditFlags { get; set; }

        [JsonPropertyName("buildingBusinessFlags")]
        public object BuildingBusinessFlags { get; set; }

        [JsonPropertyName("buildingClassificationId")]
        public object BuildingClassificationId { get; set; }

        [JsonPropertyName("buildingComments")]
        public string BuildingComments { get; set; }

        [JsonPropertyName("buildingElectricPremiseNum")]
        public string BuildingElectricPremiseNum { get; set; }

        [JsonPropertyName("buildingFloorsCount")]
        public object BuildingFloorsCount { get; set; }

        [JsonPropertyName("buildingGisId")]
        public object BuildingGisId { get; set; }

        [JsonPropertyName("buildingLegalRemarks")]
        public string BuildingLegalRemarks { get; set; }

        [JsonPropertyName("buildingNameA")]
        public string BuildingNameA { get; set; }

        [JsonPropertyName("buildingNameE")]
        public string BuildingNameE { get; set; }

        [JsonPropertyName("buildingNumber")]
        public string BuildingNumber { get; set; }

        [JsonPropertyName("buildingRegNum")]
        public string BuildingRegNum { get; set; }

        [JsonPropertyName("buildingUnitsCount")]
        public object BuildingUnitsCount { get; set; }

        [JsonPropertyName("buildingUsageTypeId")]
        public object BuildingUsageTypeId { get; set; }

        [JsonPropertyName("buisinessFlags")]
        public int? BuisinessFlags { get; set; }

        [JsonPropertyName("calculatedDimensionFoot")]
        public string CalculatedDimensionFoot { get; set; }

        [JsonPropertyName("calculatedDimensionMeter")]
        public string CalculatedDimensionMeter { get; set; }

        [JsonPropertyName("communityId")]
        public int? CommunityId { get; set; }

        [JsonPropertyName("constructionDate")]
        public object ConstructionDate { get; set; }

        [JsonPropertyName("constructionStatus")]
        public int? ConstructionStatus { get; set; }

        [JsonPropertyName("datePlacedInService")]
        public object DatePlacedInService { get; set; }

        [JsonPropertyName("decreeId")]
        public object DecreeId { get; set; }

        [JsonPropertyName("dimensionDescription")]
        public string DimensionDescription { get; set; }

        [JsonPropertyName("estimatedArea")]
        public double EstimatedArea { get; set; }

        [JsonPropertyName("flatNumber")]
        public string FlatNumber { get; set; }

        [JsonPropertyName("floorGisId")]
        public object FloorGisId { get; set; }

        [JsonPropertyName("floorHeight")]
        public object FloorHeight { get; set; }

        [JsonPropertyName("floorNumber")]
        public string FloorNumber { get; set; }

        [JsonPropertyName("hasSingleUnit")]
        public object HasSingleUnit { get; set; }

        [JsonPropertyName("investmentAreaId")]
        public object InvestmentAreaId { get; set; }

        [JsonPropertyName("isAuditApproved")]
        public int? IsAuditApproved { get; set; }

        [JsonPropertyName("isBuildingComplete")]
        public object IsBuildingComplete { get; set; }

        [JsonPropertyName("isPlotOffPlan")]
        public object IsPlotOffPlan { get; set; }

        [JsonPropertyName("isSquareMeters")]
        public int? IsSquareMeters { get; set; }

        [JsonPropertyName("isTemporaryPlot")]
        public int? IsTemporaryPlot { get; set; }

        [JsonPropertyName("isTradable")]
        public int? IsTradable { get; set; }

        [JsonPropertyName("landAddress")]
        public string LandAddress { get; set; }

        [JsonPropertyName("landUid")]
        public string LandUid { get; set; }

        [JsonPropertyName("landuseClassificationId")]
        public object LanduseClassificationId { get; set; }

        [JsonPropertyName("landuseId")]
        public int? LanduseId { get; set; }

        [JsonPropertyName("legalRemarks")]
        public string LegalRemarks { get; set; }

        [JsonPropertyName("migNote")]
        public object MigNote { get; set; }

        [JsonPropertyName("municipalityId")]
        public int? MunicipalityId { get; set; }

        [JsonPropertyName("mussatahaContractEndDate")]
        public object MussatahaContractEndDate { get; set; }

        [JsonPropertyName("oldtpdplotid")]
        public object Oldtpdplotid { get; set; }

        [JsonPropertyName("parentBuildingId")]
        public object ParentBuildingId { get; set; }

        [JsonPropertyName("parentFloorId")]
        public object ParentFloorId { get; set; }

        [JsonPropertyName("parentPlotId")]
        public object ParentPlotId { get; set; }

        [JsonPropertyName("parentUnitId")]
        public object ParentUnitId { get; set; }

        [JsonPropertyName("perimeterDescription")]
        public string PerimeterDescription { get; set; }

        [JsonPropertyName("plotAllocationTypeId")]
        public int? PlotAllocationTypeId { get; set; }

        [JsonPropertyName("plotAuditStatus")]
        public int? PlotAuditStatus { get; set; }

        [JsonPropertyName("plotClassificationId")]
        public int? PlotClassificationId { get; set; }

        [JsonPropertyName("plotExtensionExpectedDate")]
        public object PlotExtensionExpectedDate { get; set; }

        [JsonPropertyName("plotExtensionStatus")]
        public object PlotExtensionStatus { get; set; }

        [JsonPropertyName("plotExtensionTypeFlags")]
        public object PlotExtensionTypeFlags { get; set; }

        [JsonPropertyName("plotGeometry")]
        public string PlotGeometry { get; set; }

        [JsonPropertyName("plotId")]
        public int? PlotId { get; set; }

        [JsonPropertyName("plotInspStatusId")]
        public object PlotInspStatusId { get; set; }

        [JsonPropertyName("plotNumber")]
        public string PlotNumber { get; set; }

        [JsonPropertyName("plotOriginTypeId")]
        public int? PlotOriginTypeId { get; set; }

        [JsonPropertyName("propertyCode")]
        public string PropertyCode { get; set; }

        [JsonPropertyName("propertyConstructionDate")]
        public object PropertyConstructionDate { get; set; }

        [JsonPropertyName("propertyType")]
        public int? PropertyType { get; set; }

        [JsonPropertyName("propertyUsefulLife")]
        public string PropertyUsefulLife { get; set; }

        [JsonPropertyName("publicHouseClassificationId")]
        public object PublicHouseClassificationId { get; set; }

        [JsonPropertyName("publicHouseNumber")]
        public string PublicHouseNumber { get; set; }

        [JsonPropertyName("remarks")]
        public string Remarks { get; set; }

        [JsonPropertyName("roadId")]
        public int? RoadId { get; set; }

        [JsonPropertyName("serviceStatus")]
        public int? ServiceStatus { get; set; }

        [JsonPropertyName("tempTpdPlotId")]
        public object TempTpdPlotId { get; set; }

        [JsonPropertyName("tpdPlotId")]
        public object TpdPlotId { get; set; }

        [JsonPropertyName("unitArchiveNumber")]
        public object UnitArchiveNumber { get; set; }

        [JsonPropertyName("unitArea")]
        public object UnitArea { get; set; }

        [JsonPropertyName("unitAuditFlags")]
        public int? UnitAuditFlags { get; set; }

        [JsonPropertyName("unitBalconyArea")]
        public object UnitBalconyArea { get; set; }

        [JsonPropertyName("unitBalconyCount")]
        public object UnitBalconyCount { get; set; }

        [JsonPropertyName("unitBathroomCount")]
        public object UnitBathroomCount { get; set; }

        [JsonPropertyName("unitBedroomCount")]
        public object UnitBedroomCount { get; set; }

        [JsonPropertyName("unitBusinessFlags")]
        public int? UnitBusinessFlags { get; set; }

        [JsonPropertyName("unitClassificationId")]
        public object UnitClassificationId { get; set; }

        [JsonPropertyName("unitComments")]
        public string UnitComments { get; set; }

        [JsonPropertyName("unitElectricPremiseNum")]
        public string UnitElectricPremiseNum { get; set; }

        [JsonPropertyName("unitGisId")]
        public object UnitGisId { get; set; }

        [JsonPropertyName("unitLegalRemarks")]
        public string UnitLegalRemarks { get; set; }

        [JsonPropertyName("unitNumber")]
        public string UnitNumber { get; set; }

        [JsonPropertyName("unitParkingCount")]
        public object UnitParkingCount { get; set; }

        [JsonPropertyName("unitPublicAndServiceArea")]
        public object UnitPublicAndServiceArea { get; set; }

        [JsonPropertyName("unitReferenceNumber")]
        public string UnitReferenceNumber { get; set; }

        [JsonPropertyName("unitRegNum")]
        public string UnitRegNum { get; set; }

        [JsonPropertyName("unitUsageTypeId")]
        public object UnitUsageTypeId { get; set; }

        [JsonPropertyName("utm")]
        public string Utm { get; set; }

        [JsonPropertyName("utmZoneId")]
        public string UtmZoneId { get; set; }

        [JsonPropertyName("landUse")]
        public LandUsageResponse LandUse { get; set; }

        [JsonPropertyName("municipality")]
        public MunicipalityResponse Municipality { get; set; }

        [JsonPropertyName("community")]
        public CommunityResponse Community { get; set; }

        [JsonPropertyName("district")]
        public DistrictResponse District { get; set; }

        [JsonPropertyName("vwRoad")]
        public RoadResponse VwRoad { get; set; }

        [JsonPropertyName("publicHouseClassification")]
        public object PublicHouseClassification { get; set; }

        [JsonPropertyName("plotAllocationType")]
        public object PlotAllocationType { get; set; }

        [JsonPropertyName("unitUsageType")]
        public object UnitUsageType { get; set; }

        [JsonPropertyName("unitClassification")]
        public UnitClassificationResponse UnitClassification { get; set; }

        [JsonPropertyName("plotShares")]
        public List<PlotShareResponse> PlotShares { get; set; }

        [JsonPropertyName("owners")]
        public List<PlotOwnerResponse> Owners { get; set; }

        [JsonPropertyName("plotAreaFeet")]
        public string PlotAreaFeet { get; set; }

        [JsonPropertyName("plotStatus")]
        public string PlotStatus { get; set; }

        [JsonPropertyName("plotAddress")]
        public string PlotAddress { get; set; }

        [JsonPropertyName("plotAreaSquareMeter")]
        public string PlotAreaSquareMeter { get; set; }

        [JsonPropertyName("serviceStatusName")]
        public string ServiceStatusName { get; set; }

        [JsonPropertyName("constructionStatusName")]
        public string ConstructionStatusName { get; set; }

        [JsonPropertyName("totalPercentOwnership")]
        public double TotalPercentOwnership { get; set; }

        [JsonPropertyName("totalPercentOwnershipString")]
        public object TotalPercentOwnershipString { get; set; }

        [JsonPropertyName("priority")]
        public int? Priority { get; set; }

        [JsonPropertyName("formatedFloorNumberA")]
        public object FormatedFloorNumberA { get; set; }

        [JsonPropertyName("formatedFloorNumberE")]
        public object FormatedFloorNumberE { get; set; }

        [JsonPropertyName("formatedUnitAddressA")]
        public object FormatedUnitAddressA { get; set; }

        [JsonPropertyName("formatedUnitAddressE")]
        public object FormatedUnitAddressE { get; set; }

        [JsonPropertyName("formatUnitDetailsA")]
        public object FormatUnitDetailsA { get; set; }

        [JsonPropertyName("formatUnitDetailsE")]
        public object FormatUnitDetailsE { get; set; }

        [JsonPropertyName("formatUnitArea")]
        public object FormatUnitArea { get; set; }

        [JsonPropertyName("isGISAudited")]
        public bool IsGISAudited { get; set; }

        [JsonPropertyName("isOwnershipAudited")]
        public bool IsOwnershipAudited { get; set; }

        [JsonPropertyName("isOwnershipDeedAudited")]
        public bool IsOwnershipDeedAudited { get; set; }

        [JsonPropertyName("isHistoryOwnershipAudited")]
        public bool IsHistoryOwnershipAudited { get; set; }

        [JsonPropertyName("isMortgageAudited")]
        public bool IsMortgageAudited { get; set; }

        [JsonPropertyName("isDecreeAudited")]
        public bool IsDecreeAudited { get; set; }

        [JsonPropertyName("projectNumber")]
        public object ProjectNumber { get; set; }

        [JsonPropertyName("projectNameA")]
        public object ProjectNameA { get; set; }

        [JsonPropertyName("projectNameE")]
        public object ProjectNameE { get; set; }

        [JsonPropertyName("constructionStatusA")]
        public object ConstructionStatusA { get; set; }

        [JsonPropertyName("constructionStatusE")]
        public object ConstructionStatusE { get; set; }

        [JsonPropertyName("serviceStatusA")]
        public object ServiceStatusA { get; set; }

        [JsonPropertyName("serviceStatusE")]
        public object ServiceStatusE { get; set; }

        [JsonPropertyName("plotAddressA")]
        public object PlotAddressA { get; set; }

        [JsonPropertyName("plotAddressE")]
        public object PlotAddressE { get; set; }

        [JsonPropertyName("plotAreaFeetA")]
        public object PlotAreaFeetA { get; set; }

        [JsonPropertyName("plotAreaFeetE")]
        public object PlotAreaFeetE { get; set; }

        [JsonPropertyName("plotAreaSquareMeterA")]
        public object PlotAreaSquareMeterA { get; set; }

        [JsonPropertyName("plotAreaSquareMeterE")]
        public object PlotAreaSquareMeterE { get; set; }

        [JsonPropertyName("plotFileNumber")]
        public object PlotFileNumber { get; set; }

        [JsonPropertyName("ownerUrlArgs")]
        public object OwnerUrlArgs { get; set; }

        [JsonPropertyName("plotUrlArgs")]
        public object PlotUrlArgs { get; set; }

        [JsonPropertyName("isRanch")]
        public bool IsRanch { get; set; }

        [JsonPropertyName("plotBlocks")]
        public List<object> PlotBlocks { get; set; }

        [JsonPropertyName("mortgageOwnerIds")]
        public object MortgageOwnerIds { get; set; }

        [JsonPropertyName("plotComments")]
        public List<object> PlotComments { get; set; }

        [JsonPropertyName("hasBlock")]
        public bool HasBlock { get; set; }

        [JsonPropertyName("hasMortgage")]
        public bool HasMortgage { get; set; }

        [JsonPropertyName("unitFullDetails")]
        public object UnitFullDetails { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }

    public class LandClassificationResponse
    {
        [JsonPropertyName("elmsLandClassificationConst")]
        public string ElmsLandClassificationConst { get; set; }

        [JsonPropertyName("landClassificationId")]
        public int? LandClassificationId { get; set; }

        [JsonPropertyName("nameA")]
        public string NameA { get; set; }

        [JsonPropertyName("nameE")]
        public string NameE { get; set; }

        [JsonPropertyName("parentLandClassificationId")]
        public int? ParentLandClassificationId { get; set; }

        [JsonPropertyName("isSweihanRanch")]
        public bool IsSweihanRanch { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}