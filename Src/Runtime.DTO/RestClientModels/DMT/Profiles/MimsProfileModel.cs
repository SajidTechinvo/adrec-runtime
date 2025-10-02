using System.Text.Json.Serialization;

namespace ADREC.DTO.RestClientModels.DMT.Profiles
{
    public class MimsProfileResponse
    {
        [JsonPropertyName("customerId")]
        public int CustomerId { get; set; }

        [JsonPropertyName("applicationUserId")]
        public int ApplicationUserId { get; set; }

        [JsonPropertyName("applicationInboxConst")]
        public string ApplicationInboxConst { get; set; }

        [JsonPropertyName("applicationInboxId")]
        public int ApplicationInboxId { get; set; }

        [JsonPropertyName("domainCustomerId")]
        public int DomainCustomerId { get; set; }

        [JsonPropertyName("domainCustomerNameA")]
        public string DomainCustomerNameA { get; set; }

        [JsonPropertyName("domainCustomerNameE")]
        public string DomainCustomerNameE { get; set; }

        [JsonPropertyName("userType")]
        public string UserType { get; set; }

        [JsonPropertyName("displayNameA")]
        public string DisplayNameA { get; set; }

        [JsonPropertyName("displayNameE")]
        public string DisplayNameE { get; set; }

        [JsonPropertyName("inboxNameA")]
        public string InboxNameA { get; set; }

        [JsonPropertyName("inboxNameE")]
        public string InboxNameE { get; set; }

        [JsonPropertyName("isDomainAdmin")]
        public bool IsDomainAdmin { get; set; }

        [JsonPropertyName("isPersonalAccount")]
        public bool IsPersonalAccount { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("isUserAnEngineer")]
        public bool IsUserAnEngineer { get; set; }

        [JsonPropertyName("authCode")]
        public object AuthCode { get; set; }

        [JsonPropertyName("userArea")]
        public List<object> UserArea { get; set; }

        [JsonPropertyName("orgUnitId")]
        public object OrgUnitId { get; set; }

        [JsonPropertyName("orgUnitNameA")]
        public string OrgUnitNameA { get; set; }

        [JsonPropertyName("orgUnitNameE")]
        public string OrgUnitNameE { get; set; }

        [JsonPropertyName("manageUserId")]
        public object ManageUserId { get; set; }

        [JsonPropertyName("manageUserDisplayNameA")]
        public string ManageUserDisplayNameA { get; set; }

        [JsonPropertyName("manageUserDisplayNameE")]
        public string ManageUserDisplayNameE { get; set; }

        [JsonPropertyName("employmentNumber")]
        public string EmploymentNumber { get; set; }

        [JsonPropertyName("delegatedByUserId")]
        public object DelegatedByUserId { get; set; }

        [JsonPropertyName("inspEntityId")]
        public int InspEntityId { get; set; }

        [JsonPropertyName("inspEntityNameA")]
        public string InspEntityNameA { get; set; }

        [JsonPropertyName("inspEntityNameE")]
        public string InspEntityNameE { get; set; }

        [JsonPropertyName("idNumber")]
        public string IdNumber { get; set; }

        [JsonPropertyName("scores")]
        public List<object> Scores { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }
}