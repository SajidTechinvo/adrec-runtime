using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.PartialBlocks
{
    public class AddPartialBlockTxnWorkflowResponse
    {
        [JsonPropertyName("blockChangeType")]
        public object BlockChangeType { get; set; }

        [JsonPropertyName("businessEntBlkTxnWrkflwId")]
        public object BusinessEntBlkTxnWrkflwId { get; set; }

        [JsonPropertyName("businessEntityBlockId")]
        public object BusinessEntityBlockId { get; set; }

        [JsonPropertyName("businessEntityBlockTxnId")]
        public int BusinessEntityBlockTxnId { get; set; }

        [JsonPropertyName("remarks")]
        public string Remarks { get; set; }

        [JsonPropertyName("workflowId")]
        public int WorkflowId { get; set; }

        [JsonPropertyName("workflowNameA")]
        public string WorkflowNameA { get; set; }

        [JsonPropertyName("workflowNameE")]
        public string WorkflowNameE { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }
}