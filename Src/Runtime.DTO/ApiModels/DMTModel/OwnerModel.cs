using System.Text.Json.Serialization;

namespace Runtime.DTO.ApiModels.DMTModel
{
    public class EditContactRequest
    {
        [JsonPropertyName("ownerId")]
        public string OwnerId { get; set; }
        [JsonPropertyName("contactNumber")]
        public string ContactNumber { get; set; }
    }
}
