using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ErrorOr;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.UnassignedAllotmentTemporaryPlot;
using Runtime.DTO.ApiModels.DMTModel.Common;
using Runtime.DTO.ApiModels.DMTModel.ElmsServices;
using Runtime.DTO.RestClientModels.Common;
using System.Net;

namespace ADREC.RestClient.Interfaces.DMT.ElmsServices
{
    public interface IUnassignedAllotmentTemporaryPlotClient
    {
        Task<ErrorOr<DmtResponseWrapper<UnassignedAllotmentTemporaryPlotResponse>>> GetStepInfo(List<Cookie> cookies, string args);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, StartUnassignedAllotmentTemporaryPlot model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegisterWorkflow(List<Cookie> cookies, string args, RegisterUnassignedAllotmentTemporaryPlot model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> PreRegistrationSubmit(List<Cookie> cookies, string args, CommentModel model);

        Task<ErrorOr<DmtResponseWrapper<object>>> AddRecipient(List<Cookie> cookies, string args, UnassignedAllotmentTemporaryPlotAddRecipient model);

        Task<ErrorOr<DmtResponseWrapper<object>>> RemoveRecipient(List<Cookie> cookies, string args, UnassignedAllotmentTemporaryPlotAddRecipient model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> AuditOwnerPlotsSubmit(List<Cookie> cookies, string args, AuditUnassignedAllotmentTemporaryPlot model);
    }
}