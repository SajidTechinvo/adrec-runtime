using ADREC.RestClient.Interfaces.DMT.Users;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT;
using System.Text.Json;

namespace ADREC.RestClient.Implementations.DMT.Users.Inbox
{
    internal class ChallengeClient : IChallengeClient
    {
        public DmtResponseWrapper<List<ChallengeResponse>> GetChallenges()
        {
            var basePath = AppContext.BaseDirectory;

            var filePath = Path.Combine(basePath, "Response", "Challanges.json");

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"The file '{filePath}' was not found.");
            }
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<ChallengeResponse>>>(File.ReadAllText(filePath));
        }
    }
}