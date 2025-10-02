using System.Text.Json.Serialization;

namespace ADREC.DTO.RestClientModels.DMT.Users
{
    public class EmployeeLocationResponse
    {
        [JsonPropertyName("applicationUserId")]
        public int ApplicationUserId { get; set; }

        [JsonPropertyName("municipalityId")]
        public int MunicipalityId { get; set; }

        [JsonPropertyName("municipalityNameA")]
        public string MunicipalityNameA { get; set; }

        [JsonPropertyName("municipalityNameE")]
        public string MunicipalityNameE { get; set; }

        [JsonPropertyName("applicationInboxId")]
        public int ApplicationInboxId { get; set; }

        [JsonPropertyName("applicationInboxConst")]
        public string ApplicationInboxConst { get; set; }

        [JsonPropertyName("applicationInboxNameA")]
        public string ApplicationInboxNameA { get; set; }

        [JsonPropertyName("applicationInboxNameE")]
        public string ApplicationInboxNameE { get; set; }

        [JsonPropertyName("organizationUnitId")]
        public int OrganizationUnitId { get; set; }

        [JsonPropertyName("organizationUnitNameA")]
        public string OrganizationUnitNameA { get; set; }

        [JsonPropertyName("organizationUnitNameE")]
        public string OrganizationUnitNameE { get; set; }

        [JsonPropertyName("orgUnitCategoryId")]
        public int OrgUnitCategoryId { get; set; }

        [JsonPropertyName("orgUnitCategorynameA")]
        public string OrgUnitCategorynameA { get; set; }

        [JsonPropertyName("orgUnitCategorynameE")]
        public string OrgUnitCategorynameE { get; set; }

        [JsonPropertyName("employeeLevel")]
        public object EmployeeLevel { get; set; }

        [JsonPropertyName("bizEntityLookupValueId")]
        public int BizEntityLookupValueId { get; set; }

        [JsonPropertyName("bizEntityLookupValueNameA")]
        public string BizEntityLookupValueNameA { get; set; }

        [JsonPropertyName("bizEntityLookupValueNameE")]
        public string BizEntityLookupValueNameE { get; set; }
    }
}