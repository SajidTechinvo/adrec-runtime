using System.Text.Json.Serialization;

namespace Runtime.DTO.ApiModels.Common
{
    public class FileRequestModel
    {
        [JsonPropertyName("file_name")]
        public string FileName { get; set; }

        [JsonPropertyName("file_type")]
        public string FileType { get; set; }

        [JsonPropertyName("file_content")]
        public string FileContent { get; set; }

        [JsonPropertyName("file_identifier")]
        public string FileIdentifier { get; set; }

        [JsonPropertyName("file_extension")]
        public string FileExtension { get; set; }
    }

    public class FileResponse
    {
        public long Id { get; set; }

        [JsonPropertyName("file_type")]
        public string FileType { get; set; }

        [JsonPropertyName("file_name")]
        public string FileName { get; set; }

        [JsonPropertyName("file_identifier")]
        public string FileIdentifier { get; set; }

        [JsonPropertyName("file_path")]
        public string FilePath { get; set; }

        [JsonPropertyName("file_extension")]
        public string FileExtension => FileIdentifier != null && FileIdentifier.Contains('.') ? FileIdentifier.Split('.')[^1] : null;
    }
}