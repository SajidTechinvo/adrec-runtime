using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.Lookup
{
    public class AmountInWordResponse
    {
        [JsonPropertyName("amountInWord")]
        public string AmountInWord { get; set; }
    }
}