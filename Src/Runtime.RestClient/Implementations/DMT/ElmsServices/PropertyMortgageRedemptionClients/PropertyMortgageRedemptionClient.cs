using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ADREC.RestClient.Interfaces.DMT.ElmsServices;
using ADREC.RestClient.Interfaces.Factory;
using ErrorOr;
using Runtime.Common.Settings;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.PropertyMortgageRedemption;
using Runtime.RestClient.Implementations.Factory;
using Runtime.DTO.ApiModels.DMTModel.Common;
using Runtime.DTO.ApiModels.DMTModel.ElmsServices;
using Runtime.DTO.RestClientModels.Common;
using System.Net;

namespace ADREC.RestClient.Implementations.DMT.ElmsServices.PropertyMortgageRedemptionClients
{
    internal class PropertyMortgageRedemptionClient(DmtSettings settings, ICustomHttpFactory httpFactory) : HttpBase(settings, httpFactory), IPropertyMortgageRedemptionClient
    {
        #region Private Fields

        private readonly DmtSettings _settings = settings;

        #endregion Private Fields

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, StartPropertyMortgageRedemption model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, StartPropertyMortgageRedemption>(cookies, $"{_settings.BaseUrl}/api/elmsReleaseMortgage/startWorkflow?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<PropertyMortgageRedemptionStepInfo>>> GetStepInfo(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<PropertyMortgageRedemptionStepInfo>, object>(cookies, $"{_settings.BaseUrl}/api/elmsReleaseMortgage/getStepInfo?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegisterSubmit(List<Cookie> cookies, string args, RegisterPropertyMortgageRedemption model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, RegisterPropertyMortgageRedemption>(cookies, $"{_settings.BaseUrl}/api/elmsReleaseMortgage/registrationSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> PrintStickerSubmit(List<Cookie> cookies, string args, CommentModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, CommentModel>(cookies, $"{_settings.BaseUrl}/api/elmsReleaseMortgage/printStickersSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalSubmit(List<Cookie> cookies, string args, CommentModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, CommentModel>(cookies, $"{_settings.BaseUrl}/api/elmsReleaseMortgage/approvalSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> UpdateArchiveSubmit(List<Cookie> cookies, string args, CommentModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, CommentModel>(cookies, $"{_settings.BaseUrl}/api/elmsReleaseMortgage/updateArchiveSubmit?args={args}", model);
        }

        #endregion Methods
    }
}