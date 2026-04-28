
#nullable enable

namespace APITemplate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseSuccessQueryImageTemplate
    {
        /// <summary>
        /// Status<br/>
        /// Example: success
        /// </summary>
        /// <example>success</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Width<br/>
        /// Example: 1024
        /// </summary>
        /// <example>1024</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Height<br/>
        /// Example: 1024
        /// </summary>
        /// <example>1024</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Array of layers<br/>
        /// Example: [<br/>
        /// {<br/>
        ///     "name": "text_1",<br/>
        ///     "type": "textbox",<br/>
        ///     "subtype": "textbox",<br/>
        ///     "y": 50,<br/>
        ///     "x": 50,<br/>
        ///     "width": 629.82,<br/>
        ///     "height": 406.8,<br/>
        ///     "fontSize": 120,<br/>
        ///     "fontWeight": "normal",<br/>
        ///     "fontFamily": "Anton",<br/>
        ///     "fontStyle": "normal",<br/>
        ///     "text": "Type ~something~ ::here::",<br/>
        ///     "stroke": null,<br/>
        ///     "strokeWidth": 0,<br/>
        ///     "opacity": 1,<br/>
        ///     "backgroundColor": "",<br/>
        ///     "textAlign": "left",<br/>
        ///     "splitByGrapheme": false,<br/>
        ///     "textBackgroundColor": "rgba(246, 243, 243, 0)",<br/>
        ///     "color": "#FFB029"<br/>
        /// },<br/>
        /// {<br/>
        ///     "name": "rect_1",<br/>
        ///     "type": "rect",<br/>
        ///     "subtype": "rect",<br/>
        ///     "y": 101.9,<br/>
        ///     "x": 708.82,<br/>
        ///     "width": 300,<br/>
        ///     "height": 300,<br/>
        ///     "stroke": "grey",<br/>
        ///     "strokeWidth": 3,<br/>
        ///     "opacity": 1,<br/>
        ///     "backgroundColor": "",<br/>
        ///     "color": "#BEF4FF"<br/>
        /// }<br/>
        /// ]
        /// </summary>
        /// <example>
        /// [<br/>
        /// {<br/>
        ///     "name": "text_1",<br/>
        ///     "type": "textbox",<br/>
        ///     "subtype": "textbox",<br/>
        ///     "y": 50,<br/>
        ///     "x": 50,<br/>
        ///     "width": 629.82,<br/>
        ///     "height": 406.8,<br/>
        ///     "fontSize": 120,<br/>
        ///     "fontWeight": "normal",<br/>
        ///     "fontFamily": "Anton",<br/>
        ///     "fontStyle": "normal",<br/>
        ///     "text": "Type ~something~ ::here::",<br/>
        ///     "stroke": null,<br/>
        ///     "strokeWidth": 0,<br/>
        ///     "opacity": 1,<br/>
        ///     "backgroundColor": "",<br/>
        ///     "textAlign": "left",<br/>
        ///     "splitByGrapheme": false,<br/>
        ///     "textBackgroundColor": "rgba(246, 243, 243, 0)",<br/>
        ///     "color": "#FFB029"<br/>
        /// },<br/>
        /// {<br/>
        ///     "name": "rect_1",<br/>
        ///     "type": "rect",<br/>
        ///     "subtype": "rect",<br/>
        ///     "y": 101.9,<br/>
        ///     "x": 708.82,<br/>
        ///     "width": 300,<br/>
        ///     "height": 300,<br/>
        ///     "stroke": "grey",<br/>
        ///     "strokeWidth": 3,<br/>
        ///     "opacity": 1,<br/>
        ///     "backgroundColor": "",<br/>
        ///     "color": "#BEF4FF"<br/>
        /// }<br/>
        /// ]
        /// </example>
        [global::System.Text.Json.Serialization.JsonPropertyName("layers")]
        public global::System.Collections.Generic.IList<object>? Layers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSuccessQueryImageTemplate" /> class.
        /// </summary>
        /// <param name="status">
        /// Status<br/>
        /// Example: success
        /// </param>
        /// <param name="width">
        /// Width<br/>
        /// Example: 1024
        /// </param>
        /// <param name="height">
        /// Height<br/>
        /// Example: 1024
        /// </param>
        /// <param name="layers">
        /// Array of layers<br/>
        /// Example: [<br/>
        /// {<br/>
        ///     "name": "text_1",<br/>
        ///     "type": "textbox",<br/>
        ///     "subtype": "textbox",<br/>
        ///     "y": 50,<br/>
        ///     "x": 50,<br/>
        ///     "width": 629.82,<br/>
        ///     "height": 406.8,<br/>
        ///     "fontSize": 120,<br/>
        ///     "fontWeight": "normal",<br/>
        ///     "fontFamily": "Anton",<br/>
        ///     "fontStyle": "normal",<br/>
        ///     "text": "Type ~something~ ::here::",<br/>
        ///     "stroke": null,<br/>
        ///     "strokeWidth": 0,<br/>
        ///     "opacity": 1,<br/>
        ///     "backgroundColor": "",<br/>
        ///     "textAlign": "left",<br/>
        ///     "splitByGrapheme": false,<br/>
        ///     "textBackgroundColor": "rgba(246, 243, 243, 0)",<br/>
        ///     "color": "#FFB029"<br/>
        /// },<br/>
        /// {<br/>
        ///     "name": "rect_1",<br/>
        ///     "type": "rect",<br/>
        ///     "subtype": "rect",<br/>
        ///     "y": 101.9,<br/>
        ///     "x": 708.82,<br/>
        ///     "width": 300,<br/>
        ///     "height": 300,<br/>
        ///     "stroke": "grey",<br/>
        ///     "strokeWidth": 3,<br/>
        ///     "opacity": 1,<br/>
        ///     "backgroundColor": "",<br/>
        ///     "color": "#BEF4FF"<br/>
        /// }<br/>
        /// ]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseSuccessQueryImageTemplate(
            string? status,
            int? width,
            int? height,
            global::System.Collections.Generic.IList<object>? layers)
        {
            this.Status = status;
            this.Width = width;
            this.Height = height;
            this.Layers = layers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSuccessQueryImageTemplate" /> class.
        /// </summary>
        public ResponseSuccessQueryImageTemplate()
        {
        }
    }
}