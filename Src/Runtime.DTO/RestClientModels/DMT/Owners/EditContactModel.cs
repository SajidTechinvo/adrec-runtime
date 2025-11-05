using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.Owners
{

    public class EditContactResponse
    {
        [JsonPropertyName("_fieldsData")]
        public List<List<object>> FieldsData { get; set; }

        [JsonPropertyName("_fieldsFlags")]
        public List<bool> FieldsFlags { get; set; }

        [JsonPropertyName("_fieldsState")]
        public int FieldsState { get; set; }

        [JsonPropertyName("_fieldsIsDirty")]
        public bool FieldsIsDirty { get; set; }

        [JsonPropertyName("_name")]
        public string Name { get; set; }

        [JsonPropertyName("_isNew")]
        public bool IsNew { get; set; }

        [JsonPropertyName("_validator")]
        public object Validator { get; set; }

        [JsonPropertyName("_objectID")]
        public string ObjectID { get; set; }

        [JsonPropertyName("_concurrencyPredicateFactoryToUse")]
        public object ConcurrencyPredicateFactoryToUse { get; set; }

        [JsonPropertyName("_dataErrorInfoError")]
        public string DataErrorInfoError { get; set; }

        [JsonPropertyName("_dataErrorInfoErrorsPerField")]
        public object DataErrorInfoErrorsPerField { get; set; }

        [JsonPropertyName("_typeDefaultValueProvider")]
        public object TypeDefaultValueProvider { get; set; }

        [JsonPropertyName("_authorizerToUse")]
        public object AuthorizerToUse { get; set; }

        [JsonPropertyName("_auditorToUse")]
        public object AuditorToUse { get; set; }

        [JsonPropertyName("_relatedEntitySyncInfos")]
        public object RelatedEntitySyncInfos { get; set; }

        [JsonPropertyName("_field2RelatedEntity")]
        public object Field2RelatedEntity { get; set; }
    }
}
