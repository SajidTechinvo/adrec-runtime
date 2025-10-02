using ADREC.DTO.RestClientModels.DMT.ElmsTenancy;
using ErrorOr;
using Runtime.DTO.ApiModels.DMTModel.ElmsTenancy;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.ElmsTenancy;
using Runtime.RestClient.Interfaces.DMT.ElmsTenancy;
using System.Net;
using System.Text.Json;

namespace ADREC.RestClient.Implementations.DMT.ElmsTenancy
{
    internal class ElmsTenancyMockClient : IElmsTenancyClient
    {
        #region Private Methods

        private static async Task<string> GetFileContent(string fileName)
        {
            var basePath = AppContext.BaseDirectory;

            var filePath = Path.Combine(basePath, "Response", "ElmsTenancy", fileName);

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"The file '{filePath}' was not found.");
            }

            return await File.ReadAllTextAsync(filePath);
        }

        #endregion Private Methods

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<CalculateRentFeesResponse>>> CalculateRentFees(List<Cookie> cookies, string args, CalculateRentFeesRequest model)
        {
            var content = await GetFileContent("CalculateRentFees.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<CalculateRentFeesResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<LateRentPaymentResponse>>>> FetchLandLateRentPayments(List<Cookie> cookies, string args, int id)
        {
            var content = await GetFileContent("FetchLandLateRentPayments.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<LateRentPaymentResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<TenancyContractResponse>>>> FetchTenancyContractList(List<Cookie> cookies, string args, int plotId, bool showAll, int tenancyContractCategory)
        {
            var content = await GetFileContent("FetchTenancyContractList.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<TenancyContractResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<TenancyContractResponse>>> FetchTenancyContractDetails(List<Cookie> cookies, string args, int id)
        {
            var content = await GetFileContent("FetchTenancyContractDetails.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<TenancyContractResponse>>(content);
        }

        public Task<ErrorOr<DmtResponseWrapper<SearchTenancyContractResponse>>> SearchTenancyContracts(List<Cookie> cookies, string args, string contractNumber, string contractType, string matchTypeId, int pageNumber, int pageSize, string startDate)
        {
            //Todo implement this
            throw new NotImplementedException();
        }

        #endregion Methods
    }
}