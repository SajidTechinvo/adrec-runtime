using ADREC.DTO.ApiModels.DMTModel.ElmsServices;
using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ADREC.RestClient.Interfaces.DMT.ElmsServices;
using ADREC.RestClient.Interfaces.Factory;
using ErrorOr;
using Runtime.Common.Settings;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.ManageUnitPartialBlock;
using Runtime.RestClient.Implementations.Factory;
using Runtime.DTO.ApiModels.DMTModel.Common;
using Runtime.DTO.RestClientModels.Common;
using System.Net;

namespace ADREC.RestClient.Implementations.DMT.ElmsServices.ManagerUnitPartialBlockClients
{
    internal class ManageUnitPartialBlockClient(DmtSettings settings, ICustomHttpFactory httpFactory) : HttpBase(settings, httpFactory), IManageUnitPartialBlockClient
    {
        #region Private Fields

        private readonly DmtSettings _settings = settings;

        #endregion Private Fields

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalApprove(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, object>(cookies, $"{_settings.BaseUrl}/api/elmsManageUnitPartialBlocks/ApprovalApprove?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalReject(List<Cookie> cookies, string args, CommentModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, CommentModel>(cookies, $"{_settings.BaseUrl}/api/elmsManageUnitPartialBlocks/approvalReject?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<ManageUnitPartialBlockResponse>>> GetStepInfo(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<ManageUnitPartialBlockResponse>, object>(cookies, $"{_settings.BaseUrl}/api/elmsManageUnitPartialBlocks/startWorkflow?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, StartManageUnitPartialBlock model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, StartManageUnitPartialBlock>(cookies, $"{_settings.BaseUrl}/api/elmsManageUnitPartialBlocks/startWorkflow?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegisterSubmit(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, object>(cookies, $"{_settings.BaseUrl}/api/elmsManageUnitPartialBlocks/registrationSubmit?args={args}", new { });
        }

        #endregion Methods
    }
}