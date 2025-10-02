using Microsoft.AspNetCore.Mvc;
using Runtime.API.Caching;
using Runtime.API.Controllers.Base;
using Runtime.Common.Helpers;
using Runtime.RestClient.Interfaces.Unit;
using System.Net;

namespace Runtime.API.Controllers.DMT
{
    [Route("mortgage")]
    public class MortgageController(IRedisCacheService redis, ILogger logger, IRestClientUnit rest) : ApiController(logger)
    {
        #region Private Fields

        private readonly IRestClientUnit _rest = rest;
        private readonly IRedisCacheService _redis = redis;

        #endregion Private Fields

        #region Methods

        #region End Points

        #region GET

        [HttpGet("banks")]
        public async Task<IActionResult> FetchBanks(string args)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            return (await _rest.Mortgage.FetchBanks(cookies, args)).Match(Ok, Problem);
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchMortgages(string args, string bankid, string contractNumber,
                                                         bool createUrlArgs, int matchTypeId, string municipalityId,
                                                         int pageNumber, int pageSize, int propertyType,
                                                         int resultsPerPage, int totalCount)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            return (await _rest.Mortgage.SearchMortgages(cookies, args, bankid, contractNumber, createUrlArgs, matchTypeId,
                                                     municipalityId, pageNumber, pageSize, propertyType, resultsPerPage,
                                                     totalCount)).Match(Ok, Problem);
        }

        [HttpGet("profile")]
        public async Task<IActionResult> FetchMortgageProfile(string args)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            return (await _rest.Mortgage.FetchMortgageProfile(cookies, args)).Match(Ok, Problem);
        }

        #endregion GET

        #endregion End Points

        #endregion Methods
    }
}