using System.Text.Json.Serialization;

namespace ADREC.DTO.RestClientModels.DMT.Owners
{
    public class CompanyResponse
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
        public object SonCount { get; set; }

        [JsonPropertyName("personRemarks")]
        public object PersonRemarks { get; set; }

        [JsonPropertyName("gender")]
        public object Gender { get; set; }

        [JsonPropertyName("nationalityName")]
        public object NationalityName { get; set; }

        [JsonPropertyName("companyOwnerName")]
        public string CompanyOwnerName { get; set; }

        [JsonPropertyName("fileNumber")]
        public object FileNumber { get; set; }

        [JsonPropertyName("phoneMobile")]
        public string PhoneMobile { get; set; }

        [JsonPropertyName("cityName")]
        public string CityName { get; set; }

        [JsonPropertyName("cityNumber")]
        public string CityNumber { get; set; }

        [JsonPropertyName("familyBookCity")]
        public object FamilyBookCity { get; set; }

        [JsonPropertyName("familyBookNumber")]
        public object FamilyBookNumber { get; set; }

        [JsonPropertyName("familyBookPageNumber")]
        public object FamilyBookPageNumber { get; set; }

        [JsonPropertyName("passportNumber")]
        public object PassportNumber { get; set; }

        [JsonPropertyName("propertyCardNumber")]
        public object PropertyCardNumber { get; set; }

        [JsonPropertyName("hasBlock")]
        public bool HasBlock { get; set; }

        [JsonPropertyName("nationalNumber")]
        public object NationalNumber { get; set; }

        [JsonPropertyName("passportLocation")]
        public object PassportLocation { get; set; }

        [JsonPropertyName("emirateName")]
        public string EmirateName { get; set; }

        [JsonPropertyName("tradeLicenseNumber")]
        public string TradeLicenseNumber { get; set; }

        [JsonPropertyName("moiUnifiedNumber")]
        public object MoiUnifiedNumber { get; set; }

        [JsonPropertyName("ownerRcertPrintId")]
        public object OwnerRcertPrintId { get; set; }

        [JsonPropertyName("chamberNumberId")]
        public string ChamberNumberId { get; set; }

        [JsonPropertyName("ownerName_A")]
        public string OwnerNameA { get; set; }

        [JsonPropertyName("ownerName_E")]
        public string OwnerNameE { get; set; }

        [JsonPropertyName("ownerStatus")]
        public object OwnerStatus { get; set; }

        [JsonPropertyName("ownerSource")]
        public string OwnerSource { get; set; }

        [JsonPropertyName("nonLocalNationalNumber")]
        public object NonLocalNationalNumber { get; set; }

        [JsonPropertyName("nationalityType")]
        public object NationalityType { get; set; }

        [JsonPropertyName("accessGroups")]
        public object AccessGroups { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}