using System.Text.Json.Serialization;

namespace Runtime.DTO.ApiModels.DMTModel
{
    public class FetchUnitRequest
    {
        [JsonPropertyName("requestId")]
        public int RequestId { get; set; }

        [JsonPropertyName("createUrlArgs")]
        public string CreateUrlArgs { get; set; }

        [JsonPropertyName("municipalityId")]
        public string MunicipalityId { get; set; }

        [JsonPropertyName("districtId")]
        public string DistrictId { get; set; }

        [JsonPropertyName("communityId")]
        public string CommunityId { get; set; }

        [JsonPropertyName("roadId")]
        public string RoadId { get; set; }

        [JsonPropertyName("plotNumber")]
        public string PlotNumber { get; set; }

        [JsonPropertyName("landuseId")]
        public string LandUseId { get; set; }

        [JsonPropertyName("buildingNumber")]
        public string BuildingNumber { get; set; }

        [JsonPropertyName("flourNumber")]
        public string FlourNumber { get; set; }

        [JsonPropertyName("unitNumber")]
        public string UnitNumber { get; set; }

        [JsonPropertyName("unitClassificationId")]
        public string UnitClassificationId { get; set; }

        [JsonPropertyName("matchTypeId")]
        public string MatchTypeId { get; set; }

        [JsonPropertyName("pageSize")]
        public int PageSize { get; set; }

        [JsonPropertyName("searchPlotFlags")]
        public string SearchPlotFlags { get; set; }

        [JsonPropertyName("searchOwnerFlags")]
        public string SearchOwnerFlags { get; set; }

        [JsonPropertyName("ownerId")]
        public string OwnerId { get; set; }

        [JsonPropertyName("pageNumber")]
        public int PageNumber { get; set; }

        [JsonPropertyName("totalCount")]
        public int TotalCount { get; set; }
    }
}