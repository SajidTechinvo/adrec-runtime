using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ADREC.RestClient.Interfaces.Factory;
using ErrorOr;
using Runtime.Common.Settings;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.EditUnitDetail;
using Runtime.RestClient.Implementations.Factory;
using Runtime.DTO.ApiModels.DMTModel.ElmsServices;
using Runtime.DTO.RestClientModels.Common;
using Runtime.RestClient.Interfaces.DMT.ElmsServices;
using System.Net;

namespace ADREC.RestClient.Implementations.DMT.ElmsServices
{
    internal class EditUnitDetailClient(DmtSettings settings, ICustomHttpFactory httpFactory) : HttpBase(settings, httpFactory), IEditUnitDetailClient
    {
        #region Private Fields

        private readonly DmtSettings _settings = settings;

        #endregion Private Fields

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, StartEditUnitDetailRequest model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, StartEditUnitDetailRequest>(cookies, $"{_settings.BaseUrl}/api/elmsEditUnitDetails/startWorkflow?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegisterSubmit(List<Cookie> cookies, string args, SubmitEditUnitDetailRequest model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, SubmitEditUnitDetailRequest>(cookies, $"{_settings.BaseUrl}/api/elmsEditUnitDetails/registrationSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<EditUnitDetailResponse>>> GetStepInfo(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<EditUnitDetailResponse>, object>(cookies, $"{_settings.BaseUrl}/api/elmsEditUnitDetails/getStepInfo?args={args}", new { });
        }

        #endregion Methods
    }
}