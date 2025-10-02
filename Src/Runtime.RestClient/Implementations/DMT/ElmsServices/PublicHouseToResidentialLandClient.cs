using ADREC.DTO.ApiModels.DMTModel.ElmsServices;
using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ADREC.RestClient.Interfaces.Factory;
using ErrorOr;
using Runtime.Common.Settings;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.PublicHouseToResidentialLand;
using Runtime.RestClient.Implementations.Factory;
using Runtime.DTO.ApiModels.DMTModel.Common;
using Runtime.DTO.RestClientModels.Common;
using Runtime.RestClient.Interfaces.DMT.ElmsServices;
using System.Net;

namespace ADREC.RestClient.Implementations.DMT.ElmsServices
{
    internal class PublicHouseToResidentialLandClient(DmtSettings settings, ICustomHttpFactory httpFactory) : HttpBase(settings, httpFactory), IPublicHouseToResidentialLandClient
    {
        #region Private Fields

        private readonly DmtSettings _settings = settings;

        #endregion Private Fields

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> AuditWorkflow(List<Cookie> cookies, string args, BackOfficeModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, BackOfficeModel>(cookies, $"{_settings.BaseUrl}/api/elmsConvertPublicHouseToResidentialLand/auditSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> AuditBack(List<Cookie> cookies, string args, CommentModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, CommentModel>(cookies, $"{_settings.BaseUrl}/api/elmsConvertPublicHouseToResidentialLand/auditBack?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> CompletionApprove(List<Cookie> cookies, string args, BackOfficeModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, BackOfficeModel>(cookies, $"{_settings.BaseUrl}/api/elmsConvertPublicHouseToResidentialLand/completionApprove?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<PublicHouseToResidentialLandResponse>>> GetStepInfo(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<PublicHouseToResidentialLandResponse>, object>(cookies, $"{_settings.BaseUrl}/api/elmsConvertPublicHouseToResidentialLand/getStepInfo?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> InspectionSubmit(List<Cookie> cookies, string args, BackOfficeModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, BackOfficeModel>(cookies, $"{_settings.BaseUrl}/api/elmsConvertPublicHouseToResidentialLand/inspectionSubmit?args={args}", model);
        }

        public Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegistrationSubmit(List<Cookie> cookies, string args, PublicHouseToResidentialLandRegistrationSubmitRequest model)
        {
            return Post<DmtResponseWrapper<WorkflowResponse>, PublicHouseToResidentialLandRegistrationSubmitRequest>(cookies, $"{_settings.BaseUrl}/api/elmsConvertPublicHouseToResidentialLand/registrationSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, AddPlotRequest model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, AddPlotRequest>(cookies, $"{_settings.BaseUrl}/api/elmsConvertPublicHouseToResidentialLand/startWorkflow?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> TDPAuditSubmit(List<Cookie> cookies, string args, BackOfficeModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, BackOfficeModel>(cookies, $"{_settings.BaseUrl}/api/elmsConvertPublicHouseToResidentialLand/tPDAuditSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> InspectionBack(List<Cookie> cookies, string args, CommentModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, CommentModel>(cookies, $"{_settings.BaseUrl}/api/elmsConvertPublicHouseToResidentialLand/inspectionBack?args={args}", model);
        }

        #endregion Methods
    }
}