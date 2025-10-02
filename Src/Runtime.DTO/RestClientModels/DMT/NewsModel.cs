using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT
{
    public class AttachmentList
    {
        [JsonPropertyName("attachmentId")]
        public int AttachmentId { get; set; }

        [JsonPropertyName("documentId")]
        public int DocumentId { get; set; }

        [JsonPropertyName("attachmentTitle")]
        public string AttachmentTitle { get; set; }

        [JsonPropertyName("attachmentDate")]
        public DateTime AttachmentDate { get; set; }

        [JsonPropertyName("downloadUrl")]
        public string DownloadUrl { get; set; }
    }

    public class Media
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("attachmentList")]
        public List<AttachmentList> AttachmentList { get; set; }

        [JsonPropertyName("documentType")]
        public string DocumentType { get; set; }
    }

    public class NewsResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("body")]
        public string Body { get; set; }

        [JsonPropertyName("bodyAr")]
        public string BodyAr { get; set; }

        [JsonPropertyName("creationDate")]
        public string CreationDate { get; set; }

        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        [JsonPropertyName("subjectAr")]
        public string SubjectAr { get; set; }

        [JsonPropertyName("media")]
        public Media Media { get; set; }

        [JsonPropertyName("thumbnailDocuments")]
        public List<ThumbnailDocument> ThumbnailDocuments { get; set; }
    }

    public class ThumbnailDocument
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("attachmentList")]
        public List<AttachmentList> AttachmentList { get; set; }

        [JsonPropertyName("documentType")]
        public string DocumentType { get; set; }
    }
}