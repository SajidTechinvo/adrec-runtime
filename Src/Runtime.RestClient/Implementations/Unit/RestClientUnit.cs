using ADREC.RestClient.Implementations.DMT.Common;
using ADREC.RestClient.Implementations.DMT.ElmsDecree;
using ADREC.RestClient.Implementations.DMT.ElmsPayment;
using ADREC.RestClient.Implementations.DMT.ElmsServices;
using ADREC.RestClient.Implementations.DMT.ElmsServices.CreateOwnerBlockClients;
using ADREC.RestClient.Implementations.DMT.ElmsServices.CreatePlotBlockMockClients;
using ADREC.RestClient.Implementations.DMT.ElmsServices.CreateUnitBlockClients;
using ADREC.RestClient.Implementations.DMT.ElmsServices.ManagePlotLegalRemarksClients;
using ADREC.RestClient.Implementations.DMT.ElmsServices.ManagePlotPartialBlockClients;
using ADREC.RestClient.Implementations.DMT.ElmsServices.ManagerUnitPartialBlockClients;
using ADREC.RestClient.Implementations.DMT.ElmsServices.ManageUnitLegalRemarksClients;
using ADREC.RestClient.Implementations.DMT.ElmsServices.PropertyMortgageRedemptionClients;
using ADREC.RestClient.Implementations.DMT.ElmsServices.ReleaseOwnerBlockClients;
using ADREC.RestClient.Implementations.DMT.ElmsServices.ReleasePlotBlockClients;
using ADREC.RestClient.Implementations.DMT.ElmsServices.ReleaseUnitBlockClients;
using ADREC.RestClient.Implementations.DMT.ElmsServices.TenancyAgreementReplacementClients;
using ADREC.RestClient.Implementations.DMT.ElmsServices.UnassignedAllotmentTemporaryPlotClients;
using ADREC.RestClient.Implementations.DMT.ElmsTenancy;
using ADREC.RestClient.Implementations.DMT.PartialBlock;
using ADREC.RestClient.Implementations.DMT.Plots;
using ADREC.RestClient.Implementations.DMT.Profiles;
using ADREC.RestClient.Implementations.DMT.Users;
using ADREC.RestClient.Implementations.DMT.Users.Inbox;
using ADREC.RestClient.Interfaces;
using ADREC.RestClient.Interfaces.DMT;
using ADREC.RestClient.Interfaces.DMT.Common;
using ADREC.RestClient.Interfaces.DMT.ElmsPayment;
using ADREC.RestClient.Interfaces.DMT.ElmsServices;
using ADREC.RestClient.Interfaces.DMT.Mocks;
using ADREC.RestClient.Interfaces.DMT.Users;
using ADREC.RestClient.Interfaces.Factory;
using Microsoft.Extensions.Options;
using Runtime.Common.Settings;
using Runtime.RestClient.Implementations.DMT;
using Runtime.RestClient.Implementations.DMT.Common;
using Runtime.RestClient.Implementations.DMT.Documents;
using Runtime.RestClient.Implementations.DMT.ElmsServices;
using Runtime.RestClient.Implementations.DMT.ElmsServices.AllowLandTradingClients;
using Runtime.RestClient.Implementations.DMT.ElmsServices.ClearanceCertificateClients;
using Runtime.RestClient.Implementations.DMT.ElmsServices.ManageOwnerPartialBlockClients;
using Runtime.RestClient.Implementations.DMT.ElmsServices.ManagePlotPartialBlockClients;
using Runtime.RestClient.Implementations.DMT.ElmsServices.ManagerUnitPartialBlockClients;
using Runtime.RestClient.Implementations.DMT.ElmsServices.RegisterMusatahaContractClients;
using Runtime.RestClient.Implementations.DMT.ElmsServices.ReprintTempPlotTenancyContractClients;
using Runtime.RestClient.Implementations.DMT.ElmsServices.TenancyAgreementFixClients;
using Runtime.RestClient.Implementations.DMT.ElmsServices.TenancyAgreementReplacementClients;
using Runtime.RestClient.Implementations.DMT.ElmsUnits;
using Runtime.RestClient.Implementations.DMT.Mortgage;
using Runtime.RestClient.Implementations.DMT.Owners;
using Runtime.RestClient.Implementations.DMT.Plots;
using Runtime.RestClient.Implementations.DMT.Profiles;
using Runtime.RestClient.Implementations.DMT.Users;
using Runtime.RestClient.Implementations.DMT.Users.Inbox;
using Runtime.RestClient.Interfaces;
using Runtime.RestClient.Interfaces.DMT;
using Runtime.RestClient.Interfaces.DMT.Common;
using Runtime.RestClient.Interfaces.DMT.ElmsServices;
using Runtime.RestClient.Interfaces.DMT.ElmsTenancy;
using Runtime.RestClient.Interfaces.DMT.ElmsUnits;
using Runtime.RestClient.Interfaces.DMT.Users;
using Runtime.RestClient.Interfaces.Unit;

namespace Runtime.RestClient.Implementations.Unit
{
    internal class RestClientUnit(IOptions<DmtSettings> options, IHttpClientFactory clientFactory,
                                  ICustomHttpFactory customFactory) : IRestClientUnit
    {
        #region Private Fields

        private readonly string env = "Production";

        //private readonly string env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        private readonly IHttpClientFactory _clientFactory = clientFactory;

        private readonly ICustomHttpFactory _customFactory = customFactory;
        private readonly DmtSettings _options = options.Value;

        private IAllowLandTradingClient _allowLandTrading;
        private IApplicationClient _application;
        private IAuthClient _auth;
        private IChallengeClient _challenge;
        private ICreatePlotBlockClient _createPlotBlock;
        private ICreateOwnerBlockClient _createOwnerBlock;
        private ICreateUnitBlockClient _createUnitBlock;
        private IDemolitionAndConvertPublicHouseToResidentialLandClient _demolitionAndConvertPublicHouseToResidentialLand;
        private IEditPlotConstructionDateClient _editPlotConstructionDate;
        private IEditPlotDetailClient _editPlotDetail;
        private IEditUnitDetailClient _editUnitDetail;
        private IElmsPaymentClient _payment;
        private IElmsTenancyClient _tenancy;
        private IEmployeeClient _employee;
        private IDatastoreClient _datastore;
        private IPageInfoClient _pageInfo;
        private IFileClient _file;
        private IDocumentClient _document;
        private IImportPlotClient _importPlot;
        private IInboxClient _inbox;
        private IIncreasePlotAreaClient _increasePlotArea;
        private ILookupClient _lookup;
        private IManageOwnerPartialBlockClient _manageOwnerPartialBlock;
        private IManagePlotCommentClient _managePlotComment;
        private IManagePlotPartialBlockClient _managePlotPartialBlock;
        private IManageUnitPartialBlockClient _manageUnitPartialBlock;
        private IMergePlotsClient _mergePlots;
        private IMortgageClient _mortgage;
        private IMyActivityClient _myActivity;
        private INewsClient _news;
        private IOwnerClient _owner;
        private IPartialBlockClient _partialBlock;
        private IPlotClient _plot;
        private IPlotDemarcationClient _plotDemarcation;
        private IProfileClient _profile;
        private IPropertyMortgageRedemptionClient _propertyMortgageRedemption;
        private IPublicHouseToResidentialLandClient _publicHouseToResidentialLand;
        private IRanchClient _ranch;
        private IReleaseOwnerBlockClient _releaseOwnerBlock;
        private IReleasePlotBlockClient _releasePlotBlock;
        private IReleaseUnitBlockClient _releaseUnitBlock;
        private IUnitClient _unit;
        private ISwaggerClient _swagger;
        private IManagePlotLegalRemarksClient _managePlotLegalRemarks;
        private IManageUnitLegalRemarksClient _manageUnitLegalRemarks;
        private IClearanceCertificateClient _clearanceCertificate;
        private ITenancyAgreementFixClient _tenancyAgreementFix;
        private IElmsDecreeClient _decree;
        private IReprintTempPlotTenancyContractClient _reprintTempPlotTenancyContract;
        private IRegisterMusatahaContractClient _registerMusatahaContract;
        private IUnassignedAllotmentTemporaryPlotClient _unassignedAllotmentTemporaryPlot;
        private ITenancyAgreementReplacementClient _tenancyAgreementReplacement;

        #endregion Private Fields

        #region Properties

        public IDatastoreClient Datastore => _datastore ??= new DatastoreClient(_clientFactory);
        public IPageInfoClient PageInfo => _pageInfo ??= new PageInfoClient(_clientFactory);
        public ISwaggerClient Swagger => _swagger ??= new SwaggerClient(_clientFactory);

        public IAuthClient Auth
        {
            get
            {
                if (env == "Production")
                {
                    _auth = new AuthClient(_options);
                }
                else
                {
                    _auth = new AuthMockClient();
                }
                return _auth;
            }
        }

        public IApplicationClient Application
        {
            get
            {
                if (env == "Production")
                {
                    _application = new ApplicationClient(_options, _customFactory);
                }
                else
                {
                    _application = new ApplicationMockClient();
                }
                return _application;
            }
        }

        public IManagePlotCommentClient ManagePlotComment
        {
            get
            {
                if (env == "Production")
                {
                    _managePlotComment = new ManagePlotCommentClient(_options, _customFactory);
                }
                else
                {
                    _managePlotComment = new ManagePlotCommentMockClient();
                }
                return _managePlotComment;
            }
        }

        public IFileClient File
        {
            get
            {
                if (env == "Production")
                {
                    _file = new FileClient(_options, _customFactory);
                }
                else
                {
                    _file = new FileMockClient();
                }
                return _file;
            }
        }

        public IDocumentClient Document
        {
            get
            {
                if (env == "Production")
                {
                    _document = new DocumentClient(_options, _customFactory);
                }
                else
                {
                    throw new NotImplementedException();
                }
                return _document;
            }
        }

        public IEditPlotDetailClient EditPlotDetail
        {
            get
            {
                if (env == "Production")
                {
                    _editPlotDetail = new EditPlotDetailClient(_options, _customFactory);
                }
                else
                {
                    _editPlotDetail = new EditPlotDetailMockClient();
                }
                return _editPlotDetail;
            }
        }

        public IImportPlotClient ImportPlot
        {
            get
            {
                if (env == "Production")
                {
                    _importPlot = new ImportPlotClient(_options, _customFactory);
                }
                else
                {
                    _importPlot = new ImportPlotMockClient();
                }
                return _importPlot;
            }
        }

        public IEditPlotConstructionDateClient EditPlotConstructionDate
        {
            get
            {
                if (env == "Production")
                {
                    _editPlotConstructionDate = new EditPlotConstructionDateClient(_options, _customFactory);
                }
                else
                {
                    _editPlotConstructionDate = new EditPlotConstructionDateMockClient();
                }
                return _editPlotConstructionDate;
            }
        }

        public IPublicHouseToResidentialLandClient PublicHouseToResidentialLand
        {
            get
            {
                if (env == "Production")
                {
                    _publicHouseToResidentialLand = new PublicHouseToResidentialLandClient(_options, _customFactory);
                }
                else
                {
                    _publicHouseToResidentialLand = new PublicHouseToResidentialLandMockClient();
                }
                return _publicHouseToResidentialLand;
            }
        }

        public IDemolitionAndConvertPublicHouseToResidentialLandClient DemolitionAndConvertPublicHouseToResidentialLand
        {
            get
            {
                if (env == "Production")
                {
                    _demolitionAndConvertPublicHouseToResidentialLand = new DemolitionAndConvertPublicHouseToResidentialLandClient(_options, _customFactory);
                }
                else
                {
                    _demolitionAndConvertPublicHouseToResidentialLand = new DemolitionAndConvertPublicHouseToResidentialLandMockClient();
                }
                return _demolitionAndConvertPublicHouseToResidentialLand;
            }
        }

        public ILookupClient Lookup
        {
            get
            {
                if (env == "Production")
                {
                    _lookup = new LookupClient(_options, _customFactory);
                }
                else
                {
                    _lookup = new LookupMockClient();
                }
                return _lookup;
            }
        }

        public IPlotClient Plot
        {
            get
            {
                if (env == "Production")
                {
                    _plot = new PlotClient(_options, _customFactory);
                }
                else
                {
                    _plot = new PlotMockClient();
                }
                return _plot;
            }
        }

        public IProfileClient Profile
        {
            get
            {
                if (env == "Production")
                {
                    _profile = new ProfileClient(_options, _customFactory);
                }
                else
                {
                    _profile = new ProfileMockClient();
                }
                return _profile;
            }
        }

        public INewsClient News
        {
            get
            {
                if (env == "Production")
                {
                    _news = new NewsClient();
                }
                else
                {
                    _news = new NewsMockClient();
                }
                return _news;
            }
        }

        public IRanchClient Ranch
        {
            get
            {
                if (env == "Production")
                {
                    _ranch = new RanchClient(_options, _customFactory);
                }
                else
                {
                    _ranch = new RanchMockClient();
                }
                return _ranch;
            }
        }

        public IOwnerClient Owner
        {
            get
            {
                if (env == "Production")
                {
                    _owner = new OwnerClient(_options, _customFactory);
                }
                else
                {
                    _owner = new OwnerMockClient();
                }
                return _owner;
            }
        }

        public IUnitClient Unit
        {
            get
            {
                if (env == "Production")
                {
                    _unit = new UnitClient(_options, _customFactory);
                }
                else
                {
                    _unit = new UnitMockClient();
                }
                return _unit;
            }
        }

        public IInboxClient Inbox
        {
            get
            {
                if (env == "Production")
                {
                    _inbox = new InboxClient(_options, _customFactory);
                }
                else
                {
                    _inbox = new InboxMockClient();
                }
                return _inbox;
            }
        }

        public IElmsTenancyClient Tenancy
        {
            get
            {
                if (env == "Production")
                {
                    _tenancy = new ElmsTenancyClient(_options, _customFactory);
                }
                else
                {
                    _tenancy = new ElmsTenancyMockClient();
                }
                return _tenancy;
            }
        }

        public IElmsPaymentClient Payment
        {
            get
            {
                if (env == "Production")
                {
                    _payment = new ElmsPaymentClient(_options, _customFactory);
                }
                else
                {
                    _payment = new ElmsPaymentMockClient();
                }
                return _payment;
            }
        }

        public IEmployeeClient Employee
        {
            get
            {
                if (env == "Production")
                {
                    _employee = new EmployeeClient(_options, _customFactory);
                }
                else
                {
                    _employee = new EmployeeMockClient();
                }
                return _employee;
            }
        }

        public IChallengeClient Challenge => _challenge ??= new ChallengeClient();
        public IMyActivityClient MyActivity => _myActivity ??= new MyActivityClient();

        public IEditUnitDetailClient EditUnitDetail
        {
            get
            {
                if (env == "Production")
                {
                    _editUnitDetail = new EditUnitDetailClient(_options, _customFactory);
                }
                else
                {
                    _editUnitDetail = new EditUnitDetailMockClient();
                }
                return _editUnitDetail;
            }
        }

        public IIncreasePlotAreaClient IncreasePlotArea
        {
            get
            {
                if (env == "Production")
                {
                    _increasePlotArea = new IncreasePlotAreaClient(_options, _customFactory);
                }
                else
                {
                    _increasePlotArea = new IncreasePlotAreaMockClient();
                }
                return _increasePlotArea;
            }
        }

        public IPlotDemarcationClient PlotDemarcation
        {
            get
            {
                if (env == "Production")
                {
                    _plotDemarcation = new PlotDemarcationClient(_options, _customFactory);
                }
                else
                {
                    _plotDemarcation = new PlotDemarcationMockClient();
                }
                return _plotDemarcation;
            }
        }

        public IMergePlotsClient MergePlots
        {
            get
            {
                if (env == "Production")
                {
                    _mergePlots = new MergePlotsClient(_options, _customFactory);
                }
                else
                {
                    _mergePlots = new MergePlotsMockClient();
                }
                return _mergePlots;
            }
        }

        public IPropertyMortgageRedemptionClient PropertyMortgageRedemption
        {
            get
            {
                if (env == "Production")
                {
                    _propertyMortgageRedemption = new PropertyMortgageRedemptionClient(_options, _customFactory);
                }
                else
                {
                    _propertyMortgageRedemption = new PropertyMortgageRedemptionMockClient();
                }

                return _propertyMortgageRedemption;
            }
        }

        public IMortgageClient Mortgage
        {
            get
            {
                if (env == "Production")
                {
                    _mortgage = new MortgageClient(_options, _customFactory);
                }
                else
                {
                    _mortgage = new MortgageMockClient();
                }

                return _mortgage;
            }
        }

        public IAllowLandTradingClient AllowLandTrading
        {
            get
            {
                if (env == "Production")
                {
                    _allowLandTrading = new AllowLandTradingClient(_options, _customFactory);
                }
                else
                {
                    _allowLandTrading = new AllowLandTradingMockClient();
                }

                return _allowLandTrading;
            }
        }

        public ICreateUnitBlockClient CreateUnitBlock
        {
            get
            {
                if (env == "Production")
                {
                    _createUnitBlock = new CreateUnitBlockClient(_options, _customFactory);
                }
                else
                {
                    _createUnitBlock = new CreateUnitBlockMockClient();
                }

                return _createUnitBlock;
            }
        }

        public IReleaseUnitBlockClient ReleaseUnitBlock
        {
            get
            {
                if (env == "Production")
                {
                    _releaseUnitBlock = new ReleaseUnitBlockClient(_options, _customFactory);
                }
                else
                {
                    _releaseUnitBlock = new ReleaseUnitBlockMockClient();
                }
                return _releaseUnitBlock;
            }
        }

        public ICreatePlotBlockClient CreatePlotBlock
        {
            get
            {
                if (env == "Production")
                {
                    _createPlotBlock = new CreatePlotBlockClient(_options, _customFactory);
                }
                else
                {
                    _createPlotBlock = new CreatePlotBlockMockClient();
                }
                return _createPlotBlock;
            }
        }

        public ICreateOwnerBlockClient CreateOwnerBlock
        {
            get
            {
                if (env == "Production")
                {
                    _createOwnerBlock = new CreateOwnerBlockClient(_options, _customFactory);
                }
                else
                {
                    _createOwnerBlock = new CreateOwnerBlockMockClient();
                }
                return _createOwnerBlock;
            }
        }

        public IReleasePlotBlockClient ReleasePlotBlock
        {
            get
            {
                if (env == "Production")
                {
                    _releasePlotBlock = new ReleasePlotBlockClient(_options, _customFactory);
                }
                else
                {
                    _releasePlotBlock = new ReleasePlotBlockMockClient();
                }
                return _releasePlotBlock;
            }
        }

        public IManagePlotPartialBlockClient ManagePlotPartialBlock
        {
            get
            {
                if (env == "Production")
                {
                    _managePlotPartialBlock = new ManagePlotPartialBlockClient(_options, _customFactory);
                }
                else
                {
                    _managePlotPartialBlock = new ManagePlotPartialBlockMockClient();
                }
                return _managePlotPartialBlock;
            }
        }

        public IManageOwnerPartialBlockClient ManageOwnerPartialBlock
        {
            get
            {
                if (env == "Production")
                {
                    _manageOwnerPartialBlock = new ManageOwnerPartialBlockClient(_options, _customFactory);
                }
                else
                {
                    _manageOwnerPartialBlock = new ManageOwnerPartialBlockMockClient();
                }
                return _manageOwnerPartialBlock;
            }
        }

        public IManageUnitPartialBlockClient ManageUnitPartialBlock
        {
            get
            {
                if (env == "Production")
                {
                    _manageUnitPartialBlock = new ManageUnitPartialBlockClient(_options, _customFactory);
                }
                else
                {
                    _manageUnitPartialBlock = new ManageUnitPartialBlockMockClient();
                }
                return _manageUnitPartialBlock;
            }
        }

        public IPartialBlockClient PartialBlock
        {
            get
            {
                if (env == "Production")
                {
                    _partialBlock = new PartialBlockClient(_options, _customFactory);
                }
                else
                {
                    _partialBlock = new PartialBlockMockClient();
                }
                return _partialBlock;
            }
        }

        public IReleaseOwnerBlockClient ReleaseOwnerBlock
        {
            get
            {
                if (env == "Production")
                {
                    _releaseOwnerBlock = new ReleaseOwnerBlockClient(_options, _customFactory);
                }
                else
                {
                    _releaseOwnerBlock = new ReleaseOwnerBlockMockClient();
                }
                return _releaseOwnerBlock;
            }
        }

        public IManagePlotLegalRemarksClient ManagePlotLegalRemarks
        {
            get
            {
                if (env == "Production")
                {
                    _managePlotLegalRemarks = new ManagePlotLegalRemarksClient(_options, _customFactory);
                }
                else
                {
                    _managePlotLegalRemarks = new ManagePlotLegalRemarksMockClient();
                }
                return _managePlotLegalRemarks;
            }
        }

        public ITenancyAgreementFixClient TenancyAgreementFix
        {
            get
            {
                if (env == "Production")
                {
                    _tenancyAgreementFix ??= new TenancyAgreementFixClient(_options, _customFactory);
                }
                else
                {
                    _tenancyAgreementFix ??= new TenancyAgreementFixMockClient();
                }

                return _tenancyAgreementFix;
            }
        }
        public IManageUnitLegalRemarksClient ManageUnitLegalRemarks
        {
            get
            {
                if (env == "Production")
                {
                    _manageUnitLegalRemarks ??= new ManageUnitLegalRemarksClient(_options, _customFactory);
                }
                else
                {
                    _manageUnitLegalRemarks ??= new ManageUnitLegalRemarksMockClient();
                }
                return _manageUnitLegalRemarks;
            }
        }

        public IClearanceCertificateClient ClearanceCertificate
        {
            get
            {
                if (env == "Production")
                {
                    _clearanceCertificate = new ClearanceCertificateClient(_options, _customFactory);
                }
                else
                {
                    _clearanceCertificate = new ClearanceCertificateMockClient();
                }
                return _clearanceCertificate;
            }
        }

        public IElmsDecreeClient Decree
        {
            get
            {
                if (env == "Production")
                {
                    _decree = new ElmsDecreeClient(_options, _customFactory);
                }
                else
                {
                    _decree = new ElmsDecreeMockClient();
                }
                return _decree;
            }
        }

        public IReprintTempPlotTenancyContractClient ReprintTempPlotTenancyContract
        {
            get
            {
                if (env == "Production")
                {
                    _reprintTempPlotTenancyContract = new ReprintTempPlotTenancyContractClient(_options, _customFactory);
                }
                else
                {
                    _reprintTempPlotTenancyContract = new ReprintTempPlotTenancyContractMockClient();
                }
                return _reprintTempPlotTenancyContract;
            }
        }

        public IRegisterMusatahaContractClient RegisterMusatahaContract
        {
            get
            {
                if (env == "Production")
                {
                    _registerMusatahaContract = new RegisterMusatahaContractClient(_options, _customFactory);
                }
                else
                {
                    _registerMusatahaContract = new RegisterMusatahaContractMockClient();
                }
                return _registerMusatahaContract;
            }
        }
        public IUnassignedAllotmentTemporaryPlotClient UnassignedAllotmentTemporaryPlot
        {
            get
            {
                if (env == "Production")
                {
                    _unassignedAllotmentTemporaryPlot = new UnassignedAllotmentTemporaryPlotClient(_options, _customFactory);
                }
                else
                {
                    _unassignedAllotmentTemporaryPlot = new UnassignedAllotmentTemporaryPlotMockClient();
                }
                return _unassignedAllotmentTemporaryPlot;
            }
        }

        public ITenancyAgreementReplacementClient TenancyAgreementReplacement
        {
            get
            {
                if (env == "Production")
                {
                    _tenancyAgreementReplacement = new TenancyAgreementReplacementClient(_options, _customFactory);
                }
                else
                {
                    _tenancyAgreementReplacement = new TenancyAgreementReplacementMockClient();
                }
                return _tenancyAgreementReplacement;
            }
        }

        #endregion Properties
    }
}