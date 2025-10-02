using ADREC.DTO.RestClientModels.DMT.ElmsPayment;
using ADREC.RestClient.Interfaces.DMT.ElmsPayment;
using ADREC.RestClient.Interfaces.Factory;
using ErrorOr;
using Runtime.Common.Settings;
using Runtime.RestClient.Implementations.Factory;
using Runtime.DTO.ApiModels.DMTModel.ElmsPayment;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.Common;
using System.Net;

namespace ADREC.RestClient.Implementations.DMT.ElmsPayment
{
    internal class ElmsPaymentClient(DmtSettings settings, ICustomHttpFactory httpFactory) : HttpBase(settings, httpFactory), IElmsPaymentClient
    {
        #region Private Fields

        private readonly DmtSettings _settings = settings;

        #endregion Private Fields

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<OverridePaymentResponse>>> OverridePayment(List<Cookie> cookies, string args, OverridePaymentRequest model)
        {
            return await Post<DmtResponseWrapper<OverridePaymentResponse>, OverridePaymentRequest>(cookies, $"{_settings.BaseUrl}/api/ElmsPayment/OverridePayment?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WfiDocumentAttachmentResponse>>> PrintPaymentSlip(List<Cookie> cookies, string args, PrintPaymentSlipRequest model)
        {
            return await Post<DmtResponseWrapper<WfiDocumentAttachmentResponse>, PrintPaymentSlipRequest>(cookies, $"{_settings.BaseUrl}/api/ElmsPayment/PrintPaymentSlip?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<OverridePaymentResponse>>> VerifyPayment(List<Cookie> cookies, string args, VerifyPaymentRequest model)
        {
            return await Post<DmtResponseWrapper<OverridePaymentResponse>, VerifyPaymentRequest>(cookies, $"{_settings.BaseUrl}/api/ElmsPayment/VerifyPayment?args={args}", model);
        }

        #endregion Methods
    }
}