using ADREC.DTO.ApiModels.DMTModel.ElmsServices;
using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ADREC.RestClient.Interfaces.Factory;
using ErrorOr;
using Runtime.Common.Settings;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.ManageUnitLegalRemarks;
using Runtime.RestClient.Implementations.Factory;
using Runtime.DTO.ApiModels.DMTModel.Common;
using Runtime.DTO.RestClientModels.Common;
using Runtime.RestClient.Interfaces.DMT.ElmsServices;
using System.Net;

namespace ADREC.RestClient.Implementations.DMT.ElmsServices.ManageUnitLegalRemarksClients
{
    internal class ManageUnitLegalRemarksClient(DmtSettings settings, ICustomHttpFactory httpFactory) : HttpBase(settings, httpFactory), IManageUnitLegalRemarksClient
    {
        #region Private Fields

        private readonly DmtSettings _settings = settings;

        #endregion Private Fields

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, StartManageUnitLegalRemarks model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, StartManageUnitLegalRemarks>(cookies, $"{_settings.BaseUrl}/api/elmsManageUnitLegalRemarks/startWorkflow?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegisterSubmit(List<Cookie> cookies, string args, RegisterManageUnitLegalRemarks model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, RegisterManageUnitLegalRemarks>(cookies, $"{_settings.BaseUrl}/api/elmsManageUnitLegalRemarks/registrationSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<ManageUnitLegalRemarksResponse>>> GetStepInfo(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<ManageUnitLegalRemarksResponse>, object>(cookies, $"{_settings.BaseUrl}/api/elmsManageUnitLegalRemarks/getStepInfo?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalBack(List<Cookie> cookies, string args, BackModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, BackModel>(cookies, $"{_settings.BaseUrl}/api/elmsManageUnitLegalRemarks/ApprovalBack?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalApprove(List<Cookie> cookies, string args, ApproveManageUnitLegalRemarks model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, ApproveManageUnitLegalRemarks>(cookies, $"{_settings.BaseUrl}/api/elmsManageUnitLegalRemarks/ApprovalApprove?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalReject(List<Cookie> cookies, string args, BackModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, BackModel>(cookies, $"{_settings.BaseUrl}/api/elmsManageUnitLegalRemarks/approvalReject?args={args}", model);
        }

        #endregion Methods
    }
}