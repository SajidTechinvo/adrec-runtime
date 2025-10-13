using ErrorOr;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Runtime.API.Caching;
using Runtime.Common.Errors.Exceptions;
using System.Net;
using System.Text.Json;

namespace Runtime.API.Controllers.Base
{
    [Authorize]
    [ApiController]
    public class ApiController : ControllerBase
    {
        #region Private Fields

        protected readonly ILogger _logger;
        private readonly IRedisCacheService _redis;

        #endregion Private Fields

        #region Constructors

        public ApiController(IRedisCacheService redis, ILogger logger)
        {
            _logger = logger;
            _redis = redis;
        }

        public ApiController(ILogger logger)
        {
            _logger = logger;
        }

        #endregion Constructors

        #region Methods

        protected ActionResult Problem(List<Error> errors)
        {
            var actionName = ControllerContext.ActionDescriptor.RouteValues["action"];

            if (errors.Count is 0)
            {
                return Problem();
            }

            if (errors.All(err => err.Type == ErrorType.Validation))
            {
                return ValidationProblem(errors);
            }

            HttpContext.Items.Add("errors", errors);

            foreach (var error in errors)
            {
                _logger.Error("{Code}: {Description}. Action: {ActionName}", error.Code, error.Description, actionName);
            }

            return Problem(errors[0]);
        }

        private ActionResult Problem(Error error)
        {
            int statusCode;
            if (error.NumericType > 1000)
            {
                switch (error.NumericType % 1000)
                {
                    case 400:
                        Response.StatusCode = StatusCodes.Status400BadRequest;
                        break;

                    case 404:
                        Response.StatusCode = StatusCodes.Status404NotFound;
                        break;

                    case 405:
                        Response.StatusCode = StatusCodes.Status405MethodNotAllowed;
                        break;

                    default:
                        break;
                }

                object result = null;

                if (!string.IsNullOrWhiteSpace(error.Description))
                {
                    try
                    {
                        result = JsonSerializer.Deserialize<dynamic>(error.Description);
                    }
                    catch (JsonException)
                    {
                        result = error.Description;
                    }
                }

                return new JsonResult(result);
            }
            else
            {
                statusCode = error.Type switch
                {
                    ErrorType.Conflict => StatusCodes.Status409Conflict,
                    ErrorType.Unauthorized => StatusCodes.Status401Unauthorized,
                    ErrorType.Unexpected => StatusCodes.Status400BadRequest,
                    ErrorType.Validation => StatusCodes.Status400BadRequest,
                    ErrorType.NotFound => StatusCodes.Status404NotFound,
                    _ => StatusCodes.Status500InternalServerError
                };
                return Problem(statusCode: statusCode, title: error.Description);
            }
        }

        private ActionResult ValidationProblem(List<Error> errors)
        {
            var modelState = new ModelStateDictionary();
            foreach (var error in errors)
            {
                modelState.AddModelError(error.Code, error.Description);
            }

            return ValidationProblem(modelState);
        }

        protected IActionResult Page<T, TResult>(IEnumerable<T> data, Func<IEnumerable<T>, TResult> action, int? page_size, int? page_index)
        {
            int pageSize = page_size.GetValueOrDefault(10);
            int pageIndex = page_index.GetValueOrDefault(1);

            int totalRecords = data.Count();
            int totalPages = (int)Math.Ceiling(totalRecords / (double)pageSize);

            if (page_index.HasValue && page_size.HasValue && pageIndex > 0)
            {
                data = data.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            }

            Response.Headers["X-Page-Size"] = pageSize.ToString();
            Response.Headers["X-Page-Index"] = pageIndex.ToString();
            Response.Headers["X-Total-Pages"] = totalPages.ToString();
            Response.Headers["X-Total-Records"] = totalRecords.ToString();

            return Ok(action(data));
        }

        protected async Task<List<Cookie>> GetCookies(string token, string applicationName)
        {
            switch (applicationName)
            {
                case "Runtime":
                    return await _redis.GetCacheValueAsync<List<Cookie>>(token) ?? throw new NotFoundException("Cookies not found in cache.");


                case "ServiceBuilder":
                    var runTimeToken = await _redis.GetCacheValueAsync<string>(token) ?? throw new NotFoundException("Token not found in cache.");
                    return await GetCookies(runTimeToken, "Runtime");
            }
            throw new GeneralException("An error occurred while processing your request.");
        }

        #endregion Methods
    }
}