using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.Mortgage
{
    public class PlotMortgageTypeResponse
    {
        [JsonPropertyName("migNote")]
        public double? MigNote { get; set; }

        [JsonPropertyName("migNoteL")]
        public string MigNoteL { get; set; }

        [JsonPropertyName("migNoteLm")]
        public string MigNoteLm { get; set; }

        [JsonPropertyName("plotMortgageTypeConst")]
        public string PlotMortgageTypeConst { get; set; }

        [JsonPropertyName("plotMortgageTypeId")]
        public int PlotMortgageTypeId { get; set; }

        [JsonPropertyName("plotMortgageTypeNameA")]
        public string PlotMortgageTypeNameA { get; set; }

        [JsonPropertyName("plotMortgageTypeNameE")]
        public string PlotMortgageTypeNameE { get; set; }

        [JsonPropertyName("customPlotMortgageTypeId")]
        public int CustomPlotMortgageTypeId { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }
}