using Microsoft.AspNetCore.Mvc;
using Runtime.API.Controllers.Base;
using Runtime.Common.Helpers;
using Runtime.DTO.ApiModels;
using Runtime.RestClient.Interfaces.Unit;

namespace Runtime.API.Controllers
{
    [Route("api/page_info")]
    public class PageInformationController(IRestClientUnit rest, ILogger logger) : ApiController(logger)
    {
        #region Private Methods

        private readonly IRestClientUnit _rest = rest;

        #endregion Private Methods

        #region Methods

        #region End Points

        #region GET

        [HttpGet("slug/{slug}")]
        [ProducesResponseType(typeof(TableResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetDatastore(string slug)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var page = await _rest.PageInfo.GetPage(token, slug);
            if (page.IsError) return Problem(page.Errors);

            return Ok(page.Value);
        }

        #endregion GET

        #endregion End Points

        #endregion Methods
    }
}