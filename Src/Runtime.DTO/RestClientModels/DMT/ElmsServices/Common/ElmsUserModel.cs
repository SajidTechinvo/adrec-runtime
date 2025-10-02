using System.Text.Json.Serialization;

namespace ADREC.DTO.RestClientModels.DMT.ElmsServices.Common
{
    public class ElmsUserResponse
    {
        [JsonPropertyName("userId")]
        public int UserId { get; set; }

        [JsonPropertyName("userTypeId")]
        public string UserTypeId { get; set; }

        [JsonPropertyName("inboxId")]
        public int InboxId { get; set; }

        [JsonPropertyName("domainCustomerId")]
        public int DomainCustomerId { get; set; }

        [JsonPropertyName("customerNameA")]
        public string CustomerNameA { get; set; }

        [JsonPropertyName("customerNameE")]
        public string CustomerNameE { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        [JsonPropertyName("identificationNumber")]
        public string IdentificationNumber { get; set; }

        [JsonPropertyName("identificationExpiryDate")]
        public DateTime? IdentificationExpiryDate { get; set; }

        [JsonPropertyName("birthDate")]
        public DateTime? BirthDate { get; set; }

        [JsonPropertyName("birthPlace")]
        public string BirthPlace { get; set; }

        [JsonPropertyName("birthPlaceA")]
        public string BirthPlaceA { get; set; }

        [JsonPropertyName("birthPlaceE")]
        public string BirthPlaceE { get; set; }

        [JsonPropertyName("nationalityId")]
        public int? NationalityId { get; set; }

        [JsonPropertyName("nationalityNameA")]
        public string NationalityNameA { get; set; }

        [JsonPropertyName("nationalityNameE")]
        public string NationalityNameE { get; set; }

        [JsonPropertyName("domainCustomerNameA")]
        public string DomainCustomerNameA { get; set; }

        [JsonPropertyName("domainCustomerNameE")]
        public string DomainCustomerNameE { get; set; }

        [JsonPropertyName("tradeLicenseNumber")]
        public string TradeLicenseNumber { get; set; }

        [JsonPropertyName("tradeLicenseExpiryDate")]
        public DateTime? TradeLicenseExpiryDate { get; set; }

        [JsonPropertyName("gender")]
        public int? Gender { get; set; }

        [JsonPropertyName("genderName")]
        public object GenderName { get; set; }

        [JsonPropertyName("userPositionNameA")]
        public object UserPositionNameA { get; set; }

        [JsonPropertyName("userPositionNameE")]
        public object UserPositionNameE { get; set; }

        [JsonPropertyName("inboxConst")]
        public object InboxConst { get; set; }

        [JsonPropertyName("inboxNameA")]
        public string InboxNameA { get; set; }

        [JsonPropertyName("inboxNameE")]
        public string InboxNameE { get; set; }

        [JsonPropertyName("isOldAssignedInspector")]
        public bool IsOldAssignedInspector { get; set; }

        [JsonPropertyName("moiUnifiedNumber")]
        public object MoiUnifiedNumber { get; set; }

        [JsonPropertyName("remarks")]
        public object Remarks { get; set; }

        [JsonPropertyName("familyName")]
        public object FamilyName { get; set; }

        [JsonPropertyName("subUserPositionId")]
        public object SubUserPositionId { get; set; }

        [JsonPropertyName("subUserPositionIds")]
        public object SubUserPositionIds { get; set; }

        [JsonPropertyName("userTitle")]
        public object UserTitle { get; set; }

        [JsonPropertyName("subUsersTitle")]
        public object SubUsersTitle { get; set; }

        [JsonPropertyName("insTaskCount")]
        public int InsTaskCount { get; set; }

        [JsonPropertyName("validationError")]
        public object ValidationError { get; set; }

        [JsonPropertyName("showInspectorTypes")]
        public bool ShowInspectorTypes { get; set; }

        [JsonPropertyName("showManageUsers")]
        public bool ShowManageUsers { get; set; }

        [JsonPropertyName("user")]
        public object User { get; set; }

        [JsonPropertyName("userEntities")]
        public object UserEntities { get; set; }

        [JsonPropertyName("delegatedByUserId")]
        public object DelegatedByUserId { get; set; }

        [JsonPropertyName("delegatedByUserDetail")]
        public object DelegatedByUserDetail { get; set; }

        [JsonPropertyName("elmsUserId")]
        public object ElmsUserId { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }
}