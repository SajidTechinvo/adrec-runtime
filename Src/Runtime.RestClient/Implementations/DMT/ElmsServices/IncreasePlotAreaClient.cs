using ADREC.DTO.ApiModels.DMTModel.ElmsServices;
using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ADREC.RestClient.Interfaces.DMT.ElmsServices;
using ADREC.RestClient.Interfaces.Factory;
using ErrorOr;
using Runtime.Common.Settings;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.IncreasePlotArea;
using Runtime.RestClient.Implementations.Factory;
using Runtime.DTO.ApiModels.DMTModel.Common;
using Runtime.DTO.RestClientModels.Common;
using System.Net;
using System.Text.Json;

namespace ADREC.RestClient.Implementations.DMT.ElmsServices
{
    internal class IncreasePlotAreaClient(DmtSettings settings, ICustomHttpFactory httpFactory) : HttpBase(settings, httpFactory), IIncreasePlotAreaClient
    {
        #region Private Fields

        private readonly DmtSettings _settings = settings;

        #endregion Private Fields

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, AddPlotRequest model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, AddPlotRequest>(cookies, $"{_settings.BaseUrl}/api/elmsIncreasePlotArea/startWorkflow?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<IncreasePlotAreaResponse>>> GetStepInfo(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<IncreasePlotAreaResponse>, object>(cookies, $"{_settings.BaseUrl}/api/elmsIncreasePlotArea/getStepInfo?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegisterSubmit(List<Cookie> cookies, string args, IncreasePlotAreaRegisterRequest model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, IncreasePlotAreaRegisterRequest>(cookies, $"{_settings.BaseUrl}/api/elmsIncreasePlotArea/registrationSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> AssignEngineerSubmit(List<Cookie> cookies, string args, IncreasePlotAreaAssignEngineerRequest model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, IncreasePlotAreaAssignEngineerRequest>(cookies, $"{_settings.BaseUrl}/api/elmsIncreasePlotArea/assignEngineerSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StudySubmit(List<Cookie> cookies, string args, IncreasePlotAreaStudyRequest model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, IncreasePlotAreaStudyRequest>(cookies, $"{_settings.BaseUrl}/api/elmsIncreasePlotArea/studySubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> UrbanPlanningApprovalSubmit(List<Cookie> cookies, string args, BackOfficeModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, BackOfficeModel>(cookies, $"{_settings.BaseUrl}/api/elmsIncreasePlotArea/urbanPlanningApprovalSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> TPDApprovalSubmit(List<Cookie> cookies, string args, BackOfficeModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, BackOfficeModel>(cookies, $"{_settings.BaseUrl}/api/elmsIncreasePlotArea/tpdApprovalSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> UploadInitialSitePlanSubmit(List<Cookie> cookies, string args, BackOfficeModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, BackOfficeModel>(cookies, $"{_settings.BaseUrl}/api/elmsIncreasePlotArea/uploadInitialSitePlanSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> UploadNocLetterSubmit(List<Cookie> cookies, string args, BackOfficeModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, BackOfficeModel>(cookies, $"{_settings.BaseUrl}/api/elmsIncreasePlotArea/uploadNocLetterSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> EvaluationSubmit(List<Cookie> cookies, string args, IncreasePlotAreaEvaluationRequest model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, IncreasePlotAreaEvaluationRequest>(cookies, $"{_settings.BaseUrl}/api/elmsIncreasePlotArea/evaluationSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> GISApprovalLayerSubmit(List<Cookie> cookies, string args, BackOfficeModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, BackOfficeModel>(cookies, $"{_settings.BaseUrl}/api/elmsIncreasePlotArea/gISApprovalLayerSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> PropertyRegistrationApproval(List<Cookie> cookies, string args, BackOfficeModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, BackOfficeModel>(cookies, $"{_settings.BaseUrl}/api/elmsIncreasePlotArea/propertyRegistrationApprovalApprove?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> EngineerBack(List<Cookie> cookies, string args, CommentModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, CommentModel>(cookies, $"{_settings.BaseUrl}/api/elmsIncreasePlotArea/assignEngineerBack?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StudyBack(List<Cookie> cookies, string args, CommentModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, CommentModel>(cookies, $"{_settings.BaseUrl}/api/elmsIncreasePlotArea/studyBack?args={args}", model);
        }

        #endregion Methods
    }

    internal class IncreasePlotAreaMockClient : IIncreasePlotAreaClient
    {
        #region Private Methods

        private static async Task<string> GetFileContent(string fileName)
        {
            var basePath = AppContext.BaseDirectory;

            var filePath = Path.Combine(basePath, "Response", "ElmsServices", "IncreasePlotArea", fileName);

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"The file '{filePath}' was not found.");
            }

            return await File.ReadAllTextAsync(filePath);
        }

        #endregion Private Methods

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, AddPlotRequest model)
        {
            var content = await GetFileContent("StartWorkflow.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<IncreasePlotAreaResponse>>> GetStepInfo(List<Cookie> cookies, string args)
        {
            var content = await GetFileContent("StepInfo.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<IncreasePlotAreaResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegisterSubmit(List<Cookie> cookies, string args, IncreasePlotAreaRegisterRequest model)
        {
            var content = await GetFileContent("RegisterSubmit.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> AssignEngineerSubmit(List<Cookie> cookies, string args, IncreasePlotAreaAssignEngineerRequest model)
        {
            var content = await GetFileContent("RegisterSubmit.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StudySubmit(List<Cookie> cookies, string args, IncreasePlotAreaStudyRequest model)
        {
            var content = await GetFileContent("StudySubmit.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> UrbanPlanningApprovalSubmit(List<Cookie> cookies, string args, BackOfficeModel model)
        {
            var content = await GetFileContent("UrbanPlanningApprovalSubmit.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> TPDApprovalSubmit(List<Cookie> cookies, string args, BackOfficeModel model)
        {
            var content = await GetFileContent("TPDApprovalSubmit.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> UploadInitialSitePlanSubmit(List<Cookie> cookies, string args, BackOfficeModel model)
        {
            var content = await GetFileContent("UploadInitialSitePlanSubmit.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> UploadNocLetterSubmit(List<Cookie> cookies, string args, BackOfficeModel model)
        {
            var content = await GetFileContent("UploadNocLetterSubmit.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> EvaluationSubmit(List<Cookie> cookies, string args, IncreasePlotAreaEvaluationRequest model)
        {
            var content = await GetFileContent("EvaluationSubmit.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> GISApprovalLayerSubmit(List<Cookie> cookies, string args, BackOfficeModel model)
        {
            var content = await GetFileContent("EvaluationSubmit.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> PropertyRegistrationApproval(List<Cookie> cookies, string args, BackOfficeModel model)
        {
            var content = await GetFileContent("PropertyRegistrationApproval.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> EngineerBack(List<Cookie> cookies, string args, CommentModel model)
        {
            var content = await GetFileContent("AssignEngineerBack.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StudyBack(List<Cookie> cookies, string args, CommentModel model)
        {
            var content = await GetFileContent("AssignEngineerBack.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WorkflowResponse>>(content);
        }

        #endregion Methods
    }
}