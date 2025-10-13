using ADREC.DTO.ApiModels.DMTModel;
using Microsoft.AspNetCore.Mvc;
using Runtime.API.Caching;
using Runtime.API.Controllers.Base;
using Runtime.Common.Helpers;
using Runtime.RestClient.Interfaces.Unit;
using System.Net;

namespace Runtime.API.Controllers.DMT.Plots
{
    [Route("gis-plot")]
    public class GisPlotController(IRedisCacheService redis, ILogger logger, IRestClientUnit rest) : ApiController(redis,logger)
    {
        #region Private Fields

        private readonly IRestClientUnit _rest = rest;
        private readonly IRedisCacheService _redis = redis;

        #endregion Private Fields

        #region Methods

        #region End Points

        #region POST

        [HttpPost("search")]
        public async Task<IActionResult> SearchGisPlot(SearchGisPlotRequest model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            return Ok(await _rest.Plot.SearchGisPlot(cookies, model));
        }

        #endregion POST

        #region GET

        [HttpGet("detail/{tpdPlotId}/{municipalityId}")]
        public async Task<IActionResult> GetDisPlotDetail(long tpdPlotId, long municipalityId)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            return Ok(await _rest.Plot.GetGisPlotDetail(cookies, tpdPlotId, municipalityId));
        }

        #endregion GET

        #endregion End Points

        #endregion Methods
    }
}