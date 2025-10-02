using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT;

namespace ADREC.RestClient.Interfaces.DMT.Users
{
    public interface IChallengeClient
    {
        DmtResponseWrapper<List<ChallengeResponse>> GetChallenges();
    }
}