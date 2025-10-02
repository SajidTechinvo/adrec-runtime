using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ADREC.RestClient.Interfaces.Factory;
using ErrorOr;
using Runtime.Common.Settings;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.ClearanceCertificate;
using Runtime.RestClient.Implementations.Factory;
using Runtime.DTO.ApiModels.DMTModel.Common;
using Runtime.DTO.ApiModels.DMTModel.ElmsServices;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.Documents;
using Runtime.RestClient.Interfaces.DMT.ElmsServices;
using System.Net;

namespace Runtime.RestClient.Implementations.DMT.ElmsServices.ClearanceCertificateClients
{
    internal class ClearanceCertificateClient(DmtSettings settings, ICustomHttpFactory httpFactory) : HttpBase(settings, httpFactory), IClearanceCertificateClient
    {
        #region Private Fields

        private readonly DmtSettings _settings = settings;

        #endregion Private Fields

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, StartClearanceCertificate model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, StartClearanceCertificate>(cookies, $"{_settings.BaseUrl}/api/elmsClearanceForIndustrialTempPlots/startWorkflow?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<ClearanceCertificateResponse>>> GetStepInfo(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<ClearanceCertificateResponse>, object>(cookies, $"{_settings.BaseUrl}/api/elmsClearanceForIndustrialTempPlots/getStepInfo?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegisterSubmit(List<Cookie> cookies, string args, RegisterClearanceCertificate model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, RegisterClearanceCertificate>(cookies, $"{_settings.BaseUrl}/api/elmsClearanceForIndustrialTempPlots/registrationSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalSubmit(List<Cookie> cookies, string args, CommentModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, CommentModel>(cookies, $"{_settings.BaseUrl}/api/elmsClearanceForIndustrialTempPlots/approvalSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<DocumentDownloadResponse>>> Print(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<DocumentDownloadResponse>, object>(cookies, $"{_settings.BaseUrl}/api/elmsClearanceForIndustrialTempPlots/print?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> PrintSubmit(List<Cookie> cookies, string args, CommentModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, CommentModel>(cookies, $"{_settings.BaseUrl}/api/elmsClearanceForIndustrialTempPlots/printSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegisterCancel(List<Cookie> cookies, string args, BackModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, BackModel>(cookies, $"{_settings.BaseUrl}/api/elmsClearanceForIndustrialTempPlots/registrationCancel?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalReject(List<Cookie> cookies, string args, BackModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, BackModel>(cookies, $"{_settings.BaseUrl}/api/elmsClearanceForIndustrialTempPlots/ApprovalReject?args={args}", model);
        }

        #endregion Methods
    }
}