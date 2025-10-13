using Microsoft.AspNetCore.Mvc;
using Runtime.API.Caching;
using Runtime.API.Controllers.Base;
using Runtime.Common.Helpers;
using Runtime.DTO.ApiModels.DMTModel;
using Runtime.RestClient.Interfaces.Unit;
using System.Net;

namespace Runtime.API.Controllers.DMT.Lookup
{
    [Route("master-const")]
    public class MasterConstController(IRedisCacheService redis, ILogger logger, IRestClientUnit rest) : ApiController(redis,logger)
    {
        #region Private Fields

        private readonly IRestClientUnit _rest = rest;
        private readonly IRedisCacheService _redis = redis;

        #endregion Private Fields

        #region Methods

        #region End Points

        #region POST

        [HttpPost("")]
        public async Task<IActionResult> GetLandUsage(MasterConstRequest model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            return Ok(await _rest.Lookup.GetMasterConst(cookies, model.Const));
        }

        #endregion POST

        #endregion End Points

        #endregion Methods
    }
}