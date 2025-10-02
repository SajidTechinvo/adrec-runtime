using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.Profiles
{
    public class LandServicesAvailabilityResponse
    {
        [JsonPropertyName("ownerNameA")]
        public object OwnerNameA { get; set; }

        [JsonPropertyName("ownerNameE")]
        public object OwnerNameE { get; set; }

        [JsonPropertyName("nationalNumber")]
        public object NationalNumber { get; set; }

        [JsonPropertyName("tradeLicenseNumber")]
        public object TradeLicenseNumber { get; set; }

        [JsonPropertyName("ownerTitleA")]
        public object OwnerTitleA { get; set; }

        [JsonPropertyName("ownerTitleE")]
        public object OwnerTitleE { get; set; }

        [JsonPropertyName("gender")]
        public object Gender { get; set; }

        [JsonPropertyName("nationalityNameA")]
        public object NationalityNameA { get; set; }

        [JsonPropertyName("nationalityNameE")]
        public object NationalityNameE { get; set; }

        [JsonPropertyName("customerId")]
        public object CustomerId { get; set; }

        [JsonPropertyName("onlineAccessVerified")]
        public bool OnlineAccessVerified { get; set; }

        [JsonPropertyName("hasBlocks")]
        public bool HasBlocks { get; set; }

        [JsonPropertyName("activeVerificationApplicationNumber")]
        public object ActiveVerificationApplicationNumber { get; set; }

        [JsonPropertyName("mobileNumber")]
        public object MobileNumber { get; set; }

        [JsonPropertyName("moiNumber")]
        public object MoiNumber { get; set; }

        [JsonPropertyName("archiveNumber")]
        public object ArchiveNumber { get; set; }

        [JsonPropertyName("familybookNumber")]
        public object FamilybookNumber { get; set; }

        [JsonPropertyName("familyBookCityNumber")]
        public object FamilyBookCityNumber { get; set; }

        [JsonPropertyName("rightHoldTypeId")]
        public object RightHoldTypeId { get; set; }

        [JsonPropertyName("rightHoldTypeNameA")]
        public object RightHoldTypeNameA { get; set; }

        [JsonPropertyName("rightHoldTypeNameE")]
        public object RightHoldTypeNameE { get; set; }

        [JsonPropertyName("plotTransactionTypeId")]
        public object PlotTransactionTypeId { get; set; }

        [JsonPropertyName("plotTransactionTypeNameA")]
        public object PlotTransactionTypeNameA { get; set; }

        [JsonPropertyName("plotTransactionTypeNameE")]
        public object PlotTransactionTypeNameE { get; set; }

        [JsonPropertyName("percentOwnerShip")]
        public object PercentOwnerShip { get; set; }

        [JsonPropertyName("priority")]
        public object Priority { get; set; }

        [JsonPropertyName("ownerType")]
        public object OwnerType { get; set; }

        [JsonPropertyName("isDisplayTitle")]
        public bool IsDisplayTitle { get; set; }

        [JsonPropertyName("share")]
        public object Share { get; set; }

        [JsonPropertyName("isAuthorizedOwner")]
        public bool IsAuthorizedOwner { get; set; }

        [JsonPropertyName("isBigOwner")]
        public bool IsBigOwner { get; set; }

        [JsonPropertyName("isOwnerByInheritance")]
        public bool IsOwnerByInheritance { get; set; }

        [JsonPropertyName("isOwnerElmsAudited")]
        public bool IsOwnerElmsAudited { get; set; }

        [JsonPropertyName("isPmaOwnershipAllowed")]
        public bool IsPmaOwnershipAllowed { get; set; }

        [JsonPropertyName("isAwqafOwner")]
        public bool IsAwqafOwner { get; set; }

        [JsonPropertyName("passportNumber")]
        public object PassportNumber { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}