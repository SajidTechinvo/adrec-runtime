using ADREC.DTO.RestClientModels.DMT.Plots;
using Runtime.DTO.RestClientModels.Common;
using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.Mortgage
{
    public class PlotMortgageResponse
    {
        [JsonPropertyName("bankEmployeeId")]
        public int BankEmployeeId { get; set; }

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

        [JsonPropertyName("closeApproveByUserId")]
        public object CloseApproveByUserId { get; set; }

        [JsonPropertyName("closeApproveDate")]
        public object CloseApproveDate { get; set; }

        [JsonPropertyName("closeByUserId")]
        public object CloseByUserId { get; set; }

        [JsonPropertyName("closeComments")]
        public string CloseComments { get; set; }

        [JsonPropertyName("closeDate")]
        public object CloseDate { get; set; }

        [JsonPropertyName("endDate")]
        public object EndDate { get; set; }

        [JsonPropertyName("isGovernment")]
        public bool IsGovernment { get; set; }

        [JsonPropertyName("issueApproveByUserId")]
        public int IssueApproveByUserId { get; set; }

        [JsonPropertyName("issueApproveDate")]
        public DateTime IssueApproveDate { get; set; }

        [JsonPropertyName("issueByUserId")]
        public int IssueByUserId { get; set; }

        [JsonPropertyName("issueComments")]
        public string IssueComments { get; set; }

        [JsonPropertyName("issueDate")]
        public DateTime IssueDate { get; set; }

        [JsonPropertyName("letterNumber")]
        public string LetterNumber { get; set; }

        [JsonPropertyName("migNote")]
        public double MigNote { get; set; }

        [JsonPropertyName("migNoteL")]
        public string MigNoteL { get; set; }

        [JsonPropertyName("migNoteLm")]
        public string MigNoteLm { get; set; }

        [JsonPropertyName("migReferenceLm")]
        public string MigReferenceLm { get; set; }

        [JsonPropertyName("mortgageAmount")]
        public double MortgageAmount { get; set; }

        [JsonPropertyName("mortgageDegree")]
        public double MortgageDegree { get; set; }

        [JsonPropertyName("plotMortgageGuid")]
        public string PlotMortgageGuid { get; set; }

        [JsonPropertyName("plotMortgageId")]
        public int PlotMortgageId { get; set; }

        [JsonPropertyName("plotMortgageTypeId")]
        public int PlotMortgageTypeId { get; set; }

        [JsonPropertyName("referenceNumber")]
        public string ReferenceNumber { get; set; }

        [JsonPropertyName("startDate")]
        public object StartDate { get; set; }

        [JsonPropertyName("totalMortgageFees")]
        public double TotalMortgageFees { get; set; }

        [JsonPropertyName("valuatorOwnerId")]
        public object ValuatorOwnerId { get; set; }

        [JsonPropertyName("mortgageId")]
        public int MortgageId { get; set; }

        [JsonPropertyName("applicationNumber")]
        public object ApplicationNumber { get; set; }

        [JsonPropertyName("contractNumber")]
        public object ContractNumber { get; set; }

        [JsonPropertyName("amount")]
        public double Amount { get; set; }

        [JsonPropertyName("strAmount")]
        public string StrAmount { get; set; }

        [JsonPropertyName("mortgageTypeName")]
        public object MortgageTypeName { get; set; }

        [JsonPropertyName("degree")]
        public object Degree { get; set; }

        [JsonPropertyName("releaseDate")]
        public object ReleaseDate { get; set; }

        [JsonPropertyName("plotMortgageType")]
        public PlotMortgageTypeResponse PlotMortgageType { get; set; }

        [JsonPropertyName("bankEmployee")]
        public BankEmployeeResponse BankEmployee { get; set; }

        [JsonPropertyName("hasBankDetails")]
        public bool HasBankDetails { get; set; }

        [JsonPropertyName("strIssueDate")]
        public string StrIssueDate { get; set; }

        [JsonPropertyName("signature")]
        public object Signature { get; set; }

        [JsonPropertyName("plots")]
        public List<PlotDetailResponse> Plots { get; set; }

        [JsonPropertyName("owners")]
        public object Owners { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }
}