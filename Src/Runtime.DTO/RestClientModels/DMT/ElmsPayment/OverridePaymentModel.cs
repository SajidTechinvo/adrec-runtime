using System.Text.Json.Serialization;

namespace ADREC.DTO.RestClientModels.DMT.ElmsPayment
{
    public class OverridePaymentResponse
    {
        [JsonPropertyName("isOverridePayment")]
        public bool IsOverridePayment { get; set; }

        [JsonPropertyName("isPaid")]
        public bool IsPaid { get; set; }

        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("paidByName")]
        public string PaidByName { get; set; }

        [JsonPropertyName("amountPaid")]
        public double AmountPaid { get; set; }

        [JsonPropertyName("paymentType")]
        public string PaymentType { get; set; }

        [JsonPropertyName("checkDate")]
        public object CheckDate { get; set; }

        [JsonPropertyName("paymentNumber")]
        public object PaymentNumber { get; set; }

        [JsonPropertyName("comments")]
        public object Comments { get; set; }

        [JsonPropertyName("receiptNumber")]
        public string ReceiptNumber { get; set; }

        [JsonPropertyName("receiptDate")]
        public DateTime ReceiptDate { get; set; }
    }
}