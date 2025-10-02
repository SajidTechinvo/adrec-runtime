using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Runtime.API.Caching;
using Runtime.API.Controllers.Base;
using Runtime.Common.Helpers;
using Runtime.DTO.ApiModels.DMTModel;
using Runtime.RestClient.Interfaces.Unit;
using System.Net;

namespace Runtime.API.Controllers.DMT
{
    [Route("file")]
    public class FileController(IRedisCacheService redis, ILogger logger, IRestClientUnit rest) : ApiController(logger)
    {
        #region Private Fields

        private readonly IRestClientUnit _rest = rest;
        private readonly IRedisCacheService _redis = redis;

        #endregion Private Fields

        #region Methods

        #region End Points

        #region POST

        [HttpPost("upload")]
        public async Task<IActionResult> Upload(string args, UploadFileRequest model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.File.UploadFileAsync(cookies, Convert.FromBase64String(model.File.FileContent), model.Name, model.File.FileName, args);

            return result.Match(Ok, Problem);
        }

        [AllowAnonymous]
        [HttpGet("download")]
        public async Task<IActionResult> Download(string args)
        {
            var result = await _rest.File.DownloadFileAsync(args);

            return result.Match(data => File(data.Stream, MimeTypeMap.GetMimeType(Path.GetExtension(data.FileName))), Problem);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete(string args)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.File.DeleteFileAsync(cookies, args);

            return result.Match(Ok, Problem);
        }

        #endregion POST

        #endregion End Points

        #endregion Methods
    }
}