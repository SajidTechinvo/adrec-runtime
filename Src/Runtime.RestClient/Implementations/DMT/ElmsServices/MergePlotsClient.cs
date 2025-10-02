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

namespace ADREC.RestClient.Implementations.DMT.ElmsServices
{
    internal class MergePlotsClient(DmtSettings settings, ICustomHttpFactory httpFactory) : HttpBase(settings, httpFactory), IMergePlotsClient
    {
        #region Private Fields

        private readonly DmtSettings _settings = settings;

        #endregion Private Fields

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, StartMergePlotsRequest model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, StartMergePlotsRequest>(cookies, $"{_settings.BaseUrl}/api/elmsMergePlots/startWorkflow?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<StepMergePlotsResponse>>> GetStepInfo(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<StepMergePlotsResponse>, object>(cookies, $"{_settings.BaseUrl}/api/elmsMergePlots/getStepInfo?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegistrationCancel(List<Cookie> cookies, string args, CommentModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, CommentModel>(cookies, $"{_settings.BaseUrl}/api/elmsMergePlots/registrationCancel?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegistrationSubmit(List<Cookie> cookies, string args, RegisterMergePlotsRequest model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, RegisterMergePlotsRequest>(cookies, $"{_settings.BaseUrl}/api/elmsMergePlots/registrationSubmit?args={args}", model);
        }

        #endregion Methods
    }
}