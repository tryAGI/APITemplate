
#nullable enable

namespace APITemplate
{
    /// <summary>
    /// Settings of the template, the followings is an example:<br/>
    /// Example: {"custom_header":"\u003Cstyle\u003E#header, #footer { padding: 0 !important; }\u003C/style\u003E","custom_footer":"\u003Cstyle\u003E#header, #footer { padding: 0 !important; }\u003C/style\u003E"}
    /// </summary>
    public sealed partial class UpdateTemplateRequestSettings
    {
        /// <summary>
        /// Specify custom HTML markup for the headerof the PDF. These properties should contain valid HTML markup, including any necessary CSS styles.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_header")]
        public string? CustomHeader { get; set; }

        /// <summary>
        /// Specify custom HTML markup for the footer of the PDF. These properties should contain valid HTML markup, including any necessary CSS styles.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_footer")]
        public string? CustomFooter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTemplateRequestSettings" /> class.
        /// </summary>
        /// <param name="customHeader">
        /// Specify custom HTML markup for the headerof the PDF. These properties should contain valid HTML markup, including any necessary CSS styles.
        /// </param>
        /// <param name="customFooter">
        /// Specify custom HTML markup for the footer of the PDF. These properties should contain valid HTML markup, including any necessary CSS styles.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateTemplateRequestSettings(
            string? customHeader,
            string? customFooter)
        {
            this.CustomHeader = customHeader;
            this.CustomFooter = customFooter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTemplateRequestSettings" /> class.
        /// </summary>
        public UpdateTemplateRequestSettings()
        {
        }
    }
}