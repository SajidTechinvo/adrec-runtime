using ADREC.DTO.ApiModels.DMTModel.ElmsServices;
using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ErrorOr;
using Runtime.DTO.RestClientModels.DMT.Plots;
using Runtime.DTO.ApiModels.DMTModel.Common;
using Runtime.DTO.RestClientModels.Common;
using System.Net;

namespace Runtime.RestClient.Interfaces.DMT.ElmsServices
{
    public interface IPlotDemarcationClient
    {
        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, AddPlotRequest model);

        Task<ErrorOr<DmtResponseWrapper<StepPlotDemarcationResponse>>> GetStepInfo(List<Cookie> cookies, string args);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegistrationCancel(List<Cookie> cookies, string args, CommentModel model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegistrationSubmit(List<Cookie> cookies, string args, RegisterPlotDemarcationRequest model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> PrintAppointmentSlip(List<Cookie> cookies, string args, PrintAppointmentSlipPlotDemarcationRequest model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> AssignSurveyAppointmentSubmit(List<Cookie> cookies, string args, AssignSurveyAppointmentSubmitPlotDemarcationRequest model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> CompletionApprove(List<Cookie> cookies, string args, BackOfficeModel model);
    }
}