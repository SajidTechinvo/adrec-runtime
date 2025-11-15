using Microsoft.AspNetCore.Mvc;
using Runtime.API.Caching;
using Runtime.API.Controllers.Base;
using Runtime.RestClient.Interfaces.Unit;
using System.Net;
using System.Security.Claims;

namespace Runtime.API.Controllers.DMT.Lookup
{
    [Route("emirates")]
    public class EmiratesController(IRedisCacheService redis, ILogger logger, IRestClientUnit rest) : ApiController(redis, logger)
    {
        #region Private Fields

        private readonly IRestClientUnit _rest = rest;
        private readonly IRedisCacheService _redis = redis;

        #endregion Private Fields

        #region Methods

        #region End Points

        #region GET

        [HttpGet("")]
        public async Task<IActionResult> GetLandUsage(string args)
        {
            var email = User.Claims.First(f => f.Type.Equals(ClaimTypes.Email)).Value;

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(email);

            var result = await _rest.Lookup.SearchEmirates(cookies, args);

            return result.Match(data => Ok(data.Result), Problem);
        }

        #endregion GET

        #endregion End Points

        #endregion Methods
    }
}