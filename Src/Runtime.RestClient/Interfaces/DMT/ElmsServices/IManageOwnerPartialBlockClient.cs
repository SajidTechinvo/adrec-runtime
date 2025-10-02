using ADREC.DTO.ApiModels.DMTModel.ElmsServices;
using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ErrorOr;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.ManageOwnerPartialBlock;
using Runtime.DTO.ApiModels.DMTModel.Common;
using Runtime.DTO.RestClientModels.Common;
using System.Net;

namespace ADREC.RestClient.Interfaces.DMT.ElmsServices
{
    public interface IManageOwnerPartialBlockClient
    {
        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalApprove(List<Cookie> cookies, string args);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalReject(List<Cookie> cookies, string args, CommentModel model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegisterSubmit(List<Cookie> cookies, string args);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, StartManageOwnerPartialBlock model);

        Task<ErrorOr<DmtResponseWrapper<ManageOwnerPartialBlockResponse>>> GetStepInfo(List<Cookie> cookies, string args);
    }
}