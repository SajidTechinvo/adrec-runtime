using System.Text.Json.Serialization;

namespace ADREC.DTO.RestClientModels.DMT.Lookup
{
    public class FetchWorkflowFeesResponse
    {
        [JsonPropertyName("aboveIndicatorFirstPayment")]
        public object AboveIndicatorFirstPayment { get; set; }

        [JsonPropertyName("aboveIndicatorInstallCount")]
        public object AboveIndicatorInstallCount { get; set; }

        [JsonPropertyName("aboveIndicatorInstallMonths")]
        public object AboveIndicatorInstallMonths { get; set; }

        [JsonPropertyName("accountNoAA")]
        public string AccountNoAA { get; set; }

        [JsonPropertyName("accountNoAD")]
        public string AccountNoAD { get; set; }

        [JsonPropertyName("accountNoWR")]
        public string AccountNoWR { get; set; }

        [JsonPropertyName("applicationTypeAA")]
        public string ApplicationTypeAA { get; set; }

        [JsonPropertyName("applicationTypeAD")]
        public string ApplicationTypeAD { get; set; }

        [JsonPropertyName("applicationTypeDR")]
        public string ApplicationTypeDR { get; set; }

        [JsonPropertyName("belowIndicatorFirstPayment")]
        public object BelowIndicatorFirstPayment { get; set; }

        [JsonPropertyName("belowIndicatorInstallCount")]
        public object BelowIndicatorInstallCount { get; set; }

        [JsonPropertyName("belowIndicatorInstallMonths")]
        public object BelowIndicatorInstallMonths { get; set; }

        [JsonPropertyName("codeIdAA")]
        public string CodeIdAA { get; set; }

        [JsonPropertyName("codeIdAD")]
        public string CodeIdAD { get; set; }

        [JsonPropertyName("codeIdDR")]
        public string CodeIdDR { get; set; }

        [JsonPropertyName("descriptionA")]
        public string DescriptionA { get; set; }

        [JsonPropertyName("descriptionE")]
        public string DescriptionE { get; set; }

        [JsonPropertyName("elmsWorkflowFeeConst")]
        public string ElmsWorkflowFeeConst { get; set; }

        [JsonPropertyName("feeBaseAmount")]
        public double FeeBaseAmount { get; set; }

        [JsonPropertyName("feeDiscount")]
        public object FeeDiscount { get; set; }

        [JsonPropertyName("feeMaximumAmount")]
        public double FeeMaximumAmount { get; set; }

        [JsonPropertyName("feeMinimumAmount")]
        public double FeeMinimumAmount { get; set; }

        [JsonPropertyName("feeMultiple")]
        public double FeeMultiple { get; set; }

        [JsonPropertyName("installmentIndicatorAmount")]
        public object InstallmentIndicatorAmount { get; set; }

        [JsonPropertyName("isAccrual")]
        public int IsAccrual { get; set; }

        [JsonPropertyName("maxInstallmentNo")]
        public object MaxInstallmentNo { get; set; }

        [JsonPropertyName("migNote")]
        public object MigNote { get; set; }

        [JsonPropertyName("migNoteL")]
        public string MigNoteL { get; set; }

        [JsonPropertyName("migNoteLm")]
        public string MigNoteLm { get; set; }

        [JsonPropertyName("minAmountAllowInstallment")]
        public object MinAmountAllowInstallment { get; set; }

        [JsonPropertyName("sectionCodeAA")]
        public string SectionCodeAA { get; set; }

        [JsonPropertyName("sectionCodeAD")]
        public string SectionCodeAD { get; set; }

        [JsonPropertyName("sectionCodeDR")]
        public string SectionCodeDR { get; set; }

        [JsonPropertyName("vatPercentage")]
        public object VatPercentage { get; set; }

        [JsonPropertyName("workflowfeeId")]
        public int WorkflowfeeId { get; set; }

        [JsonPropertyName("workflowFeeNameA")]
        public string WorkflowFeeNameA { get; set; }

        [JsonPropertyName("workflowFeeNameE")]
        public string WorkflowFeeNameE { get; set; }

        [JsonPropertyName("workflowId")]
        public int WorkflowId { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}