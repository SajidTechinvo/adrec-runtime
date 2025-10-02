using ADREC.DTO.RestClientModels.DMT.Users;
using ErrorOr;
using Runtime.DTO.RestClientModels.Common;
using Runtime.RestClient.Interfaces.DMT.Users;
using System.Net;
using System.Text.Json;

namespace ADREC.RestClient.Implementations.DMT.Users
{
    internal class EmployeeMockClient : IEmployeeClient
    {
        #region Private Methods

        private static async Task<string> GetFileContent(string fileName)
        {
            var basePath = AppContext.BaseDirectory;

            var filePath = Path.Combine(basePath, "Response", "Users", fileName);

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"The file '{filePath}' was not found.");
            }

            return await File.ReadAllTextAsync(filePath);
        }

        #endregion Private Methods

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<EmployeeLocationResponse>>> GetEmployeeLocation(List<Cookie> cookies, string args)
        {
            var content = await GetFileContent("GetEmployeeLocation.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<EmployeeLocationResponse>>(content);
        }

        #endregion Methods
    }
}