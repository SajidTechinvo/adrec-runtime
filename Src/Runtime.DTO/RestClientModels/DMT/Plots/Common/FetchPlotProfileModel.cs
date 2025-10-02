using ADREC.DTO.RestClientModels.DMT.Lookup;
using Runtime.DTO.RestClientModels.DMT.Lookup;
using Runtime.DTO.RestClientModels.DMT.Mortgage;
using Runtime.DTO.RestClientModels.DMT.Owners;
using System.Text.Json.Serialization;

namespace ADREC.DTO.RestClientModels.DMT.Plots.Common
{
    public class PlotProfile
    {
        [JsonPropertyName("plotId")]
        public int PlotId { get; set; }

        [JsonPropertyName("municipality")]
        public MunicipalityResponse Municipality { get; set; }

        [JsonPropertyName("plotAddressA")]
        public string PlotAddressA { get; set; }

        [JsonPropertyName("plotAddressE")]
        public string PlotAddressE { get; set; }

        [JsonPropertyName("landAddress")]
        public string LandAddress { get; set; }

        [JsonPropertyName("plotAllocationType")]
        public PlotAllocationTypeResponse PlotAllocationType { get; set; }

        [JsonPropertyName("landUse")]
        public LandUsageResponse LandUse { get; set; }

        [JsonPropertyName("district")]
        public DistrictResponse District { get; set; }

        [JsonPropertyName("community")]
        public CommunityResponse Community { get; set; }

        [JsonPropertyName("vwRoad")]
        public RoadResponse VwRoad { get; set; }

        [JsonPropertyName("publicHouseClassification")]
        public object PublicHouseClassification { get; set; }

        [JsonPropertyName("unitUsageType")]
        public object UnitUsageType { get; set; }

        [JsonPropertyName("unitClassification")]
        public object UnitClassification { get; set; }

        [JsonPropertyName("plotAreaSquareMeterA")]
        public string PlotAreaSquareMeterA { get; set; }

        [JsonPropertyName("plotAreaSquareMeterE")]
        public string PlotAreaSquareMeterE { get; set; }

        [JsonPropertyName("plotAreaFeetA")]
        public string PlotAreaFeetA { get; set; }

        [JsonPropertyName("plotAreaFeetE")]
        public string PlotAreaFeetE { get; set; }

        [JsonPropertyName("calculatedDimensionMeter")]
        public object CalculatedDimensionMeter { get; set; }

        [JsonPropertyName("calculatedDimensionFoot")]
        public object CalculatedDimensionFoot { get; set; }

        [JsonPropertyName("plotNumber")]
        public string PlotNumber { get; set; }

        [JsonPropertyName("plotFileNumber")]
        public string PlotFileNumber { get; set; }

        [JsonPropertyName("showPlotStatus")]
        public bool ShowPlotStatus { get; set; }

        [JsonPropertyName("plotStatusA")]
        public object PlotStatusA { get; set; }

        [JsonPropertyName("plotStatusE")]
        public object PlotStatusE { get; set; }

        [JsonPropertyName("showPublicHouseNumber")]
        public bool ShowPublicHouseNumber { get; set; }

        [JsonPropertyName("publicHouseNumber")]
        public object PublicHouseNumber { get; set; }

        [JsonPropertyName("showPublicHouseClassification")]
        public bool ShowPublicHouseClassification { get; set; }

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

        [JsonPropertyName("isTemporary")]
        public bool IsTemporary { get; set; }

        [JsonPropertyName("serviceStatusA")]
        public string ServiceStatusA { get; set; }

        [JsonPropertyName("serviceStatusE")]
        public string ServiceStatusE { get; set; }

        [JsonPropertyName("constructionStatusA")]
        public string ConstructionStatusA { get; set; }

        [JsonPropertyName("constructionStatusE")]
        public string ConstructionStatusE { get; set; }

        [JsonPropertyName("constructionDate")]
        public object ConstructionDate { get; set; }

        [JsonPropertyName("joindLandUseName")]
        public object JoindLandUseName { get; set; }

        [JsonPropertyName("plotAxisStatusA")]
        public string PlotAxisStatusA { get; set; }

        [JsonPropertyName("plotAxisStatusE")]
        public string PlotAxisStatusE { get; set; }

        [JsonPropertyName("hasServiceCondition")]
        public bool HasServiceCondition { get; set; }

        [JsonPropertyName("dimensionMeter")]
        public object DimensionMeter { get; set; }

        [JsonPropertyName("dimensionFoot")]
        public object DimensionFoot { get; set; }

        [JsonPropertyName("legalRemarks")]
        public string LegalRemarks { get; set; }

        [JsonPropertyName("remarks")]
        public string Remarks { get; set; }

        [JsonPropertyName("hasExpatOwnershipPercentage")]
        public bool HasExpatOwnershipPercentage { get; set; }

        [JsonPropertyName("expatOwnershipPercentageA")]
        public string ExpatOwnershipPercentageA { get; set; }

        [JsonPropertyName("expatOwnershipPercentageE")]
        public string ExpatOwnershipPercentageE { get; set; }

        [JsonPropertyName("isInvestmentArea")]
        public bool IsInvestmentArea { get; set; }

        [JsonPropertyName("isInvestmentAreaNameA")]
        public string IsInvestmentAreaNameA { get; set; }

        [JsonPropertyName("isInvestmentAreaNameE")]
        public string IsInvestmentAreaNameE { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }

        [JsonPropertyName("plotInspStatusString")]
        public object PlotInspStatusString { get; set; }
    }

    public class PlotProfileBasicDetail
    {
        [JsonPropertyName("plotId")]
        public int PlotId { get; set; }

        [JsonPropertyName("plotAddressNameA")]
        public string PlotAddressNameA { get; set; }

        [JsonPropertyName("plotAddressNameE")]
        public string PlotAddressNameE { get; set; }

        [JsonPropertyName("plotBlocks")]
        public List<object> PlotBlocks { get; set; }

        [JsonPropertyName("relatedApplications")]
        public object RelatedApplications { get; set; }

        [JsonPropertyName("isInRandomAllotmentSet")]
        public bool IsInRandomAllotmentSet { get; set; }

        [JsonPropertyName("randomAllotmentSetNameA")]
        public object RandomAllotmentSetNameA { get; set; }

        [JsonPropertyName("randomAllotmentSetNameE")]
        public object RandomAllotmentSetNameE { get; set; }

        [JsonPropertyName("isInCommitteeMeeting")]
        public bool IsInCommitteeMeeting { get; set; }

        [JsonPropertyName("committeeMeetingNumber")]
        public object CommitteeMeetingNumber { get; set; }

        [JsonPropertyName("committeeMeetingDate")]
        public object CommitteeMeetingDate { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }

    public class FetchPlotProfileResponse
    {
        [JsonPropertyName("hasAccess")]
        public bool HasAccess { get; set; }

        [JsonPropertyName("plotProfileBasicDetail")]
        public PlotProfileBasicDetail PlotProfileBasicDetail { get; set; }

        [JsonPropertyName("sourceNameA")]
        public string SourceNameA { get; set; }

        [JsonPropertyName("sourceNameE")]
        public string SourceNameE { get; set; }

        [JsonPropertyName("plotTransactionTypeA")]
        public string PlotTransactionTypeA { get; set; }

        [JsonPropertyName("plotTransactionTypeE")]
        public string PlotTransactionTypeE { get; set; }

        [JsonPropertyName("decreeContractNameA")]
        public string DecreeContractNameA { get; set; }

        [JsonPropertyName("decreeContractNameE")]
        public string DecreeContractNameE { get; set; }

        [JsonPropertyName("plotTransactionDate")]
        public DateTime PlotTransactionDate { get; set; }

        [JsonPropertyName("plotTransactionApproveDate")]
        public DateTime PlotTransactionApproveDate { get; set; }

        [JsonPropertyName("hasAllotment")]
        public bool HasAllotment { get; set; }

        [JsonPropertyName("decreeFullDetailA")]
        public string DecreeFullDetailA { get; set; }

        [JsonPropertyName("decreeFullDetailE")]
        public string DecreeFullDetailE { get; set; }

        [JsonPropertyName("decreeNumber")]
        public string DecreeNumber { get; set; }

        [JsonPropertyName("plot")]
        public PlotProfile Plot { get; set; }

        [JsonPropertyName("plotOwners")]
        public List<PlotOwnerResponse> PlotOwners { get; set; }

        [JsonPropertyName("plotMortgages")]
        public List<PlotMortgage> PlotMortgages { get; set; }

        [JsonPropertyName("endowmentContracts")]
        public List<object> EndowmentContracts { get; set; }

        [JsonPropertyName("contracts")]
        public List<object> Contracts { get; set; }

        [JsonPropertyName("offPlanContracts")]
        public List<object> OffPlanContracts { get; set; }
    }
}