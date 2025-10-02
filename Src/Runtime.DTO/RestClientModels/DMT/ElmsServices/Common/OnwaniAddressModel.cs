using System.Text.Json.Serialization;

namespace ADREC.DTO.RestClientModels.DMT.ElmsServices.Common
{
    public class OnwaniAddressResponse
    {
        [JsonPropertyName("customerAddressId")]
        public object CustomerAddressId { get; set; }

        [JsonPropertyName("customerId")]
        public object CustomerId { get; set; }

        [JsonPropertyName("plotId")]
        public object PlotId { get; set; }

        [JsonPropertyName("onwaniAddressA")]
        public object OnwaniAddressA { get; set; }

        [JsonPropertyName("onwaniAddressE")]
        public object OnwaniAddressE { get; set; }

        [JsonPropertyName("onwaniAddressGuid")]
        public object OnwaniAddressGuid { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}