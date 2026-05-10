
#nullable enable

namespace APITemplate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePdfFromHtmlRequest
    {
        /// <summary>
        /// The HTML body content for the PDF. This property supports HTML markup and can include Jinja2 syntax (e.g {{name}}). The value of {{name}} will be replaced with the actual value provided in the data object.<br/>
        /// Example: &lt;h1&gt; hello world {{name}} &lt;/h1&gt;
        /// </summary>
        /// <example>&lt;h1&gt; hello world {{name}} &lt;/h1&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// The CSS styles to be applied to the PDF. This property should contain valid CSS markup and should also include the style tag.<br/>
        /// Example: &lt;style&gt;.bg{background: red};&lt;/style&gt;
        /// </summary>
        /// <example>&lt;style&gt;.bg{background: red};&lt;/style&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("css")]
        public string? Css { get; set; }

        /// <summary>
        /// The data object containing values for dynamic content in the HTML body. This object should include properties with corresponding values.<br/>
        /// Example: {"name":"This is a title"}
        /// </summary>
        /// <example>{"name":"This is a title"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// The settings object contains various properties to configure the PDF generation.<br/>
        /// Example: {"paper_size":"A4","orientation":"1","header_font_size":"9px","margin_top":"40","margin_right":"10","margin_bottom":"40","margin_left":"10","print_background":"1","displayHeaderFooter":true,"custom_header":"\u003Cstyle\u003E#header, #footer { padding: 0 !important; }\u003C/style\u003E\n\u003Ctable style=\u0022width: 100%; padding: 0px 5px;margin: 0px!important;font-size: 15px\u0022\u003E\n  \u003Ctr\u003E\n    \u003Ctd style=\u0022text-align:left; width:30%!important;\u0022\u003E\u003Cspan class=\u0022date\u0022\u003E\u003C/span\u003E\u003C/td\u003E\n    \u003Ctd style=\u0022text-align:center; width:30%!important;\u0022\u003E\u003Cspan class=\u0022pageNumber\u0022\u003E\u003C/span\u003E\u003C/td\u003E\n    \u003Ctd style=\u0022text-align:right; width:30%!important;\u0022\u003E\u003Cspan class=\u0022totalPages\u0022\u003E\u003C/span\u003E\u003C/td\u003E\n  \u003C/tr\u003E\n\u003C/table\u003E","custom_footer":"\u003Cstyle\u003E#header, #footer { padding: 0 !important; }\u003C/style\u003E\n\u003Ctable style=\u0022width: 100%; padding: 0px 5px;margin: 0px!important;font-size: 15px\u0022\u003E\n  \u003Ctr\u003E\n    \u003Ctd style=\u0022text-align:left; width:30%!important;\u0022\u003E\u003Cspan class=\u0022date\u0022\u003E\u003C/span\u003E\u003C/td\u003E\n    \u003Ctd style=\u0022text-align:center; width:30%!important;\u0022\u003E\u003Cspan class=\u0022pageNumber\u0022\u003E\u003C/span\u003E\u003C/td\u003E\n    \u003Ctd style=\u0022text-align:right; width:30%!important;\u0022\u003E\u003Cspan class=\u0022totalPages\u0022\u003E\u003C/span\u003E\u003C/td\u003E\n  \u003C/tr\u003E\n\u003C/table\u003E"}
        /// </summary>
        /// <example>{"paper_size":"A4","orientation":"1","header_font_size":"9px","margin_top":"40","margin_right":"10","margin_bottom":"40","margin_left":"10","print_background":"1","displayHeaderFooter":true,"custom_header":"\u003Cstyle\u003E#header, #footer { padding: 0 !important; }\u003C/style\u003E\n\u003Ctable style=\u0022width: 100%; padding: 0px 5px;margin: 0px!important;font-size: 15px\u0022\u003E\n  \u003Ctr\u003E\n    \u003Ctd style=\u0022text-align:left; width:30%!important;\u0022\u003E\u003Cspan class=\u0022date\u0022\u003E\u003C/span\u003E\u003C/td\u003E\n    \u003Ctd style=\u0022text-align:center; width:30%!important;\u0022\u003E\u003Cspan class=\u0022pageNumber\u0022\u003E\u003C/span\u003E\u003C/td\u003E\n    \u003Ctd style=\u0022text-align:right; width:30%!important;\u0022\u003E\u003Cspan class=\u0022totalPages\u0022\u003E\u003C/span\u003E\u003C/td\u003E\n  \u003C/tr\u003E\n\u003C/table\u003E","custom_footer":"\u003Cstyle\u003E#header, #footer { padding: 0 !important; }\u003C/style\u003E\n\u003Ctable style=\u0022width: 100%; padding: 0px 5px;margin: 0px!important;font-size: 15px\u0022\u003E\n  \u003Ctr\u003E\n    \u003Ctd style=\u0022text-align:left; width:30%!important;\u0022\u003E\u003Cspan class=\u0022date\u0022\u003E\u003C/span\u003E\u003C/td\u003E\n    \u003Ctd style=\u0022text-align:center; width:30%!important;\u0022\u003E\u003Cspan class=\u0022pageNumber\u0022\u003E\u003C/span\u003E\u003C/td\u003E\n    \u003Ctd style=\u0022text-align:right; width:30%!important;\u0022\u003E\u003Cspan class=\u0022totalPages\u0022\u003E\u003C/span\u003E\u003C/td\u003E\n  \u003C/tr\u003E\n\u003C/table\u003E"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::APITemplate.PDFGenerationSettingsObject? Settings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePdfFromHtmlRequest" /> class.
        /// </summary>
        /// <param name="body">
        /// The HTML body content for the PDF. This property supports HTML markup and can include Jinja2 syntax (e.g {{name}}). The value of {{name}} will be replaced with the actual value provided in the data object.<br/>
        /// Example: &lt;h1&gt; hello world {{name}} &lt;/h1&gt;
        /// </param>
        /// <param name="css">
        /// The CSS styles to be applied to the PDF. This property should contain valid CSS markup and should also include the style tag.<br/>
        /// Example: &lt;style&gt;.bg{background: red};&lt;/style&gt;
        /// </param>
        /// <param name="data">
        /// The data object containing values for dynamic content in the HTML body. This object should include properties with corresponding values.<br/>
        /// Example: {"name":"This is a title"}
        /// </param>
        /// <param name="settings">
        /// The settings object contains various properties to configure the PDF generation.<br/>
        /// Example: {"paper_size":"A4","orientation":"1","header_font_size":"9px","margin_top":"40","margin_right":"10","margin_bottom":"40","margin_left":"10","print_background":"1","displayHeaderFooter":true,"custom_header":"\u003Cstyle\u003E#header, #footer { padding: 0 !important; }\u003C/style\u003E\n\u003Ctable style=\u0022width: 100%; padding: 0px 5px;margin: 0px!important;font-size: 15px\u0022\u003E\n  \u003Ctr\u003E\n    \u003Ctd style=\u0022text-align:left; width:30%!important;\u0022\u003E\u003Cspan class=\u0022date\u0022\u003E\u003C/span\u003E\u003C/td\u003E\n    \u003Ctd style=\u0022text-align:center; width:30%!important;\u0022\u003E\u003Cspan class=\u0022pageNumber\u0022\u003E\u003C/span\u003E\u003C/td\u003E\n    \u003Ctd style=\u0022text-align:right; width:30%!important;\u0022\u003E\u003Cspan class=\u0022totalPages\u0022\u003E\u003C/span\u003E\u003C/td\u003E\n  \u003C/tr\u003E\n\u003C/table\u003E","custom_footer":"\u003Cstyle\u003E#header, #footer { padding: 0 !important; }\u003C/style\u003E\n\u003Ctable style=\u0022width: 100%; padding: 0px 5px;margin: 0px!important;font-size: 15px\u0022\u003E\n  \u003Ctr\u003E\n    \u003Ctd style=\u0022text-align:left; width:30%!important;\u0022\u003E\u003Cspan class=\u0022date\u0022\u003E\u003C/span\u003E\u003C/td\u003E\n    \u003Ctd style=\u0022text-align:center; width:30%!important;\u0022\u003E\u003Cspan class=\u0022pageNumber\u0022\u003E\u003C/span\u003E\u003C/td\u003E\n    \u003Ctd style=\u0022text-align:right; width:30%!important;\u0022\u003E\u003Cspan class=\u0022totalPages\u0022\u003E\u003C/span\u003E\u003C/td\u003E\n  \u003C/tr\u003E\n\u003C/table\u003E"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePdfFromHtmlRequest(
            string? body,
            string? css,
            object? data,
            global::APITemplate.PDFGenerationSettingsObject? settings)
        {
            this.Body = body;
            this.Css = css;
            this.Data = data;
            this.Settings = settings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePdfFromHtmlRequest" /> class.
        /// </summary>
        public CreatePdfFromHtmlRequest()
        {
        }

    }
}