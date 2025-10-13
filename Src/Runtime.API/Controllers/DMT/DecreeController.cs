using Microsoft.AspNetCore.Mvc;
using Runtime.API.Caching;
using Runtime.API.Controllers.Base;
using Runtime.Common.Helpers;
using Runtime.RestClient.Interfaces.Unit;
using System.Net;

namespace Runtime.API.Controllers.DMT
{
    [Route("decree")]
    public class DecreeController(IRedisCacheService redis, ILogger logger, IRestClientUnit rest) : ApiController(redis,logger)
    {
        #region Private Fields

        private readonly IRestClientUnit _rest = rest;
        private readonly IRedisCacheService _redis = redis;

        #endregion Private Fields

        #region Methods

        #region End Points

        #region GET

        [HttpGet("owner-allotment-name")]
        public async Task<IActionResult> SearchOwnerAllotmentName(string args, string cityNo, string familyBookNumber,
                                                                  string fullName, string matchTypeId,
                                                                  string nationalNumber, int pageNumber, int pageSize,
                                                                  int totalCount, string tribe)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.Decree.SearchOwnerAllotmentName(cookies, args, cityNo, familyBookNumber, fullName,
                                                                     matchTypeId, nationalNumber, pageNumber, pageSize,
                                                                     totalCount, tribe);

            return result.Match(Ok, Problem);
        }

        [HttpGet("allotment-name/{id}")]
        public async Task<IActionResult> FetchAllotmentName(string args, int id)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.Decree.FetchAllotmentName(cookies, args, id);

            return result.Match(Ok, Problem);
        }

        #endregion GET

        #endregion End Points

        #endregion Methods
    }
}