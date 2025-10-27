using Microsoft.AspNetCore.Mvc;
using Runtime.API.Caching;
using Runtime.API.Controllers.Base;
using Runtime.Common.Helpers;
using Runtime.RestClient.Interfaces.Unit;

namespace Runtime.API.Controllers.DMT
{
    [Route("document")]
    public class DocumentController(IRedisCacheService redis, ILogger logger, IRestClientUnit rest) : ApiController(redis, logger)
    {
        #region Private Fields

        private readonly IRestClientUnit _rest = rest;

        #endregion Private Fields

        #region Methods

        #region End Points

        #region GET

        [HttpGet("thumbnail")]
        public async Task<IActionResult> GetThumbnail(string args)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var applicationName = User.Claims.First(f => f.Type == "Application").Value;

            var cookies = await GetCookies(token, applicationName);

            var result = await _rest.Document.DownloadFileAsync(cookies, args);

            if (result.IsError)
                return Problem(result.Errors);

            var data = result.Value;

            if (string.IsNullOrWhiteSpace(data.FileName))
                data.FileName = "DefaultPlotProfileMap.png";

            return File(data.Stream, MimeTypeMap.GetMimeType(Path.GetExtension(data.FileName)));
        }

        #endregion GET

        #endregion End Points

        #endregion Methods
    }
}