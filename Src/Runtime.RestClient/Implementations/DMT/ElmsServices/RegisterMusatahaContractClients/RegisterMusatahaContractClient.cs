using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ADREC.RestClient.Interfaces.Factory;
using ErrorOr;
using Runtime.Common.Settings;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.RegisterMusatahaContract;
using Runtime.RestClient.Implementations.Factory;
using Runtime.DTO.ApiModels.DMTModel.Common;
using Runtime.DTO.ApiModels.DMTModel.ElmsPayment;
using Runtime.DTO.ApiModels.DMTModel.ElmsServices;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.Common;
using Runtime.RestClient.Interfaces.DMT.ElmsServices;
using System.Net;

namespace Runtime.RestClient.Implementations.DMT.ElmsServices.RegisterMusatahaContractClients
{
    internal class RegisterMusatahaContractClient(DmtSettings settings, ICustomHttpFactory factory) : HttpBase(settings, factory), IRegisterMusatahaContractClient
    {
        #region Private Fields

        private readonly DmtSettings _settings = settings;

        #endregion Private Fields

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<RegisterMusatahaContractResponse>>> GetStepInfo(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<RegisterMusatahaContractResponse>, object>(cookies, $"{_settings.BaseUrl}/api/elmsRegisterMusatahaContract/getStepInfo?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, StartRegisterMusatahaContract model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, StartRegisterMusatahaContract>(cookies, $"{_settings.BaseUrl}/api/elmsRegisterMusatahaContract/startWorkflow?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegisterSubmit(List<Cookie> cookies, string args, SubmitRegisterMusatahaContractRequest model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, SubmitRegisterMusatahaContractRequest>(cookies, $"{_settings.BaseUrl}/api/elmsRegisterMusatahaContract/registrationSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalSubmit(List<Cookie> cookies, string args, ApproveRegisterMusatahaContract model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, ApproveRegisterMusatahaContract>(cookies, $"{_settings.BaseUrl}/api/elmsRegisterMusatahaContract/approvalSubmit?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WfiDocumentAttachmentResponse>>> PrintPaymentSlip(List<Cookie> cookies, string args, PrintPaymentSlipRequest model)
        {
            return await Post<DmtResponseWrapper<WfiDocumentAttachmentResponse>, PrintPaymentSlipRequest>(cookies, $"{_settings.BaseUrl}/api/elmsRegisterMusatahaContract/PrintPaymentSlip?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> PaymentSubmit(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, object>(cookies, $"{_settings.BaseUrl}/api/elmsRegisterMusatahaContract/BackOfficePaymentSubmit?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<WfiDocumentAttachmentResponse>>> PrintContract(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<WfiDocumentAttachmentResponse>, object>(cookies, $"{_settings.BaseUrl}/api/elmsRegisterMusatahaContract/printContract?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> PrintSubmit(List<Cookie> cookies, string args, BackOfficeModel model)
        {
            return await Post<DmtResponseWrapper<WorkflowResponse>, BackOfficeModel>(cookies, $"{_settings.BaseUrl}/api/elmsRegisterMusatahaContract/printSubmit?args={args}", model);
        }

        #endregion Methods
    }
}