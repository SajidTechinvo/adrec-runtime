using Microsoft.AspNetCore.Mvc;
using Runtime.API.Caching;
using Runtime.API.Controllers.Base;
using Runtime.Common.Helpers;
using Runtime.RestClient.Interfaces.Unit;
using System.Net;

namespace Runtime.API.Controllers.DMT.Users
{
    [Route("inbox")]
    public class InboxController(IRedisCacheService redis, ILogger logger, IRestClientUnit rest) : ApiController(logger)
    {
        #region Private Fields

        private readonly IRestClientUnit _rest = rest;
        private readonly IRedisCacheService _redis = redis;

        #endregion Private Fields

        #region Methods

        #region End Points

        #region GET

        [HttpGet("")]
        public async Task<IActionResult> GetBackOfficeInbox(
            int pageSize, int pageNumber, string applicationNumber, string referenceNumber,
            string districtId, string communityId, string workflowId, string workflowStepId, string workflowStatusId,
            string workflowStepTypeId, string nationalNumber, string tradeLicenseNumber, DateTime startDate,
            DateTime endDate, string sorting, string municipalityId)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            return Ok(await _rest.Inbox.GetBackOfficeInbox(cookies, pageSize, pageNumber, applicationNumber,
                referenceNumber, districtId, communityId, workflowId, workflowStepId, workflowStatusId,
                workflowStepTypeId, nationalNumber, tradeLicenseNumber, startDate, endDate, sorting, municipalityId));
        }

        [HttpGet("drafts")]
        public async Task<IActionResult> GetBackOfficeDrafts(
            string applicationNumber, string communityId, string districtId, int pageSize, int pageNumber,
            string referenceNumber, string workflowId, string workflowStepId, string workflowStatusId,
            string workflowStepTypeId, string nationalNumber, string tradeLicenseNumber, DateTime startDate,
            DateTime endDate, string sorting, string municipalityId)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            return Ok(await _rest.Inbox.GetBackOfficeDrafts(cookies, pageSize, pageNumber, applicationNumber,
                referenceNumber, districtId, communityId, workflowId, workflowStepId, workflowStatusId,
                workflowStepTypeId, nationalNumber, tradeLicenseNumber, startDate, endDate, sorting, municipalityId));
        }

        #endregion GET

        #endregion End Points

        #endregion Methods
    }
}