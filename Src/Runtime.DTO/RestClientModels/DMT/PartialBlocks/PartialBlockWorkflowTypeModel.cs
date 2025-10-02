using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.PartialBlocks
{
    public class PartialBlockWorkflowTypeResponse
    {
        [JsonPropertyName("descriptionA")]
        public string DescriptionA { get; set; }

        [JsonPropertyName("descriptionE")]
        public string DescriptionE { get; set; }

        [JsonPropertyName("elmsWorkflowTypeConst")]
        public string ElmsWorkflowTypeConst { get; set; }

        [JsonPropertyName("migNote")]
        public double? MigNote { get; set; }

        [JsonPropertyName("migNoteL")]
        public string MigNoteL { get; set; }

        [JsonPropertyName("migNoteLm")]
        public string MigNoteLm { get; set; }

        [JsonPropertyName("workflowTypeId")]
        public int WorkflowTypeId { get; set; }

        [JsonPropertyName("workflowTypeNameA")]
        public string WorkflowTypeNameA { get; set; }

        [JsonPropertyName("workflowTypeNameE")]
        public string WorkflowTypeNameE { get; set; }

        [JsonPropertyName("workflows")]
        public object Workflows { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}