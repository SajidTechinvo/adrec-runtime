namespace Runtime.Common.Settings
{
    public record UaePassSettings
    {
        public const string SectionName = "UaePassSettings";
        public string DeviceId { get; set; }
        public string DeviceLang { get; set; }
        public string SourceSystem { get; set; }
        public string SourceSystemValue { get; set; }
    }
}