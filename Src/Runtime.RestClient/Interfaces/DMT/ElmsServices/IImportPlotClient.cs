using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ErrorOr;
using Runtime.DTO.RestClientModels.DMT.Plots;
using Runtime.DTO.ApiModels.DMTModel.Common;
using Runtime.DTO.RestClientModels.Common;
using System.Net;
using Runtime.DTO.ApiModels.DMTModel.ElmsServices;

namespace Runtime.RestClient.Interfaces.DMT.ElmsServices
{
    public interface IImportPlotClient
    {
        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, StartImportPlotRequest model);

        Task<ErrorOr<DmtResponseWrapper<StepImportPlotResponse>>> GetStepInfo(List<Cookie> cookies, string args);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegistrationSubmit(List<Cookie> cookies, string args, RegisterImportPlotRequest model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegistrationCancel(List<Cookie> cookies, string args, CommentModel model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalBack(List<Cookie> cookies, string args, CommentModel model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalReject(List<Cookie> cookies, string args, CommentModel model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalApprove(List<Cookie> cookies, string args);
    }
}