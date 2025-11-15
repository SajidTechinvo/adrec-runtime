using Microsoft.AspNetCore.Mvc;
using Runtime.API.Caching;
using Runtime.API.Controllers.Base;
using Runtime.RestClient.Interfaces.Unit;
using System.Net;
using System.Security.Claims;

namespace Runtime.API.Controllers.DMT.Mocks
{
    [Route("news")]
    public class NewsController(IRedisCacheService redis, ILogger logger, IRestClientUnit rest) : ApiController(redis, logger)
    {
        #region Private Fields

        private readonly IRestClientUnit _rest = rest;
        private readonly IRedisCacheService _redis = redis;

        #endregion Private Fields

        #region Methods

        #region End Points

        #region GET

        [HttpGet("")]
        public async Task<IActionResult> GetMimsProfile()
        {
            var email = User.Claims.First(f => f.Type.Equals(ClaimTypes.Email)).Value;

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(email);

            return Ok(await _rest.News.GetNews(cookies));
        }

        #endregion GET

        #endregion End Points

        #endregion Methods
    }
}