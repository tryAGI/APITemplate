
#nullable enable

namespace APITemplate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateTemplateRequest
    {
        /// <summary>
        /// Your template id, it can be obtained in the web console(Manage Templates)<br/>
        /// Example: 00377b2b1e0ee394
        /// </summary>
        /// <example>00377b2b1e0ee394</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateId { get; set; }

        /// <summary>
        /// The HTML body<br/>
        /// Example: &lt;h1&gt;Title&lt;/h1&gt;
        /// </summary>
        /// <example>&lt;h1&gt;Title&lt;/h1&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// The css<br/>
        /// Example: {body{ background: white;}
        /// </summary>
        /// <example>{body{ background: white;}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("css")]
        public string? Css { get; set; }

        /// <summary>
        /// Settings of the template, the followings is an example:<br/>
        /// Example: {"custom_header":"\u003Cstyle\u003E#header, #footer { padding: 0 !important; }\u003C/style\u003E","custom_footer":"\u003Cstyle\u003E#header, #footer { padding: 0 !important; }\u003C/style\u003E"}
        /// </summary>
        /// <example>{"custom_header":"\u003Cstyle\u003E#header, #footer { padding: 0 !important; }\u003C/style\u003E","custom_footer":"\u003Cstyle\u003E#header, #footer { padding: 0 !important; }\u003C/style\u003E"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::APITemplate.UpdateTemplateRequestSettings? Settings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTemplateRequest" /> class.
        /// </summary>
        /// <param name="templateId">
        /// Your template id, it can be obtained in the web console(Manage Templates)<br/>
        /// Example: 00377b2b1e0ee394
        /// </param>
        /// <param name="body">
        /// The HTML body<br/>
        /// Example: &lt;h1&gt;Title&lt;/h1&gt;
        /// </param>
        /// <param name="css">
        /// The css<br/>
        /// Example: {body{ background: white;}
        /// </param>
        /// <param name="settings">
        /// Settings of the template, the followings is an example:<br/>
        /// Example: {"custom_header":"\u003Cstyle\u003E#header, #footer { padding: 0 !important; }\u003C/style\u003E","custom_footer":"\u003Cstyle\u003E#header, #footer { padding: 0 !important; }\u003C/style\u003E"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateTemplateRequest(
            string templateId,
            string? body,
            string? css,
            global::APITemplate.UpdateTemplateRequestSettings? settings)
        {
            this.TemplateId = templateId ?? throw new global::System.ArgumentNullException(nameof(templateId));
            this.Body = body;
            this.Css = css;
            this.Settings = settings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTemplateRequest" /> class.
        /// </summary>
        public UpdateTemplateRequest()
        {
        }
    }
}