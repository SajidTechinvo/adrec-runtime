using System.Text.Json.Serialization;

namespace Runtime.DTO.ApiModels.DMTModel.ElmsServices
{
    public class StartUnassignedAllotmentTemporaryPlot
    {
        [JsonPropertyName("_check0")]
        public string Check0 { get; set; }

        [JsonPropertyName("acceptServiceConditions")]
        public string AcceptServiceConditions { get; set; }

        [JsonPropertyName("municipalityId")]
        public int MunicipalityId { get; set; }

        [JsonPropertyName("allotmentOrderId")]
        public int AllotmentOrderId { get; set; }
    }

    public class UnassignedAllotmentTemporaryPlotAddRecipient
    {
        public List<int> OwnerIdList { get; set; }
    }

    public class Entity
    {
        [JsonPropertyName("ownerId")]
        public int OwnerId { get; set; }

        [JsonPropertyName("comments")]
        public string Comments { get; set; }

        [JsonPropertyName("priorityValue")]
        public string PriorityValue { get; set; }
    }

    public class RegisterUnassignedAllotmentTemporaryPlot
    {
        [JsonPropertyName("comments")]
        public string Comments { get; set; }

        [JsonPropertyName("entities")]
        public List<Entity> Entities { get; set; }
    }

    public class AuditUnassignedAllotmentTemporaryPlot
    {
        [JsonPropertyName("cancelOtherMunicipalities")]
        public bool CancelOtherMunicipalities { get; set; }

        [JsonPropertyName("comments")]
        public string Comments { get; set; }
    }
}