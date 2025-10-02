using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ADREC.RestClient.Interfaces.Factory;
using ErrorOr;
using Runtime.Common.Settings;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.ManagePlotLegalRemarks;
using Runtime.RestClient.Implementations.Factory;
using Runtime.DTO.ApiModels.DMTModel.Common;
using Runtime.DTO.ApiModels.DMTModel.ElmsServices;
using Runtime.DTO.RestClientModels.Common;
using Runtime.RestClient.Interfaces.DMT.ElmsServices;
using System.Net;

namespace ADREC.RestClient.Implementations.DMT.ElmsServices.ManagePlotLegalRemarksClients
{
    internal class ManagePlotLegalRemarksClient(DmtSettings settings, ICustomHttpFactory httpFactory) : HttpBase(settings, httpFactory), IManagePlotLegalRemarksClient
    {
        #region Private Fields

        private readonly DmtSettings _settings = settings;

        #endregion Private Fields

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, StartManagePlotLegalRemarks model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, StartManagePlotLegalRemarks>(cookies, $"{_settings.BaseUrl}/api/elmsManagePlotLegalRemarks/startWorkflow?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<ManagePlotLegalRemarksResponse>>> GetStepInfo(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<ManagePlotLegalRemarksResponse>, object>(cookies, $"{_settings.BaseUrl}/api/elmsManagePlotLegalRemarks/getStepInfo?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegisterSubmit(List<Cookie> cookies, string args, RegisterManagePlotLegalRemarks model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, RegisterManagePlotLegalRemarks>(cookies, $"{_settings.BaseUrl}/api/elmsManagePlotLegalRemarks/registrationSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalBack(List<Cookie> cookies, string args, BackModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, BackModel>(cookies, $"{_settings.BaseUrl}/api/elmsManagePlotLegalRemarks/ApprovalBack?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalApprove(List<Cookie> cookies, string args, ApproveManagePlotLegalRemarks model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, ApproveManagePlotLegalRemarks>(cookies, $"{_settings.BaseUrl}/api/elmsManagePlotLegalRemarks/ApprovalApprove?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalReject(List<Cookie> cookies, string args, BackModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, BackModel>(cookies, $"{_settings.BaseUrl}/api/elmsManagePlotLegalRemarks/approvalReject?args={args}", model);
        }

        #endregion Methods
    }
}