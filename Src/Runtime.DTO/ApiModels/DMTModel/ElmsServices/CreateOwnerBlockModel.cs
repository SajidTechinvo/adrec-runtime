using System.Text.Json.Serialization;

namespace Runtime.DTO.ApiModels.DMTModel.ElmsServices
{
    public class StartCreateOwnerBlock
    {
        [JsonPropertyName("_check0")]
        public string Check0 { get; set; }

        [JsonPropertyName("acceptServiceConditions")]
        public string AcceptServiceConditions { get; set; }

        [JsonPropertyName("ownerId")]
        public int OwnerId { get; set; }
    }

    public class RegisterCreateOwnerBlock
    {
        [JsonPropertyName("comments")]
        public string Comments { get; set; }

        [JsonPropertyName("blockEndDate")]
        public DateTime BlockEndDate { get; set; }

        [JsonPropertyName("authoritySourceId")]
        public string AuthoritySourceId { get; set; }
    }
}