
#nullable enable

namespace APITemplate
{
    /// <summary>
    /// JSON data for the template. The key `einvoice_xml` is reserved: when `einvoice=true` it must hold the ZUGFeRD/Factur-X invoice XML as a string. It is removed from the data before the template is rendered.<br/>
    /// Example: {"invoice_number":"INV38379","date":"2021-09-30","currency":"USD","total_amount":82542.56}
    /// </summary>
    public sealed partial class CreatePdfRequest
    {
        /// <summary>
        /// Reserved key. The ZUGFeRD/Factur-X invoice XML to embed, as a string. It must use the UN/CEFACT CII syntax with the root element `rsm:CrossIndustryInvoice` (`rsm:CrossIndustryDocument` for ZUGFeRD 1); UBL is not supported. It must not contain a DOCTYPE declaration. Required when `einvoice=true`; never passed to the template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("einvoice_xml")]
        public string? EinvoiceXml { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePdfRequest" /> class.
        /// </summary>
        /// <param name="einvoiceXml">
        /// Reserved key. The ZUGFeRD/Factur-X invoice XML to embed, as a string. It must use the UN/CEFACT CII syntax with the root element `rsm:CrossIndustryInvoice` (`rsm:CrossIndustryDocument` for ZUGFeRD 1); UBL is not supported. It must not contain a DOCTYPE declaration. Required when `einvoice=true`; never passed to the template.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePdfRequest(
            string? einvoiceXml)
        {
            this.EinvoiceXml = einvoiceXml;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePdfRequest" /> class.
        /// </summary>
        public CreatePdfRequest()
        {
        }

    }
}