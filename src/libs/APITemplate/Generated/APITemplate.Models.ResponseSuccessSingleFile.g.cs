
#nullable enable

namespace APITemplate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseSuccessSingleFile
    {
        /// <summary>
        /// Status<br/>
        /// Example: success
        /// </summary>
        /// <example>success</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Generated PDF document<br/>
        /// Example: https://craftmypdf.com/output.pdf
        /// </summary>
        /// <example>https://craftmypdf.com/output.pdf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary_url")]
        public string? PrimaryUrl { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSuccessSingleFile" /> class.
        /// </summary>
        /// <param name="status">
        /// Status<br/>
        /// Example: success
        /// </param>
        /// <param name="primaryUrl">
        /// Generated PDF document<br/>
        /// Example: https://craftmypdf.com/output.pdf
        /// </param>
        /// <param name="totalPages">
        /// Page count<br/>
        /// Example: 4
        /// </param>
        /// <param name="transactionRef">
        /// Transaction reference<br/>
        /// Example: a0430897-2c94-40e1-a09b-57403d811ceb
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseSuccessSingleFile(
            string? status,
            string? primaryUrl,
            int? totalPages,
            string? transactionRef)
        {
            this.Status = status;
            this.PrimaryUrl = primaryUrl;
            this.TotalPages = totalPages;
            this.TransactionRef = transactionRef;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSuccessSingleFile" /> class.
        /// </summary>
        public ResponseSuccessSingleFile()
        {
        }

    }
}