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
    internal class PlotDemarcationClient(DmtSettings settings, ICustomHttpFactory httpFactory) : HttpBase(settings, httpFactory), IPlotDemarcationClient
    {
        #region Private Fields

        private readonly DmtSettings _settings = settings;

        #endregion Private Fields

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, AddPlotRequest model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, AddPlotRequest>(cookies, $"{_settings.BaseUrl}/api/elmsPlotDemarcation/startWorkflow?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<StepPlotDemarcationResponse>>> GetStepInfo(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<StepPlotDemarcationResponse>, object>(cookies, $"{_settings.BaseUrl}/api/elmsPlotDemarcation/getStepInfo?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegistrationCancel(List<Cookie> cookies, string args, CommentModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, CommentModel>(cookies, $"{_settings.BaseUrl}/api/elmsPlotDemarcation/registrationCancel?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegistrationSubmit(List<Cookie> cookies, string args, RegisterPlotDemarcationRequest model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, RegisterPlotDemarcationRequest>(cookies, $"{_settings.BaseUrl}/api/elmsPlotDemarcation/registrationSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> PrintAppointmentSlip(List<Cookie> cookies, string args, PrintAppointmentSlipPlotDemarcationRequest model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, PrintAppointmentSlipPlotDemarcationRequest>(cookies, $"{_settings.BaseUrl}/api/elmsPlotDemarcation/PrintAppointmentSlip?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> AssignSurveyAppointmentSubmit(List<Cookie> cookies, string args, AssignSurveyAppointmentSubmitPlotDemarcationRequest model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, AssignSurveyAppointmentSubmitPlotDemarcationRequest>(cookies, $"{_settings.BaseUrl}/api/elmsPlotDemarcation/assignSurveyAppointmentSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> CompletionApprove(List<Cookie> cookies, string args, BackOfficeModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, BackOfficeModel>(cookies, $"{_settings.BaseUrl}/api/elmsPlotDemarcation/completionApprove?args={args}", model);
        }

        #endregion Methods
    }
}