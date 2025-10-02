using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.Units
{
    public class UnitResponse
    {
        [JsonPropertyName("communityId")]
        public int CommunityId { get; set; }

        [JsonPropertyName("communityNumber")]
        public string CommunityNumber { get; set; }

        [JsonPropertyName("communityName")]
        public string CommunityName { get; set; }

        [JsonPropertyName("dimensionDescription")]
        public string DimensionDescription { get; set; }

        [JsonPropertyName("districtName")]
        public string DistrictName { get; set; }

        [JsonPropertyName("districtId")]
        public int DistrictId { get; set; }

        [JsonPropertyName("districtNumber")]
        public string DistrictNumber { get; set; }

        [JsonPropertyName("estimatedArea")]
        public double EstimatedArea { get; set; }

        [JsonPropertyName("hasBlock")]
        public bool HasBlock { get; set; }

        [JsonPropertyName("hasMortgage")]
        public bool HasMortgage { get; set; }

        [JsonPropertyName("landUseId")]
        public int LandUseId { get; set; }

        [JsonPropertyName("plotId")]
        public int PlotId { get; set; }

        [JsonPropertyName("plotNumber")]
        public string PlotNumber { get; set; }

        [JsonPropertyName("roadId")]
        public int RoadId { get; set; }

        [JsonPropertyName("roadName")]
        public string RoadName { get; set; }

        [JsonPropertyName("roadNumber")]
        public string RoadNumber { get; set; }

        [JsonPropertyName("unitBuildingNumber")]
        public string UnitBuildingNumber { get; set; }

        [JsonPropertyName("unitFloorNumber")]
        public string UnitFloorNumber { get; set; }

        [JsonPropertyName("unitNumber")]
        public string UnitNumber { get; set; }

        [JsonPropertyName("landUseName")]
        public string LandUseName { get; set; }

        [JsonPropertyName("municipalityName")]
        public string MunicipalityName { get; set; }

        [JsonPropertyName("municipalityId")]
        public int MunicipalityId { get; set; }
    }
}