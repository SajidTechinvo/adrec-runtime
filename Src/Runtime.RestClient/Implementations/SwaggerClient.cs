using Runtime.RestClient.Interfaces;

namespace ADREC.RestClient.Implementations
{
    internal class SwaggerClient(IHttpClientFactory clientFactory) : ISwaggerClient
    {
        #region Private Fields

        private readonly IHttpClientFactory _client = clientFactory;

        #endregion Private Fields

        #region Methods

        public async Task<string> GetSwaggerJson(string url)
        {
            using var client = _client.CreateClient();
            try
            {
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    throw new Exception("An Error occurred while getting data.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion Methods
    }
}