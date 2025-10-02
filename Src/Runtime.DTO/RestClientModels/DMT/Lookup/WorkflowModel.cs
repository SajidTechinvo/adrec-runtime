using System.Text.Json.Serialization;

namespace ADREC.DTO.RestClientModels.DMT.Lookup
{
    public class WorkflowResponse
    {
        [JsonPropertyName("aaOrgUnitId")]
        public object AaOrgUnitId { get; set; }

        [JsonPropertyName("aaOrgUnitKpi")]
        public object AaOrgUnitKpi { get; set; }

        [JsonPropertyName("adOrgUnitId")]
        public object AdOrgUnitId { get; set; }

        [JsonPropertyName("adOrgUnitKpi")]
        public object AdOrgUnitKpi { get; set; }

        [JsonPropertyName("applicationFlags")]
        public int? ApplicationFlags { get; set; }

        [JsonPropertyName("baseServiceClassName")]
        public string BaseServiceClassName { get; set; }

        [JsonPropertyName("businessFlags")]
        public int BusinessFlags { get; set; }

        [JsonPropertyName("dmtServiceCode")]
        public string DmtServiceCode { get; set; }

        [JsonPropertyName("draftAutoCancelPeriod")]
        public object DraftAutoCancelPeriod { get; set; }

        [JsonPropertyName("elmsWorkflowId")]
        public object ElmsWorkflowId { get; set; }

        [JsonPropertyName("gspCode")]
        public string GspCode { get; set; }

        [JsonPropertyName("hasBaseServiceClass")]
        public bool HasBaseServiceClass { get; set; }

        [JsonPropertyName("isActive")]
        public int IsActive { get; set; }

        [JsonPropertyName("isIncludeStpSaeed")]
        public int IsIncludeStpSaeed { get; set; }

        [JsonPropertyName("lastWorkflowStepIndexFlag")]
        public int LastWorkflowStepIndexFlag { get; set; }

        [JsonPropertyName("municipalityFlags")]
        public object MunicipalityFlags { get; set; }

        [JsonPropertyName("parentWorkflowId")]
        public int? ParentWorkflowId { get; set; }

        [JsonPropertyName("sortOrder")]
        public int SortOrder { get; set; }

        [JsonPropertyName("swfmsId")]
        public object SwfmsId { get; set; }

        [JsonPropertyName("tammServiceCode")]
        public string TammServiceCode { get; set; }

        [JsonPropertyName("tammUrlAr")]
        public string TammUrlAr { get; set; }

        [JsonPropertyName("tammUrlEn")]
        public string TammUrlEn { get; set; }

        [JsonPropertyName("unifiedServiceCode")]
        public string UnifiedServiceCode { get; set; }

        [JsonPropertyName("validUserTypes")]
        public string ValidUserTypes { get; set; }

        [JsonPropertyName("viewsPath")]
        public string ViewsPath { get; set; }

        [JsonPropertyName("webApiUrl")]
        public string WebApiUrl { get; set; }

        [JsonPropertyName("workflowCategoryId")]
        public int WorkflowCategoryId { get; set; }

        [JsonPropertyName("workflowConst")]
        public string WorkflowConst { get; set; }

        [JsonPropertyName("workflowId")]
        public int WorkflowId { get; set; }

        [JsonPropertyName("workflowNameA")]
        public string WorkflowNameA { get; set; }

        [JsonPropertyName("workflowNameE")]
        public string WorkflowNameE { get; set; }

        [JsonPropertyName("workflowTagA")]
        public string WorkflowTagA { get; set; }

        [JsonPropertyName("workflowTagE")]
        public string WorkflowTagE { get; set; }

        [JsonPropertyName("workflowTypeId")]
        public int WorkflowTypeId { get; set; }

        [JsonPropertyName("wrOrgUnitId")]
        public object WrOrgUnitId { get; set; }

        [JsonPropertyName("wrOrgUnitKpi")]
        public object WrOrgUnitKpi { get; set; }

        [JsonPropertyName("steps")]
        public object Steps { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }

    public class WorkflowStepTypeResponse
    {
        [JsonPropertyName("workflowStepTypeConst")]
        public string WorkflowStepTypeConst { get; set; }

        [JsonPropertyName("workflowStepTypeId")]
        public int WorkflowStepTypeId { get; set; }

        [JsonPropertyName("workflowStepTypeNameA")]
        public string WorkflowStepTypeNameA { get; set; }

        [JsonPropertyName("workflowStepTypeNameE")]
        public string WorkflowStepTypeNameE { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}