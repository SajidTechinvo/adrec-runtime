using ADREC.DTO.RestClientModels.DMT.ElmsPayment;
using ErrorOr;
using Runtime.DTO.ApiModels.DMTModel.ElmsPayment;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.Common;
using System.Net;

namespace ADREC.RestClient.Interfaces.DMT.ElmsPayment
{
    public interface IElmsPaymentClient
    {
        Task<ErrorOr<DmtResponseWrapper<WfiDocumentAttachmentResponse>>> PrintPaymentSlip(List<Cookie> cookies, string args, PrintPaymentSlipRequest model);

        Task<ErrorOr<DmtResponseWrapper<OverridePaymentResponse>>> OverridePayment(List<Cookie> cookies, string args, OverridePaymentRequest model);

        Task<ErrorOr<DmtResponseWrapper<OverridePaymentResponse>>> VerifyPayment(List<Cookie> cookies, string args, VerifyPaymentRequest model);
    }
}