namespace Runtime.Common.Settings
{
    public record DmtSettings
    {
        public const string SectionName = "DMTSettings";
        public string BaseUrl { get; set; }
    }
}