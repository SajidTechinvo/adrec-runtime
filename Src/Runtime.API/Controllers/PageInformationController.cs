using Microsoft.AspNetCore.Mvc;
using Runtime.API.Controllers.Base;
using Runtime.DTO.ApiModels;
using Runtime.RestClient.Interfaces;

namespace Runtime.API.Controllers
{
    [Route("api/page_info")]
    public class PageInformationController(IAmazonClient aws, ILogger logger) : ApiController(logger)
    {
        #region Private Methods

        private readonly IAmazonClient _aws = aws;

        #endregion Private Methods

        #region Methods

        #region End Points

        #region GET

        [HttpGet("slug/{slug}")]
        [ProducesResponseType(typeof(TableResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetDatastore(string slug)
        {

            await _aws.ReadFileAsync("OneHubRanchAllocationService");


            return Ok();
        }

        #endregion GET

        #endregion End Points

        #endregion Methods
    }
}