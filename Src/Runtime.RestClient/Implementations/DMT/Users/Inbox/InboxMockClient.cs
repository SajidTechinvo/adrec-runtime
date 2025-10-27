using ADREC.DTO.RestClientModels.DMT.Users;
using ErrorOr;
using Runtime.DTO.RestClientModels.Common;
using Runtime.RestClient.Interfaces.DMT.Users;
using System.Net;
using System.Text.Json;

namespace Runtime.RestClient.Implementations.DMT.Users.Inbox
{
    internal class InboxMockClient : IInboxClient
    {
        #region Private Methods

        private static async Task<string> GetFileContent(string fileName)
        {
            var basePath = AppContext.BaseDirectory;

            var filePath = Path.Combine(basePath, "Response", "Users", fileName);

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"The file '{filePath}' was not found.");
            }

            return await File.ReadAllTextAsync(filePath);
        }

        #endregion Private Methods

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<BackOfficeInboxResponse>>> GetBackOfficeDrafts(
            List<Cookie> cookies, int pageSize, int pageNumber, string applicationNumber, string referenceNumber,
            string districtId, string communityId, string workflowId, string workflowStepId, string workflowStatusId,
            string workflowStepTypeId, string nationalNumber, string tradeLicenseNumber, DateTime startDate,
            DateTime endDate, string sorting, string municipalityId)
        {
            var content = await GetFileContent("BackOfficeDraft.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<BackOfficeInboxResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<BackOfficeInboxResponse>>> GetBackOfficeInbox(
           List<Cookie> cookies, int pageSize, int pageNumber, string applicationNumber, string referenceNumber,
           string districtId, string communityId, string workflowId, string workflowStepId, string workflowStatusId,
           string workflowStepTypeId, string nationalNumber, string tradeLicenseNumber, DateTime startDate,
           DateTime endDate, string sorting, string municipalityId)
        {
            var content = await GetFileContent("BackOfficeInbox.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<BackOfficeInboxResponse>>(content);
        }

        #endregion Methods
    }
}