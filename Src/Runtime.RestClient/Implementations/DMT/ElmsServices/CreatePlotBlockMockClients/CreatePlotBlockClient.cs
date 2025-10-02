using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ADREC.RestClient.Interfaces.Factory;
using ErrorOr;
using Runtime.Common.Settings;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.CreatePlotBlock;
using Runtime.RestClient.Implementations.Factory;
using Runtime.DTO.ApiModels.DMTModel.Common;
using Runtime.DTO.ApiModels.DMTModel.ElmsServices;
using Runtime.DTO.RestClientModels.Common;
using Runtime.RestClient.Interfaces.DMT.ElmsServices;
using System.Net;

namespace ADREC.RestClient.Implementations.DMT.ElmsServices.CreatePlotBlockMockClients
{
    internal class CreatePlotBlockClient(DmtSettings settings, ICustomHttpFactory httpFactory) : HttpBase(settings, httpFactory), ICreatePlotBlockClient
    {
        #region Private Fields

        private readonly DmtSettings _settings = settings;

        #endregion Private Fields

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalApprove(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, object>(cookies, $"{_settings.BaseUrl}/api/elmsCreatePlotBlock/ApprovalApprove?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalReject(List<Cookie> cookies, string args, CommentModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, CommentModel>(cookies, $"{_settings.BaseUrl}/api/elmsCreatePlotBlock/approvalReject?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<CreatePlotBlockResponse>>> GetStepInfo(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<CreatePlotBlockResponse>, object>(cookies, $"{_settings.BaseUrl}/api/elmsCreatePlotBlock/startWorkflow?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegisterSubmit(List<Cookie> cookies, string args, RegisterCreatePlotBlock model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, RegisterCreatePlotBlock>(cookies, $"{_settings.BaseUrl}/api/elmsCreatePlotBlock/registrationSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, StartCreatePlotBlock model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, StartCreatePlotBlock>(cookies, $"{_settings.BaseUrl}/api/elmsCreatePlotBlock/startWorkflow?args={args}", model);
        }

        #endregion Methods
    }
}