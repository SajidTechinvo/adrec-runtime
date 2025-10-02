using ADREC.DTO.RestClientModels.DMT.Users;
using Runtime.DTO.RestClientModels.Common;
using System.Net;

namespace ADREC.RestClient.Interfaces.DMT.Users
{
    public interface IInboxClient
    {
        Task<DmtResponseWrapper<BackOfficeInboxResponse>> GetBackOfficeDrafts(
            List<Cookie> cookies, int pageSize, int pageNumber, string applicationNumber, string referenceNumber,
            string districtId, string communityId, string workflowId, string workflowStepId, string workflowStatusId,
            string workflowStepTypeId, string nationalNumber, string tradeLicenseNumber, DateTime startDate,
            DateTime endDate, string sorting, string municipalityId);

        Task<DmtResponseWrapper<BackOfficeInboxResponse>> GetBackOfficeInbox(
            List<Cookie> cookies, int pageSize, int pageNumber, string applicationNumber, string referenceNumber,
            string districtId, string communityId, string workflowId, string workflowStepId, string workflowStatusId,
            string workflowStepTypeId, string nationalNumber, string tradeLicenseNumber, DateTime startDate,
            DateTime endDate, string sorting, string municipalityId);
    }
}