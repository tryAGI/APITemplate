
#nullable enable

namespace APITemplate
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResponseSuccessCreatePDFVariant2
    {
        /// <summary>
        /// Overall ZUGFeRD/Factur-X validation status. Only returned when `einvoice=true`, `einvoice_validate=true` and `export_type=json` on a synchronous request.<br/>
        /// Example: valid
        /// </summary>
        /// <example>valid</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("einvoice_validation_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::APITemplate.JsonConverters.ResponseSuccessCreatePDFVariant2EinvoiceValidationStatusJsonConverter))]
        public global::APITemplate.ResponseSuccessCreatePDFVariant2EinvoiceValidationStatus? EinvoiceValidationStatus { get; set; }

        /// <summary>
        /// The full ZUGFeRD/Factur-X validation report (XML) produced by the validator. Only returned when `einvoice=true`, `einvoice_validate=true` and `export_type=json` on a synchronous request.<br/>
        /// Example: &lt;?xml version="1.0" encoding="UTF-8"?&gt;&lt;validation filename="output-einvoice.pdf"&gt;...&lt;summary status="valid"/&gt;&lt;/validation&gt;
        /// </summary>
        /// <example>&lt;?xml version="1.0" encoding="UTF-8"?&gt;&lt;validation filename="output-einvoice.pdf"&gt;...&lt;summary status="valid"/&gt;&lt;/validation&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("einvoice_validation_details")]
        public string? EinvoiceValidationDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSuccessCreatePDFVariant2" /> class.
        /// </summary>
        /// <param name="einvoiceValidationStatus">
        /// Overall ZUGFeRD/Factur-X validation status. Only returned when `einvoice=true`, `einvoice_validate=true` and `export_type=json` on a synchronous request.<br/>
        /// Example: valid
        /// </param>
        /// <param name="einvoiceValidationDetails">
        /// The full ZUGFeRD/Factur-X validation report (XML) produced by the validator. Only returned when `einvoice=true`, `einvoice_validate=true` and `export_type=json` on a synchronous request.<br/>
        /// Example: &lt;?xml version="1.0" encoding="UTF-8"?&gt;&lt;validation filename="output-einvoice.pdf"&gt;...&lt;summary status="valid"/&gt;&lt;/validation&gt;
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseSuccessCreatePDFVariant2(
            global::APITemplate.ResponseSuccessCreatePDFVariant2EinvoiceValidationStatus? einvoiceValidationStatus,
            string? einvoiceValidationDetails)
        {
            this.EinvoiceValidationStatus = einvoiceValidationStatus;
            this.EinvoiceValidationDetails = einvoiceValidationDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSuccessCreatePDFVariant2" /> class.
        /// </summary>
        public ResponseSuccessCreatePDFVariant2()
        {
        }

    }
}