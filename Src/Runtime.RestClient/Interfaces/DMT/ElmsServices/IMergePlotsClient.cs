using ADREC.DTO.ApiModels.DMTModel.ElmsServices;
using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ErrorOr;
using Runtime.DTO.RestClientModels.DMT.Plots;
using Runtime.DTO.ApiModels.DMTModel.Common;
using Runtime.DTO.RestClientModels.Common;
using System.Net;

namespace Runtime.RestClient.Interfaces.DMT.ElmsServices
{
    public interface IMergePlotsClient
    {
        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, StartMergePlotsRequest model);

        Task<ErrorOr<DmtResponseWrapper<StepMergePlotsResponse>>> GetStepInfo(List<Cookie> cookies, string args);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegistrationCancel(List<Cookie> cookies, string args, CommentModel model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegistrationSubmit(List<Cookie> cookies, string args, RegisterMergePlotsRequest model);
    }
}