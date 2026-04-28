
#nullable enable

namespace APITemplate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseSuccessImageFile
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
        /// Example: https://bucket.s3.amazonaws.com/91f62769-69e4-48bf.jpeg
        /// </summary>
        /// <example>https://bucket.s3.amazonaws.com/91f62769-69e4-48bf.jpeg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_url")]
        public string? DownloadUrl { get; set; }

        /// <summary>
        /// Download URL PNG<br/>
        /// Example: https://bucket.s3.amazonaws.com/91f62769-69e4-48bf.png
        /// </summary>
        /// <example>https://bucket.s3.amazonaws.com/91f62769-69e4-48bf.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_url_png")]
        public string? DownloadUrlPng { get; set; }

        /// <summary>
        /// Template ID<br/>
        /// Example: cd890b2b199c5c42
        /// </summary>
        /// <example>cd890b2b199c5c42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// Transaction reference<br/>
        /// Example: a0430897-2c94-40e1-a09b-57403d811ceb
        /// </summary>
        /// <example>a0430897-2c94-40e1-a09b-57403d811ceb</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("transaction_ref")]
        public string? TransactionRef { get; set; }

        /// <summary>
        /// Example: [{"action":"S3","name":"S3 Storage","bucket":"alphacloud-test-bucket","status":"success","file":"s3://alphacloud-test-bucket/91f62769-69e4-48bf.png"}, {"action":"S3","name":"S3 Storage","bucket":"alphacloud-test-bucket","status":"success","file":"s3://alphacloud-test-bucket/91f62769-69e4-48bf.jpg"}]
        /// </summary>
        /// <example>[{"action":"S3","name":"S3 Storage","bucket":"alphacloud-test-bucket","status":"success","file":"s3://alphacloud-test-bucket/91f62769-69e4-48bf.png"}, {"action":"S3","name":"S3 Storage","bucket":"alphacloud-test-bucket","status":"success","file":"s3://alphacloud-test-bucket/91f62769-69e4-48bf.jpg"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("post_actions")]
        public global::System.Collections.Generic.IList<global::APITemplate.ResponseSuccessImageFilePostAction>? PostActions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSuccessImageFile" /> class.
        /// </summary>
        /// <param name="status">
        /// Status<br/>
        /// Example: success
        /// </param>
        /// <param name="downloadUrl">
        /// Download URL<br/>
        /// Example: https://bucket.s3.amazonaws.com/91f62769-69e4-48bf.jpeg
        /// </param>
        /// <param name="downloadUrlPng">
        /// Download URL PNG<br/>
        /// Example: https://bucket.s3.amazonaws.com/91f62769-69e4-48bf.png
        /// </param>
        /// <param name="templateId">
        /// Template ID<br/>
        /// Example: cd890b2b199c5c42
        /// </param>
        /// <param name="transactionRef">
        /// Transaction reference<br/>
        /// Example: a0430897-2c94-40e1-a09b-57403d811ceb
        /// </param>
        /// <param name="postActions">
        /// Example: [{"action":"S3","name":"S3 Storage","bucket":"alphacloud-test-bucket","status":"success","file":"s3://alphacloud-test-bucket/91f62769-69e4-48bf.png"}, {"action":"S3","name":"S3 Storage","bucket":"alphacloud-test-bucket","status":"success","file":"s3://alphacloud-test-bucket/91f62769-69e4-48bf.jpg"}]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseSuccessImageFile(
            string? status,
            string? downloadUrl,
            string? downloadUrlPng,
            string? templateId,
            string? transactionRef,
            global::System.Collections.Generic.IList<global::APITemplate.ResponseSuccessImageFilePostAction>? postActions)
        {
            this.Status = status;
            this.DownloadUrl = downloadUrl;
            this.DownloadUrlPng = downloadUrlPng;
            this.TemplateId = templateId;
            this.TransactionRef = transactionRef;
            this.PostActions = postActions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSuccessImageFile" /> class.
        /// </summary>
        public ResponseSuccessImageFile()
        {
        }
    }
}