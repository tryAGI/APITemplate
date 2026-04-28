
#nullable enable

namespace APITemplate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MergePdfsRequest
    {
        /// <summary>
        /// URL array. We support normal http/https URLs and data URLs<br/>
        /// - Normal URLs: URLs start with http/https, e.g: "https://fileserver.com/a1.pdf")<br/>
        /// - Data URLs: URLs prefixed with the "data:" scheme, e.g "data:application/pdf;base64,JVBERi0xLjIg...[truncated]"<br/>
        /// Example: [https://fileserver.com/a1.pdf, https://fileserver.com/b2.pdf, data:application/pdf;base64,JVBERi0xLjIg...[truncated]]
        /// </summary>
        /// <example>[https://fileserver.com/a1.pdf, https://fileserver.com/b2.pdf, data:application/pdf;base64,JVBERi0xLjIg...[truncated]]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Urls { get; set; }

        /// <summary>
        /// - Either `file` or `json`(Default).<br/>
        ///   - The option `json` returns a JSON object, and the output PDF is stored on a CDN.<br/>
        ///   - The option `file` returns binary data of the generated PDF(Secure and completely private) and the response HTTP header Content-Disposition is set to attachment. It has a file size limit of 6MB.<br/>
        /// Example: json
        /// </summary>
        /// <example>json</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("export_type")]
        public string? ExportType { get; set; }

        /// <summary>
        /// - Expiration of the generated PDF in minutes(default to `0`, store permanently)<br/>
        ///   - Use `0` to store on cdn permanently<br/>
        ///   - Or use the range between `1` minute and `43200` minutes(30 days) to specify the expiration of the generated PDF<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration")]
        public int? Expiration { get; set; }

        /// <summary>
        /// - Upload the generated PDFs/images to our storage CDN, default to `1`. If you have configured `Post Action` to upload the PDFs/Images to your own S3, please set it to `0`.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloud_storage")]
        public int? CloudStorage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MergePdfsRequest" /> class.
        /// </summary>
        /// <param name="urls">
        /// URL array. We support normal http/https URLs and data URLs<br/>
        /// - Normal URLs: URLs start with http/https, e.g: "https://fileserver.com/a1.pdf")<br/>
        /// - Data URLs: URLs prefixed with the "data:" scheme, e.g "data:application/pdf;base64,JVBERi0xLjIg...[truncated]"<br/>
        /// Example: [https://fileserver.com/a1.pdf, https://fileserver.com/b2.pdf, data:application/pdf;base64,JVBERi0xLjIg...[truncated]]
        /// </param>
        /// <param name="exportType">
        /// - Either `file` or `json`(Default).<br/>
        ///   - The option `json` returns a JSON object, and the output PDF is stored on a CDN.<br/>
        ///   - The option `file` returns binary data of the generated PDF(Secure and completely private) and the response HTTP header Content-Disposition is set to attachment. It has a file size limit of 6MB.<br/>
        /// Example: json
        /// </param>
        /// <param name="expiration">
        /// - Expiration of the generated PDF in minutes(default to `0`, store permanently)<br/>
        ///   - Use `0` to store on cdn permanently<br/>
        ///   - Or use the range between `1` minute and `43200` minutes(30 days) to specify the expiration of the generated PDF<br/>
        /// Example: 5
        /// </param>
        /// <param name="cloudStorage">
        /// - Upload the generated PDFs/images to our storage CDN, default to `1`. If you have configured `Post Action` to upload the PDFs/Images to your own S3, please set it to `0`.<br/>
        /// Example: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MergePdfsRequest(
            global::System.Collections.Generic.IList<object> urls,
            string? exportType,
            int? expiration,
            int? cloudStorage)
        {
            this.Urls = urls ?? throw new global::System.ArgumentNullException(nameof(urls));
            this.ExportType = exportType;
            this.Expiration = expiration;
            this.CloudStorage = cloudStorage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MergePdfsRequest" /> class.
        /// </summary>
        public MergePdfsRequest()
        {
        }
    }
}