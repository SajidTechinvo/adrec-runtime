using ADREC.DTO.RestClientModels.DMT.Plots;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.Common;
using Runtime.DTO.RestClientModels.DMT.Lookup;
using Runtime.DTO.RestClientModels.DMT.Plots.Common;
using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.Owners
{
    public class PlotOwnerResponse
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
        public int ApproveByUserId { get; set; }

        [JsonPropertyName("approveDate")]
        public DateTime? ApproveDate { get; set; }

        [JsonPropertyName("archiveFileNumberAA")]
        public int? ArchiveFileNumberAA { get; set; }

        [JsonPropertyName("archiveFileNumberAD")]
        public int? ArchiveFileNumberAD { get; set; }

        [JsonPropertyName("archiveFileNumberWR")]
        public int? ArchiveFileNumberWR { get; set; }

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

        [JsonPropertyName("companyOwnersNames")]
        public string CompanyOwnersNames { get; set; }

        [JsonPropertyName("companyTypeId")]
        public int? CompanyTypeId { get; set; }

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
        public int OwnerId { get; set; }

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
        public DateTime? TradeLicenseExpiryDate { get; set; }

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
        public int? VerificationType { get; set; }

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
        public object MaritalStatus { get; set; }

        [JsonPropertyName("familyStatus")]
        public object FamilyStatus { get; set; }

        [JsonPropertyName("companyType")]
        public object CompanyType { get; set; }

        [JsonPropertyName("warning")]
        public object Warning { get; set; }

        [JsonPropertyName("archiveNumber")]
        public string ArchiveNumber { get; set; }

        [JsonPropertyName("primaryMobileNumber")]
        public object PrimaryMobileNumber { get; set; }

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
        public List<ElmsOwnerDocumentResponse> ElmsOwnerDocumentModel { get; set; }

        [JsonPropertyName("totalPercentOwnership")]
        public double TotalPercentOwnership { get; set; }

        [JsonPropertyName("totalPercentOwnershipString")]
        public string TotalPercentOwnershipString { get; set; }

        [JsonPropertyName("priority")]
        public int Priority { get; set; }

        [JsonPropertyName("displayNameA")]
        public string DisplayNameA { get; set; }

        [JsonPropertyName("displayNameE")]
        public string DisplayNameE { get; set; }

        [JsonPropertyName("companyTypeA")]
        public string CompanyTypeA { get; set; }

        [JsonPropertyName("companyTypeE")]
        public string CompanyTypeE { get; set; }

        [JsonPropertyName("addressCityA")]
        public string AddressCityA { get; set; }

        [JsonPropertyName("addressCityE")]
        public string AddressCityE { get; set; }

        [JsonPropertyName("addressEmiratA")]
        public string AddressEmiratA { get; set; }

        [JsonPropertyName("addressEmiratE")]
        public string AddressEmiratE { get; set; }

        [JsonPropertyName("titleNameA")]
        public string TitleNameA { get; set; }

        [JsonPropertyName("titleNameE")]
        public string TitleNameE { get; set; }

        [JsonPropertyName("familyBookCityA")]
        public string FamilyBookCityA { get; set; }

        [JsonPropertyName("familyBookCityE")]
        public string FamilyBookCityE { get; set; }

        [JsonPropertyName("emirateId")]
        public object EmirateId { get; set; }

        [JsonPropertyName("familyBookEmirateA")]
        public string FamilyBookEmirateA { get; set; }

        [JsonPropertyName("familyBookEmirateE")]
        public string FamilyBookEmirateE { get; set; }

        [JsonPropertyName("onlineStatusA")]
        public string OnlineStatusA { get; set; }

        [JsonPropertyName("onlineStatusE")]
        public string OnlineStatusE { get; set; }

        [JsonPropertyName("nationalityA")]
        public string NationalityA { get; set; }

        [JsonPropertyName("nationalityE")]
        public string NationalityE { get; set; }

        [JsonPropertyName("isLocal")]
        public bool IsLocal { get; set; }

        [JsonPropertyName("isGCC")]
        public bool IsGCC { get; set; }

        [JsonPropertyName("genderA")]
        public string GenderA { get; set; }

        [JsonPropertyName("genderE")]
        public string GenderE { get; set; }

        [JsonPropertyName("maritalStatusA")]
        public string MaritalStatusA { get; set; }

        [JsonPropertyName("maritalStatusE")]
        public string MaritalStatusE { get; set; }

        [JsonPropertyName("familyStatusNameA")]
        public string FamilyStatusNameA { get; set; }

        [JsonPropertyName("familyStatusNameE")]
        public string FamilyStatusNameE { get; set; }

        [JsonPropertyName("plots")]
        public object Plots { get; set; }

        [JsonPropertyName("ownerUrlArgs")]
        public string OwnerUrlArgs { get; set; }

        [JsonPropertyName("isAuthorizedOwner")]
        public bool IsAuthorizedOwner { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }
}