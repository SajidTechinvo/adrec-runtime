using ADREC.DTO.ApiModels.DMTModel.ElmsServices;
using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ADREC.DTO.RestClientModels.DMT.ElmsServices.TenancyAgreementFix;
using ErrorOr;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.TenancyAgreementFix;
using Runtime.RestClient.Interfaces.DMT.ElmsServices;
using System.Net;
using System.Text.Json;

namespace Runtime.RestClient.Implementations.DMT.ElmsServices.TenancyAgreementFixClients
{
    internal class TenancyAgreementFixMockClient : ITenancyAgreementFixClient
    {
        #region Private Fields

        private static async Task<string> GetFileContent(string fileName)
        {
            var basePath = AppContext.BaseDirectory;

            var filePath = Path.Combine(basePath, "Response", "ElmsServices", "TenancyAgreementFix", fileName);

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"The file '{filePath}' was not found.");
            }

            return await File.ReadAllTextAsync(filePath);
        }

        #endregion Private Fields

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalSubmit(List<Cookie> cookies, string args)
        {
            var content = await GetFileContent("Workflow.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<TenancyAgreementFixResponse>>> GetStepInfo(List<Cookie> cookies, string args)
        {
            var content = await GetFileContent("StepInfo.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<TenancyAgreementFixResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegisterWorkflow(List<Cookie> cookies, string args, RegisterTenancyAgreementFix model)
        {
            var content = await GetFileContent("Workflow.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, StartTenancyAgreementFix model)
        {
            var content = await GetFileContent("Workflow.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<FetchTenancyContractFixDetailResponse>>> FetchTenancyContractDetails(List<Cookie> cookies, string args, long id)
        {
            var content = await GetFileContent("FetchTenancyContractDetails.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<FetchTenancyContractFixDetailResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<DataFixAmountResponse>>> DataFixScreenFeeAmount(List<Cookie> cookies, string args, bool isNewContract)
        {
            var content = await GetFileContent("DataFixAmount.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<DataFixAmountResponse>>(content);
        }

        #endregion Methods
    }
}