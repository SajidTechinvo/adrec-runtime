using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.ElmsServices.Common
{
    public class BlockResponse
    {
        [JsonPropertyName("approveByUserId")]
        public int? ApproveByUserId { get; set; }

        [JsonPropertyName("approveComments")]
        public string ApproveComments { get; set; }

        [JsonPropertyName("approveDate")]
        public DateTime? ApproveDate { get; set; }

        [JsonPropertyName("authoritySourceId")]
        public int? AuthoritySourceId { get; set; }

        [JsonPropertyName("authoritySourceName")]
        public string AuthoritySourceName { get; set; }

        [JsonPropertyName("blockSourceRefId")]
        public string BlockSourceRefId { get; set; }

        [JsonPropertyName("cancelByUserId")]
        public int? CancelByUserId { get; set; }

        [JsonPropertyName("cancelComments")]
        public string CancelComments { get; set; }

        [JsonPropertyName("cancelDate")]
        public DateTime? CancelDate { get; set; }

        [JsonPropertyName("comments")]
        public string Comments { get; set; }

        [JsonPropertyName("endDate")]
        public DateTime? EndDate { get; set; }

        [JsonPropertyName("isBlockAllWorkflows")]
        public int IsBlockAllWorkflows { get; set; }

        [JsonPropertyName("isGrantList")]
        public int IsGrantList { get; set; }

        [JsonPropertyName("migNote")]
        public double? MigNote { get; set; }

        [JsonPropertyName("migNoteL")]
        public string MigNoteL { get; set; }

        [JsonPropertyName("migNoteLm")]
        public string MigNoteLm { get; set; }

        [JsonPropertyName("plotBlockGuid")]
        public string PlotBlockGuid { get; set; }

        [JsonPropertyName("plotBlockId")]
        public int PlotBlockId { get; set; }

        [JsonPropertyName("plotId")]
        public int PlotId { get; set; }

        [JsonPropertyName("releaseBlockByUserId")]
        public object ReleaseBlockByUserId { get; set; }

        [JsonPropertyName("releaseBlockComments")]
        public string ReleaseBlockComments { get; set; }

        [JsonPropertyName("releaseBlockDate")]
        public object ReleaseBlockDate { get; set; }

        [JsonPropertyName("sourceTypeA")]
        public string SourceTypeA { get; set; }

        [JsonPropertyName("sourceTypeE")]
        public string SourceTypeE { get; set; }

        [JsonPropertyName("sourceNameA")]
        public string SourceNameA { get; set; }

        [JsonPropertyName("sourceNameE")]
        public string SourceNameE { get; set; }

        [JsonPropertyName("departmentA")]
        public string DepartmentA { get; set; }

        [JsonPropertyName("departmentE")]
        public string DepartmentE { get; set; }

        [JsonPropertyName("createdBy")]
        public BlockRequestCreatedBy CreatedBy { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }

    public class BlockRequestCreatedBy
    {
        [JsonPropertyName("employeeEmail")]
        public string EmployeeEmail { get; set; }

        [JsonPropertyName("employeeId")]
        public int EmployeeId { get; set; }

        [JsonPropertyName("employeeNameA")]
        public string EmployeeNameA { get; set; }

        [JsonPropertyName("employeeNameE")]
        public string EmployeeNameE { get; set; }

        [JsonPropertyName("employmentNumber")]
        public string EmploymentNumber { get; set; }

        [JsonPropertyName("jobId")]
        public int JobId { get; set; }

        [JsonPropertyName("migNote")]
        public object MigNote { get; set; }

        [JsonPropertyName("migNoteL")]
        public string MigNoteL { get; set; }

        [JsonPropertyName("migNoteLm")]
        public string MigNoteLm { get; set; }

        [JsonPropertyName("mobilePhone")]
        public string MobilePhone { get; set; }

        [JsonPropertyName("municipalitySectionId")]
        public int MunicipalitySectionId { get; set; }

        [JsonPropertyName("nationalNumber")]
        public string NationalNumber { get; set; }

        [JsonPropertyName("officeNumber")]
        public string OfficeNumber { get; set; }

        [JsonPropertyName("officePhone")]
        public string OfficePhone { get; set; }

        [JsonPropertyName("signatureId")]
        public int SignatureId { get; set; }

        [JsonPropertyName("tribeNameA")]
        public string TribeNameA { get; set; }

        [JsonPropertyName("tribeNameE")]
        public string TribeNameE { get; set; }

        [JsonPropertyName("userId")]
        public int UserId { get; set; }

        [JsonPropertyName("userTitleId")]
        public int UserTitleId { get; set; }

        [JsonPropertyName("jobName")]
        public object JobName { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}