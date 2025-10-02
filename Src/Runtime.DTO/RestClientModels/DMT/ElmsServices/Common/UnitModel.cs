using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ADREC.DTO.RestClientModels.DMT.Lookup;
using Runtime.DTO.RestClientModels.DMT.Lookup;
using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.ElmsServices.Common
{
    public class UnitResponse
    {
        [JsonPropertyName("unitId")]
        public int UnitId { get; set; }

        [JsonPropertyName("landId")]
        public int LandId { get; set; }

        [JsonPropertyName("municipality")]
        public MunicipalityResponse Municipality { get; set; }

        [JsonPropertyName("landAddress")]
        public string LandAddress { get; set; }

        [JsonPropertyName("landUse")]
        public LandUsageResponse LandUse { get; set; }

        [JsonPropertyName("district")]
        public DistrictResponse District { get; set; }

        [JsonPropertyName("community")]
        public CommunityResponse Community { get; set; }

        [JsonPropertyName("vwRoad")]
        public RoadResponse VwRoad { get; set; }

        [JsonPropertyName("unitUsageType")]
        public UnitUsageTypeResponse UnitUsageType { get; set; }

        [JsonPropertyName("unitClassification")]
        public UnitClassificationResponse UnitClassification { get; set; }

        [JsonPropertyName("unitBusinessFlags")]
        public int UnitBusinessFlags { get; set; }

        [JsonPropertyName("plotNumber")]
        public string PlotNumber { get; set; }

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

        [JsonPropertyName("remarks")]
        public string Remarks { get; set; }

        [JsonPropertyName("buildingNumber")]
        public string BuildingNumber { get; set; }

        [JsonPropertyName("floorNumber")]
        public string FloorNumber { get; set; }

        [JsonPropertyName("unitNumber")]
        public string UnitNumber { get; set; }

        [JsonPropertyName("formatedUnitAddressA")]
        public object FormatedUnitAddressA { get; set; }

        [JsonPropertyName("formatedUnitAddressE")]
        public object FormatedUnitAddressE { get; set; }

        [JsonPropertyName("formatedUnitDetailsA")]
        public object FormatedUnitDetailsA { get; set; }

        [JsonPropertyName("formatedUnitDetailsE")]
        public object FormatedUnitDetailsE { get; set; }

        [JsonPropertyName("bedRoomCount")]
        public int? BedRoomCount { get; set; }

        [JsonPropertyName("bathRoomCount")]
        public int? BathRoomCount { get; set; }

        [JsonPropertyName("balconyCount")]
        public int? BalconyCount { get; set; }

        [JsonPropertyName("parkingCount")]
        public int ParkingCount { get; set; }

        [JsonPropertyName("unitArea")]
        public string UnitArea { get; set; }

        [JsonPropertyName("projectNameA")]
        public string ProjectNameA { get; set; }

        [JsonPropertyName("projectNameE")]
        public string ProjectNameE { get; set; }

        [JsonPropertyName("projectNumber")]
        public string ProjectNumber { get; set; }

        [JsonPropertyName("isBuildingComplete")]
        public bool IsBuildingComplete { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }

        [JsonPropertyName("plotChangeTypeA")]
        public string PlotChangeTypeA { get; set; }

        [JsonPropertyName("plotChangeTypeE")]
        public string PlotChangeTypeE { get; set; }
    }
}