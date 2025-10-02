using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ADREC.RestClient.Interfaces.Factory;
using ErrorOr;
using Runtime.Common.Settings;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.ReprintTempPlotTenancyContract;
using Runtime.RestClient.Implementations.Factory;
using Runtime.DTO.ApiModels.DMTModel.Common;
using Runtime.DTO.ApiModels.DMTModel.ElmsServices;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.Documents;
using Runtime.DTO.RestClientModels.DMT.Owners;
using Runtime.RestClient.Interfaces.DMT.ElmsServices;
using System.Net;
using System.Text.Json;

namespace Runtime.RestClient.Implementations.DMT.ElmsServices.ReprintTempPlotTenancyContractClients
{
    internal class ReprintTempPlotTenancyContractClient(DmtSettings settings, ICustomHttpFactory httpFactory) : HttpBase(settings, httpFactory), IReprintTempPlotTenancyContractClient
    {
        #region Private Fields

        private readonly DmtSettings _settings = settings;

        #endregion Private Fields

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, StartReprintTempPlotTenancyContract model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, StartReprintTempPlotTenancyContract>(cookies, $"{_settings.BaseUrl}/api/elmsReprintTempPlotTenancyContract/startWorkflow?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<ReprintTempPlotTenancyContractResponse>>> GetStepInfo(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<ReprintTempPlotTenancyContractResponse>, object>(cookies, $"{_settings.BaseUrl}/api/elmsReprintTempPlotTenancyContract/getStepInfo?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<PlotOwnerResponse>>>> FetchNewOwners(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<List<PlotOwnerResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/elmsReprintTempPlotTenancyContract/FetchNewOwners?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<object>>> AddRecipient(List<Cookie> cookies, string args, AddRecipientRequest model)
        {
            return await Post<DmtResponseWrapper<object>, AddRecipientRequest>(cookies, $"{_settings.BaseUrl}/api/elmsReprintTempPlotTenancyContract/AddRecipients?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<PlotOwnerResponse>>>> GetRecipient(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<List<PlotOwnerResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/elmsReprintTempPlotTenancyContract/GetApplicants?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegisterSubmit(List<Cookie> cookies, string args, RegisterReprintTempPlotTenancyContract model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, RegisterReprintTempPlotTenancyContract>(cookies, $"{_settings.BaseUrl}/api/elmsReprintTempPlotTenancyContract/registrationSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalSubmit(List<Cookie> cookies, string args, BackOfficeModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, BackOfficeModel>(cookies, $"{_settings.BaseUrl}/api/elmsReprintTempPlotTenancyContract/approvalSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<DocumentDownloadResponse>>> PrintContract(List<Cookie> cookies, string args, PrintContractReprintTempPlotTenancyContract model)
        {
            return await Post<DmtResponseWrapper<DocumentDownloadResponse>, PrintContractReprintTempPlotTenancyContract>(cookies, $"{_settings.BaseUrl}/api/elmsReprintTempPlotTenancyContract/printContract?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> PrintSubmit(List<Cookie> cookies, string args, CommentModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, CommentModel>(cookies, $"{_settings.BaseUrl}/api/elmsReprintTempPlotTenancyContract/printStickersSubmit?args={args}", model);
        }

        #endregion Methods
    }

    internal class ReprintTempPlotTenancyContractMockClient() : IReprintTempPlotTenancyContractClient
    {
        #region Private Methods

        private static async Task<string> GetFileContent(string fileName)
        {
            var basePath = AppContext.BaseDirectory;

            var filePath = Path.Combine(basePath, "Response", "ElmsServices", "ReprintTempPlotTenancyContract", fileName);

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"The file '{filePath}' was not found.");
            }

            return await File.ReadAllTextAsync(filePath);
        }

        #endregion Private Methods

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, StartReprintTempPlotTenancyContract model)
        {
            var content = await GetFileContent("Workflow.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<ReprintTempPlotTenancyContractResponse>>> GetStepInfo(List<Cookie> cookies, string args)
        {
            var content = await GetFileContent("StepInfo.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<ReprintTempPlotTenancyContractResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<PlotOwnerResponse>>>> FetchNewOwners(List<Cookie> cookies, string args)
        {
            var content = await GetFileContent("FetchNewOwners.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<PlotOwnerResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<object>>> AddRecipient(List<Cookie> cookies, string args, AddRecipientRequest model)
        {
            return await Task.FromResult(new DmtResponseWrapper<object>()
            {
                App = true,
                Success = true
            });
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<PlotOwnerResponse>>>> GetRecipient(List<Cookie> cookies, string args)
        {
            var content = await GetFileContent("GetApplicants.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<PlotOwnerResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegisterSubmit(List<Cookie> cookies, string args, RegisterReprintTempPlotTenancyContract model)
        {
            var content = await GetFileContent("Workflow.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalSubmit(List<Cookie> cookies, string args, BackOfficeModel model)
        {
            var content = await GetFileContent("Workflow.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<DocumentDownloadResponse>>> PrintContract(List<Cookie> cookies, string args, PrintContractReprintTempPlotTenancyContract model)
        {
            var content = await GetFileContent("PrintContract.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<DocumentDownloadResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> PrintSubmit(List<Cookie> cookies, string args, CommentModel model)
        {
            var content = await GetFileContent("Workflow.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        #endregion Methods
    }
}