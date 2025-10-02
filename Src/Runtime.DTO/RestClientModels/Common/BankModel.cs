using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.Common
{
    public class ElmsBankResponse
    {
        [JsonPropertyName("bankid")]
        public int Bankid { get; set; }

        [JsonPropertyName("bankNameA")]
        public string BankNameA { get; set; }

        [JsonPropertyName("bankNameE")]
        public string BankNameE { get; set; }

        [JsonPropertyName("gcsBankCode")]
        public string GcsBankCode { get; set; }

        [JsonPropertyName("isGovernmetAgency")]
        public int IsGovernmetAgency { get; set; }

        [JsonPropertyName("mergeComments")]
        public string MergeComments { get; set; }

        [JsonPropertyName("migNote")]
        public double? MigNote { get; set; }

        [JsonPropertyName("migNoteL")]
        public string MigNoteL { get; set; }

        [JsonPropertyName("migNoteLm")]
        public string MigNoteLm { get; set; }

        [JsonPropertyName("ownerId")]
        public object OwnerId { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }

    public class ElmsBankBranch
    {
        [JsonPropertyName("bankBranchId")]
        public int BankBranchId { get; set; }

        [JsonPropertyName("bankBranchNameA")]
        public string BankBranchNameA { get; set; }

        [JsonPropertyName("bankBranchNameE")]
        public string BankBranchNameE { get; set; }

        [JsonPropertyName("bankId")]
        public int BankId { get; set; }

        [JsonPropertyName("buildingNumber")]
        public string BuildingNumber { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("fax")]
        public string Fax { get; set; }

        [JsonPropertyName("migNote")]
        public double MigNote { get; set; }

        [JsonPropertyName("migNoteL")]
        public string MigNoteL { get; set; }

        [JsonPropertyName("migNoteLm")]
        public string MigNoteLm { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("poBox")]
        public string PoBox { get; set; }

        [JsonPropertyName("roadName")]
        public string RoadName { get; set; }

        [JsonPropertyName("elmsBank")]
        public ElmsBankResponse ElmsBank { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }

    public class BankEmployeeResponse
    {
        [JsonPropertyName("bankBranchId")]
        public int BankBranchId { get; set; }

        [JsonPropertyName("bankEmployeeId")]
        public int BankEmployeeId { get; set; }

        [JsonPropertyName("bankEmployeeNameA")]
        public string BankEmployeeNameA { get; set; }

        [JsonPropertyName("bankEmployeeNameE")]
        public string BankEmployeeNameE { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("migNote")]
        public double MigNote { get; set; }

        [JsonPropertyName("migNoteL")]
        public string MigNoteL { get; set; }

        [JsonPropertyName("migNoteLm")]
        public string MigNoteLm { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("signatureId")]
        public object SignatureId { get; set; }

        [JsonPropertyName("elmsBankBranch")]
        public ElmsBankBranch ElmsBankBranch { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}