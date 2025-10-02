using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ADREC.RestClient.Interfaces.DMT.ElmsServices;
using ADREC.RestClient.Interfaces.Factory;
using ErrorOr;
using Runtime.Common.Settings;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.UnassignedAllotmentTemporaryPlot;
using Runtime.RestClient.Implementations.Factory;
using Runtime.DTO.ApiModels.DMTModel.Common;
using Runtime.DTO.ApiModels.DMTModel.ElmsServices;
using Runtime.DTO.RestClientModels.Common;
using System.Net;
using System.Text.Json;

namespace ADREC.RestClient.Implementations.DMT.ElmsServices.UnassignedAllotmentTemporaryPlotClients
{
    internal class UnassignedAllotmentTemporaryPlotClient(DmtSettings settings, ICustomHttpFactory factory) : HttpBase(settings, factory), IUnassignedAllotmentTemporaryPlotClient
    {
        #region Private Fields

        private readonly DmtSettings _settings = settings;

        #endregion Private Fields

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, StartUnassignedAllotmentTemporaryPlot model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, StartUnassignedAllotmentTemporaryPlot>(cookies, $"{_settings.BaseUrl}/api/elmsUnassignedAllotmentTemporaryPlots/startWorkflow?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegisterWorkflow(List<Cookie> cookies, string args, RegisterUnassignedAllotmentTemporaryPlot model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, RegisterUnassignedAllotmentTemporaryPlot>(cookies, $"{_settings.BaseUrl}/api/elmsUnassignedAllotmentTemporaryPlots/registrationSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> AuditOwnerPlotsSubmit(List<Cookie> cookies, string args, AuditUnassignedAllotmentTemporaryPlot model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, AuditUnassignedAllotmentTemporaryPlot>(cookies, $"{_settings.BaseUrl}/api/elmsUnassignedAllotmentTemporaryPlots/auditOwnerPlotsSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<UnassignedAllotmentTemporaryPlotResponse>>> GetStepInfo(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<UnassignedAllotmentTemporaryPlotResponse>, object>(cookies, $"{_settings.BaseUrl}/api/elmsUnassignedAllotmentTemporaryPlots/getStepInfo?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> PreRegistrationSubmit(List<Cookie> cookies, string args, CommentModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, CommentModel>(cookies, $"{_settings.BaseUrl}/api/elmsUnassignedAllotmentTemporaryPlots/preRegistrationSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<object>>> AddRecipient(List<Cookie> cookies, string args, UnassignedAllotmentTemporaryPlotAddRecipient model)
        {
            return await Post<DmtResponseWrapper<object>, UnassignedAllotmentTemporaryPlotAddRecipient>(cookies, $"{_settings.BaseUrl}/api/elmsUnassignedAllotmentTemporaryPlots/addRecipients?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<object>>> RemoveRecipient(List<Cookie> cookies, string args, UnassignedAllotmentTemporaryPlotAddRecipient model)
        {
            return await Post<DmtResponseWrapper<object>, UnassignedAllotmentTemporaryPlotAddRecipient>(cookies, $"{_settings.BaseUrl}/api/elmsUnassignedAllotmentTemporaryPlots/RemoveRecipients?args={args}", model);
        }

        #endregion Methods
    }

    internal class UnassignedAllotmentTemporaryPlotMockClient : IUnassignedAllotmentTemporaryPlotClient
    {
        #region Private Methods

        private static async Task<string> GetFileContent(string fileName)
        {
            var basePath = AppContext.BaseDirectory;

            var filePath = Path.Combine(basePath, "Response", "ElmsServices", "UnassignedAllotmentTemporaryPlot", fileName);

            if (!File.Exists(filePath))
                throw new FileNotFoundException($"The file '{filePath}' was not found.");

            return await File.ReadAllTextAsync(filePath);
        }

        #endregion Private Methods

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, StartUnassignedAllotmentTemporaryPlot model)
        {
            var content = await GetFileContent("Workflow.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegisterWorkflow(List<Cookie> cookies, string args, RegisterUnassignedAllotmentTemporaryPlot model)
        {
            var content = await GetFileContent("Workflow.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> AuditOwnerPlotsSubmit(List<Cookie> cookies, string args, AuditUnassignedAllotmentTemporaryPlot model)
        {
            var content = await GetFileContent("Workflow.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<UnassignedAllotmentTemporaryPlotResponse>>> GetStepInfo(List<Cookie> cookies, string args)
        {
            var content = await GetFileContent("StepInfo.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<UnassignedAllotmentTemporaryPlotResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> PreRegistrationSubmit(List<Cookie> cookies, string args, CommentModel model)
        {
            var content = await GetFileContent("Workflow.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<object>>> AddRecipient(List<Cookie> cookies, string args, UnassignedAllotmentTemporaryPlotAddRecipient model)
        {
            var content = await GetFileContent("AddRecipient.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<object>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<object>>> RemoveRecipient(List<Cookie> cookies, string args, UnassignedAllotmentTemporaryPlotAddRecipient model)
        {
            var content = await GetFileContent("AddRecipient.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<object>>(content);
        }

        #endregion Methods
    }
}