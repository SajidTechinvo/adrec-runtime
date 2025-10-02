using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ErrorOr;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.AllowLandTrading;
using Runtime.DTO.ApiModels.DMTModel.Common;
using Runtime.DTO.ApiModels.DMTModel.ElmsServices;
using Runtime.DTO.RestClientModels.Common;
using System.Net;

namespace Runtime.RestClient.Interfaces.DMT.ElmsServices
{
    public interface IAllowLandTradingClient
    {
        Task<ErrorOr<DmtResponseWrapper<AllowLandTradingResponse>>> GetStepInfo(List<Cookie> cookies, string args);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalSubmit(List<Cookie> cookies, string args, CommentModel model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> EvaluationSubmit(List<Cookie> cookies, string args, EvaluateAllowLandTrading model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegistrationSubmit(List<Cookie> cookies, string args, RegisterAllowLandTrading model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, AddPlotRequest model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> PaymentSubmit(List<Cookie> cookies, string args, CommentModel model);
    }
}