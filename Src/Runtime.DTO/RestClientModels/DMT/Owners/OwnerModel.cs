using System.Text.Json.Serialization;

namespace ADREC.DTO.RestClientModels.DMT.Owners
{
    public class OwnerResponse
    {
        [JsonPropertyName("ownerGuid")]
        public string OwnerGuid { get; set; }

        [JsonPropertyName("ownerId")]
        public int OwnerId { get; set; }

        [JsonPropertyName("ownerName")]
        public string OwnerName { get; set; }

        [JsonPropertyName("ownerType")]
        public string OwnerType { get; set; }

        [JsonPropertyName("userTitleName")]
        public object UserTitleName { get; set; }

        [JsonPropertyName("tribeName")]
        public object TribeName { get; set; }

        [JsonPropertyName("sonCount")]
        public string SonCount { get; set; }

        [JsonPropertyName("personRemarks")]
        public object PersonRemarks { get; set; }

        [JsonPropertyName("gender")]
        public int? Gender { get; set; }

        [JsonPropertyName("nationalityName")]
        public string NationalityName { get; set; }

        [JsonPropertyName("companyOwnerName")]
        public object CompanyOwnerName { get; set; }

        [JsonPropertyName("fileNumber")]
        public object FileNumber { get; set; }

        [JsonPropertyName("phoneMobile")]
        public string PhoneMobile { get; set; }

        [JsonPropertyName("cityName")]
        public object CityName { get; set; }

        [JsonPropertyName("cityNumber")]
        public object CityNumber { get; set; }

        [JsonPropertyName("familyBookCity")]
        public string FamilyBookCity { get; set; }

        [JsonPropertyName("familyBookNumber")]
        public string FamilyBookNumber { get; set; }

        [JsonPropertyName("familyBookPageNumber")]
        public object FamilyBookPageNumber { get; set; }

        [JsonPropertyName("passportNumber")]
        public string PassportNumber { get; set; }

        [JsonPropertyName("propertyCardNumber")]
        public object PropertyCardNumber { get; set; }

        [JsonPropertyName("hasBlock")]
        public bool HasBlock { get; set; }

        [JsonPropertyName("nationalNumber")]
        public string NationalNumber { get; set; }

        [JsonPropertyName("passportLocation")]
        public string PassportLocation { get; set; }

        [JsonPropertyName("emirateName")]
        public object EmirateName { get; set; }

        [JsonPropertyName("tradeLicenseNumber")]
        public object TradeLicenseNumber { get; set; }

        [JsonPropertyName("moiUnifiedNumber")]
        public string MoiUnifiedNumber { get; set; }

        [JsonPropertyName("ownerRcertPrintId")]
        public object OwnerRcertPrintId { get; set; }

        [JsonPropertyName("chamberNumberId")]
        public object ChamberNumberId { get; set; }

        [JsonPropertyName("ownerName_A")]
        public string OwnerNameA { get; set; }

        [JsonPropertyName("ownerName_E")]
        public string OwnerNameE { get; set; }

        [JsonPropertyName("ownerStatus")]
        public object OwnerStatus { get; set; }

        [JsonPropertyName("ownerSource")]
        public object OwnerSource { get; set; }

        [JsonPropertyName("nonLocalNationalNumber")]
        public object NonLocalNationalNumber { get; set; }

        [JsonPropertyName("nationalityType")]
        public int? NationalityType { get; set; }

        [JsonPropertyName("accessGroups")]
        public object AccessGroups { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}