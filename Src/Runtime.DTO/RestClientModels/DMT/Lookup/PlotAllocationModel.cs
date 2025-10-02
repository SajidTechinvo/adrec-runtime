using System.Text.Json.Serialization;

namespace ADREC.DTO.RestClientModels.DMT.Lookup
{
    public class PlotAllocationTypeResponse
    {
        [JsonPropertyName("elmsPlotAllocationTypeConst")]
        public string ElmsPlotAllocationTypeConst { get; set; }

        [JsonPropertyName("plotAllocationTypeId")]
        public int PlotAllocationTypeId { get; set; }

        [JsonPropertyName("plotAllocationTypeNameA")]
        public string PlotAllocationTypeNameA { get; set; }

        [JsonPropertyName("plotAllocationTypeNameE")]
        public string PlotAllocationTypeNameE { get; set; }

        [JsonPropertyName("updateByDate")]
        public DateTime UpdateByDate { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}