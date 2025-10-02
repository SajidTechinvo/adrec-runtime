using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.ElmsServices.TenancyAgreementFix
{
    public class DataFixAmountResponse
    {
        [JsonPropertyName("fees")]
        public double Fees { get; set; }
    }
}