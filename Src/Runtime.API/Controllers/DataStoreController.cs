using Microsoft.AspNetCore.Mvc;
using Runtime.API.Controllers.Base;
using Runtime.DTO.ApiModels;
using Runtime.RestClient.Interfaces.Unit;

namespace Runtime.API.Controllers
{
    [Route("api/data-store")]
    public class DataStoreController(IRestClientUnit rest, ILogger logger) : ApiController(logger)
    {
        #region Private Methods

        private readonly IRestClientUnit _rest = rest;

        #endregion Private Methods

        #region Methods

        #region End Points

        #region GET

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(TableResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetDatastore(long id)
        {
            var table = await _rest.Datastore.GetTable(id);
            if (table.IsError) return Problem(table.Errors);

            return Ok(table.Value);
        }

        #endregion GET

        #endregion End Points

        #endregion Methods
    }
}