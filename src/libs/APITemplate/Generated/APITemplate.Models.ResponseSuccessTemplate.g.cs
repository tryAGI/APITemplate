
#nullable enable

namespace APITemplate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseSuccessTemplate
    {
        /// <summary>
        /// Status<br/>
        /// Example: success
        /// </summary>
        /// <example>success</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Template ID<br/>
        /// Example: cd890b2b199c5c42
        /// </summary>
        /// <example>cd890b2b199c5c42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// HTML body of the template<br/>
        /// Example: &lt;h1&gt;Title&lt;/h1&gt;
        /// </summary>
        /// <example>&lt;h1&gt;Title&lt;/h1&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// CSS of the template<br/>
        /// Example: body{background: white}
        /// </summary>
        /// <example>body{background: white}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("css")]
        public string? Css { get; set; }

        /// <summary>
        /// Print settings of the template<br/>
        /// Example: {"paper_size":"A4","orientation":"1","print_background":"1","margin_top":"40","margin_bottom":"40","margin_right":"40","margin_left":"40","header_right":"{{pageNumber}}/{{totalPages}}","footer_center":"{{pageNumber}}/{{totalPages}}","header_center":"Sample Invoice","header_font_size":"11px","header_left":"{{date}}","footer_left":"{{date}}","custom_header":"","footer_font_size":"11px"}
        /// </summary>
        /// <example>{"paper_size":"A4","orientation":"1","print_background":"1","margin_top":"40","margin_bottom":"40","margin_right":"40","margin_left":"40","header_right":"{{pageNumber}}/{{totalPages}}","footer_center":"{{pageNumber}}/{{totalPages}}","header_center":"Sample Invoice","header_font_size":"11px","header_left":"{{date}}","footer_left":"{{date}}","custom_header":"","footer_font_size":"11px"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public string? Settings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSuccessTemplate" /> class.
        /// </summary>
        /// <param name="status">
        /// Status<br/>
        /// Example: success
        /// </param>
        /// <param name="templateId">
        /// Template ID<br/>
        /// Example: cd890b2b199c5c42
        /// </param>
        /// <param name="body">
        /// HTML body of the template<br/>
        /// Example: &lt;h1&gt;Title&lt;/h1&gt;
        /// </param>
        /// <param name="css">
        /// CSS of the template<br/>
        /// Example: body{background: white}
        /// </param>
        /// <param name="settings">
        /// Print settings of the template<br/>
        /// Example: {"paper_size":"A4","orientation":"1","print_background":"1","margin_top":"40","margin_bottom":"40","margin_right":"40","margin_left":"40","header_right":"{{pageNumber}}/{{totalPages}}","footer_center":"{{pageNumber}}/{{totalPages}}","header_center":"Sample Invoice","header_font_size":"11px","header_left":"{{date}}","footer_left":"{{date}}","custom_header":"","footer_font_size":"11px"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseSuccessTemplate(
            string? status,
            string? templateId,
            string? body,
            string? css,
            string? settings)
        {
            this.Status = status;
            this.TemplateId = templateId;
            this.Body = body;
            this.Css = css;
            this.Settings = settings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSuccessTemplate" /> class.
        /// </summary>
        public ResponseSuccessTemplate()
        {
        }
    }
}