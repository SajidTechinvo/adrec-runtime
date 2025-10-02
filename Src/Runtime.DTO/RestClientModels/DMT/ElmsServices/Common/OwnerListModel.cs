using ADREC.DTO.RestClientModels.DMT.Plots;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.Ranch;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.Lookup;
using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.ElmsServices.Common
{
    public class OwnerListResponse
    {
        [JsonPropertyName("accessGroups")]
        public object AccessGroups { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("addressBuildingNumber")]
        public string AddressBuildingNumber { get; set; }

        [JsonPropertyName("addressCityId")]
        public int? AddressCityId { get; set; }

        [JsonPropertyName("approveByUserId")]
        public int? ApproveByUserId { get; set; }

        [JsonPropertyName("approveDate")]
        public DateTime ApproveDate { get; set; }

        [JsonPropertyName("archiveFileNumberAA")]
        public int? ArchiveFileNumberAA { get; set; }

        [JsonPropertyName("archiveFileNumberAD")]
        public int? ArchiveFileNumberAD { get; set; }

        [JsonPropertyName("archiveFileNumberWR")]
        public object ArchiveFileNumberWR { get; set; }

        [JsonPropertyName("attorneyName")]
        public string AttorneyName { get; set; }

        [JsonPropertyName("attorneyOwnerId")]
        public object AttorneyOwnerId { get; set; }

        [JsonPropertyName("attorneyPhone")]
        public string AttorneyPhone { get; set; }

        [JsonPropertyName("auditFlags")]
        public int? AuditFlags { get; set; }

        [JsonPropertyName("birthDate")]
        public DateTime? BirthDate { get; set; }

        [JsonPropertyName("birthPlace")]
        public string BirthPlace { get; set; }

        [JsonPropertyName("buisinessFlags")]
        public int? BuisinessFlags { get; set; }

        [JsonPropertyName("companyOwnersNames")]
        public string CompanyOwnersNames { get; set; }

        [JsonPropertyName("cancelByUserId")]
        public object CancelByUserId { get; set; }

        [JsonPropertyName("cancelDate")]
        public object CancelDate { get; set; }

        [JsonPropertyName("chamberNumber")]
        public string ChamberNumber { get; set; }

        [JsonPropertyName("chamberNumberExpiryDate")]
        public object ChamberNumberExpiryDate { get; set; }

        [JsonPropertyName("comments")]
        public string Comments { get; set; }

        [JsonPropertyName("companyTypeId")]
        public object CompanyTypeId { get; set; }

        [JsonPropertyName("deathDate")]
        public DateTime? DeathDate { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("familyBookCityId")]
        public int? FamilyBookCityId { get; set; }

        [JsonPropertyName("familyBookIssueDate")]
        public DateTime? FamilyBookIssueDate { get; set; }

        [JsonPropertyName("familyBookIssuePlace")]
        public string FamilyBookIssuePlace { get; set; }

        [JsonPropertyName("familyBookNumber")]
        public string FamilyBookNumber { get; set; }

        [JsonPropertyName("familyPageNumber")]
        public string FamilyPageNumber { get; set; }

        [JsonPropertyName("familyStatusId")]
        public int? FamilyStatusId { get; set; }

        [JsonPropertyName("fatherOwnerId")]
        public object FatherOwnerId { get; set; }

        [JsonPropertyName("fax")]
        public string Fax { get; set; }

        [JsonPropertyName("fileNumber")]
        public string FileNumber { get; set; }

        [JsonPropertyName("finalOwnerId")]
        public object FinalOwnerId { get; set; }

        [JsonPropertyName("firstNameA")]
        public string FirstNameA { get; set; }

        [JsonPropertyName("firstNameE")]
        public string FirstNameE { get; set; }

        [JsonPropertyName("fourthNameA")]
        public string FourthNameA { get; set; }

        [JsonPropertyName("fourthNameE")]
        public string FourthNameE { get; set; }

        [JsonPropertyName("gender")]
        public int? Gender { get; set; }

        [JsonPropertyName("homePhone")]
        public string HomePhone { get; set; }

        [JsonPropertyName("husbandOwnerId")]
        public object HusbandOwnerId { get; set; }

        [JsonPropertyName("isMunicipalityOwner")]
        public int? IsMunicipalityOwner { get; set; }

        [JsonPropertyName("lAddress")]
        public string LAddress { get; set; }

        [JsonPropertyName("lAddressBuildingNumber")]
        public string LAddressBuildingNumber { get; set; }

        [JsonPropertyName("lAddressCityId")]
        public int? LAddressCityId { get; set; }

        [JsonPropertyName("lEmail")]
        public string LEmail { get; set; }

        [JsonPropertyName("lFax")]
        public string LFax { get; set; }

        [JsonPropertyName("lHomePhone")]
        public string LHomePhone { get; set; }

        [JsonPropertyName("lPoBox")]
        public string LPoBox { get; set; }

        [JsonPropertyName("lPrimaryMobilePhone")]
        public string LPrimaryMobilePhone { get; set; }

        [JsonPropertyName("lSeconderyMobilePhobe")]
        public string LSeconderyMobilePhobe { get; set; }

        [JsonPropertyName("lWebsite")]
        public string LWebsite { get; set; }

        [JsonPropertyName("lWorkPhone")]
        public string LWorkPhone { get; set; }

        [JsonPropertyName("maritalStatusId")]
        public int? MaritalStatusId { get; set; }

        [JsonPropertyName("mergeComments")]
        public string MergeComments { get; set; }

        [JsonPropertyName("migNote")]
        public double? MigNote { get; set; }

        [JsonPropertyName("migNoteL")]
        public string MigNoteL { get; set; }

        [JsonPropertyName("migNoteLm")]
        public string MigNoteLm { get; set; }

        [JsonPropertyName("moiUnifiedNumber")]
        public string MoiUnifiedNumber { get; set; }

        [JsonPropertyName("motherName")]
        public string MotherName { get; set; }

        [JsonPropertyName("motherOwnerId")]
        public object MotherOwnerId { get; set; }

        [JsonPropertyName("nationalityId")]
        public int? NationalityId { get; set; }

        [JsonPropertyName("nationalNumber")]
        public string NationalNumber { get; set; }

        [JsonPropertyName("newOwnerId")]
        public object NewOwnerId { get; set; }

        [JsonPropertyName("nonLocalNationalNumber")]
        public string NonLocalNationalNumber { get; set; }

        [JsonPropertyName("onlineAccessVerified")]
        public bool? OnlineAccessVerified { get; set; }

        [JsonPropertyName("ownerGuid")]
        public string OwnerGuid { get; set; }

        [JsonPropertyName("ownerId")]
        public int? OwnerId { get; set; }

        [JsonPropertyName("ownerNameA")]
        public string OwnerNameA { get; set; }

        [JsonPropertyName("ownerNameE")]
        public string OwnerNameE { get; set; }

        [JsonPropertyName("ownerSource")]
        public int? OwnerSource { get; set; }

        [JsonPropertyName("ownerTitleId")]
        public int? OwnerTitleId { get; set; }

        [JsonPropertyName("ownerType")]
        public string OwnerType { get; set; }

        [JsonPropertyName("passportExpiryDate")]
        public DateTime? PassportExpiryDate { get; set; }

        [JsonPropertyName("passportIssueDate")]
        public DateTime? PassportIssueDate { get; set; }

        [JsonPropertyName("passportIssuePlace")]
        public string PassportIssuePlace { get; set; }

        [JsonPropertyName("passportNumber")]
        public string PassportNumber { get; set; }

        [JsonPropertyName("poBox")]
        public string PoBox { get; set; }

        [JsonPropertyName("primaryMobilePhone")]
        public string PrimaryMobilePhone { get; set; }

        [JsonPropertyName("seconderyMobilePhobe")]
        public string SeconderyMobilePhobe { get; set; }

        [JsonPropertyName("secondNameA")]
        public string SecondNameA { get; set; }

        [JsonPropertyName("secondNameE")]
        public string SecondNameE { get; set; }

        [JsonPropertyName("securitylevel")]
        public object Securitylevel { get; set; }

        [JsonPropertyName("sonCount")]
        public double? SonCount { get; set; }

        [JsonPropertyName("spouseName")]
        public string SpouseName { get; set; }

        [JsonPropertyName("thirdNameA")]
        public string ThirdNameA { get; set; }

        [JsonPropertyName("thirdNameE")]
        public string ThirdNameE { get; set; }

        [JsonPropertyName("tradeLicenseExpiryDate")]
        public object TradeLicenseExpiryDate { get; set; }

        [JsonPropertyName("tradeLicenseNumber")]
        public string TradeLicenseNumber { get; set; }

        [JsonPropertyName("tribeNameA")]
        public string TribeNameA { get; set; }

        [JsonPropertyName("tribeNameE")]
        public string TribeNameE { get; set; }

        [JsonPropertyName("userId")]
        public object UserId { get; set; }

        [JsonPropertyName("vatOwnerRegNo")]
        public string VatOwnerRegNo { get; set; }

        [JsonPropertyName("verificationType")]
        public object VerificationType { get; set; }

        [JsonPropertyName("website")]
        public string Website { get; set; }

        [JsonPropertyName("wivesCount")]
        public int? WivesCount { get; set; }

        [JsonPropertyName("workPhone")]
        public string WorkPhone { get; set; }

        [JsonPropertyName("plotShares")]
        public List<PlotShareResponse> PlotShares { get; set; }

        [JsonPropertyName("city")]
        public CityResponse City { get; set; }

        [JsonPropertyName("ownerTitle")]
        public OwnerTitleResponse OwnerTitle { get; set; }

        [JsonPropertyName("nationality")]
        public NationalityResponse Nationality { get; set; }

        [JsonPropertyName("maritalStatus")]
        public MaritalStatus MaritalStatus { get; set; }

        [JsonPropertyName("familyStatus")]
        public FamilyStatus FamilyStatus { get; set; }

        [JsonPropertyName("warning")]
        public object Warning { get; set; }

        [JsonPropertyName("archiveNumber")]
        public string ArchiveNumber { get; set; }

        [JsonPropertyName("primaryMobileNumber")]
        public string PrimaryMobileNumber { get; set; }

        [JsonPropertyName("companyType")]
        public object CompanyType { get; set; }

        [JsonPropertyName("type")]
        public object Type { get; set; }

        [JsonPropertyName("isAbuDhabiAudited")]
        public bool IsAbuDhabiAudited { get; set; }

        [JsonPropertyName("isAlAinAudited")]
        public bool IsAlAinAudited { get; set; }

        [JsonPropertyName("isWesternRegionAudited")]
        public bool IsWesternRegionAudited { get; set; }

        [JsonPropertyName("hasSpecialNationality")]
        public bool? HasSpecialNationality { get; set; }

        [JsonPropertyName("hasSpecialNationalityA")]
        public string HasSpecialNationalityA { get; set; }

        [JsonPropertyName("hasSpecialNationalityE")]
        public string HasSpecialNationalityE { get; set; }

        [JsonPropertyName("elmsOwnerCertificateModel")]
        public List<ElmsOwnerCertificateResponse> ElmsOwnerCertificateModel { get; set; }

        [JsonPropertyName("elmsOwnerDocumentModel")]
        public List<object> ElmsOwnerDocumentModel { get; set; }

        [JsonPropertyName("totalPercentOwnership")]
        public double TotalPercentOwnership { get; set; }

        [JsonPropertyName("totalPercentOwnershipString")]
        public string TotalPercentOwnershipString { get; set; }

        [JsonPropertyName("priority")]
        public int? Priority { get; set; }

        [JsonPropertyName("displayNameA")]
        public string DisplayNameA { get; set; }

        [JsonPropertyName("displayNameE")]
        public string DisplayNameE { get; set; }

        [JsonPropertyName("companyTypeA")]
        public object CompanyTypeA { get; set; }

        [JsonPropertyName("companyTypeE")]
        public object CompanyTypeE { get; set; }

        [JsonPropertyName("addressCityA")]
        public object AddressCityA { get; set; }

        [JsonPropertyName("addressCityE")]
        public object AddressCityE { get; set; }

        [JsonPropertyName("addressEmiratA")]
        public object AddressEmiratA { get; set; }

        [JsonPropertyName("addressEmiratE")]
        public object AddressEmiratE { get; set; }

        [JsonPropertyName("titleNameA")]
        public object TitleNameA { get; set; }

        [JsonPropertyName("titleNameE")]
        public object TitleNameE { get; set; }

        [JsonPropertyName("familyBookCityA")]
        public object FamilyBookCityA { get; set; }

        [JsonPropertyName("familyBookCityE")]
        public object FamilyBookCityE { get; set; }

        [JsonPropertyName("emirateId")]
        public int? EmirateId { get; set; }

        [JsonPropertyName("familyBookEmirateA")]
        public object FamilyBookEmirateA { get; set; }

        [JsonPropertyName("familyBookEmirateE")]
        public object FamilyBookEmirateE { get; set; }

        [JsonPropertyName("onlineStatusA")]
        public object OnlineStatusA { get; set; }

        [JsonPropertyName("onlineStatusE")]
        public object OnlineStatusE { get; set; }

        [JsonPropertyName("nationalityA")]
        public object NationalityA { get; set; }

        [JsonPropertyName("nationalityE")]
        public object NationalityE { get; set; }

        [JsonPropertyName("isLocal")]
        public bool IsLocal { get; set; }

        [JsonPropertyName("isGCC")]
        public bool IsGCC { get; set; }

        [JsonPropertyName("genderA")]
        public object GenderA { get; set; }

        [JsonPropertyName("genderE")]
        public object GenderE { get; set; }

        [JsonPropertyName("maritalStatusA")]
        public object MaritalStatusA { get; set; }

        [JsonPropertyName("maritalStatusE")]
        public object MaritalStatusE { get; set; }

        [JsonPropertyName("familyStatusNameA")]
        public object FamilyStatusNameA { get; set; }

        [JsonPropertyName("familyStatusNameE")]
        public object FamilyStatusNameE { get; set; }

        [JsonPropertyName("plots")]
        public object Plots { get; set; }

        [JsonPropertyName("ownerUrlArgs")]
        public object OwnerUrlArgs { get; set; }

        [JsonPropertyName("isAuthorizedOwner")]
        public bool IsAuthorizedOwner { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }
}