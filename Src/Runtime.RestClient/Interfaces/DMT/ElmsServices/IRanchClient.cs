using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ADREC.DTO.RestClientModels.DMT.ElmsServices.Ranch;
using ErrorOr;
using Runtime.DTO.ApiModels.DMTModel.Common;
using Runtime.DTO.ApiModels.DMTModel.ElmsServices;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.Common;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.Ranch;
using System.Net;

namespace Runtime.RestClient.Interfaces.DMT.ElmsServices
{
    public interface IRanchClient
    {
        Task<ErrorOr<DmtResponseWrapper<ApplicationDetailResponse>>> GetApplicationDetails(List<Cookie> cookies, string args);

        Task<ErrorOr<DmtResponseWrapper<DmtResponseWrapper<WfiDocumentAttachmentResponse>>>> Print(List<Cookie> cookies, string args);

        Task<ErrorOr<DmtResponseWrapper<List<ApplicantResponse>>>> AddApplicants(List<Cookie> cookies, string args);

        Task<ErrorOr<DmtResponseWrapper<List<ApplicantResponse>>>> GetApplicants(List<Cookie> cookies, string args);

        Task<ErrorOr<DmtResponseWrapper<List<LandClassificationResponse>>>> SearchRanchLandClassifications(List<Cookie> cookies, string args, RanchLandClassificationRequest model);

        Task<ErrorOr<DmtResponseWrapper<List<RanchAllocationSetResponse>>>> SearchRandomAllotmentSets(List<Cookie> cookies, string args, bool isRanch, long municipalityId);

        Task<ErrorOr<DmtResponseWrapper<List<RanchCardResponse>>>> GetRanchCards(List<Cookie> cookies, int pageSize, int pageNumber);

        Task<ErrorOr<DmtResponseWrapper<object>>> AddRecipients(List<Cookie> cookies, string args, AddRecipientRequest model);

        Task<ErrorOr<DmtResponseWrapper<object>>> AssignPlot(List<Cookie> cookies, string args, long plotId);

        Task<ErrorOr<DmtResponseWrapper<object>>> HoldApplication(List<Cookie> cookies, string args, HoldApplicationRequest model);

        Task<ErrorOr<DmtResponseWrapper<object>>> RemoveRecipients(List<Cookie> cookies, string args, AddRecipientRequest model);

        Task<ErrorOr<DmtResponseWrapper<RanchResponse>>> GetStepInfo(List<Cookie> cookies, string args);

        Task<ErrorOr<DmtResponseWrapper<RegistrationCancelResponse>>> RegistrationCancel(List<Cookie> cookies, string args, RegistrationCancelRequest model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalBack(List<Cookie> cookies, string args, BackRequest model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalReject(List<Cookie> cookies, string args, ApprovalRejectRequest model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalSubmit(List<Cookie> cookies, string args, ApprovalSubmitRequest model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> AssignmentBack(List<Cookie> cookies, string args, BackRequest model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> AssignmentReject(List<Cookie> cookies, string args, BackOfficeModel model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> AssignmentSubmit(List<Cookie> cookies, string args, AssignmentSubmitRequest model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> BackOfficePaymentSubmit(List<Cookie> cookies, string args, BackOfficePaymentSubmitRequest model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ConfirmCollectingPaymentsSubmit(List<Cookie> cookies, string args, ConfirmCollectingPaymentsSubmitRequest model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> PrintSubmit(List<Cookie> cookies, string args, ApprovalSubmitRequest model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegistrationSubmit(List<Cookie> cookies, string args, RanchRegistrationSubmitRequest model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, StartRanchWorkflowRequest model);
    }
}