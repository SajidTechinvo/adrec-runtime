using ErrorOr;
using Runtime.Common.Errors.Exceptions;
using Runtime.Common.Helpers;
using Runtime.DTO.ApiModels;
using Runtime.RestClient.Interfaces;
using System.Net.Http.Json;

namespace Runtime.RestClient.Implementations
{
    internal class PageInfoClient(IHttpClientFactory clientFactory) : IPageInfoClient
    {
        #region Private Fields

        private readonly IHttpClientFactory _client = clientFactory;

        #endregion Private Fields

        #region Methods

        public async Task<ErrorOr<PageInfoResponse>> GetPage(string slug)
        {
            using var client = _client.CreateClient();
            try
            {
                var response = await client.GetAsync($"{AppSettingHelper.GetServiceBuilderUrl()}/api/page_info/slug/{slug}");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<PageInfoResponse>();
                }
                else
                {
                    throw new GeneralException("An Error occurred while getting data.");
                }
            }
            catch (Exception ex)
            {
                throw new GeneralException("An error occurred while getting data. See inner exception for details", ex);
            }
        }

        #endregion Methods
    }

    internal class DatastoreClient(IHttpClientFactory clientFactory) : IDatastoreClient
    {
        #region Private Fields

        private readonly IHttpClientFactory _client = clientFactory;

        #endregion Private Fields

        #region Methods

        public async Task<ErrorOr<TableResponse>> GetTable(long id)
        {
            using var client = _client.CreateClient();
            try
            {
                var response = await client.GetAsync($"{AppSettingHelper.GetServiceBuilderUrl()}/api/data-store/{id}");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<TableResponse>();
                }
                else
                {
                    throw new GeneralException($"An Error occurred while getting data {response.ReasonPhrase}.");
                }
            }
            catch (Exception ex)
            {
                throw new GeneralException("An error occurred while getting data. See inner exception for details", ex);
            }
        }

        #endregion Methods
    }
}