using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.Plots
{
    public class ServiceOverviewResponse
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("critical")]
        public int Critical { get; set; }

        [JsonPropertyName("action")]
        public int Action { get; set; }

        [JsonPropertyName("active")]
        public int Active { get; set; }

        [JsonPropertyName("requireAttention")]
        public List<MyActivityResponse> RequireAttention { get; set; }

        [JsonPropertyName("inProcess")]
        public List<MyActivityResponse> InProcess { get; set; }
    }

    public class ServiceDetailResponse
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("requiredDocs")]
        public List<string> RequiredDocs { get; set; }

        [JsonPropertyName("steps")]
        public List<string> Steps { get; set; }

        [JsonPropertyName("contractIssueFee")]
        public decimal ContractIssueFee { get; set; }

        [JsonPropertyName("insuranceFee")]
        public decimal InsuranceFee { get; set; }

        [JsonPropertyName("rentalValueForSeasonalRanches")]
        public decimal RentalValueForSeasonalRanches { get; set; }

        [JsonPropertyName("rentalValueFullyServiced")]
        public decimal RentalValueFullyServiced { get; set; }

        [JsonPropertyName("rentalValueNotAllServices")]
        public decimal RentalValueNotAllServices { get; set; }
    }
}