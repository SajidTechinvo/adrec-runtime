using Microsoft.AspNetCore.Mvc;
using Runtime.API.Caching;
using Runtime.API.Controllers.Base;
using Runtime.Common.Helpers;
using Runtime.RestClient.Interfaces.Unit;
using System.Net;

namespace Runtime.API.Controllers.DMT.Lookup
{
    [Route("land-usage")]
    public class LandUsageController(IRedisCacheService redis, ILogger logger, IRestClientUnit rest) : ApiController(redis,logger)
    {
        #region Private Fields

        private readonly IRestClientUnit _rest = rest;
        private readonly IRedisCacheService _redis = redis;

        #endregion Private Fields

        #region Methods

        #region End Points

        #region GET

        /// <summary>
        ///
        /// </summary>
        /// <param name="id">Municipality ID</param>
        /// <param name="request_id">Request ID</param>
        /// <returns></returns>

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLandUsage(long id, int? request_id)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.Lookup.SearchLandUsage(cookies, id, request_id);

            return result.Match(data => Ok(data.Result), Problem);
        }

        [HttpGet("by-id/{id}")]
        public async Task<IActionResult> FetchLanduseById(long id, int? request_id)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.Lookup.FetchLanduseById(cookies, id, request_id);

            return result.Match(data => Ok(data.Result), Problem);
        }

        #endregion GET

        #endregion End Points

        #endregion Methods
    }
}