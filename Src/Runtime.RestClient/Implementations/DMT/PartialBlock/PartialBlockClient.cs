using ADREC.RestClient.Interfaces.DMT;
using ADREC.RestClient.Interfaces.Factory;
using ErrorOr;
using Runtime.Common.Settings;
using Runtime.RestClient.Implementations.Factory;
using Runtime.DTO.ApiModels.DMTModel;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.PartialBlocks;
using System.Net;
using System.Text.Json;

namespace ADREC.RestClient.Implementations.DMT.PartialBlock
{
    internal class PartialBlockClient(DmtSettings settings, ICustomHttpFactory httpFactory) : HttpBase(settings, httpFactory), IPartialBlockClient
    {
        #region Private Fields

        private readonly DmtSettings _settings = settings;

        #endregion Private Fields

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<List<PartialBlockWorkflowResponse>>>> GetWorkflows(List<Cookie> cookies, string args, long id)
        {
            return await Post<DmtResponseWrapper<List<PartialBlockWorkflowResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/ElmsPartialBlocks/FetchWorkflows?args={args}", new { id });
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<PartialBlockWorkflowTypeResponse>>>> GetWorkflowTypes(List<Cookie> cookies, string args, long id)
        {
            return await Post<DmtResponseWrapper<List<PartialBlockWorkflowTypeResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/ElmsPartialBlocks/FetchWorkflowTypes?args={args}", new { id });
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<AddPartialBlockTxnWorkflowResponse>>>> AddPartialBlockTxnWorkflows(List<Cookie> cookies, string args, AddPartialBlockWorkflowRequest model)
        {
            return await Post<DmtResponseWrapper<List<AddPartialBlockTxnWorkflowResponse>>, AddPartialBlockWorkflowRequest>(cookies, $"{_settings.BaseUrl}/api/ElmsPartialBlocks/FetchWorkflowTypes?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<AddPartialBlockTxnWorkflowResponse>>>> FetchPartialBlockTxnWorkflows(List<Cookie> cookies, string args, int id)
        {
            return await Post<DmtResponseWrapper<List<AddPartialBlockTxnWorkflowResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/ElmsPartialBlocks/FetchWorkflowTypes?args={args}", new { id });
        }

        #endregion Methods
    }

    internal class PartialBlockMockClient : IPartialBlockClient
    {
        #region Private Methods

        private static async Task<string> GetFileContent(string fileName)
        {
            var basePath = AppContext.BaseDirectory;

            var filePath = Path.Combine(basePath, "Response", "PartialBlock", fileName);

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"The file '{filePath}' was not found.");
            }

            return await File.ReadAllTextAsync(filePath);
        }

        #endregion Private Methods

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<List<PartialBlockWorkflowResponse>>>> GetWorkflows(List<Cookie> cookies, string args, long id)
        {
            var content = await GetFileContent("Workflows.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<PartialBlockWorkflowResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<PartialBlockWorkflowTypeResponse>>>> GetWorkflowTypes(List<Cookie> cookies, string args, long id)
        {
            var content = await GetFileContent("WorkflowTypes.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<PartialBlockWorkflowTypeResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<AddPartialBlockTxnWorkflowResponse>>>> AddPartialBlockTxnWorkflows(List<Cookie> cookies, string args, AddPartialBlockWorkflowRequest model)
        {
            var content = await GetFileContent("AddPartialBlockTxnWorkflow.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<AddPartialBlockTxnWorkflowResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<AddPartialBlockTxnWorkflowResponse>>>> FetchPartialBlockTxnWorkflows(List<Cookie> cookies, string args, int id)
        {
            var content = await GetFileContent("AddPartialBlockTxnWorkflow.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<AddPartialBlockTxnWorkflowResponse>>>(content);
        }

        #endregion Methods
    }
}