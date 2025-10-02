using ADREC.DTO.ApiModels.DMTModel.ElmsServices;
using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ErrorOr;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.PublicHouseToResidentialLand;
using Runtime.DTO.ApiModels.DMTModel.Common;
using Runtime.DTO.RestClientModels.Common;
using System.Net;

namespace Runtime.RestClient.Interfaces.DMT.ElmsServices
{
    public interface IDemolitionAndConvertPublicHouseToResidentialLandClient
    {
        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, AddPlotRequest model);

        Task<ErrorOr<DmtResponseWrapper<PublicHouseToResidentialLandResponse>>> GetStepInfo(List<Cookie> cookies, string args);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegistrationSubmit(List<Cookie> cookies, string args, PublicHouseToResidentialLandRegistrationSubmitRequest model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegistrationCancel(List<Cookie> cookies, string args, CommentModel model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> AuditSubmit(List<Cookie> cookies, string args, BackOfficeModel model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> AuditBack(List<Cookie> cookies, string args, CommentModel model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> InspectionSubmit(List<Cookie> cookies, string args, BackOfficeModel model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> InspectionBack(List<Cookie> cookies, string args, CommentModel model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> TPDApprovalBack(List<Cookie> cookies, string args, CommentModel model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> TDPAuditSubmit(List<Cookie> cookies, string args, BackOfficeModel model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> CompletionBack(List<Cookie> cookies, string args, CommentModel model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> CompletionApprove(List<Cookie> cookies, string args, BackOfficeModel model);
    }
}