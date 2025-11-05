using ADREC.DTO.RestClientModels.DMT.Owners;
using ErrorOr;
using Runtime.DTO.ApiModels.DMTModel;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.Owners;
using Runtime.RestClient.Interfaces.DMT.Common;
using System.Net;
using System.Text.Json;

namespace Runtime.RestClient.Implementations.DMT.Owners
{
    internal class OwnerMockClient : IOwnerClient
    {
        #region Private Methods

        private static async Task<string> GetFileContent(string fileName)
        {
            var basePath = AppContext.BaseDirectory;

            var filePath = Path.Combine(basePath, "Response", "Owners", fileName);

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"The file '{filePath}' was not found.");
            }

            return await File.ReadAllTextAsync(filePath);
        }

        #endregion Private Methods

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<DmtPageResponse<OwnerResponse>>>> GetOwners(
            List<Cookie> cookies, string args, int requestId, string ownerName, string tribe, string nationalNumber,
            string nationalityId, string familyBookNumber, string cityNumber, string passPortNumber,
            string moiUnifiedNumber, string matchTypeId, int pageSize, int pageNumber, int totalCount)
        {
            var content = await GetFileContent("SearchOwner.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<DmtPageResponse<OwnerResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<DmtPageResponse<CompanyResponse>>>> GetCompanies(
            List<Cookie> cookies, string args, string chamberOfCommerceNo, string matchTypeId, string ownerName, int pageNumber,
            int pageSize, int requestId, int totalCount, string tradeLicense)
        {
            var content = await GetFileContent("SearchCompany.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<DmtPageResponse<CompanyResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<PlotOwnerResponse>>>> SearchAuthorizedOwners(List<Cookie> cookies, string args)
        {
            var content = await GetFileContent("AuthorizedOwner.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<PlotOwnerResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<OwnerPlotResponse>>> OwnerPlots(List<Cookie> cookies, string args)
        {
            var content = await GetFileContent("OwnerPlot.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<OwnerPlotResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<PlotWithShareResponse>>> GetOwnerProfilePlotsWithShares(List<Cookie> cookies, string args, int id)
        {
            var content = await GetFileContent("PlotWithShare.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<PlotWithShareResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<EditContactResponse>>> EditContact(List<Cookie> cookies, EditContactRequest model)
        {
            var content = await GetFileContent("EditContact.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<EditContactResponse>>(content);
        }

        #endregion Methods
    }
}