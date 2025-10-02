using ADREC.DTO.RestClientModels.DMT.Users;
using ADREC.RestClient.Interfaces.DMT.Users;
using ADREC.RestClient.Interfaces.Factory;
using Runtime.Common.Settings;
using Runtime.DTO.RestClientModels.Common;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace ADREC.RestClient.Implementations.DMT.Users.Inbox
{
    internal class InboxClient(DmtSettings settings, ICustomHttpFactory httpFactory) : IInboxClient
    {
        #region Private Fields

        private readonly ICustomHttpFactory _httpFactory = httpFactory;
        private readonly DmtSettings _settings = settings;

        #endregion Private Fields

        #region Methods

        public async Task<DmtResponseWrapper<BackOfficeInboxResponse>> GetBackOfficeInbox(
            List<Cookie> cookies, int pageSize, int pageNumber, string applicationNumber, string referenceNumber,
            string districtId, string communityId, string workflowId, string workflowStepId, string workflowStatusId,
            string workflowStepTypeId, string nationalNumber, string tradeLicenseNumber, DateTime startDate,
            DateTime endDate, string sorting, string municipalityId)
        {
            var client = _httpFactory.CreateWithCookies(cookies, new Uri(_settings.BaseUrl));
            var response = await client.PostAsync($"{_settings.BaseUrl}/api/user/GetBackOfficeInbox",
                                                    new StringContent(JsonSerializer.Serialize(new
                                                    {
                                                        pageSize,
                                                        pageNumber,
                                                        applicationNumber,
                                                        referenceNumber,
                                                        districtId,
                                                        communityId,
                                                        workflowId,
                                                        workflowStepId,
                                                        workflowStatusId,
                                                        workflowStepTypeId,
                                                        nationalNumber,
                                                        tradeLicenseNumber,
                                                        startDate,
                                                        endDate,
                                                        sorting,
                                                        municipalityId
                                                    }), Encoding.UTF8, "application/json"));
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<DmtResponseWrapper<BackOfficeInboxResponse>>();
            }
            throw new Exception("An Error Occurred");
        }

        public async Task<DmtResponseWrapper<BackOfficeInboxResponse>> GetBackOfficeDrafts(
            List<Cookie> cookies, int pageSize, int pageNumber, string applicationNumber, string referenceNumber,
            string districtId, string communityId, string workflowId, string workflowStepId, string workflowStatusId,
            string workflowStepTypeId, string nationalNumber, string tradeLicenseNumber, DateTime startDate,
            DateTime endDate, string sorting, string municipalityId)
        {
            var client = _httpFactory.CreateWithCookies(cookies, new Uri(_settings.BaseUrl));
            var response = await client.PostAsync($"{_settings.BaseUrl}/api/user/GetBackOfficeDrafts",
                                                    new StringContent(JsonSerializer.Serialize(new
                                                    {
                                                        pageSize,
                                                        pageNumber,
                                                        applicationNumber,
                                                        referenceNumber,
                                                        districtId,
                                                        communityId,
                                                        workflowId,
                                                        workflowStepId,
                                                        workflowStatusId,
                                                        workflowStepTypeId,
                                                        nationalNumber,
                                                        tradeLicenseNumber,
                                                        startDate,
                                                        endDate,
                                                        sorting,
                                                        municipalityId
                                                    }), Encoding.UTF8, "application/json"));
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<DmtResponseWrapper<BackOfficeInboxResponse>>();
            }
            throw new Exception("An Error Occurred");
        }

        #endregion Methods
    }
}