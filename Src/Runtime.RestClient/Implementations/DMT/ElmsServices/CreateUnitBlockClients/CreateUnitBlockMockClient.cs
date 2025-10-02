using ADREC.DTO.ApiModels.DMTModel.ElmsServices;
using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ADREC.RestClient.Interfaces.DMT.ElmsServices;
using ErrorOr;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.CreateUnitBlock;
using Runtime.DTO.ApiModels.DMTModel.Common;
using Runtime.DTO.RestClientModels.Common;
using System.Net;
using System.Text.Json;

namespace ADREC.RestClient.Implementations.DMT.ElmsServices.CreateUnitBlockClients
{
    internal class CreateUnitBlockMockClient : ICreateUnitBlockClient
    {
        #region Private Methods

        private static async Task<string> GetFileContent(string fileName)
        {
            var basePath = AppContext.BaseDirectory;

            var filePath = Path.Combine(basePath, "Response", "ElmsServices", "CreateUnitBlock", fileName);

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"The file '{filePath}' was not found.");
            }

            return await File.ReadAllTextAsync(filePath);
        }

        #endregion Private Methods

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalApprove(List<Cookie> cookies, string args)
        {
            var content = await GetFileContent("StartWorkflow.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalReject(List<Cookie> cookies, string args, CommentModel model)
        {
            var content = await GetFileContent("StartWorkflow.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<CreateUnitBlockResponse>>> GetStepInfo(List<Cookie> cookies, string args)
        {
            var content = await GetFileContent("StepInfo.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<CreateUnitBlockResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegisterSubmit(List<Cookie> cookies, string args, RegisterSubmitCreateUnitBlock model)
        {
            var content = await GetFileContent("StartWorkflow.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, StartCreateUnitBlock model)
        {
            var content = await GetFileContent("StartWorkflow.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        #endregion Methods
    }
}