using Runtime.DTO.RestClientModels.DMT.ElmsServices.Common;
using Runtime.DTO.RestClientModels.DMT.Owners;
using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.Units
{
    public class UnitDetailResponse
    {
        [JsonPropertyName("hasAccess")]
        public bool HasAccess { get; set; }

        [JsonPropertyName("unitProfileBasicDetail")]
        public UnitProfileBasicDetailResponse UnitProfileBasicDetail { get; set; }

        [JsonPropertyName("unit")]
        public UnitResponse Unit { get; set; }

        [JsonPropertyName("owners")]
        public List<PlotOwnerResponse> Owners { get; set; }

        [JsonPropertyName("mortgages")]
        public object Mortgages { get; set; }

        [JsonPropertyName("contracts")]
        public object Contracts { get; set; }

        [JsonPropertyName("offPlanContracts")]
        public object OffPlanContracts { get; set; }

        [JsonPropertyName("documentTypes")]
        public object DocumentTypes { get; set; }

        [JsonPropertyName("hasAccessOnInternalDocuments")]
        public bool HasAccessOnInternalDocuments { get; set; }

        [JsonPropertyName("historyTransactions")]
        public object HistoryTransactions { get; set; }

        [JsonPropertyName("historicalMortgages")]
        public object HistoricalMortgages { get; set; }

        [JsonPropertyName("blocks")]
        public List<object> Blocks { get; set; }

        [JsonPropertyName("partialBlocks")]
        public List<object> PartialBlocks { get; set; }
    }
}