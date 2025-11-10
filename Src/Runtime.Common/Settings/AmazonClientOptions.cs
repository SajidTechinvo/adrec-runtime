namespace Runtime.Common.Settings
{
    public record AmazonClientOptions
    {
        public const string SectionName = "AmazonClientOptions";
        public string ServiceURL { get; set; }
        public string AwsAccessKeyId { get; set; }
        public string AwsSecretKey { get; set; }
        public string BucketName { get; set; }
    }
}