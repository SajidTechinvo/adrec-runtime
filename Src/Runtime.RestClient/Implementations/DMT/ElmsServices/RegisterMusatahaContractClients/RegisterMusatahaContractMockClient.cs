using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ErrorOr;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.RegisterMusatahaContract;
using Runtime.DTO.ApiModels.DMTModel.Common;
using Runtime.DTO.ApiModels.DMTModel.ElmsPayment;
using Runtime.DTO.ApiModels.DMTModel.ElmsServices;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.Common;
using Runtime.RestClient.Interfaces.DMT.ElmsServices;
using System.Net;
using System.Text.Json;

namespace Runtime.RestClient.Implementations.DMT.ElmsServices.RegisterMusatahaContractClients
{
    internal class RegisterMusatahaContractMockClient : IRegisterMusatahaContractClient
    {
        #region Private Methods

        private static async Task<string> GetFileContent(string fileName)
        {
            var basePath = AppContext.BaseDirectory;

            var filePath = Path.Combine(basePath, "Response", "ElmsServices", "RegisterMusatahaContract", fileName);

            if (!File.Exists(filePath))
                throw new FileNotFoundException($"The file '{filePath}' was not found.");

            return await File.ReadAllTextAsync(filePath);
        }

        #endregion Private Methods

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalSubmit(List<Cookie> cookies, string args, ApproveRegisterMusatahaContract model)
        {
            var content = await GetFileContent("Workflow.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<RegisterMusatahaContractResponse>>> GetStepInfo(List<Cookie> cookies, string args)
        {
            var content = await GetFileContent("StepInfo.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<RegisterMusatahaContractResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> PaymentSubmit(List<Cookie> cookies, string args)
        {
            var content = await GetFileContent("Workflow.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WfiDocumentAttachmentResponse>>> PrintContract(List<Cookie> cookies, string args)
        {
            var content = await GetFileContent("PrintContract.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WfiDocumentAttachmentResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WfiDocumentAttachmentResponse>>> PrintPaymentSlip(List<Cookie> cookies, string args, PrintPaymentSlipRequest model)
        {
            var content = await GetFileContent("PrintPaymentSlip.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WfiDocumentAttachmentResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> PrintSubmit(List<Cookie> cookies, string args, BackOfficeModel model)
        {
            var content = await GetFileContent("Workflow.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegisterSubmit(List<Cookie> cookies, string args, SubmitRegisterMusatahaContractRequest model)
        {
            var content = await GetFileContent("Workflow.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, StartRegisterMusatahaContract model)
        {
            var content = await GetFileContent("Workflow.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        #endregion Methods
    }
}