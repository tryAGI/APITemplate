
#nullable enable

namespace APITemplate
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResponseSuccessPDFFile
    {
        /// <summary>
        /// Status<br/>
        /// Example: success
        /// </summary>
        /// <example>success</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Download URL<br/>
        /// Example: https://bucket.s3.amazonaws.com/91f62769-69e4-48bf.pdf
        /// </summary>
        /// <example>https://bucket.s3.amazonaws.com/91f62769-69e4-48bf.pdf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_url")]
        public string? DownloadUrl { get; set; }

        /// <summary>
        /// Template ID<br/>
        /// Example: cd890b2b199c5c42
        /// </summary>
        /// <example>cd890b2b199c5c42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// Page count<br/>
        /// Example: 4
        /// </summary>
        /// <example>4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_pages")]
        public int? TotalPages { get; set; }

        /// <summary>
        /// Transaction reference<br/>
        /// Example: a0430897-2c94-40e1-a09b-57403d811ceb
        /// </summary>
        /// <example>a0430897-2c94-40e1-a09b-57403d811ceb</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("transaction_ref")]
        public string? TransactionRef { get; set; }

        /// <summary>
        /// Example: [{"action":"S3","name":"S3 Storage","bucket":"alphacloud-test-bucket","status":"success","file":"s3://alphacloud-test-bucket/ab2e1bf7-cefa-42c7-929f-38d92b8bf8bf.pdf"}]
        /// </summary>
        /// <example>[{"action":"S3","name":"S3 Storage","bucket":"alphacloud-test-bucket","status":"success","file":"s3://alphacloud-test-bucket/ab2e1bf7-cefa-42c7-929f-38d92b8bf8bf.pdf"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("post_actions")]
        public global::System.Collections.Generic.IList<global::APITemplate.ResponseSuccessPDFFilePostAction>? PostActions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSuccessPDFFile" /> class.
        /// </summary>
        /// <param name="status">
        /// Status<br/>
        /// Example: success
        /// </param>
        /// <param name="downloadUrl">
        /// Download URL<br/>
        /// Example: https://bucket.s3.amazonaws.com/91f62769-69e4-48bf.pdf
        /// </param>
        /// <param name="templateId">
        /// Template ID<br/>
        /// Example: cd890b2b199c5c42
        /// </param>
        /// <param name="totalPages">
        /// Page count<br/>
        /// Example: 4
        /// </param>
        /// <param name="transactionRef">
        /// Transaction reference<br/>
        /// Example: a0430897-2c94-40e1-a09b-57403d811ceb
        /// </param>
        /// <param name="postActions">
        /// Example: [{"action":"S3","name":"S3 Storage","bucket":"alphacloud-test-bucket","status":"success","file":"s3://alphacloud-test-bucket/ab2e1bf7-cefa-42c7-929f-38d92b8bf8bf.pdf"}]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseSuccessPDFFile(
            string? status,
            string? downloadUrl,
            string? templateId,
            int? totalPages,
            string? transactionRef,
            global::System.Collections.Generic.IList<global::APITemplate.ResponseSuccessPDFFilePostAction>? postActions)
        {
            this.Status = status;
            this.DownloadUrl = downloadUrl;
            this.TemplateId = templateId;
            this.TotalPages = totalPages;
            this.TransactionRef = transactionRef;
            this.PostActions = postActions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSuccessPDFFile" /> class.
        /// </summary>
        public ResponseSuccessPDFFile()
        {
        }

    }
}