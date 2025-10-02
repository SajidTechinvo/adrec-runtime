using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ErrorOr;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.ReleaseUnitBlock;
using Runtime.DTO.ApiModels.DMTModel.Common;
using Runtime.DTO.ApiModels.DMTModel.ElmsServices;
using Runtime.DTO.RestClientModels.Common;
using System.Net;

namespace ADREC.RestClient.Interfaces.DMT.ElmsServices
{
    public interface IReleaseUnitBlockClient
    {
        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, StartReleaseUnitBlock model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegisterSubmit(List<Cookie> cookies, string args);

        Task<ErrorOr<DmtResponseWrapper<ReleaseUnitBlockResponse>>> GetStepInfo(List<Cookie> cookies, string args);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalReject(List<Cookie> cookies, string args, CommentModel model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalApprove(List<Cookie> cookies, string args);
    }
}