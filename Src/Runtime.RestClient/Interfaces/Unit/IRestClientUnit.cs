using ADREC.RestClient.Interfaces;
using ADREC.RestClient.Interfaces.DMT;
using ADREC.RestClient.Interfaces.DMT.Common;
using ADREC.RestClient.Interfaces.DMT.ElmsPayment;
using ADREC.RestClient.Interfaces.DMT.ElmsServices;
using ADREC.RestClient.Interfaces.DMT.Mocks;
using ADREC.RestClient.Interfaces.DMT.Users;
using Runtime.RestClient.Interfaces.DMT;
using Runtime.RestClient.Interfaces.DMT.Common;
using Runtime.RestClient.Interfaces.DMT.ElmsServices;
using Runtime.RestClient.Interfaces.DMT.ElmsTenancy;
using Runtime.RestClient.Interfaces.DMT.ElmsUnits;
using Runtime.RestClient.Interfaces.DMT.Users;

namespace Runtime.RestClient.Interfaces.Unit
{
    public interface IRestClientUnit
    {
        IDocumentClient Document { get; }
        IAllowLandTradingClient AllowLandTrading { get; }
        IApplicationClient Application { get; }
        IAuthClient Auth { get; }
        IChallengeClient Challenge { get; }
        ICreatePlotBlockClient CreatePlotBlock { get; }
        ICreateOwnerBlockClient CreateOwnerBlock { get; }
        ICreateUnitBlockClient CreateUnitBlock { get; }
        IDemolitionAndConvertPublicHouseToResidentialLandClient DemolitionAndConvertPublicHouseToResidentialLand { get; }
        IEditPlotConstructionDateClient EditPlotConstructionDate { get; }
        IEditPlotDetailClient EditPlotDetail { get; }
        IEditUnitDetailClient EditUnitDetail { get; }
        IElmsPaymentClient Payment { get; }
        IElmsTenancyClient Tenancy { get; }
        IElmsDecreeClient Decree { get; }
        IEmployeeClient Employee { get; }
        IDatastoreClient Datastore { get; }
        IPageInfoClient PageInfo { get; }
        IFileClient File { get; }
        IImportPlotClient ImportPlot { get; }
        IInboxClient Inbox { get; }
        IIncreasePlotAreaClient IncreasePlotArea { get; }
        ILookupClient Lookup { get; }
        IManageOwnerPartialBlockClient ManageOwnerPartialBlock { get; }
        IManagePlotCommentClient ManagePlotComment { get; }
        IManagePlotPartialBlockClient ManagePlotPartialBlock { get; }
        IManageUnitPartialBlockClient ManageUnitPartialBlock { get; }
        IMergePlotsClient MergePlots { get; }
        IMortgageClient Mortgage { get; }
        IMyActivityClient MyActivity { get; }
        INewsClient News { get; }
        IOwnerClient Owner { get; }
        IPartialBlockClient PartialBlock { get; }
        IPlotClient Plot { get; }
        IPlotDemarcationClient PlotDemarcation { get; }
        IProfileClient Profile { get; }
        IPropertyMortgageRedemptionClient PropertyMortgageRedemption { get; }
        IPublicHouseToResidentialLandClient PublicHouseToResidentialLand { get; }
        IRanchClient Ranch { get; }
        IReleaseOwnerBlockClient ReleaseOwnerBlock { get; }
        IReleasePlotBlockClient ReleasePlotBlock { get; }
        IReleaseUnitBlockClient ReleaseUnitBlock { get; }
        IUnitClient Unit { get; }
        ISwaggerClient Swagger { get; }
        IManagePlotLegalRemarksClient ManagePlotLegalRemarks { get; }
        IManageUnitLegalRemarksClient ManageUnitLegalRemarks { get; }
        IClearanceCertificateClient ClearanceCertificate { get; }
        IReprintTempPlotTenancyContractClient ReprintTempPlotTenancyContract { get; }
        IRegisterMusatahaContractClient RegisterMusatahaContract { get; }
        IUnassignedAllotmentTemporaryPlotClient UnassignedAllotmentTemporaryPlot { get; }
        ITenancyAgreementReplacementClient TenancyAgreementReplacement { get; }
        ITenancyAgreementFixClient TenancyAgreementFix { get; }
    }
}