using Runtime.DTO.RestClientModels.DMT.Mortgage;
using System.Text.Json.Serialization;

namespace ADREC.DTO.RestClientModels.DMT.Mortgage
{
    public class MortgageHistoryList
    {
        [JsonPropertyName("approveByUserId")]
        public int ApproveByUserId { get; set; }

        [JsonPropertyName("approveDate")]
        public DateTime ApproveDate { get; set; }

        [JsonPropertyName("bankReferenceNumber")]
        public string BankReferenceNumber { get; set; }

        [JsonPropertyName("bankSignatoryOwnerId")]
        public object BankSignatoryOwnerId { get; set; }

        [JsonPropertyName("cancelByUserId")]
        public object CancelByUserId { get; set; }

        [JsonPropertyName("cancelComments")]
        public string CancelComments { get; set; }

        [JsonPropertyName("cancelDate")]
        public object CancelDate { get; set; }

        [JsonPropertyName("endDate")]
        public object EndDate { get; set; }

        [JsonPropertyName("isGovernment")]
        public bool IsGovernment { get; set; }

        [JsonPropertyName("issueApproveDate")]
        public object IssueApproveDate { get; set; }

        [JsonPropertyName("issueByUserId")]
        public int IssueByUserId { get; set; }

        [JsonPropertyName("issueComments")]
        public string IssueComments { get; set; }

        [JsonPropertyName("issueDate")]
        public DateTime IssueDate { get; set; }

        [JsonPropertyName("isVideoAuthenticated")]
        public object IsVideoAuthenticated { get; set; }

        [JsonPropertyName("migNote")]
        public object MigNote { get; set; }

        [JsonPropertyName("migNoteL")]
        public string MigNoteL { get; set; }

        [JsonPropertyName("migNoteLm")]
        public string MigNoteLm { get; set; }

        [JsonPropertyName("mortgageTransactionGuid")]
        public string MortgageTransactionGuid { get; set; }

        [JsonPropertyName("mortgageTransactionId")]
        public int MortgageTransactionId { get; set; }

        [JsonPropertyName("plotMortgageId")]
        public int PlotMortgageId { get; set; }

        [JsonPropertyName("referenceNumber")]
        public string ReferenceNumber { get; set; }

        [JsonPropertyName("startDate")]
        public object StartDate { get; set; }

        [JsonPropertyName("valuatorOwnerId")]
        public object ValuatorOwnerId { get; set; }

        [JsonPropertyName("videoUrl")]
        public string VideoUrl { get; set; }

        [JsonPropertyName("plotMortgage")]
        public PlotMortgage PlotMortgage { get; set; }

        [JsonPropertyName("applicationNumber")]
        public object ApplicationNumber { get; set; }

        [JsonPropertyName("mortgageChanges")]
        public object MortgageChanges { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }

    public class FetchMortgageProfileResponse
    {
        [JsonPropertyName("plotMortgage")]
        public PlotMortgageResponse PlotMortgage { get; set; }

        [JsonPropertyName("mortgageHistoryList")]
        public List<MortgageHistoryList> MortgageHistoryList { get; set; }
    }
}