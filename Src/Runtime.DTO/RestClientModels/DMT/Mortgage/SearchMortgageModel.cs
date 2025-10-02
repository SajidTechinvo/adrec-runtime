using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.Mortgage
{
    public class PlotMortgage
    {
        [JsonPropertyName("plotMortgageId")]
        public string PlotMortgageId { get; set; }

        [JsonPropertyName("plotMortgageGuid")]
        public string PlotMortgageGuid { get; set; }

        [JsonPropertyName("mortgageDecree")]
        public string MortgageDecree { get; set; }

        [JsonPropertyName("referenceNumber")]
        public string ReferenceNumber { get; set; }

        [JsonPropertyName("letterNumber")]
        public string LetterNumber { get; set; }

        [JsonPropertyName("mortgageAmount")]
        public string MortgageAmount { get; set; }

        [JsonPropertyName("issueComments")]
        public string IssueComments { get; set; }

        [JsonPropertyName("issueDate")]
        public string IssueDate { get; set; }

        [JsonPropertyName("issueApprovalDate")]
        public string IssueApprovalDate { get; set; }

        [JsonPropertyName("bankName")]
        public string BankName { get; set; }

        [JsonPropertyName("bankBranchName")]
        public string BankBranchName { get; set; }

        [JsonPropertyName("bankEmployeeName")]
        public string BankEmployeeName { get; set; }

        [JsonPropertyName("signature")]
        public object Signature { get; set; }

        [JsonPropertyName("plotMortgageTypeId")]
        public string PlotMortgageTypeId { get; set; }

        [JsonPropertyName("closeApproveDate")]
        public string CloseApproveDate { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }

        [JsonPropertyName("plotMortgageTypeNameA")]
        public string PlotMortgageTypeNameA { get; set; }

        [JsonPropertyName("plotMortgageTypeNameE")]
        public string PlotMortgageTypeNameE { get; set; }

        [JsonPropertyName("plots")]
        public object Plots { get; set; }
    }

    public class SearchMortgageResponse
    {
        [JsonPropertyName("plotMortgage")]
        public PlotMortgageResponse PlotMortgage { get; set; }

        [JsonPropertyName("mortgageHistory")]
        public object MortgageHistory { get; set; }

        [JsonPropertyName("plotMortgages")]
        public List<PlotMortgage> PlotMortgages { get; set; }
    }
}