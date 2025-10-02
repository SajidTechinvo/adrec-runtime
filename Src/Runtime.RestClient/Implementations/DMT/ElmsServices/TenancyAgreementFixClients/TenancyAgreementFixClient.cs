using ADREC.DTO.ApiModels.DMTModel.ElmsServices;
using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ADREC.DTO.RestClientModels.DMT.ElmsServices.TenancyAgreementFix;
using ADREC.RestClient.Interfaces.Factory;
using ErrorOr;
using Runtime.Common.Settings;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.TenancyAgreementFix;
using Runtime.RestClient.Implementations.Factory;
using Runtime.RestClient.Interfaces.DMT.ElmsServices;
using System.Net;

namespace Runtime.RestClient.Implementations.DMT.ElmsServices.TenancyAgreementFixClients
{
    internal class TenancyAgreementFixClient(DmtSettings settings, ICustomHttpFactory httpFactory) : HttpBase(settings, httpFactory), ITenancyAgreementFixClient
    {
        #region Private Fields

        private readonly DmtSettings _settings = settings;

        #endregion Private Fields

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<TenancyAgreementFixResponse>>> GetStepInfo(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<TenancyAgreementFixResponse>, object>(cookies, $"{_settings.BaseUrl}/api/elmsTenancyAgreementForIndustrialTempPlotsDataFix/getStepInfo?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, StartTenancyAgreementFix model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, StartTenancyAgreementFix>(cookies, $"{_settings.BaseUrl}/api/elmsTenancyAgreementForIndustrialTempPlotsDataFix/startWorkflow?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegisterWorkflow(List<Cookie> cookies, string args, RegisterTenancyAgreementFix model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, RegisterTenancyAgreementFix>(cookies, $"{_settings.BaseUrl}/api/elmsTenancyAgreementForIndustrialTempPlotsDataFix/registrationSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalSubmit(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, object>(cookies, $"{_settings.BaseUrl}/api/elmsTenancyAgreementForIndustrialTempPlotsDataFix/approvalApprove?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<FetchTenancyContractFixDetailResponse>>> FetchTenancyContractDetails(List<Cookie> cookies, string args, long id)
        {
            return await Post<DmtResponseWrapper<FetchTenancyContractFixDetailResponse>, object>(cookies, $"{_settings.BaseUrl}/api/elmsTenancyAgreementForIndustrialTempPlotsDataFix/FetchTenancyContractDetails?args={args}", new { id = id.ToString() });
        }

        public async Task<ErrorOr<DmtResponseWrapper<DataFixAmountResponse>>> DataFixScreenFeeAmount(List<Cookie> cookies, string args, bool isNewContract)
        {
            return await Post<DmtResponseWrapper<DataFixAmountResponse>, object>(cookies, $"{_settings.BaseUrl}/api/elmsTenancyAgreementForIndustrialTempPlotsDataFix/DataFixScreenFeeAmount?args={args}", new { isNewContract });
        }

        #endregion Methods
    }
}