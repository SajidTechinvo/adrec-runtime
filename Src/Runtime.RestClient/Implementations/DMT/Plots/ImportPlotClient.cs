using ADREC.DTO.ApiModels.DMTModel.ElmsServices;
using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ADREC.RestClient.Interfaces.Factory;
using ErrorOr;
using Runtime.Common.Settings;
using Runtime.DTO.RestClientModels.DMT.Plots;
using Runtime.RestClient.Implementations.Factory;
using Runtime.DTO.ApiModels.DMTModel.Common;
using Runtime.DTO.RestClientModels.Common;
using Runtime.RestClient.Interfaces.DMT.ElmsServices;
using System.Net;

namespace ADREC.RestClient.Implementations.DMT.Plots
{
    internal class ImportPlotClient(DmtSettings settings, ICustomHttpFactory httpFactory) : HttpBase(settings, httpFactory), IImportPlotClient
    {
        #region Private Fields

        private readonly DmtSettings _settings = settings;

        #endregion Private Fields

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, StartImportPlotRequest model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, StartImportPlotRequest>(cookies, $"{_settings.BaseUrl}/api/elmsImportPlot/startWorkflow?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<StepImportPlotResponse>>> GetStepInfo(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<StepImportPlotResponse>, object>(cookies, $"{_settings.BaseUrl}/api/elmsImportPlot/getStepInfo?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegistrationSubmit(List<Cookie> cookies, string args, RegisterImportPlotRequest model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, RegisterImportPlotRequest>(cookies, $"{_settings.BaseUrl}/api/elmsImportPlot/registrationSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegistrationCancel(List<Cookie> cookies, string args, CommentModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, CommentModel>(cookies, $"{_settings.BaseUrl}/api/elmsImportPlot/registrationCancel?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalBack(List<Cookie> cookies, string args, CommentModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, CommentModel>(cookies, $"{_settings.BaseUrl}/api/elmsImportPlot/approvalBack?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalReject(List<Cookie> cookies, string args, CommentModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, CommentModel>(cookies, $"{_settings.BaseUrl}/api/elmsImportPlot/approvalReject?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalApprove(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, object>(cookies, $"{_settings.BaseUrl}/api/elmsImportPlot/approvalApprove?args={args}", new { });
        }

        #endregion Methods
    }
}