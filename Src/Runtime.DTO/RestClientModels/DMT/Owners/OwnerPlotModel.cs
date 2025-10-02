using ADREC.DTO.RestClientModels.DMT.Plots;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.Common;
using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.Owners
{
    public class OwnerProfileBasicDetail
    {
        [JsonPropertyName("ownerId")]
        public int OwnerId { get; set; }

        [JsonPropertyName("ownerNameA")]
        public string OwnerNameA { get; set; }

        [JsonPropertyName("ownerNameE")]
        public string OwnerNameE { get; set; }

        [JsonPropertyName("ownerComments")]
        public string OwnerComments { get; set; }

        [JsonPropertyName("ownerBlocks")]
        public object OwnerBlocks { get; set; }

        [JsonPropertyName("relatedApplications")]
        public List<RelatedApplicationResponse> RelatedApplications { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }

    public class OwnerPlotResponse
    {
        [JsonPropertyName("hasAccess")]
        public bool HasAccess { get; set; }

        [JsonPropertyName("ownerProfileBasicDetail")]
        public OwnerProfileBasicDetail OwnerProfileBasicDetail { get; set; }

        [JsonPropertyName("ownerPlots")]
        public List<PlotDetailResponse> OwnerPlots { get; set; }

        [JsonPropertyName("contracts")]
        public object Contracts { get; set; }

        [JsonPropertyName("offPlanContracts")]
        public List<object> OffPlanContracts { get; set; }
    }
}