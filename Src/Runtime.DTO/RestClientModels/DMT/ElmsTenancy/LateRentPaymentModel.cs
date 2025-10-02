using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.ElmsTenancy
{
    public class LateRentPaymentResponse
    {
        [JsonPropertyName("activityTypeA")]
        public string ActivityTypeA { get; set; }

        [JsonPropertyName("comments")]
        public string Comments { get; set; }

        [JsonPropertyName("endDate")]
        public DateTime? EndDate { get; set; }

        [JsonPropertyName("isPaid")]
        public int IsPaid { get; set; }

        [JsonPropertyName("landId")]
        public int LandId { get; set; }

        [JsonPropertyName("landLateRentPaymentId")]
        public int LandLateRentPaymentId { get; set; }

        [JsonPropertyName("rentAmount")]
        public double RentAmount { get; set; }

        [JsonPropertyName("rentAmountVat")]
        public double RentAmountVat { get; set; }

        [JsonPropertyName("startDate")]
        public DateTime? StartDate { get; set; }

        [JsonPropertyName("tenancyContractType")]
        public int TenancyContractType { get; set; }

        [JsonPropertyName("tenancyContractTypeValue")]
        public string TenancyContractTypeValue { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }
}