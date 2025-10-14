using Microsoft.AspNetCore.Mvc;
using Runtime.API.Caching;
using Runtime.API.Controllers.Base;
using Runtime.Common.Helpers;
using Runtime.RestClient.Interfaces.Unit;

namespace Runtime.API.Controllers.DMT.Lookup
{
    [Route("roads")]
    public class RoadController(IRedisCacheService redis, ILogger logger, IRestClientUnit rest) : ApiController(redis, logger)
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
        /// <param name="id">Community ID</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoads(long id)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var applicationName = User.Claims.First(f => f.Type == "Application").Value;

            var cookies = await GetCookies(token, applicationName);

            var result = await _rest.Lookup.SearchRoads(cookies, id);

            return result.Match(data => Ok(data.Result), Problem);
        }

        #endregion GET

        #endregion End Points

        #endregion Methods
    }
}