using ADREC.DTO.ApiModels.DMTModel.ElmsServices;
using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ErrorOr;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.PublicHouseToResidentialLand;
using Runtime.DTO.ApiModels.DMTModel.Common;
using Runtime.DTO.RestClientModels.Common;
using Runtime.RestClient.Interfaces.DMT.ElmsServices;
using System.Net;
using System.Text.Json;

namespace ADREC.RestClient.Implementations.DMT.ElmsServices
{
    internal class PublicHouseToResidentialLandMockClient : IPublicHouseToResidentialLandClient
    {
        #region Private Methods

        private static async Task<string> GetFileContent(string fileName)
        {
            var basePath = AppContext.BaseDirectory;

            var filePath = Path.Combine(basePath, "Response", "ElmsServices", "PublicHouseToResidentialLand", fileName);

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"The file '{filePath}' was not found.");
            }

            return await File.ReadAllTextAsync(filePath);
        }

        #endregion Private Methods

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> AuditWorkflow(List<Cookie> cookies, string args, BackOfficeModel model)
        {
            var content = await GetFileContent("AuditWorkflow.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<PublicHouseToResidentialLandResponse>>> GetStepInfo(List<Cookie> cookies, string args)
        {
            var content = await GetFileContent("StepInfo.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<PublicHouseToResidentialLandResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> InspectionSubmit(List<Cookie> cookies, string args, BackOfficeModel model)
        {
            var content = await GetFileContent("AuditWorkflow.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> TDPAuditSubmit(List<Cookie> cookies, string args, BackOfficeModel model)
        {
            var content = await GetFileContent("TDPAuditSubmit.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> CompletionApprove(List<Cookie> cookies, string args, BackOfficeModel model)
        {
            var content = await GetFileContent("TDPAuditSubmit.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegistrationSubmit(List<Cookie> cookies, string args, PublicHouseToResidentialLandRegistrationSubmitRequest model)
        {
            var content = await GetFileContent("RegistrationSubmit.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, AddPlotRequest model)
        {
            var content = await GetFileContent("StartWorkflow.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> AuditBack(List<Cookie> cookies, string args, CommentModel model)
        {
            var content = await GetFileContent("AuditBack.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> InspectionBack(List<Cookie> cookies, string args, CommentModel model)
        {
            var content = await GetFileContent("InspectionBack.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        #endregion Methods
    }
}