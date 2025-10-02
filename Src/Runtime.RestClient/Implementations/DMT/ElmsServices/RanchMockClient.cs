using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ADREC.DTO.RestClientModels.DMT.ElmsServices.Ranch;
using ErrorOr;
using Runtime.DTO.ApiModels.DMTModel.Common;
using Runtime.DTO.ApiModels.DMTModel.ElmsServices;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.Common;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.Ranch;
using Runtime.RestClient.Interfaces.DMT.ElmsServices;
using System.Net;
using System.Text.Json;

namespace Runtime.RestClient.Implementations.DMT.ElmsServices
{
    internal class RanchMockClient : IRanchClient
    {
        #region Private Methods

        private static async Task<string> GetFileContent(string fileName)
        {
            var basePath = AppContext.BaseDirectory;

            var filePath = Path.Combine(basePath, "Response", "ElmsServices", "Ranch", fileName);

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"The file '{filePath}' was not found.");
            }

            return await File.ReadAllTextAsync(filePath);
        }

        #endregion Private Methods

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<RanchResponse>>> GetStepInfo(List<Cookie> cookies, string args)
        {
            var content = await GetFileContent("StepInfo.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<RanchResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<LandClassificationResponse>>>> SearchRanchLandClassifications(List<Cookie> cookies, string args, RanchLandClassificationRequest model)
        {
            var content = await GetFileContent("LandClassification.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<LandClassificationResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<object>>> AddRecipients(List<Cookie> cookies, string args, AddRecipientRequest model)
        {
            return await Task.FromResult(new DmtResponseWrapper<object>()
            {
                Success = true,
                App = true,
            });
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<ApplicantResponse>>>> AddApplicants(List<Cookie> cookies, string args)
        {
            var content = await GetFileContent("Applicants.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<ApplicantResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<ApplicantResponse>>>> GetApplicants(List<Cookie> cookies, string args)
        {
            var content = await GetFileContent("Applicants.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<ApplicantResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, StartRanchWorkflowRequest model)
        {
            var content = await GetFileContent("StartWorkflow.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<object>>> RemoveRecipients(List<Cookie> cookies, string args, AddRecipientRequest model)
        {
            return await Task.FromResult(new DmtResponseWrapper<object>()
            {
                Success = true,
                App = true,
            });
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegistrationSubmit(List<Cookie> cookies, string args, RanchRegistrationSubmitRequest model)
        {
            var content = await GetFileContent("Submit.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<RanchAllocationSetResponse>>>> SearchRandomAllotmentSets(List<Cookie> cookies, string args, bool isRanch, long municipalityId)
        {
            var content = await GetFileContent("RanchAllocationSet.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<RanchAllocationSetResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<RanchCardResponse>>>> GetRanchCards(List<Cookie> cookies, int pageSize, int pageNumber)
        {
            var content = await GetFileContent("Cards.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<RanchCardResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<object>>> HoldApplication(List<Cookie> cookies, string args, HoldApplicationRequest model)
        {
            var content = await GetFileContent("HoldApplication.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<object>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<RegistrationCancelResponse>>> RegistrationCancel(List<Cookie> cookies, string args, RegistrationCancelRequest model)
        {
            var content = await GetFileContent("RegistrationCancel.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<RegistrationCancelResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<object>>> AssignPlot(List<Cookie> cookies, string args, long plotId)
        {
            var content = await GetFileContent("AssignPlot.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<object>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> AssignmentBack(List<Cookie> cookies, string args, BackRequest model)
        {
            var content = await GetFileContent("AssignmentBack.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> AssignmentReject(List<Cookie> cookies, string args, BackOfficeModel model)
        {
            var content = await GetFileContent("AssignmentReject.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> AssignmentSubmit(List<Cookie> cookies, string args, AssignmentSubmitRequest model)
        {
            var content = await GetFileContent("AssignmentSubmit.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalSubmit(List<Cookie> cookies, string args, ApprovalSubmitRequest model)
        {
            var content = await GetFileContent("ApprovalSubmit.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalReject(List<Cookie> cookies, string args, ApprovalRejectRequest model)
        {
            var content = await GetFileContent("ApprovalReject.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalBack(List<Cookie> cookies, string args, BackRequest model)
        {
            var content = await GetFileContent("ApprovalBack.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ConfirmCollectingPaymentsSubmit(List<Cookie> cookies, string args, ConfirmCollectingPaymentsSubmitRequest model)
        {
            var content = await GetFileContent("ConfirmCollectingPaymentsSubmit.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<DmtResponseWrapper<WfiDocumentAttachmentResponse>>>> Print(List<Cookie> cookies, string args)
        {
            var content = await GetFileContent("Print.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<DmtResponseWrapper<WfiDocumentAttachmentResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> PrintSubmit(List<Cookie> cookies, string args, ApprovalSubmitRequest model)
        {
            var content = await GetFileContent("PrintSubmit.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> BackOfficePaymentSubmit(List<Cookie> cookies, string args, BackOfficePaymentSubmitRequest model)
        {
            var content = await GetFileContent("BackOfficePaymentSubmit.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<ApplicationDetailResponse>>> GetApplicationDetails(List<Cookie> cookies, string args)
        {
            var content = await GetFileContent("ApplicationDetail.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<ApplicationDetailResponse>>(content);
        }

        #endregion Methods
    }
}