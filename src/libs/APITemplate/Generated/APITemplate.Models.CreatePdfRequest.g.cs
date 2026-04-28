
#nullable enable

namespace APITemplate
{
    /// <summary>
    /// JSON data<br/>
    /// Example: {"invoice_number":"INV38379","date":"2021-09-30","currency":"USD","total_amount":82542.56}
    /// </summary>
    public sealed partial class CreatePdfRequest
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}