using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Runtime.API.Controllers.Base;
using Runtime.DTO.ApiModels;
using Runtime.RestClient.Interfaces;
using Runtime.RestClient.Interfaces.Unit;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Runtime.API.Controllers
{
    [Route("api/page_info")]
    public class PageInformationController(IWebHostEnvironment env, IRestClientUnit rest, IAmazonClient aws, ILogger logger) : ApiController(logger)
    {
        #region Private Fields

        private readonly IAmazonClient _aws = aws;
        private readonly IRestClientUnit _rest = rest;
        private readonly IWebHostEnvironment _env = env;

        #endregion Private Fields

        #region Private Methods

        private static string FixJsToJson(string jsObject)
        {
            string json = jsObject;

            json = Regex.Replace(json, @"'", "\"");

            json = Regex.Replace(json, @"(\w+)\s*:", "\"$1\":");

            return json;
        }

        #endregion Private Methods

        #region Methods

        #region End Points

        #region GET

        [AllowAnonymous]
        [HttpGet("slug/{slug}")]
        [ProducesResponseType(typeof(TableResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetDatastore(string slug)
        {
            if (_env.IsProduction())
            {
                var fileContent = await _aws.ReadFileAsync("OneHubRanchAllocationService.js");

                if (string.IsNullOrWhiteSpace(fileContent))
                    return NotFound("File is empty or missing.");

                var match = Regex.Match(
                    fileContent,
                    @"const\s+(\w+)\s*=\s*(\{[\s\S]*?\});\s*export\s+default\s+\1\s*;",
                    RegexOptions.Multiline
                );

                if (!match.Success)
                    return BadRequest("Could not find a valid object declaration in the JS file.");

                var jsObject = match.Groups[2].Value.Trim();

                string json = FixJsToJson(jsObject);

                var data = JsonSerializer.Deserialize<object>(json);

                return Ok(data);
            }
            else
            {
                var page = await _rest.PageInfo.GetPage(slug);
                if (page.IsError) return Problem(page.Errors);

                return Ok(page.Value);
            }
        }

        #endregion GET

        #endregion End Points

        #endregion Methods
    }
}