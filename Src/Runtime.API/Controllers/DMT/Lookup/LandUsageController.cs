using Microsoft.AspNetCore.Mvc;
using Runtime.API.Caching;
using Runtime.API.Controllers.Base;
using Runtime.RestClient.Interfaces.Unit;
using System.Security.Claims;

namespace Runtime.API.Controllers.DMT.Lookup
{
    [Route("land-usage")]
    public class LandUsageController(IRedisCacheService redis, ILogger logger, IRestClientUnit rest) : ApiController(redis, logger)
    {
        #region Private Fields

        private readonly IRestClientUnit _rest = rest;

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
            var email = User.Claims.First(f => f.Type.Equals(ClaimTypes.Email)).Value;

            var cookies = await GetCookies(email);

            var result = await _rest.Lookup.SearchLandUsage(cookies, id, request_id);

            return result.Match(data => Ok(data.Result), Problem);
        }

        [HttpGet("by-id/{id}")]
        public async Task<IActionResult> FetchLanduseById(long id, int? request_id)
        {
            var email = User.Claims.First(f => f.Type.Equals(ClaimTypes.Email)).Value;

            var cookies = await GetCookies(email);

            var result = await _rest.Lookup.FetchLanduseById(cookies, id, request_id);

            return result.Match(data => Ok(data.Result), Problem);
        }

        #endregion GET

        #endregion End Points

        #endregion Methods
    }
}