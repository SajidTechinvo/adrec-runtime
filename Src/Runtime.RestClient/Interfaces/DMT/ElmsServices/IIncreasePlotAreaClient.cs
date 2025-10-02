using ADREC.DTO.ApiModels.DMTModel.ElmsServices;
using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ErrorOr;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.IncreasePlotArea;
using Runtime.DTO.ApiModels.DMTModel.Common;
using Runtime.DTO.RestClientModels.Common;
using System.Net;

namespace ADREC.RestClient.Interfaces.DMT.ElmsServices
{
    public interface IIncreasePlotAreaClient
    {
        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, AddPlotRequest model);

        Task<ErrorOr<DmtResponseWrapper<IncreasePlotAreaResponse>>> GetStepInfo(List<Cookie> cookies, string args);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegisterSubmit(List<Cookie> cookies, string args, IncreasePlotAreaRegisterRequest model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> AssignEngineerSubmit(List<Cookie> cookies, string args, IncreasePlotAreaAssignEngineerRequest model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StudySubmit(List<Cookie> cookies, string args, IncreasePlotAreaStudyRequest model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> UrbanPlanningApprovalSubmit(List<Cookie> cookies, string args, BackOfficeModel model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> TPDApprovalSubmit(List<Cookie> cookies, string args, BackOfficeModel model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> UploadInitialSitePlanSubmit(List<Cookie> cookies, string args, BackOfficeModel model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> UploadNocLetterSubmit(List<Cookie> cookies, string args, BackOfficeModel model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> EvaluationSubmit(List<Cookie> cookies, string args, IncreasePlotAreaEvaluationRequest model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> GISApprovalLayerSubmit(List<Cookie> cookies, string args, BackOfficeModel model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> PropertyRegistrationApproval(List<Cookie> cookies, string args, BackOfficeModel model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> EngineerBack(List<Cookie> cookies, string args, CommentModel model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StudyBack(List<Cookie> cookies, string args, CommentModel model);
    }
}