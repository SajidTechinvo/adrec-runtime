using ErrorOr;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Text.Json;

namespace Runtime.API.Controllers.Base
{
    [Authorize]
    [ApiController]
    public class ApiController(ILogger logger) : ControllerBase
    {
        #region Private Fields

        protected readonly ILogger _logger = logger;

        #endregion Private Fields

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

        #endregion Methods
    }
}