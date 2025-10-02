using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.ElmsTenancy
{
    public class ContractPaymentResponse
    {
        [JsonPropertyName("contractNumber")]
        public string ContractNumber { get; set; }

        [JsonPropertyName("contractDate")]
        public DateTime? ContractDate { get; set; }

        [JsonPropertyName("contractStartDate")]
        public DateTime? ContractStartDate { get; set; }

        [JsonPropertyName("contractEndDate")]
        public DateTime? ContractEndDate { get; set; }

        [JsonPropertyName("rentPaymentId")]
        public int RentPaymentId { get; set; }

        [JsonPropertyName("rentPaymentAmount")]
        public double? RentPaymentAmount { get; set; }

        [JsonPropertyName("rentPaymentStartDate")]
        public DateTime? RentPaymentStartDate { get; set; }

        [JsonPropertyName("rentPaymentEndDate")]
        public DateTime? RentPaymentEndDate { get; set; }

        [JsonPropertyName("comments")]
        public string Comments { get; set; }

        [JsonPropertyName("approveByUserId")]
        public int ApproveByUserId { get; set; }

        [JsonPropertyName("approveDate")]
        public DateTime? ApproveDate { get; set; }

        [JsonPropertyName("paymentConst")]
        public string PaymentConst { get; set; }

        [JsonPropertyName("receiptNumber")]
        public string ReceiptNumber { get; set; }

        [JsonPropertyName("receiptDate")]
        public DateTime? ReceiptDate { get; set; }

        [JsonPropertyName("paidByName")]
        public string PaidByName { get; set; }

        [JsonPropertyName("amountDue")]
        public double AmountDue { get; set; }

        [JsonPropertyName("applicationNumber")]
        public string ApplicationNumber { get; set; }

        [JsonPropertyName("applicationPaymentId")]
        public string ApplicationPaymentId { get; set; }

        [JsonPropertyName("paymentDescription")]
        public string PaymentDescription { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("statusValue")]
        public int StatusValue { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}