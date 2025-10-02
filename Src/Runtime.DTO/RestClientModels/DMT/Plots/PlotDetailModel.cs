using ADREC.DTO.RestClientModels.DMT.Lookup;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.Common;
using Runtime.DTO.RestClientModels.DMT.Lookup;
using System.Text.Json.Serialization;

namespace ADREC.DTO.RestClientModels.DMT.Plots
{
    public class PlotDetailResponse
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
        public int? AuditByUserId { get; set; }

        [JsonPropertyName("auditDate")]
        public DateTime? AuditDate { get; set; }

        [JsonPropertyName("auditFlags")]
        public int AuditFlags { get; set; }

        [JsonPropertyName("buildingBusinessFlags")]
        public object BuildingBusinessFlags { get; set; }

        [JsonPropertyName("buildingClassificationId")]
        public int? BuildingClassificationId { get; set; }

        [JsonPropertyName("buildingComments")]
        public string BuildingComments { get; set; }

        [JsonPropertyName("buildingElectricPremiseNum")]
        public string BuildingElectricPremiseNum { get; set; }

        [JsonPropertyName("buildingFloorsCount")]
        public int? BuildingFloorsCount { get; set; }

        [JsonPropertyName("buildingGisId")]
        public int? BuildingGisId { get; set; }

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
        public DateTime? ConstructionDate { get; set; }

        [JsonPropertyName("constructionStatus")]
        public int? ConstructionStatus { get; set; }

        [JsonPropertyName("datePlacedInService")]
        public object DatePlacedInService { get; set; }

        [JsonPropertyName("decreeId")]
        public int? DecreeId { get; set; }

        [JsonPropertyName("dimensionDescription")]
        public string DimensionDescription { get; set; }

        [JsonPropertyName("estimatedArea")]
        public double EstimatedArea { get; set; }

        [JsonPropertyName("flatNumber")]
        public string FlatNumber { get; set; }

        [JsonPropertyName("floorGisId")]
        public int? FloorGisId { get; set; }

        [JsonPropertyName("floorHeight")]
        public double? FloorHeight { get; set; }

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
        public int? Oldtpdplotid { get; set; }

        [JsonPropertyName("parentBuildingId")]
        public int? ParentBuildingId { get; set; }

        [JsonPropertyName("parentFloorId")]
        public int? ParentFloorId { get; set; }

        [JsonPropertyName("parentPlotId")]
        public int? ParentPlotId { get; set; }

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
        public int? TpdPlotId { get; set; }

        [JsonPropertyName("unitArchiveNumber")]
        public int? UnitArchiveNumber { get; set; }

        [JsonPropertyName("unitArea")]
        public double? UnitArea { get; set; }

        [JsonPropertyName("unitAuditFlags")]
        public int? UnitAuditFlags { get; set; }

        [JsonPropertyName("unitBalconyArea")]
        public double? UnitBalconyArea { get; set; }

        [JsonPropertyName("unitBalconyCount")]
        public object UnitBalconyCount { get; set; }

        [JsonPropertyName("unitBathroomCount")]
        public int? UnitBathroomCount { get; set; }

        [JsonPropertyName("unitBedroomCount")]
        public int? UnitBedroomCount { get; set; }

        [JsonPropertyName("unitBusinessFlags")]
        public int? UnitBusinessFlags { get; set; }

        [JsonPropertyName("unitClassificationId")]
        public int? UnitClassificationId { get; set; }

        [JsonPropertyName("unitComments")]
        public string UnitComments { get; set; }

        [JsonPropertyName("unitElectricPremiseNum")]
        public string UnitElectricPremiseNum { get; set; }

        [JsonPropertyName("unitGisId")]
        public int? UnitGisId { get; set; }

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
        public int? UnitUsageTypeId { get; set; }

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
        public object Owners { get; set; }

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
        public double? TotalPercentOwnership { get; set; }

        [JsonPropertyName("totalPercentOwnershipString")]
        public object TotalPercentOwnershipString { get; set; }

        [JsonPropertyName("priority")]
        public int Priority { get; set; }

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
}