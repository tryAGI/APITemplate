
#nullable enable

namespace APITemplate
{
    /// <summary>
    /// The settings object contains various properties to configure the PDF generation.<br/>
    /// Example: {"paper_size":"A4","orientation":"1","header_font_size":"9px","margin_top":"40","margin_right":"10","margin_bottom":"40","margin_left":"10","print_background":"1","displayHeaderFooter":true,"custom_header":"\u003Cstyle\u003E#header, #footer { padding: 0 !important; }\u003C/style\u003E\n\u003Ctable style=\u0022width: 100%; padding: 0px 5px;margin: 0px!important;font-size: 15px\u0022\u003E\n  \u003Ctr\u003E\n    \u003Ctd style=\u0022text-align:left; width:30%!important;\u0022\u003E\u003Cspan class=\u0022date\u0022\u003E\u003C/span\u003E\u003C/td\u003E\n    \u003Ctd style=\u0022text-align:center; width:30%!important;\u0022\u003E\u003Cspan class=\u0022pageNumber\u0022\u003E\u003C/span\u003E\u003C/td\u003E\n    \u003Ctd style=\u0022text-align:right; width:30%!important;\u0022\u003E\u003Cspan class=\u0022totalPages\u0022\u003E\u003C/span\u003E\u003C/td\u003E\n  \u003C/tr\u003E\n\u003C/table\u003E","custom_footer":"\u003Cstyle\u003E#header, #footer { padding: 0 !important; }\u003C/style\u003E\n\u003Ctable style=\u0022width: 100%; padding: 0px 5px;margin: 0px!important;font-size: 15px\u0022\u003E\n  \u003Ctr\u003E\n    \u003Ctd style=\u0022text-align:left; width:30%!important;\u0022\u003E\u003Cspan class=\u0022date\u0022\u003E\u003C/span\u003E\u003C/td\u003E\n    \u003Ctd style=\u0022text-align:center; width:30%!important;\u0022\u003E\u003Cspan class=\u0022pageNumber\u0022\u003E\u003C/span\u003E\u003C/td\u003E\n    \u003Ctd style=\u0022text-align:right; width:30%!important;\u0022\u003E\u003Cspan class=\u0022totalPages\u0022\u003E\u003C/span\u003E\u003C/td\u003E\n  \u003C/tr\u003E\n\u003C/table\u003E"}
    /// </summary>
    public sealed partial class PDFGenerationSettingsObject
    {
        /// <summary>
        /// Specifies the paper size for the PDF. The available options are Letter, Legal, Tabloid, Ledger, A0, A1, A2, A3, A4, A5,A6 or custom. custom dimensions specified as "custom_width" and "custom_height".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paper_size")]
        public string? PaperSize { get; set; }

        /// <summary>
        /// Custom width for the custom paper size. Valid units are mm, px and cm. eg: 30mm
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_width")]
        public string? CustomWidth { get; set; }

        /// <summary>
        /// Custom height for the custom paper size. Valid units are mm, px and cm. eg: 30mm
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_height")]
        public string? CustomHeight { get; set; }

        /// <summary>
        /// Specifies the orientation of the PDF. The available options are "1" for portrait and "2" for landscape.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orientation")]
        public string? Orientation { get; set; }

        /// <summary>
        /// Specifies the font size for the header in the PDF.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("header_font_size")]
        public string? HeaderFontSize { get; set; }

        /// <summary>
        /// Specify the top margin for the PDF in millimeters (mm).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("margin_top")]
        public string? MarginTop { get; set; }

        /// <summary>
        /// Specify the right margin for the PDF in millimeters (mm).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("margin_right")]
        public string? MarginRight { get; set; }

        /// <summary>
        /// Specify the bottom margin for the PDF in millimeters (mm).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("margin_bottom")]
        public string? MarginBottom { get; set; }

        /// <summary>
        /// Specify the left margin for the PDF in millimeters (mm).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("margin_left")]
        public string? MarginLeft { get; set; }

        /// <summary>
        /// Specifies whether to print the background graphics and colors in the PDF. Set to "1" to include backgrounds or "0" to exclude them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("print_background")]
        public string? PrintBackground { get; set; }

        /// <summary>
        /// Specifies whether to display the header and footer in the PDF. Set to true to include the header and footer or false to exclude them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayHeaderFooter")]
        public bool? DisplayHeaderFooter { get; set; }

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
        /// Initializes a new instance of the <see cref="PDFGenerationSettingsObject" /> class.
        /// </summary>
        /// <param name="paperSize">
        /// Specifies the paper size for the PDF. The available options are Letter, Legal, Tabloid, Ledger, A0, A1, A2, A3, A4, A5,A6 or custom. custom dimensions specified as "custom_width" and "custom_height".
        /// </param>
        /// <param name="customWidth">
        /// Custom width for the custom paper size. Valid units are mm, px and cm. eg: 30mm
        /// </param>
        /// <param name="customHeight">
        /// Custom height for the custom paper size. Valid units are mm, px and cm. eg: 30mm
        /// </param>
        /// <param name="orientation">
        /// Specifies the orientation of the PDF. The available options are "1" for portrait and "2" for landscape.
        /// </param>
        /// <param name="headerFontSize">
        /// Specifies the font size for the header in the PDF.
        /// </param>
        /// <param name="marginTop">
        /// Specify the top margin for the PDF in millimeters (mm).
        /// </param>
        /// <param name="marginRight">
        /// Specify the right margin for the PDF in millimeters (mm).
        /// </param>
        /// <param name="marginBottom">
        /// Specify the bottom margin for the PDF in millimeters (mm).
        /// </param>
        /// <param name="marginLeft">
        /// Specify the left margin for the PDF in millimeters (mm).
        /// </param>
        /// <param name="printBackground">
        /// Specifies whether to print the background graphics and colors in the PDF. Set to "1" to include backgrounds or "0" to exclude them.
        /// </param>
        /// <param name="displayHeaderFooter">
        /// Specifies whether to display the header and footer in the PDF. Set to true to include the header and footer or false to exclude them.
        /// </param>
        /// <param name="customHeader">
        /// Specify custom HTML markup for the headerof the PDF. These properties should contain valid HTML markup, including any necessary CSS styles.
        /// </param>
        /// <param name="customFooter">
        /// Specify custom HTML markup for the footer of the PDF. These properties should contain valid HTML markup, including any necessary CSS styles.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PDFGenerationSettingsObject(
            string? paperSize,
            string? customWidth,
            string? customHeight,
            string? orientation,
            string? headerFontSize,
            string? marginTop,
            string? marginRight,
            string? marginBottom,
            string? marginLeft,
            string? printBackground,
            bool? displayHeaderFooter,
            string? customHeader,
            string? customFooter)
        {
            this.PaperSize = paperSize;
            this.CustomWidth = customWidth;
            this.CustomHeight = customHeight;
            this.Orientation = orientation;
            this.HeaderFontSize = headerFontSize;
            this.MarginTop = marginTop;
            this.MarginRight = marginRight;
            this.MarginBottom = marginBottom;
            this.MarginLeft = marginLeft;
            this.PrintBackground = printBackground;
            this.DisplayHeaderFooter = displayHeaderFooter;
            this.CustomHeader = customHeader;
            this.CustomFooter = customFooter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PDFGenerationSettingsObject" /> class.
        /// </summary>
        public PDFGenerationSettingsObject()
        {
        }
    }
}