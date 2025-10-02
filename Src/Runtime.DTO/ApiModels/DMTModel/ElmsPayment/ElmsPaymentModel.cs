using System.Text.Json.Serialization;

namespace Runtime.DTO.ApiModels.DMTModel.ElmsPayment
{
    public class PrintPaymentSlipRequest
    {
        [JsonPropertyName("applicationPaymentId")]
        public int ApplicationPaymentId { get; set; }
    }

    public class OverridePaymentRequest
    {
        [JsonPropertyName("applicationPaymentId")]
        public int ApplicationPaymentId { get; set; }

        [JsonPropertyName("receiptNumber")]
        public string ReceiptNumber { get; set; }

        [JsonPropertyName("receiptDate")]
        public DateTime ReceiptDate { get; set; }

        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        [JsonPropertyName("duplicateReceiptNumber")]
        public bool DuplicateReceiptNumber { get; set; }
    }

    public class VerifyPaymentRequest
    {
        [JsonPropertyName("MunicipalityId")]
        public int MunicipalityId { get; set; }

        [JsonPropertyName("ApplicationPaymentId")]
        public int ApplicationPaymentId { get; set; }
    }
}