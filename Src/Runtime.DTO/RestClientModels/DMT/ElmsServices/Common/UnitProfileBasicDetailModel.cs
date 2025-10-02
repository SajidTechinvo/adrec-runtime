using ADREC.DTO.RestClientModels.DMT.Lookup;
using Runtime.DTO.RestClientModels.DMT.Lookup;
using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.ElmsServices.Common
{
    public class UnitProfileBasicDetailResponse
    {
        [JsonPropertyName("unitId")]
        public int UnitId { get; set; }

        [JsonPropertyName("unitFullAddressA")]
        public string UnitFullAddressA { get; set; }

        [JsonPropertyName("unitFullAddressE")]
        public string UnitFullAddressE { get; set; }

        [JsonPropertyName("unitFullDetails")]
        public string UnitFullDetails { get; set; }

        [JsonPropertyName("plotNumber")]
        public string PlotNumber { get; set; }

        [JsonPropertyName("buildingNumber")]
        public string BuildingNumber { get; set; }

        [JsonPropertyName("floorNumber")]
        public string FloorNumber { get; set; }

        [JsonPropertyName("unitNumber")]
        public string UnitNumber { get; set; }

        [JsonPropertyName("unitBuisinessFlags")]
        public int UnitBuisinessFlags { get; set; }

        [JsonPropertyName("municipality")]
        public MunicipalityResponse Municipality { get; set; }

        [JsonPropertyName("landAddress")]
        public object LandAddress { get; set; }

        [JsonPropertyName("district")]
        public DistrictResponse District { get; set; }

        [JsonPropertyName("community")]
        public CommunityResponse Community { get; set; }

        [JsonPropertyName("vwRoad")]
        public RoadResponse VwRoad { get; set; }

        [JsonPropertyName("blocks")]
        public List<BlockResponse> Blocks { get; set; }

        [JsonPropertyName("relatedApplications")]
        public List<RelatedApplicationResponse> RelatedApplications { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }

        [JsonPropertyName("bedRoomCount")]
        public int BedRoomCount { get; set; }

        [JsonPropertyName("bathRoomCount")]
        public int? BathRoomCount { get; set; }

        [JsonPropertyName("balconyCount")]
        public int? BalconyCount { get; set; }

        [JsonPropertyName("parkingCount")]
        public int? ParkingCount { get; set; }

        [JsonPropertyName("area")]
        public double Area { get; set; }
    }
}