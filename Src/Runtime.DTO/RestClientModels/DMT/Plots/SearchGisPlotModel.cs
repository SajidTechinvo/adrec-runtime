using System.Text.Json.Serialization;

namespace ADREC.DTO.RestClientModels.DMT.Plots
{
    public class PlotResponse
    {
        [JsonPropertyName("zone")]
        public string Zone { get; set; }

        [JsonPropertyName("sector")]
        public string Sector { get; set; }

        [JsonPropertyName("plotNumber")]
        public string PlotNumber { get; set; }

        [JsonPropertyName("road")]
        public string Road { get; set; }

        [JsonPropertyName("area")]
        public double Area { get; set; }

        [JsonPropertyName("dimensions")]
        public string Dimensions { get; set; }

        [JsonPropertyName("municipalityId")]
        public int MunicipalityId { get; set; }

        [JsonPropertyName("plotId")]
        public int PlotId { get; set; }
    }
}