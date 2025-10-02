using ADREC.DTO.ApiModels.DMTModel.ElmsServices;
using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ADREC.RestClient.Interfaces.Factory;
using ErrorOr;
using Runtime.Common.Settings;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.TenancyAgreementReplacement;
using Runtime.RestClient.Implementations.Factory;
using Runtime.DTO.ApiModels.DMTModel.Common;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.Common;
using Runtime.RestClient.Interfaces.DMT.ElmsServices;
using System.Net;

namespace ADREC.RestClient.Implementations.DMT.ElmsServices.TenancyAgreementReplacementClients
{
    internal class TenancyAgreementReplacementClient(DmtSettings settings, ICustomHttpFactory httpFactory) : HttpBase(settings, httpFactory), ITenancyAgreementReplacementClient
    {
        #region Private Fields

        private readonly DmtSettings _settings = settings;

        #endregion Private Fields

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalSubmit(List<Cookie> cookies, string args, BackOfficeModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, BackOfficeModel>(cookies, $"{_settings.BaseUrl}/api/elmsTenancyAgreementReplacement/approvalSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<TenancyAgreementReplacementResponse>>> GetStepInfo(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<TenancyAgreementReplacementResponse>, object>(cookies, $"{_settings.BaseUrl}/api/elmsTenancyAgreementReplacement/getStepInfo?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> PrintSubmit(List<Cookie> cookies, string args, BackOfficeModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, BackOfficeModel>(cookies, $"{_settings.BaseUrl}/api/elmsTenancyAgreementReplacement/printSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WfiDocumentAttachmentResponse>>> PrintTenancyAgreementReplacementContract(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<WfiDocumentAttachmentResponse>, object>(cookies, $"{_settings.BaseUrl}/api/elmsTenancyAgreementReplacement/PrintTenancyAgreementReplacementContract?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegisterWorkflow(List<Cookie> cookies, string args, RegisterTenancyAgreementReplacement model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, RegisterTenancyAgreementReplacement>(cookies, $"{_settings.BaseUrl}/api/elmsTenancyAgreementReplacement/registrationSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, AddPlotRequest model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, AddPlotRequest>(cookies, $"{_settings.BaseUrl}/api/elmsTenancyAgreementReplacement/startWorkflow?args={args}", model);
        }

        #endregion Methods
    }
}