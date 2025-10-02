using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Runtime.API.Controllers.Base;
using Runtime.DTO.RestClientModels.DMT;
using Runtime.RestClient.Interfaces.Unit;

namespace Runtime.API.Controllers.DMT.Mocks
{
    [Route("challenge")]
    public class ChallengeController(ILogger logger, IRestClientUnit rest) : ApiController(logger)
    {
        #region Private Fields

        private readonly IRestClientUnit _rest = rest;

        #endregion Private Fields

        #region Methods

        #region End Points

        #region GET

        [AllowAnonymous]
        [HttpGet("")]
        [ProducesResponseType(typeof(IEnumerable<ChallengeResponse>), StatusCodes.Status200OK)]
        public IActionResult GetChallenges()
        {
            return Ok(_rest.Challenge.GetChallenges());
        }

        #endregion GET

        #endregion End Points

        #endregion Methods
    }
}