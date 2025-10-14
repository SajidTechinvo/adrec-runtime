using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ADREC.DTO.RestClientModels.DMT.ElmsServices.Ranch;
using ADREC.RestClient.Interfaces.Factory;
using ErrorOr;
using Runtime.Common.Settings;
using Runtime.DTO.ApiModels.DMTModel.Common;
using Runtime.DTO.ApiModels.DMTModel.ElmsServices;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.Common;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.Ranch;
using Runtime.RestClient.Implementations.Factory;
using Runtime.RestClient.Interfaces.DMT.ElmsServices;
using System.Net;

namespace Runtime.RestClient.Implementations.DMT.ElmsServices
{
    internal class RanchClient(DmtSettings settings, ICustomHttpFactory httpFactory) : HttpBase(settings, httpFactory), IRanchClient
    {
        #region Private Fields

        private readonly DmtSettings _settings = settings;

        #endregion Private Fields

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<List<ApplicantResponse>>>> AddApplicants(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<List<ApplicantResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/elmsAllotmentOfRanchPlots/GetApplicants?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<object>>> AddRecipients(List<Cookie> cookies, string args, AddRecipientRequest model)
        {
            return await Post<DmtResponseWrapper<object>, AddRecipientRequest>(cookies, $"{_settings.BaseUrl}/api/elmsAllotmentOfRanchPlots/addRecipients?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<ApplicantResponse>>>> GetApplicants(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<List<ApplicantResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/elmsAllotmentOfRanchPlots/GetApplicants?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<RanchResponse>>> GetStepInfo(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<RanchResponse>, object>(cookies, $"{_settings.BaseUrl}/api/elmsAllotmentOfRanchPlots/getStepInfo?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<object>>> RemoveRecipients(List<Cookie> cookies, string args, AddRecipientRequest model)
        {
            return await Post<DmtResponseWrapper<object>, AddRecipientRequest>(cookies, $"{_settings.BaseUrl}/api/elmsAllotmentOfRanchPlots/RemoveRecipients?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<LandClassificationResponse>>>> SearchRanchLandClassifications(List<Cookie> cookies, string args, RanchLandClassificationRequest model)
        {
            return await Post<DmtResponseWrapper<List<LandClassificationResponse>>, RanchLandClassificationRequest>(cookies, $"{_settings.BaseUrl}/api/elmsLookup/searchRanchLandClassifications?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, StartRanchWorkflowRequest model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, StartRanchWorkflowRequest>(cookies, $"{_settings.BaseUrl}/api/elmsAllotmentOfRanchPlots/startBackOfficeWorkflow?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegistrationSubmit(List<Cookie> cookies, string args, RanchRegistrationSubmitRequest model)
        {
            var payload = new
            {
                ranchAllotmentRequestTypeId = model.RanchAllotmentRequestTypeId,
                requestlandClassificationId = model.RequestlandClassificationId,
                requestorIncome = model.RequestorIncome,
                requestorFamilyCount = model.RequestorFamilyCount,
                comments = model.Comments,
                isSocialCase = bool.TryParse(model.IsSocialCase, out var value) && value,
                entities = model.Entities
            };

            return await Post<DmtResponseWrapper<WorkflowResponse>, object>(cookies, $"{_settings.BaseUrl}/api/elmsAllotmentOfRanchPlots/RegistrationSubmit?args={args}", payload);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<RanchAllocationSetResponse>>>> SearchRandomAllotmentSets(List<Cookie> cookies, string args, bool isRanch, long municipalityId)
        {
            return await Post<DmtResponseWrapper<List<RanchAllocationSetResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/elmsLookup/searchRandomAllotmentSets?args={args}", new { isRanch, municipalityId });
        }

        public async Task<ErrorOr<DmtResponseWrapper<object>>> HoldApplication(List<Cookie> cookies, string args, HoldApplicationRequest model)
        {
            return await Post<DmtResponseWrapper<object>, HoldApplicationRequest>(cookies, $"{_settings.BaseUrl}/api/elmsAllotmentOfRanchPlots/holdApplication?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<RegistrationCancelResponse>>> RegistrationCancel(List<Cookie> cookies, string args, RegistrationCancelRequest model)
        {
            return await Post<DmtResponseWrapper<RegistrationCancelResponse>, RegistrationCancelRequest>(cookies, $"{_settings.BaseUrl}/api/elmsAllotmentOfRanchPlots/registrationCancel?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<object>>> AssignPlot(List<Cookie> cookies, string args, long plotId)
        {
            return await Post<DmtResponseWrapper<object>, object>(cookies, $"{_settings.BaseUrl}/api/elmsAllotmentOfRanchPlots/AssignPlot?args={args}", new { plotId });
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> AssignmentBack(List<Cookie> cookies, string args, BackRequest model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, BackRequest>(cookies, $"{_settings.BaseUrl}/api/elmsAllotmentOfRanchPlots/assignmentBack?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> AssignmentReject(List<Cookie> cookies, string args, BackOfficeModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, BackOfficeModel>(cookies, $"{_settings.BaseUrl}/api/elmsAllotmentOfRanchPlots/AssignmentReject?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> AssignmentSubmit(List<Cookie> cookies, string args, AssignmentSubmitRequest model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, AssignmentSubmitRequest>(cookies, $"{_settings.BaseUrl}/api/elmsAllotmentOfRanchPlots/assignmentSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalSubmit(List<Cookie> cookies, string args, ApprovalSubmitRequest model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, ApprovalSubmitRequest>(cookies, $"{_settings.BaseUrl}/api/elmsAllotmentOfRanchPlots/approvalSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalReject(List<Cookie> cookies, string args, ApprovalRejectRequest model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, ApprovalRejectRequest>(cookies, $"{_settings.BaseUrl}/api/elmsAllotmentOfRanchPlots/ApprovalReject?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalBack(List<Cookie> cookies, string args, BackRequest model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, BackRequest>(cookies, $"{_settings.BaseUrl}/api/elmsAllotmentOfRanchPlots/approvalBack?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ConfirmCollectingPaymentsSubmit(List<Cookie> cookies, string args, ConfirmCollectingPaymentsSubmitRequest model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, ConfirmCollectingPaymentsSubmitRequest>(cookies, $"{_settings.BaseUrl}/api/elmsAllotmentOfRanchPlots/confirmCollectingpaymentsSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<DmtResponseWrapper<WfiDocumentAttachmentResponse>>>> Print(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<DmtResponseWrapper<WfiDocumentAttachmentResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/elmsAllotmentOfRanchPlots/print?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> PrintSubmit(List<Cookie> cookies, string args, ApprovalSubmitRequest model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, ApprovalSubmitRequest>(cookies, $"{_settings.BaseUrl}/api/elmsAllotmentOfRanchPlots/printSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> BackOfficePaymentSubmit(List<Cookie> cookies, string args, BackOfficePaymentSubmitRequest model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, BackOfficePaymentSubmitRequest>(cookies, $"{_settings.BaseUrl}/api/elmsAllotmentOfRanchPlots/BackOfficePaymentSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<RanchCardResponse>>> GetRanchCards(List<Cookie> cookies, int pageSize, int pageNumber)
        {
            return await Post<DmtResponseWrapper<RanchCardResponse>, object>(cookies, $"{_settings.BaseUrl}/api/OneHub/GetRancheCardListing", new { pageNumber, pageSize });
        }

        public async Task<ErrorOr<DmtResponseWrapper<ApplicationDetailResponse>>> GetApplicationDetails(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<ApplicationDetailResponse>, object>(cookies, $"{_settings.BaseUrl}/api/OneHub/GetApplicationDetail?args={args}", new { });
        }

        #endregion Methods
    }
}