using Microsoft.AspNetCore.Mvc;
using Runtime.API.Caching;
using Runtime.API.Controllers.Base;
using Runtime.Common.Helpers;
using Runtime.Common.Lookups;
using Runtime.DTO.ApiModels.DMTModel;
using Runtime.RestClient.Interfaces.Unit;

namespace Runtime.API.Controllers.DMT
{
    [Route("owner")]
    public class OwnerController(IRedisCacheService redis, ILogger logger, IRestClientUnit rest) : ApiController(redis, logger)
    {
        #region Private Fields

        private readonly IRestClientUnit _rest = rest;

        #endregion Private Fields

        #region Methods

        #region End Points

        #region POST

        [HttpPost("contact")]
        public async Task<IActionResult> EditContact(EditContactRequest model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var applicationName = User.Claims.First(f => f.Type == "Application").Value;

            var cookies = await GetCookies(token, applicationName);

            var result = await _rest.Owner.EditContact(cookies, model);

            return result.Match(Ok, Problem);
        }

        #endregion POST

        #region GET

        [HttpGet("")]
        public async Task<IActionResult> SearchOwners(string args, int requestId,
            string ownerName, string tribe, string nationalNumber, string nationalityId, string familyBookNumber,
            string cityNumber, string passPortNumber, string moiUnifiedNumber, SearchMatchType matchTypeId, int pageSize,
            int pageNumber, int totalCount)
        {
            string matchType = ((int)matchTypeId).ToString();

            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var applicationName = User.Claims.First(f => f.Type == "Application").Value;

            var cookies = await GetCookies(token, applicationName);

            var result = await _rest.Owner.GetOwners(cookies, args, requestId, ownerName, tribe, nationalNumber,
                                                     nationalityId, familyBookNumber, cityNumber, passPortNumber,
                                                     moiUnifiedNumber, matchType, pageSize, pageNumber,
                                                     totalCount);

            return result.Match(Ok, Problem);
        }

        [HttpGet("companies")]
        public async Task<IActionResult> SearchCompanies(string args,
            string chamberOfCommerceNo, SearchMatchType matchTypeId, string ownerName, int pageNumber, int pageSize,
            int requestId, int totalCount, string tradeLicense)
        {
            string matchType = ((int)matchTypeId).ToString();

            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var applicationName = User.Claims.First(f => f.Type == "Application").Value;

            var cookies = await GetCookies(token, applicationName);

            var result = await _rest.Owner.GetCompanies(cookies, args, chamberOfCommerceNo, matchType, ownerName, pageNumber,
                                                                 pageSize, requestId, totalCount, tradeLicense);

            return result.Match(Ok, Problem);
        }

        [HttpGet("authorized")]
        public async Task<IActionResult> AuthorizedOwners(string args)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var applicationName = User.Claims.First(f => f.Type == "Application").Value;

            var cookies = await GetCookies(token, applicationName);

            var result = await _rest.Owner.SearchAuthorizedOwners(cookies, args);

            return result.Match(data => Ok(data.Result), Problem);
        }

        [HttpGet("plots")]
        public async Task<IActionResult> GetOwnerProfilePlots(string args)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var applicationName = User.Claims.First(f => f.Type == "Application").Value;

            var cookies = await GetCookies(token, applicationName);

            var result = await _rest.Owner.OwnerPlots(cookies, args);

            return result.Match(data => Ok(data.Result), Problem);
        }

        [HttpGet("plots-with-shares/{id}")]
        public async Task<IActionResult> GetOwnerProfilePlotsWithShares(string args, int id)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var applicationName = User.Claims.First(f => f.Type == "Application").Value;

            var cookies = await GetCookies(token, applicationName);

            var result = await _rest.Owner.GetOwnerProfilePlotsWithShares(cookies, args, id);

            return result.Match(data => Ok(data.Result), Problem);
        }

        #endregion GET

        #endregion End Points

        #endregion Methods
    }
}