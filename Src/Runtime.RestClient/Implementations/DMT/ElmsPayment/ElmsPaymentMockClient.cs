using ADREC.DTO.RestClientModels.DMT.ElmsPayment;
using ADREC.RestClient.Interfaces.DMT.ElmsPayment;
using ErrorOr;
using Runtime.DTO.ApiModels.DMTModel.ElmsPayment;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.Common;
using System.Net;
using System.Text.Json;

namespace ADREC.RestClient.Implementations.DMT.ElmsPayment
{
    internal class ElmsPaymentMockClient : IElmsPaymentClient
    {
        #region Private Methods

        private static async Task<string> GetFileContent(string fileName)
        {
            var basePath = AppContext.BaseDirectory;

            var filePath = Path.Combine(basePath, "Response", "ElmsPayment", fileName);

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"The file '{filePath}' was not found.");
            }

            return await File.ReadAllTextAsync(filePath);
        }

        #endregion Private Methods

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<OverridePaymentResponse>>> OverridePayment(List<Cookie> cookies, string args, OverridePaymentRequest model)
        {
            var content = await GetFileContent("OverridePayment.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<OverridePaymentResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WfiDocumentAttachmentResponse>>> PrintPaymentSlip(List<Cookie> cookies, string args, PrintPaymentSlipRequest model)
        {
            var content = await GetFileContent("PrintPaymentSlip.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WfiDocumentAttachmentResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<OverridePaymentResponse>>> VerifyPayment(List<Cookie> cookies, string args, VerifyPaymentRequest model)
        {
            var content = await GetFileContent("VerifyPayment.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<OverridePaymentResponse>>(content);
        }

        #endregion Methods
    }
}