using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Runtime.DTO.ApiModels;
using Runtime.RestClient.Interfaces.Unit;

namespace Runtime.API.Controllers
{
    [ApiController]
    [Route("api/swagger")]
    public class SwaggerController(IRestClientUnit rest) : ControllerBase
    {
        #region Private Fields

        private readonly IRestClientUnit _rest = rest;

        #endregion Private Fields

        #region Private Methods

        public static List<EndpointInfoResponse> ParseSwagger(JObject swagger)
        {
            var endpoints = new List<EndpointInfoResponse>();
            var paths = (JObject)swagger["paths"];
            var components = (JObject)swagger["components"]?["schemas"];

            foreach (var path in paths)
            {
                string url = path.Key;
                var methods = (JObject)path.Value;

                foreach (var method in methods)
                {
                    string httpMethod = method.Key.ToUpper();
                    var details = (JObject)method.Value;

                    var endpoint = new EndpointInfoResponse
                    {
                        Method = httpMethod,
                        Url = url
                    };

                    // Query & header params
                    if (details.TryGetValue("parameters", out var paramToken))
                    {
                        foreach (var param in paramToken as JArray)
                        {
                            string location = param["in"]?.ToString();
                            string name = param["name"]?.ToString();
                            string type = param["schema"]?["type"]?.ToString() ?? "string";

                            var target = location == "header" ? endpoint.Headers : endpoint.Params;
                            target.Add(new ParamInfo { Key = name, ValueType = type });
                        }
                    }

                    // Body
                    var bodySchema = details["requestBody"]?["content"]?
                        .Children<JProperty>()
                        .Select(x => x.Value["schema"])
                        .FirstOrDefault(x => x != null);

                    if (bodySchema != null)
                    {
                        JObject resolvedSchema = null;

                        if (bodySchema["$ref"] != null)
                        {
                            var refPath = bodySchema["$ref"].ToString().Split('/').Last();
                            resolvedSchema = components?[refPath] as JObject;
                        }
                        else if (bodySchema["properties"] != null)
                        {
                            resolvedSchema = (JObject)bodySchema;
                        }

                        if (resolvedSchema != null)
                        {
                            var properties = (JObject)resolvedSchema["properties"];
                            foreach (var prop in properties)
                            {
                                endpoint.Body.Add(new ParamInfo
                                {
                                    Key = prop.Key,
                                    ValueType = prop.Value["type"]?.ToString() ?? "string"
                                });
                            }
                        }
                    }

                    endpoints.Add(endpoint);
                }
            }

            return endpoints;
        }

        #endregion Private Methods

        #region Methods

        #region End Points

        #region GET

        [HttpGet("")]
        [ProducesResponseType(typeof(List<EndpointInfoResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetSwagger()
        {
            var json = await _rest.Swagger.GetSwaggerJson("http://38.242.224.162/adrec/swagger/v1/swagger.json");

            var swagger = JObject.Parse(json);
            return Ok(ParseSwagger(swagger));
        }

        #endregion GET

        #endregion End Points

        #endregion Methods
    }
}