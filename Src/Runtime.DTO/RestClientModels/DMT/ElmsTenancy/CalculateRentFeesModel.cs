using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.ElmsTenancy
{
    public class CalculateRentFeesResponse
    {
        [JsonPropertyName("feeAmount")]
        public double FeeAmount { get; set; }

        [JsonPropertyName("feeFormat")]
        public string FeeFormat { get; set; }

        [JsonPropertyName("amountInWords")]
        public string AmountInWords { get; set; }

        [JsonPropertyName("paidAmountInWords")]
        public string PaidAmountInWords { get; set; }

        [JsonPropertyName("rentFeesPerSqMeterUnit")]
        public double RentFeesPerSqMeterUnit { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}