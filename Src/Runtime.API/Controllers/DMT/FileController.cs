using Microsoft.AspNetCore.Mvc;
using Runtime.API.Caching;
using Runtime.API.Controllers.Base;
using Runtime.Common.Helpers;
using Runtime.DTO.ApiModels.DMTModel;
using Runtime.RestClient.Interfaces.Unit;

namespace Runtime.API.Controllers.DMT
{
    [Route("file")]
    public class FileController(IRedisCacheService redis, ILogger logger, IRestClientUnit rest) : ApiController(redis, logger)
    {
        #region Private Fields

        private readonly IRestClientUnit _rest = rest;

        #endregion Private Fields

        #region Methods

        #region End Points

        #region POST

        [HttpPost("upload")]
        public async Task<IActionResult> Upload(string args, UploadFileRequest model)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            var result = await _rest.File.UploadFileAsync(cookies, Convert.FromBase64String(model.File.FileContent), model.Name, model.File.FileName, args);

            return result.Match(Ok, Problem);
        }

        [HttpGet("download")]
        public async Task<IActionResult> Download(string args)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            var result = await _rest.File.DownloadFileAsync(cookies, args);

            return result.Match(data => File(data.Stream, MimeTypeMap.GetMimeType(Path.GetExtension(data.FileName))), Problem);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete(string args)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            var result = await _rest.File.DeleteFileAsync(cookies, args);

            return result.Match(Ok, Problem);
        }

        #endregion POST

        #endregion End Points

        #endregion Methods
    }
}