using Microsoft.AspNetCore.Mvc;
using Runtime.API.Caching;
using Runtime.API.Controllers.Base;
using Runtime.Common.Helpers;
using Runtime.RestClient.Interfaces.Unit;

namespace Runtime.API.Controllers.DMT.Lookup
{
    [Route("district")]
    public class DistrictController(IRedisCacheService redis, ILogger logger, IRestClientUnit rest) : ApiController(redis, logger)
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
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Login(long id)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            var result = await _rest.Lookup.SearchDistricts(cookies, id);

            return result.Match(data => Ok(data.Result), Problem);
        }

        #endregion GET

        #endregion End Points

        #endregion Methods
    }
}