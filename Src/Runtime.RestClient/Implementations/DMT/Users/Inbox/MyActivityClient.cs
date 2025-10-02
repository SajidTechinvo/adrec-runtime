using ADREC.RestClient.Interfaces.DMT.Users;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT;
using System.Text.Json;

namespace ADREC.RestClient.Implementations.DMT.Users.Inbox
{
    internal class MyActivityClient : IMyActivityClient
    {
        public DmtResponseWrapper<List<MyActivityResponse>> GetMyActivities()
        {
            var basePath = AppContext.BaseDirectory;

            var filePath = Path.Combine(basePath, "Response", "MyActivity.json");

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"The file '{filePath}' was not found.");
            }
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<MyActivityResponse>>>(File.ReadAllText(filePath));
        }
    }
}