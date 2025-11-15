using Microsoft.AspNetCore.Mvc;
using Runtime.API.Caching;
using Runtime.API.Controllers.Base;
using Runtime.RestClient.Interfaces.Unit;
using System.Security.Claims;

namespace Runtime.API.Controllers.DMT.Lookup
{
    [Route("community")]
    public class CommunityController(IRedisCacheService redis, ILogger logger, IRestClientUnit rest) : ApiController(redis, logger)
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
        /// <param name="id">District ID</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCommunities(long id)
        {
            var email = User.Claims.First(f => f.Type.Equals(ClaimTypes.Email)).Value;

            var cookies = await GetCookies(email);

            var result = await _rest.Lookup.SearchCommunities(cookies, id);

            return result.Match(data => Ok(data.Result), Problem);
        }

        #endregion GET

        #endregion End Points

        #endregion Methods
    }
}