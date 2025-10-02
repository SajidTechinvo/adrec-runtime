using ADREC.DTO.ApiModels.DMTModel.ElmsServices;
using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ADREC.RestClient.Interfaces.DMT.ElmsServices;
using ADREC.RestClient.Interfaces.Factory;
using ErrorOr;
using Runtime.Common.Settings;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.CreateUnitBlock;
using Runtime.RestClient.Implementations.Factory;
using Runtime.DTO.ApiModels.DMTModel.Common;
using Runtime.DTO.RestClientModels.Common;
using System.Net;

namespace ADREC.RestClient.Implementations.DMT.ElmsServices.CreateUnitBlockClients
{
    internal class CreateUnitBlockClient(DmtSettings settings, ICustomHttpFactory httpFactory) : HttpBase(settings, httpFactory), ICreateUnitBlockClient
    {
        #region Private Fields

        private readonly DmtSettings _settings = settings;

        #endregion Private Fields

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalApprove(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, object>(cookies, $"{_settings.BaseUrl}/api/elmsCreateUnitBlock/ApprovalApprove?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalReject(List<Cookie> cookies, string args, CommentModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, CommentModel>(cookies, $"{_settings.BaseUrl}/api/elmsCreateUnitBlock/approvalReject?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<CreateUnitBlockResponse>>> GetStepInfo(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<CreateUnitBlockResponse>, object>(cookies, $"{_settings.BaseUrl}/api/elmsCreateUnitBlock/getStepInfo?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegisterSubmit(List<Cookie> cookies, string args, RegisterSubmitCreateUnitBlock model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, RegisterSubmitCreateUnitBlock>(cookies, $"{_settings.BaseUrl}/api/elmsCreateUnitBlock/registrationSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, StartCreateUnitBlock model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, StartCreateUnitBlock>(cookies, $"{_settings.BaseUrl}/api/elmsCreateUnitBlock/startWorkflow?args={args}", model);
        }

        #endregion Methods
    }
}