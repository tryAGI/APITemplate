
#nullable enable

namespace APITemplate
{
    /// <summary>
    /// The data object containing values for dynamic content in the HTML body. This object should include properties with corresponding values.<br/>
    /// Example: {"name":"This is a title"}
    /// </summary>
    public sealed partial class CreatePdfFromHtmlRequestData
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}