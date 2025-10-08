namespace Runtime.DTO.ApiModels
{
    #region Response

    public class TableResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public List<ColumnResponse> Columns { get; set; }
        public List<Dictionary<string, string>> Records { get; set; }
    }

    public class ColumnResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string DataType { get; set; }
    }

    #endregion Response
}