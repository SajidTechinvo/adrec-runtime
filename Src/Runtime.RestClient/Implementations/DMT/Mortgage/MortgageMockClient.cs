using ADREC.DTO.RestClientModels.DMT.Mortgage;
using ErrorOr;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.Mortgage;
using Runtime.RestClient.Interfaces.DMT;
using System.Net;
using System.Text.Json;

namespace Runtime.RestClient.Implementations.DMT.Mortgage
{
    internal class MortgageMockClient : IMortgageClient
    {
        #region Private Methods

        private static async Task<string> GetFileContent(string fileName)
        {
            var basePath = AppContext.BaseDirectory;

            var filePath = Path.Combine(basePath, "Response", "Mortgage", fileName);

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"The file '{filePath}' was not found.");
            }

            return await File.ReadAllTextAsync(filePath);
        }

        #endregion Private Methods

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<DmtPageResponse<ElmsBankResponse>>>> FetchBanks(List<Cookie> cookies, string args)
        {
            var content = await GetFileContent("FetchBanks.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<DmtPageResponse<ElmsBankResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<FetchMortgageProfileResponse>>> FetchMortgageProfile(List<Cookie> cookies, string args)
        {
            var content = await GetFileContent("SearchMortgageProfile.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<FetchMortgageProfileResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<SearchMortgageResponse>>> SearchMortgages(List<Cookie> cookies, string args, string bankid, string contractNumber, bool createUrlArgs, int matchTypeId, string municipalityId, int pageNumber, int pageSize, int propertyType, int resultsPerPage, int totalCount)
        {
            var content = await GetFileContent("SearchMortgage.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<SearchMortgageResponse>>(content);
        }

        #endregion Methods
    }
}