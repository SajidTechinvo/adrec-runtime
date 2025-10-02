using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.Common
{
    public class AcquisitionTypeResponse
    {
        [JsonPropertyName("descriptionA")]
        public string DescriptionA { get; set; }

        [JsonPropertyName("descriptionE")]
        public string DescriptionE { get; set; }

        [JsonPropertyName("elmsPlotTransactionTypeConst")]
        public string ElmsPlotTransactionTypeConst { get; set; }

        [JsonPropertyName("isvalid")]
        public int IsValid { get; set; }

        [JsonPropertyName("maptrn")]
        public string Maptrn { get; set; }

        [JsonPropertyName("migNote")]
        public double? MigNote { get; set; }

        [JsonPropertyName("migNoteL")]
        public string MigNoteL { get; set; }

        [JsonPropertyName("migNoteLm")]
        public string MigNoteLm { get; set; }

        [JsonPropertyName("plotTransactionTypeId")]
        public int PlotTransactionTypeId { get; set; }

        [JsonPropertyName("plotTransactionTypeNameA")]
        public string PlotTransactionTypeNameA { get; set; }

        [JsonPropertyName("plotTransactionTypeNameE")]
        public string PlotTransactionTypeNameE { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}