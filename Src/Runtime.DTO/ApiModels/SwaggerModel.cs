namespace Runtime.DTO.ApiModels
{
    public class EndpointInfoResponse
    {
        public EndpointInfoResponse()
        {
            Params = [];
            Headers = [];
            Body = [];
        }

        public string Method { get; set; }
        public string Url { get; set; }
        public List<ParamInfo> Params { get; set; }
        public List<ParamInfo> Headers { get; set; }
        public List<ParamInfo> Body { get; set; }
    }

    public class ParamInfo
    {
        public string Key { get; set; }
        public string ValueType { get; set; }
    }
}