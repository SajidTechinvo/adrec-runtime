using System.Text.Json.Serialization;

namespace Runtime.DTO.ApiModels.DMTModel.ElmsServices
{
    public class StartImportPlotRequest
    {
        [JsonPropertyName("tpdPlotId")]
        public long TpdPlotId { get; set; }

        [JsonPropertyName("municipalityId")]
        public string MunicipalityId { get; set; }
    }

    public class RegisterImportPlotRequest
    {
        [JsonPropertyName("estimatedArea")]
        public string EstimatedArea { get; set; }

        [JsonPropertyName("areaUnitId")]
        public string AreaUnitId { get; set; }

        [JsonPropertyName("plotAllocationTypeId")]
        public string PlotAllocationTypeId { get; set; }

        [JsonPropertyName("landUseId")]
        public string LandUseId { get; set; }

        [JsonPropertyName("appraisalValueTypeId")]
        public string AppraisalValueTypeId { get; set; }

        [JsonPropertyName("isServiceCondition")]
        public string IsServiceCondition { get; set; }

        [JsonPropertyName("backOfficeResponse")]
        public string BackOfficeResponse { get; set; }
    }
}