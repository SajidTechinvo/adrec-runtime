using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ADREC.DTO.RestClientModels.DMT.Plots;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.Common;
using Runtime.DTO.RestClientModels.DMT.ElmsTenancy;
using Runtime.DTO.RestClientModels.DMT.Lookup;
using Runtime.DTO.RestClientModels.DMT.Owners;
using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.ElmsServices.RegisterMusatahaContract
{
    public class IndustrialTenancyAgreementsContract
    {
        [JsonPropertyName("activityTypeA")]
        public string ActivityTypeA { get; set; }

        [JsonPropertyName("annualTenancyAmount")]
        public double AnnualTenancyAmount { get; set; }

        [JsonPropertyName("annualTenancyAmountPerUnit")]
        public double AnnualTenancyAmountPerUnit { get; set; }

        [JsonPropertyName("approveByUserId")]
        public int ApproveByUserId { get; set; }

        [JsonPropertyName("approveComment")]
        public string ApproveComment { get; set; }

        [JsonPropertyName("approveDate")]
        public DateTime ApproveDate { get; set; }

        [JsonPropertyName("cancelByUserId")]
        public object CancelByUserId { get; set; }

        [JsonPropertyName("cancelComment")]
        public string CancelComment { get; set; }

        [JsonPropertyName("cancelDate")]
        public object CancelDate { get; set; }

        [JsonPropertyName("contractDate")]
        public DateTime ContractDate { get; set; }

        [JsonPropertyName("contractNumber")]
        public string ContractNumber { get; set; }

        [JsonPropertyName("contractNumberOfYears")]
        public int ContractNumberOfYears { get; set; }

        [JsonPropertyName("electricityNumber")]
        public string ElectricityNumber { get; set; }

        [JsonPropertyName("endDate")]
        public DateTime EndDate { get; set; }

        [JsonPropertyName("firstPaymentNoOfYears")]
        public int FirstPaymentNoOfYears { get; set; }

        [JsonPropertyName("insuranceAmount")]
        public double? InsuranceAmount { get; set; }

        [JsonPropertyName("insuranceCompanyAddress")]
        public string InsuranceCompanyAddress { get; set; }

        [JsonPropertyName("insuranceCompanyEmirateId")]
        public int? InsuranceCompanyEmirateId { get; set; }

        [JsonPropertyName("insuranceCompanyLicNumber")]
        public string InsuranceCompanyLicNumber { get; set; }

        [JsonPropertyName("insuranceCompanyNameA")]
        public string InsuranceCompanyNameA { get; set; }

        [JsonPropertyName("insuranceCompanyNameE")]
        public string InsuranceCompanyNameE { get; set; }

        [JsonPropertyName("isFirstYearFreeOfPayment")]
        public bool IsFirstYearFreeOfPayment { get; set; }

        [JsonPropertyName("isRenew")]
        public bool IsRenew { get; set; }

        [JsonPropertyName("isRetired")]
        public object IsRetired { get; set; }

        [JsonPropertyName("isSocialCase")]
        public bool? IsSocialCase { get; set; }

        [JsonPropertyName("migNoteL")]
        public string MigNoteL { get; set; }

        [JsonPropertyName("migNoteLm")]
        public string MigNoteLm { get; set; }

        [JsonPropertyName("plotId")]
        public int PlotId { get; set; }

        [JsonPropertyName("plotTransactionId")]
        public int PlotTransactionId { get; set; }

        [JsonPropertyName("remarks")]
        public string Remarks { get; set; }

        [JsonPropertyName("requestLandClassificationId")]
        public object RequestLandClassificationId { get; set; }

        [JsonPropertyName("startDate")]
        public DateTime StartDate { get; set; }

        [JsonPropertyName("tenancyContractCategory")]
        public int TenancyContractCategory { get; set; }

        [JsonPropertyName("tenancyContractClass")]
        public int TenancyContractClass { get; set; }

        [JsonPropertyName("tenancyContractGuid")]
        public string TenancyContractGuid { get; set; }

        [JsonPropertyName("tenancyContractId")]
        public int TenancyContractId { get; set; }

        [JsonPropertyName("tenancyContractType")]
        public int TenancyContractType { get; set; }

        [JsonPropertyName("tenancyFirstRentAppPaymentId")]
        public int? TenancyFirstRentAppPaymentId { get; set; }

        [JsonPropertyName("tenancyInsuranceAppPaymentId")]
        public object TenancyInsuranceAppPaymentId { get; set; }

        [JsonPropertyName("terminationByUserId")]
        public int? TerminationByUserId { get; set; }

        [JsonPropertyName("terminationComment")]
        public string TerminationComment { get; set; }

        [JsonPropertyName("terminationDate")]
        public DateTime? TerminationDate { get; set; }

        [JsonPropertyName("unitType")]
        public string UnitType { get; set; }

        [JsonPropertyName("wasteFeeAppPaymentId")]
        public object WasteFeeAppPaymentId { get; set; }

        [JsonPropertyName("insuranceCompanyEmirate")]
        public object InsuranceCompanyEmirate { get; set; }

        [JsonPropertyName("applicationPayment")]
        public object ApplicationPayment { get; set; }

        [JsonPropertyName("paymentExpiryDate")]
        public object PaymentExpiryDate { get; set; }

        [JsonPropertyName("gcsCheques")]
        public object GcsCheques { get; set; }

        [JsonPropertyName("contractPayment")]
        public object ContractPayment { get; set; }

        [JsonPropertyName("contractDateFormat")]
        public object ContractDateFormat { get; set; }

        [JsonPropertyName("contractDuartion")]
        public int ContractDuartion { get; set; }

        [JsonPropertyName("startDateFormat")]
        public object StartDateFormat { get; set; }

        [JsonPropertyName("endDateFormat")]
        public object EndDateFormat { get; set; }

        [JsonPropertyName("terminationDateFormat")]
        public object TerminationDateFormat { get; set; }

        [JsonPropertyName("type")]
        public object Type { get; set; }

        [JsonPropertyName("status")]
        public object Status { get; set; }

        [JsonPropertyName("contractStatusValue")]
        public int ContractStatusValue { get; set; }

        [JsonPropertyName("unitTypeValue")]
        public object UnitTypeValue { get; set; }

        [JsonPropertyName("annualTenancyAmountInWords")]
        public object AnnualTenancyAmountInWords { get; set; }

        [JsonPropertyName("ranchTenancyRegistrationFee")]
        public double RanchTenancyRegistrationFee { get; set; }

        [JsonPropertyName("amountInWords")]
        public object AmountInWords { get; set; }

        [JsonPropertyName("totalContractAmount")]
        public object TotalContractAmount { get; set; }

        [JsonPropertyName("ranchTenancyRegistrationFeeInWord")]
        public object RanchTenancyRegistrationFeeInWord { get; set; }

        [JsonPropertyName("ranchInsuranceFee")]
        public double RanchInsuranceFee { get; set; }

        [JsonPropertyName("ranchInsuranceFeeInWord")]
        public object RanchInsuranceFeeInWord { get; set; }

        [JsonPropertyName("skipPayment")]
        public object SkipPayment { get; set; }

        [JsonPropertyName("isTerminated")]
        public object IsTerminated { get; set; }

        [JsonPropertyName("rentAmountFees")]
        public object RentAmountFees { get; set; }

        [JsonPropertyName("enableAnnualTenancyAmountPerUnit")]
        public bool EnableAnnualTenancyAmountPerUnit { get; set; }

        [JsonPropertyName("isRenewValue")]
        public object IsRenewValue { get; set; }

        [JsonPropertyName("insuranceCompanyId")]
        public object InsuranceCompanyId { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }

    public class LastPaymentTenant
    {
        [JsonPropertyName("accessGroups")]
        public object AccessGroups { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("addressBuildingNumber")]
        public string AddressBuildingNumber { get; set; }

        [JsonPropertyName("addressCityId")]
        public int AddressCityId { get; set; }

        [JsonPropertyName("approveByUserId")]
        public int ApproveByUserId { get; set; }

        [JsonPropertyName("approveDate")]
        public DateTime ApproveDate { get; set; }

        [JsonPropertyName("archiveFileNumberAA")]
        public object ArchiveFileNumberAA { get; set; }

        [JsonPropertyName("archiveFileNumberAD")]
        public object ArchiveFileNumberAD { get; set; }

        [JsonPropertyName("archiveFileNumberWR")]
        public object ArchiveFileNumberWR { get; set; }

        [JsonPropertyName("attorneyName")]
        public string AttorneyName { get; set; }

        [JsonPropertyName("attorneyOwnerId")]
        public object AttorneyOwnerId { get; set; }

        [JsonPropertyName("attorneyPhone")]
        public string AttorneyPhone { get; set; }

        [JsonPropertyName("auditFlags")]
        public int AuditFlags { get; set; }

        [JsonPropertyName("birthDate")]
        public DateTime BirthDate { get; set; }

        [JsonPropertyName("birthPlace")]
        public string BirthPlace { get; set; }

        [JsonPropertyName("buisinessFlags")]
        public int BuisinessFlags { get; set; }

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
        public int CompanyTypeId { get; set; }

        [JsonPropertyName("deathDate")]
        public object DeathDate { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("familyBookCityId")]
        public int FamilyBookCityId { get; set; }

        [JsonPropertyName("familyBookIssueDate")]
        public object FamilyBookIssueDate { get; set; }

        [JsonPropertyName("familyBookIssuePlace")]
        public string FamilyBookIssuePlace { get; set; }

        [JsonPropertyName("familyBookNumber")]
        public string FamilyBookNumber { get; set; }

        [JsonPropertyName("familyPageNumber")]
        public string FamilyPageNumber { get; set; }

        [JsonPropertyName("familyStatusId")]
        public object FamilyStatusId { get; set; }

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
        public object Gender { get; set; }

        [JsonPropertyName("homePhone")]
        public string HomePhone { get; set; }

        [JsonPropertyName("husbandOwnerId")]
        public object HusbandOwnerId { get; set; }

        [JsonPropertyName("isMunicipalityOwner")]
        public int IsMunicipalityOwner { get; set; }

        [JsonPropertyName("lAddress")]
        public string LAddress { get; set; }

        [JsonPropertyName("lAddressBuildingNumber")]
        public string LAddressBuildingNumber { get; set; }

        [JsonPropertyName("lAddressCityId")]
        public object LAddressCityId { get; set; }

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
        public int MaritalStatusId { get; set; }

        [JsonPropertyName("mergeComments")]
        public string MergeComments { get; set; }

        [JsonPropertyName("migNote")]
        public object MigNote { get; set; }

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
        public int NationalityId { get; set; }

        [JsonPropertyName("nationalNumber")]
        public string NationalNumber { get; set; }

        [JsonPropertyName("newOwnerId")]
        public object NewOwnerId { get; set; }

        [JsonPropertyName("nonLocalNationalNumber")]
        public string NonLocalNationalNumber { get; set; }

        [JsonPropertyName("onlineAccessVerified")]
        public bool OnlineAccessVerified { get; set; }

        [JsonPropertyName("ownerGuid")]
        public string OwnerGuid { get; set; }

        [JsonPropertyName("ownerId")]
        public int OwnerId { get; set; }

        [JsonPropertyName("ownerNameA")]
        public string OwnerNameA { get; set; }

        [JsonPropertyName("ownerNameE")]
        public string OwnerNameE { get; set; }

        [JsonPropertyName("ownerSource")]
        public object OwnerSource { get; set; }

        [JsonPropertyName("ownerTitleId")]
        public int OwnerTitleId { get; set; }

        [JsonPropertyName("ownerType")]
        public string OwnerType { get; set; }

        [JsonPropertyName("passportExpiryDate")]
        public DateTime PassportExpiryDate { get; set; }

        [JsonPropertyName("passportIssueDate")]
        public DateTime PassportIssueDate { get; set; }

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
        public double SonCount { get; set; }

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
        public object WivesCount { get; set; }

        [JsonPropertyName("workPhone")]
        public string WorkPhone { get; set; }

        [JsonPropertyName("plotShares")]
        public object PlotShares { get; set; }

        [JsonPropertyName("city")]
        public object City { get; set; }

        [JsonPropertyName("ownerTitle")]
        public object OwnerTitle { get; set; }

        [JsonPropertyName("nationality")]
        public object Nationality { get; set; }

        [JsonPropertyName("maritalStatus")]
        public object MaritalStatus { get; set; }

        [JsonPropertyName("familyStatus")]
        public object FamilyStatus { get; set; }

        [JsonPropertyName("companyType")]
        public object CompanyType { get; set; }

        [JsonPropertyName("warning")]
        public object Warning { get; set; }

        [JsonPropertyName("archiveNumber")]
        public object ArchiveNumber { get; set; }

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
        public object HasSpecialNationality { get; set; }

        [JsonPropertyName("hasSpecialNationalityA")]
        public object HasSpecialNationalityA { get; set; }

        [JsonPropertyName("hasSpecialNationalityE")]
        public object HasSpecialNationalityE { get; set; }

        [JsonPropertyName("elmsOwnerCertificateModel")]
        public object ElmsOwnerCertificateModel { get; set; }

        [JsonPropertyName("elmsOwnerDocumentModel")]
        public object ElmsOwnerDocumentModel { get; set; }

        [JsonPropertyName("totalPercentOwnership")]
        public double TotalPercentOwnership { get; set; }

        [JsonPropertyName("totalPercentOwnershipString")]
        public object TotalPercentOwnershipString { get; set; }

        [JsonPropertyName("priority")]
        public int Priority { get; set; }

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
        public object EmirateId { get; set; }

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

        [JsonPropertyName("customerId")]
        public object CustomerId { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }

    public class LastTenancyContractTenant
    {
        [JsonPropertyName("accessGroups")]
        public object AccessGroups { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("addressBuildingNumber")]
        public string AddressBuildingNumber { get; set; }

        [JsonPropertyName("addressCityId")]
        public int AddressCityId { get; set; }

        [JsonPropertyName("approveByUserId")]
        public int ApproveByUserId { get; set; }

        [JsonPropertyName("approveDate")]
        public DateTime ApproveDate { get; set; }

        [JsonPropertyName("archiveFileNumberAA")]
        public object ArchiveFileNumberAA { get; set; }

        [JsonPropertyName("archiveFileNumberAD")]
        public object ArchiveFileNumberAD { get; set; }

        [JsonPropertyName("archiveFileNumberWR")]
        public object ArchiveFileNumberWR { get; set; }

        [JsonPropertyName("attorneyName")]
        public string AttorneyName { get; set; }

        [JsonPropertyName("attorneyOwnerId")]
        public object AttorneyOwnerId { get; set; }

        [JsonPropertyName("attorneyPhone")]
        public string AttorneyPhone { get; set; }

        [JsonPropertyName("auditFlags")]
        public int AuditFlags { get; set; }

        [JsonPropertyName("birthDate")]
        public DateTime BirthDate { get; set; }

        [JsonPropertyName("birthPlace")]
        public string BirthPlace { get; set; }

        [JsonPropertyName("buisinessFlags")]
        public int BuisinessFlags { get; set; }

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
        public int CompanyTypeId { get; set; }

        [JsonPropertyName("deathDate")]
        public object DeathDate { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("familyBookCityId")]
        public int FamilyBookCityId { get; set; }

        [JsonPropertyName("familyBookIssueDate")]
        public object FamilyBookIssueDate { get; set; }

        [JsonPropertyName("familyBookIssuePlace")]
        public string FamilyBookIssuePlace { get; set; }

        [JsonPropertyName("familyBookNumber")]
        public string FamilyBookNumber { get; set; }

        [JsonPropertyName("familyPageNumber")]
        public string FamilyPageNumber { get; set; }

        [JsonPropertyName("familyStatusId")]
        public object FamilyStatusId { get; set; }

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
        public object Gender { get; set; }

        [JsonPropertyName("homePhone")]
        public string HomePhone { get; set; }

        [JsonPropertyName("husbandOwnerId")]
        public object HusbandOwnerId { get; set; }

        [JsonPropertyName("isMunicipalityOwner")]
        public int IsMunicipalityOwner { get; set; }

        [JsonPropertyName("lAddress")]
        public string LAddress { get; set; }

        [JsonPropertyName("lAddressBuildingNumber")]
        public string LAddressBuildingNumber { get; set; }

        [JsonPropertyName("lAddressCityId")]
        public object LAddressCityId { get; set; }

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
        public int MaritalStatusId { get; set; }

        [JsonPropertyName("mergeComments")]
        public string MergeComments { get; set; }

        [JsonPropertyName("migNote")]
        public object MigNote { get; set; }

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
        public int NationalityId { get; set; }

        [JsonPropertyName("nationalNumber")]
        public string NationalNumber { get; set; }

        [JsonPropertyName("newOwnerId")]
        public object NewOwnerId { get; set; }

        [JsonPropertyName("nonLocalNationalNumber")]
        public string NonLocalNationalNumber { get; set; }

        [JsonPropertyName("onlineAccessVerified")]
        public bool OnlineAccessVerified { get; set; }

        [JsonPropertyName("ownerGuid")]
        public string OwnerGuid { get; set; }

        [JsonPropertyName("ownerId")]
        public int OwnerId { get; set; }

        [JsonPropertyName("ownerNameA")]
        public string OwnerNameA { get; set; }

        [JsonPropertyName("ownerNameE")]
        public string OwnerNameE { get; set; }

        [JsonPropertyName("ownerSource")]
        public object OwnerSource { get; set; }

        [JsonPropertyName("ownerTitleId")]
        public int OwnerTitleId { get; set; }

        [JsonPropertyName("ownerType")]
        public string OwnerType { get; set; }

        [JsonPropertyName("passportExpiryDate")]
        public DateTime PassportExpiryDate { get; set; }

        [JsonPropertyName("passportIssueDate")]
        public DateTime PassportIssueDate { get; set; }

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
        public double SonCount { get; set; }

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
        public object WivesCount { get; set; }

        [JsonPropertyName("workPhone")]
        public string WorkPhone { get; set; }

        [JsonPropertyName("plotShares")]
        public object PlotShares { get; set; }

        [JsonPropertyName("city")]
        public object City { get; set; }

        [JsonPropertyName("ownerTitle")]
        public object OwnerTitle { get; set; }

        [JsonPropertyName("nationality")]
        public object Nationality { get; set; }

        [JsonPropertyName("maritalStatus")]
        public object MaritalStatus { get; set; }

        [JsonPropertyName("familyStatus")]
        public object FamilyStatus { get; set; }

        [JsonPropertyName("companyType")]
        public object CompanyType { get; set; }

        [JsonPropertyName("warning")]
        public object Warning { get; set; }

        [JsonPropertyName("archiveNumber")]
        public object ArchiveNumber { get; set; }

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
        public object HasSpecialNationality { get; set; }

        [JsonPropertyName("hasSpecialNationalityA")]
        public object HasSpecialNationalityA { get; set; }

        [JsonPropertyName("hasSpecialNationalityE")]
        public object HasSpecialNationalityE { get; set; }

        [JsonPropertyName("elmsOwnerCertificateModel")]
        public object ElmsOwnerCertificateModel { get; set; }

        [JsonPropertyName("elmsOwnerDocumentModel")]
        public object ElmsOwnerDocumentModel { get; set; }

        [JsonPropertyName("totalPercentOwnership")]
        public double TotalPercentOwnership { get; set; }

        [JsonPropertyName("totalPercentOwnershipString")]
        public object TotalPercentOwnershipString { get; set; }

        [JsonPropertyName("priority")]
        public int Priority { get; set; }

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
        public object EmirateId { get; set; }

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

        [JsonPropertyName("customerId")]
        public object CustomerId { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }

    public class OwnerShare
    {
        [JsonPropertyName("share")]
        public string Share { get; set; }

        [JsonPropertyName("shareComments")]
        public object ShareComments { get; set; }

        [JsonPropertyName("rightHoldTypeId")]
        public int RightHoldTypeId { get; set; }

        [JsonPropertyName("rightHoldTypeName")]
        public string RightHoldTypeName { get; set; }

        [JsonPropertyName("ownerShareId")]
        public int OwnerShareId { get; set; }

        [JsonPropertyName("acquisitionTypeId")]
        public int AcquisitionTypeId { get; set; }

        [JsonPropertyName("acquisitionTypeName")]
        public string AcquisitionTypeName { get; set; }
    }

    public class OwnerWithShare
    {
        [JsonPropertyName("owner")]
        public PlotOwnerResponse Owner { get; set; }

        [JsonPropertyName("priority")]
        public int Priority { get; set; }

        [JsonPropertyName("ownerShares")]
        public List<OwnerShare> OwnerShares { get; set; }
    }

    public class PlotOwnershipHistory
    {
        [JsonPropertyName("trasactionNameA")]
        public string TrasactionNameA { get; set; }

        [JsonPropertyName("trasactionNameE")]
        public string TrasactionNameE { get; set; }

        [JsonPropertyName("trasactionDate")]
        public DateTime TrasactionDate { get; set; }

        [JsonPropertyName("ownerWithShares")]
        public List<OwnerWithShare> OwnerWithShares { get; set; }
    }

    public class PlotRentPaymentList
    {
        [JsonPropertyName("amount")]
        public double Amount { get; set; }

        [JsonPropertyName("applicationPaymentId")]
        public int ApplicationPaymentId { get; set; }

        [JsonPropertyName("approveByUserId")]
        public int ApproveByUserId { get; set; }

        [JsonPropertyName("approveDate")]
        public DateTime ApproveDate { get; set; }

        [JsonPropertyName("cancelByUserId")]
        public object CancelByUserId { get; set; }

        [JsonPropertyName("cancelComments")]
        public string CancelComments { get; set; }

        [JsonPropertyName("cancelDate")]
        public object CancelDate { get; set; }

        [JsonPropertyName("comments")]
        public string Comments { get; set; }

        [JsonPropertyName("contractDate")]
        public object ContractDate { get; set; }

        [JsonPropertyName("contractNumber")]
        public string ContractNumber { get; set; }

        [JsonPropertyName("endDate")]
        public DateTime EndDate { get; set; }

        [JsonPropertyName("migNoteL")]
        public string MigNoteL { get; set; }

        [JsonPropertyName("migNoteLm")]
        public string MigNoteLm { get; set; }

        [JsonPropertyName("plotId")]
        public int PlotId { get; set; }

        [JsonPropertyName("plotTransactionId")]
        public int PlotTransactionId { get; set; }

        [JsonPropertyName("rentPaymentGuid")]
        public string RentPaymentGuid { get; set; }

        [JsonPropertyName("rentPaymentId")]
        public int RentPaymentId { get; set; }

        [JsonPropertyName("startDate")]
        public DateTime StartDate { get; set; }

        [JsonPropertyName("tenancyContractId")]
        public int TenancyContractId { get; set; }

        [JsonPropertyName("willRefund")]
        public int WillRefund { get; set; }

        [JsonPropertyName("feeType")]
        public object FeeType { get; set; }

        [JsonPropertyName("paymentStartDateFormat")]
        public object PaymentStartDateFormat { get; set; }

        [JsonPropertyName("paymentEndDateFormat")]
        public object PaymentEndDateFormat { get; set; }

        [JsonPropertyName("plot")]
        public object Plot { get; set; }

        [JsonPropertyName("plotTransaction")]
        public object PlotTransaction { get; set; }

        [JsonPropertyName("tenancyContractNumber")]
        public object TenancyContractNumber { get; set; }

        [JsonPropertyName("contractStartDate")]
        public object ContractStartDate { get; set; }

        [JsonPropertyName("contractEndDate")]
        public object ContractEndDate { get; set; }

        [JsonPropertyName("totalRentYears")]
        public int TotalRentYears { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }

    public class RentItem
    {
        [JsonPropertyName("rentItemType")]
        public int RentItemType { get; set; }

        [JsonPropertyName("rentLabel")]
        public string RentLabel { get; set; }

        [JsonPropertyName("startDate")]
        public DateTime StartDate { get; set; }

        [JsonPropertyName("endDate")]
        public DateTime EndDate { get; set; }

        [JsonPropertyName("rentAmount")]
        public double RentAmount { get; set; }
    }

    public class RentPayment
    {
        [JsonPropertyName("amount")]
        public double Amount { get; set; }

        [JsonPropertyName("applicationPaymentId")]
        public object ApplicationPaymentId { get; set; }

        [JsonPropertyName("approveByUserId")]
        public object ApproveByUserId { get; set; }

        [JsonPropertyName("approveDate")]
        public object ApproveDate { get; set; }

        [JsonPropertyName("cancelByUserId")]
        public object CancelByUserId { get; set; }

        [JsonPropertyName("cancelComments")]
        public object CancelComments { get; set; }

        [JsonPropertyName("cancelDate")]
        public object CancelDate { get; set; }

        [JsonPropertyName("comments")]
        public object Comments { get; set; }

        [JsonPropertyName("contractDate")]
        public object ContractDate { get; set; }

        [JsonPropertyName("contractNumber")]
        public object ContractNumber { get; set; }

        [JsonPropertyName("endDate")]
        public object EndDate { get; set; }

        [JsonPropertyName("migNoteL")]
        public object MigNoteL { get; set; }

        [JsonPropertyName("migNoteLm")]
        public object MigNoteLm { get; set; }

        [JsonPropertyName("plotId")]
        public object PlotId { get; set; }

        [JsonPropertyName("plotTransactionId")]
        public object PlotTransactionId { get; set; }

        [JsonPropertyName("rentPaymentGuid")]
        public object RentPaymentGuid { get; set; }

        [JsonPropertyName("rentPaymentId")]
        public object RentPaymentId { get; set; }

        [JsonPropertyName("startDate")]
        public DateTime StartDate { get; set; }

        [JsonPropertyName("tenancyContractId")]
        public object TenancyContractId { get; set; }

        [JsonPropertyName("willRefund")]
        public object WillRefund { get; set; }

        [JsonPropertyName("feeType")]
        public object FeeType { get; set; }

        [JsonPropertyName("paymentStartDateFormat")]
        public string PaymentStartDateFormat { get; set; }

        [JsonPropertyName("paymentEndDateFormat")]
        public object PaymentEndDateFormat { get; set; }

        [JsonPropertyName("plot")]
        public object Plot { get; set; }

        [JsonPropertyName("plotTransaction")]
        public object PlotTransaction { get; set; }

        [JsonPropertyName("tenancyContractNumber")]
        public object TenancyContractNumber { get; set; }

        [JsonPropertyName("contractStartDate")]
        public object ContractStartDate { get; set; }

        [JsonPropertyName("contractEndDate")]
        public object ContractEndDate { get; set; }

        [JsonPropertyName("totalRentYears")]
        public int TotalRentYears { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }

    public class RegisterMusatahaContractResponse
    {
        [JsonPropertyName("plot")]
        public PlotDetailResponse Plot { get; set; }

        [JsonPropertyName("selectedPlot")]
        public object SelectedPlot { get; set; }

        [JsonPropertyName("owners")]
        public List<PlotOwnerResponse> Owners { get; set; }

        [JsonPropertyName("lessor")]
        public string Lessor { get; set; }

        [JsonPropertyName("rentPayment")]
        public RentPayment RentPayment { get; set; }

        [JsonPropertyName("tenants")]
        public List<Tenant> Tenants { get; set; }

        [JsonPropertyName("municipality")]
        public MunicipalityResponse Municipality { get; set; }

        [JsonPropertyName("contractNumber")]
        public string ContractNumber { get; set; }

        [JsonPropertyName("isRentFreeFirstYear")]
        public object IsRentFreeFirstYear { get; set; }

        [JsonPropertyName("totalNumberOfYears")]
        public object TotalNumberOfYears { get; set; }

        [JsonPropertyName("rentFee")]
        public double RentFee { get; set; }

        [JsonPropertyName("paymentAmountInWordsE")]
        public string PaymentAmountInWordsE { get; set; }

        [JsonPropertyName("paymentAmountInWordsA")]
        public string PaymentAmountInWordsA { get; set; }

        [JsonPropertyName("tenancyRemarks")]
        public string TenancyRemarks { get; set; }

        [JsonPropertyName("refNumber")]
        public string RefNumber { get; set; }

        [JsonPropertyName("tenancyContract")]
        public TenancyContractResponse TenancyContract { get; set; }

        [JsonPropertyName("smsNotificationsList")]
        public List<object> SmsNotificationsList { get; set; }

        [JsonPropertyName("elmsPayments")]
        public List<object> ElmsPayments { get; set; }

        [JsonPropertyName("isStartedOnline")]
        public bool IsStartedOnline { get; set; }

        [JsonPropertyName("showFinesCheckbox")]
        public bool ShowFinesCheckbox { get; set; }

        [JsonPropertyName("isApplicationOnHold")]
        public bool IsApplicationOnHold { get; set; }

        [JsonPropertyName("rentItems")]
        public List<RentItem> RentItems { get; set; }

        [JsonPropertyName("applicationFeeMultiple")]
        public double ApplicationFeeMultiple { get; set; }

        [JsonPropertyName("rentPaymentStartDate")]
        public DateTime RentPaymentStartDate { get; set; }

        [JsonPropertyName("rentPaymentStartDateType")]
        public int RentPaymentStartDateType { get; set; }

        [JsonPropertyName("industrialTenancyAgreementsContract")]
        public List<IndustrialTenancyAgreementsContract> IndustrialTenancyAgreementsContract { get; set; }

        [JsonPropertyName("activePlotTrasactionApproveDate")]
        public DateTime ActivePlotTrasactionApproveDate { get; set; }

        [JsonPropertyName("activePlotTrasactionTypeA")]
        public string ActivePlotTrasactionTypeA { get; set; }

        [JsonPropertyName("activePlotTrasactionTypeE")]
        public string ActivePlotTrasactionTypeE { get; set; }

        [JsonPropertyName("plotRentPaymentList")]
        public List<PlotRentPaymentList> PlotRentPaymentList { get; set; }

        [JsonPropertyName("lastPaymentTenants")]
        public List<LastPaymentTenant> LastPaymentTenants { get; set; }

        [JsonPropertyName("lastTenancyContract")]
        public TenancyContractResponse LastTenancyContract { get; set; }

        [JsonPropertyName("lastTenancyContractTenants")]
        public List<LastTenancyContractTenant> LastTenancyContractTenants { get; set; }

        [JsonPropertyName("plotOwnershipHistory")]
        public List<PlotOwnershipHistory> PlotOwnershipHistory { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("workflowId")]
        public int WorkflowId { get; set; }

        [JsonPropertyName("workflowStepId")]
        public int WorkflowStepId { get; set; }

        [JsonPropertyName("workflowConst")]
        public string WorkflowConst { get; set; }

        [JsonPropertyName("workflowNameA")]
        public string WorkflowNameA { get; set; }

        [JsonPropertyName("workflowNameE")]
        public string WorkflowNameE { get; set; }

        [JsonPropertyName("workflowTypeId")]
        public int WorkflowTypeId { get; set; }

        [JsonPropertyName("workflowTypeConst")]
        public object WorkflowTypeConst { get; set; }

        [JsonPropertyName("workflowTypeNameA")]
        public object WorkflowTypeNameA { get; set; }

        [JsonPropertyName("workflowTypeNameE")]
        public object WorkflowTypeNameE { get; set; }

        [JsonPropertyName("workflowStepConst")]
        public string WorkflowStepConst { get; set; }

        [JsonPropertyName("workflowStepNameA")]
        public string WorkflowStepNameA { get; set; }

        [JsonPropertyName("workflowStepNameE")]
        public string WorkflowStepNameE { get; set; }

        [JsonPropertyName("applicationNumber")]
        public string ApplicationNumber { get; set; }

        [JsonPropertyName("appVersionNumber")]
        public int AppVersionNumber { get; set; }

        [JsonPropertyName("workflowStatusConst")]
        public string WorkflowStatusConst { get; set; }

        [JsonPropertyName("workflowOnlineViewPath")]
        public object WorkflowOnlineViewPath { get; set; }

        [JsonPropertyName("workflowBackOfficeViewPath")]
        public object WorkflowBackOfficeViewPath { get; set; }

        [JsonPropertyName("startDate")]
        public DateTime StartDate { get; set; }

        [JsonPropertyName("changeDraftStatusDate")]
        public object ChangeDraftStatusDate { get; set; }

        [JsonPropertyName("assignedCustomerNameA")]
        public string AssignedCustomerNameA { get; set; }

        [JsonPropertyName("assignedCustomerNameE")]
        public string AssignedCustomerNameE { get; set; }

        [JsonPropertyName("assignedCustomerEmail")]
        public string AssignedCustomerEmail { get; set; }

        [JsonPropertyName("hasEditPermission")]
        public bool HasEditPermission { get; set; }

        [JsonPropertyName("hasReadPermission")]
        public bool HasReadPermission { get; set; }

        [JsonPropertyName("hasStatusPermission")]
        public bool HasStatusPermission { get; set; }

        [JsonPropertyName("hasDocuments")]
        public bool HasDocuments { get; set; }

        [JsonPropertyName("hasInputDocuments")]
        public bool HasInputDocuments { get; set; }

        [JsonPropertyName("startUserDisplayNameA")]
        public string StartUserDisplayNameA { get; set; }

        [JsonPropertyName("startUserDisplayNameE")]
        public string StartUserDisplayNameE { get; set; }

        [JsonPropertyName("startUserEmail")]
        public string StartUserEmail { get; set; }

        [JsonPropertyName("startUserMobile")]
        public string StartUserMobile { get; set; }

        [JsonPropertyName("domainCustomerNameA")]
        public string DomainCustomerNameA { get; set; }

        [JsonPropertyName("domainCustomerNameE")]
        public string DomainCustomerNameE { get; set; }

        [JsonPropertyName("backOfficeResponse")]
        public object BackOfficeResponse { get; set; }

        [JsonPropertyName("assignedInboxNameA")]
        public string AssignedInboxNameA { get; set; }

        [JsonPropertyName("assignedInboxNameE")]
        public string AssignedInboxNameE { get; set; }

        [JsonPropertyName("businessEntities")]
        public List<BusinessEntityResponse> BusinessEntities { get; set; }

        [JsonPropertyName("wfiStepList")]
        public List<WfiStepListResponse> WfiStepList { get; set; }

        [JsonPropertyName("wfiNoteList")]
        public List<object> WfiNoteList { get; set; }

        [JsonPropertyName("relatedApplications")]
        public List<RelatedApplicationResponse> RelatedApplications { get; set; }

        [JsonPropertyName("multiPartyApprovalList")]
        public List<object> MultiPartyApprovalList { get; set; }

        [JsonPropertyName("workflowVersions")]
        public List<WorkflowVersionResponse> WorkflowVersions { get; set; }

        [JsonPropertyName("payments")]
        public List<object> Payments { get; set; }

        [JsonPropertyName("gatewayPayments")]
        public object GatewayPayments { get; set; }

        [JsonPropertyName("gcsPayments")]
        public List<object> GcsPayments { get; set; }

        [JsonPropertyName("isCompleted")]
        public bool IsCompleted { get; set; }

        [JsonPropertyName("isDraft")]
        public bool IsDraft { get; set; }

        [JsonPropertyName("draftAutoCancelPeriod")]
        public object DraftAutoCancelPeriod { get; set; }

        [JsonPropertyName("startUser")]
        public ElmsUserResponse StartUser { get; set; }

        [JsonPropertyName("currentUser")]
        public object CurrentUser { get; set; }

        [JsonPropertyName("domainCustomer")]
        public object DomainCustomer { get; set; }

        [JsonPropertyName("stepOrganizationUnitNameA")]
        public object StepOrganizationUnitNameA { get; set; }

        [JsonPropertyName("stepOrganizationUnitNameE")]
        public object StepOrganizationUnitNameE { get; set; }

        [JsonPropertyName("isWorkflowRated")]
        public bool IsWorkflowRated { get; set; }

        [JsonPropertyName("companyCustomer")]
        public object CompanyCustomer { get; set; }

        [JsonPropertyName("cdpProviderAuthType")]
        public object CdpProviderAuthType { get; set; }

        [JsonPropertyName("showWalletOption")]
        public bool ShowWalletOption { get; set; }

        [JsonPropertyName("resultTextE")]
        public object ResultTextE { get; set; }

        [JsonPropertyName("onwaniAddress")]
        public OnwaniAddressResponse OnwaniAddress { get; set; }

        [JsonPropertyName("selectedOnwaniPlot")]
        public object SelectedOnwaniPlot { get; set; }

        [JsonPropertyName("locationAddresslink")]
        public object LocationAddresslink { get; set; }

        [JsonPropertyName("tammUrlAr")]
        public object TammUrlAr { get; set; }

        [JsonPropertyName("tammUrlEn")]
        public object TammUrlEn { get; set; }

        [JsonPropertyName("isEnableRedirection")]
        public bool IsEnableRedirection { get; set; }

        [JsonPropertyName("workflowStatusNameA")]
        public string WorkflowStatusNameA { get; set; }

        [JsonPropertyName("workflowStatusNameE")]
        public string WorkflowStatusNameE { get; set; }

        [JsonPropertyName("sourceSystemConst")]
        public string SourceSystemConst { get; set; }

        [JsonPropertyName("sourceSystemNameA")]
        public object SourceSystemNameA { get; set; }

        [JsonPropertyName("sourceSystemNameE")]
        public object SourceSystemNameE { get; set; }

        [JsonPropertyName("distanceInMeter")]
        public double DistanceInMeter { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }

    public class Tenant
    {
        [JsonPropertyName("accessGroups")]
        public object AccessGroups { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("addressBuildingNumber")]
        public string AddressBuildingNumber { get; set; }

        [JsonPropertyName("addressCityId")]
        public int AddressCityId { get; set; }

        [JsonPropertyName("approveByUserId")]
        public int ApproveByUserId { get; set; }

        [JsonPropertyName("approveDate")]
        public DateTime ApproveDate { get; set; }

        [JsonPropertyName("archiveFileNumberAA")]
        public object ArchiveFileNumberAA { get; set; }

        [JsonPropertyName("archiveFileNumberAD")]
        public object ArchiveFileNumberAD { get; set; }

        [JsonPropertyName("archiveFileNumberWR")]
        public object ArchiveFileNumberWR { get; set; }

        [JsonPropertyName("attorneyName")]
        public string AttorneyName { get; set; }

        [JsonPropertyName("attorneyOwnerId")]
        public object AttorneyOwnerId { get; set; }

        [JsonPropertyName("attorneyPhone")]
        public string AttorneyPhone { get; set; }

        [JsonPropertyName("auditFlags")]
        public int AuditFlags { get; set; }

        [JsonPropertyName("birthDate")]
        public DateTime BirthDate { get; set; }

        [JsonPropertyName("birthPlace")]
        public string BirthPlace { get; set; }

        [JsonPropertyName("buisinessFlags")]
        public int BuisinessFlags { get; set; }

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
        public int CompanyTypeId { get; set; }

        [JsonPropertyName("deathDate")]
        public object DeathDate { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("familyBookCityId")]
        public int FamilyBookCityId { get; set; }

        [JsonPropertyName("familyBookIssueDate")]
        public object FamilyBookIssueDate { get; set; }

        [JsonPropertyName("familyBookIssuePlace")]
        public string FamilyBookIssuePlace { get; set; }

        [JsonPropertyName("familyBookNumber")]
        public string FamilyBookNumber { get; set; }

        [JsonPropertyName("familyPageNumber")]
        public string FamilyPageNumber { get; set; }

        [JsonPropertyName("familyStatusId")]
        public object FamilyStatusId { get; set; }

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
        public object Gender { get; set; }

        [JsonPropertyName("homePhone")]
        public string HomePhone { get; set; }

        [JsonPropertyName("husbandOwnerId")]
        public object HusbandOwnerId { get; set; }

        [JsonPropertyName("isMunicipalityOwner")]
        public int IsMunicipalityOwner { get; set; }

        [JsonPropertyName("lAddress")]
        public string LAddress { get; set; }

        [JsonPropertyName("lAddressBuildingNumber")]
        public string LAddressBuildingNumber { get; set; }

        [JsonPropertyName("lAddressCityId")]
        public object LAddressCityId { get; set; }

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
        public int MaritalStatusId { get; set; }

        [JsonPropertyName("mergeComments")]
        public string MergeComments { get; set; }

        [JsonPropertyName("migNote")]
        public object MigNote { get; set; }

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
        public int NationalityId { get; set; }

        [JsonPropertyName("nationalNumber")]
        public string NationalNumber { get; set; }

        [JsonPropertyName("newOwnerId")]
        public object NewOwnerId { get; set; }

        [JsonPropertyName("nonLocalNationalNumber")]
        public string NonLocalNationalNumber { get; set; }

        [JsonPropertyName("onlineAccessVerified")]
        public bool OnlineAccessVerified { get; set; }

        [JsonPropertyName("ownerGuid")]
        public string OwnerGuid { get; set; }

        [JsonPropertyName("ownerId")]
        public int OwnerId { get; set; }

        [JsonPropertyName("ownerNameA")]
        public string OwnerNameA { get; set; }

        [JsonPropertyName("ownerNameE")]
        public string OwnerNameE { get; set; }

        [JsonPropertyName("ownerSource")]
        public object OwnerSource { get; set; }

        [JsonPropertyName("ownerTitleId")]
        public int OwnerTitleId { get; set; }

        [JsonPropertyName("ownerType")]
        public string OwnerType { get; set; }

        [JsonPropertyName("passportExpiryDate")]
        public DateTime PassportExpiryDate { get; set; }

        [JsonPropertyName("passportIssueDate")]
        public DateTime PassportIssueDate { get; set; }

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
        public double SonCount { get; set; }

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
        public object WivesCount { get; set; }

        [JsonPropertyName("workPhone")]
        public string WorkPhone { get; set; }

        [JsonPropertyName("plotShares")]
        public List<PlotShareResponse> PlotShares { get; set; }

        [JsonPropertyName("city")]
        public object City { get; set; }

        [JsonPropertyName("ownerTitle")]
        public object OwnerTitle { get; set; }

        [JsonPropertyName("nationality")]
        public object Nationality { get; set; }

        [JsonPropertyName("maritalStatus")]
        public object MaritalStatus { get; set; }

        [JsonPropertyName("familyStatus")]
        public object FamilyStatus { get; set; }

        [JsonPropertyName("companyType")]
        public object CompanyType { get; set; }

        [JsonPropertyName("warning")]
        public object Warning { get; set; }

        [JsonPropertyName("archiveNumber")]
        public object ArchiveNumber { get; set; }

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
        public object HasSpecialNationality { get; set; }

        [JsonPropertyName("hasSpecialNationalityA")]
        public object HasSpecialNationalityA { get; set; }

        [JsonPropertyName("hasSpecialNationalityE")]
        public object HasSpecialNationalityE { get; set; }

        [JsonPropertyName("elmsOwnerCertificateModel")]
        public object ElmsOwnerCertificateModel { get; set; }

        [JsonPropertyName("elmsOwnerDocumentModel")]
        public object ElmsOwnerDocumentModel { get; set; }

        [JsonPropertyName("totalPercentOwnership")]
        public double TotalPercentOwnership { get; set; }

        [JsonPropertyName("totalPercentOwnershipString")]
        public object TotalPercentOwnershipString { get; set; }

        [JsonPropertyName("priority")]
        public int Priority { get; set; }

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
        public object EmirateId { get; set; }

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

        [JsonPropertyName("customerId")]
        public object CustomerId { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }
}