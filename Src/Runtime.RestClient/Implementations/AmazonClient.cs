using Amazon.S3;
using Amazon.S3.Model;
using Microsoft.Extensions.Options;
using Runtime.Common.Settings;
using Runtime.RestClient.Interfaces;

namespace Runtime.RestClient.Implementations
{

    internal class MockAmazonClient : IAmazonClient
    {
        public Task<string> ReadFileAsync(string fileName)
        {
            return File.ReadAllTextAsync(fileName);
        }
    }

    internal class AmazonClient(IOptions<AmazonClientOptions> options) : IAmazonClient
    {
        #region Private Fields

        private readonly AmazonClientOptions _options = options.Value;

        #endregion Private Fields

        #region Methods

        public async Task<string> ReadFileAsync(string fileName)
        {
            var config = new AmazonS3Config
            {
                ServiceURL = _options.ServiceURL,
                ForcePathStyle = true
            };

            var client = new AmazonS3Client(
                _options.AwsAccessKeyId,
                _options.AwsSecretKey,
                config
            );

            var request = new GetObjectRequest
            {
                BucketName = _options.BucketName,
                Key = fileName
            };

            using var response = await client.GetObjectAsync(request);
            using var reader = new StreamReader(response.ResponseStream);
            var fileContent = await reader.ReadToEndAsync();

            return fileContent;
        }

        #endregion Methods
    }
}