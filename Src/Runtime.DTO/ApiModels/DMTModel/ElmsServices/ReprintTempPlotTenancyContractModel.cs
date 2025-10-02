using System.Text.Json.Serialization;

namespace Runtime.DTO.ApiModels.DMTModel.ElmsServices
{
    public class StartReprintTempPlotTenancyContract
    {
        [JsonPropertyName("isRenew")]
        public int IsRenew { get; set; }

        [JsonPropertyName("tenancyContractId")]
        public string TenancyContractId { get; set; }

        [JsonPropertyName("plotId")]
        public int PlotId { get; set; }
    }

    public class EntityReprintTempPlotTenancyContract
    {
        [JsonPropertyName("ownerId")]
        public int OwnerId { get; set; }

        [JsonPropertyName("comments")]
        public string Comments { get; set; }

        [JsonPropertyName("priorityValue")]
        public string PriorityValue { get; set; }

        [JsonPropertyName("percentOwnership")]
        public string PercentOwnership { get; set; }
    }

    public class RegisterReprintTempPlotTenancyContract
    {
        [JsonPropertyName("comments")]
        public string Comments { get; set; }

        [JsonPropertyName("entities")]
        public List<EntityReprintTempPlotTenancyContract> Entities { get; set; }

        [JsonPropertyName("type")]
        public int Type { get; set; }
    }

    public class PrintContractReprintTempPlotTenancyContract
    {
        [JsonPropertyName("contractConst")]
        public string ContractConst { get; set; }
    }
}