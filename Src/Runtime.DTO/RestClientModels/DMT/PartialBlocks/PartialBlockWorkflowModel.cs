using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.PartialBlocks
{
    public class PartialBlockWorkflowResponse

    {
        [JsonPropertyName("businessFlags")]
        public int? BusinessFlags { get; set; }

        [JsonPropertyName("descriptionA")]
        public string DescriptionA { get; set; }

        [JsonPropertyName("descriptionE")]
        public string DescriptionE { get; set; }

        [JsonPropertyName("displayStatusOnline")]
        public int DisplayStatusOnline { get; set; }

        [JsonPropertyName("dmtServiceCode")]
        public string DmtServiceCode { get; set; }

        [JsonPropertyName("elmsWorkflowConst")]
        public string ElmsWorkflowConst { get; set; }

        [JsonPropertyName("hasMultiEntityTypes")]
        public bool HasMultiEntityTypes { get; set; }

        [JsonPropertyName("isAcrossMunicipalities")]
        public bool? IsAcrossMunicipalities { get; set; }

        [JsonPropertyName("isAdres")]
        public bool IsAdres { get; set; }

        [JsonPropertyName("isDisplayedOnStartPage")]
        public bool IsDisplayedOnStartPage { get; set; }

        [JsonPropertyName("isNewUiActive")]
        public bool IsNewUiActive { get; set; }

        [JsonPropertyName("migNote")]
        public double? MigNote { get; set; }

        [JsonPropertyName("migNoteL")]
        public string MigNoteL { get; set; }

        [JsonPropertyName("migNoteLm")]
        public string MigNoteLm { get; set; }

        [JsonPropertyName("serviceTypeConst")]
        public string ServiceTypeConst { get; set; }

        [JsonPropertyName("workflowId")]
        public int WorkflowId { get; set; }

        [JsonPropertyName("workflowNameA")]
        public string WorkflowNameA { get; set; }

        [JsonPropertyName("workflowNameE")]
        public string WorkflowNameE { get; set; }

        [JsonPropertyName("workflowTypeId")]
        public int WorkflowTypeId { get; set; }

        [JsonPropertyName("hasZoneRestriction")]
        public bool HasZoneRestriction { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }
}