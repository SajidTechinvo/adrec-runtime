using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Runtime.API.Caching;
using Runtime.API.Controllers.Base;
using Runtime.DTO.RestClientModels.DMT;
using Runtime.RestClient.Interfaces.Unit;

namespace Runtime.API.Controllers.DMT.Mocks
{
    [Route("my-activity")]
    public class MyActivityController(IRedisCacheService redis, ILogger logger, IRestClientUnit rest) : ApiController(redis, logger)
    {
        #region Private Fields

        private readonly IRestClientUnit _rest = rest;

        #endregion Private Fields

        #region Methods

        #region End Points

        #region GET

        [AllowAnonymous]
        [HttpGet("")]
        [ProducesResponseType(typeof(IEnumerable<MyActivityResponse>), StatusCodes.Status200OK)]
        public IActionResult GetMyActivity()
        {
            return Ok(_rest.MyActivity.GetMyActivities());
        }

        #endregion GET

        #endregion End Points

        #endregion Methods
    }
}