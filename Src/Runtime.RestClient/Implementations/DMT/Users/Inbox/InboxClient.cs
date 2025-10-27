using ADREC.DTO.RestClientModels.DMT.Users;
using ADREC.RestClient.Interfaces.Factory;
using ErrorOr;
using Runtime.Common.Settings;
using Runtime.DTO.RestClientModels.Common;
using Runtime.RestClient.Implementations.Factory;
using Runtime.RestClient.Interfaces.DMT.Users;
using System.Net;

namespace Runtime.RestClient.Implementations.DMT.Users.Inbox
{
    internal class InboxClient(DmtSettings settings, ICustomHttpFactory httpFactory) : HttpBase(settings, httpFactory), IInboxClient
    {
        #region Private Fields

        private readonly DmtSettings _settings = settings;

        #endregion Private Fields

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<BackOfficeInboxResponse>>> GetBackOfficeInbox(
            List<Cookie> cookies, int pageSize, int pageNumber, string applicationNumber, string referenceNumber,
            string districtId, string communityId, string workflowId, string workflowStepId, string workflowStatusId,
            string workflowStepTypeId, string nationalNumber, string tradeLicenseNumber, DateTime startDate,
            DateTime endDate, string sorting, string municipalityId)
        {
            return await Post<DmtResponseWrapper<BackOfficeInboxResponse>, object>(cookies, $"{_settings.BaseUrl}/api/user/GetBackOfficeInbox", new
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
            });
        }

        public async Task<ErrorOr<DmtResponseWrapper<BackOfficeInboxResponse>>> GetBackOfficeDrafts(
            List<Cookie> cookies, int pageSize, int pageNumber, string applicationNumber, string referenceNumber,
            string districtId, string communityId, string workflowId, string workflowStepId, string workflowStatusId,
            string workflowStepTypeId, string nationalNumber, string tradeLicenseNumber, DateTime startDate,
            DateTime endDate, string sorting, string municipalityId)
        {
            return await Post<DmtResponseWrapper<BackOfficeInboxResponse>, object>(cookies, $"{_settings.BaseUrl}/api/user/GetBackOfficeDrafts", new
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
            });
        }

        #endregion Methods
    }
}