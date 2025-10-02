using ADREC.RestClient.Interfaces.Factory;
using ErrorOr;
using Runtime.Common.Settings;
using Runtime.RestClient.Implementations.Factory;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.Units;
using Runtime.RestClient.Interfaces.DMT.ElmsUnits;
using System.Net;

namespace Runtime.RestClient.Implementations.DMT.ElmsUnits
{
    internal class UnitClient(DmtSettings settings, ICustomHttpFactory httpFactory) : HttpBase(settings, httpFactory), IUnitClient
    {
        #region Private Fields

        private readonly DmtSettings _settings = settings;

        #endregion Private Fields

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<UnitDetailResponse>>> GetUnitDetails(List<Cookie> cookies, string args, long id)
        {
            return await Post<DmtResponseWrapper<UnitDetailResponse>, object>(cookies, $"{_settings.BaseUrl}/api/ElmsUnit/UnitDetails?args={args}", new
            {
                id
            });
        }

        public async Task<ErrorOr<DmtResponseWrapper<DmtPageResponse<UnitResponse>>>> SearchUnits(
            List<Cookie> cookies, string args, int requestId, string createUrlArgs, string municipalityId,
            string districtId, string communityId, string roadId, string plotNumber, string landuseId,
            string buildingNumber, string flourNumber, string unitNumber, string unitClassificationId,
            MatchType matchTypeId, int pageSize, string searchPlotFlags, string searchOwnerFlags, string ownerId,
            int pageNumber, int totalCount)
        {
            return await Post<DmtResponseWrapper<DmtPageResponse<UnitResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/elmsUnit/searchUnits?args={args}", new
            {
                requestId,
                createUrlArgs,
                municipalityId,
                districtId,
                communityId,
                roadId,
                plotNumber,
                landuseId,
                buildingNumber,
                flourNumber,
                unitNumber,
                unitClassificationId,
                matchTypeId = matchTypeId.ToString(),
                pageSize,
                searchPlotFlags,
                searchOwnerFlags,
                ownerId,
                pageNumber,
                totalCount
            });
        }

        #endregion Methods
    }
}