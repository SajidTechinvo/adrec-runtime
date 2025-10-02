using System.Text.Json.Serialization;

namespace Runtime.DTO.ApiModels.DMTModel.ElmsServices
{
    public class RegisterEditPlotDetailRequest
    {
        [JsonPropertyName("plotId")]
        public long PlotId { get; set; }

        [JsonPropertyName("plotNumber")]
        public string PlotNumber { get; set; }

        [JsonPropertyName("plotTypeId")]
        public string PlotTypeId { get; set; }

        [JsonPropertyName("plotStatusId")]
        public string PlotStatusId { get; set; }

        [JsonPropertyName("plotCategoryId")]
        public string PlotCategoryId { get; set; }

        [JsonPropertyName("estimatedArea")]
        public string EstimatedArea { get; set; }

        [JsonPropertyName("areaUnitId")]
        public string AreaUnitId { get; set; }

        [JsonPropertyName("allocationTypeId")]
        public string AllocationTypeId { get; set; }

        [JsonPropertyName("landUseId")]
        public string LandUseId { get; set; }

        [JsonPropertyName("appraisalValueTypeId")]
        public string AppraisalValueTypeId { get; set; }

        [JsonPropertyName("archiveFileNumber")]
        public string ArchiveFileNumber { get; set; }

        [JsonPropertyName("constructionDate")]
        public string ConstructionDate { get; set; }

        [JsonPropertyName("isServiceCondition")]
        public string IsServiceCondition { get; set; }

        [JsonPropertyName("backOfficeResponse")]
        public string BackOfficeResponse { get; set; }
    }
}