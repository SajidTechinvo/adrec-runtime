namespace Runtime.DTO.ApiModels
{
    #region Response

    public class PageInfoResponse
    {
        public Guid Id { get; set; }
        public string Slug { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public string MetaEn { get; set; }
        public string MetaAr { get; set; }
        public string DescriptionEn { get; set; }
        public string DescriptionAr { get; set; }
        public bool IsActive { get; set; }
        public string Json { get; set; }
    }

    #endregion Response
}