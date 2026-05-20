
#nullable enable

namespace APITemplate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseSuccessListObjectsObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transaction_ref")]
        public string? TransactionRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public string? Meta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transaction_type")]
        public string? TransactionType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary_url")]
        public string? PrimaryUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secondary_url")]
        public string? SecondaryUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_at")]
        public string? DeletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletion_status")]
        public int? DeletionStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ip_address")]
        public string? IpAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSuccessListObjectsObject" /> class.
        /// </summary>
        /// <param name="transactionRef"></param>
        /// <param name="description"></param>
        /// <param name="source"></param>
        /// <param name="meta"></param>
        /// <param name="transactionType"></param>
        /// <param name="primaryUrl"></param>
        /// <param name="secondaryUrl"></param>
        /// <param name="deletedAt"></param>
        /// <param name="deletionStatus"></param>
        /// <param name="ipAddress"></param>
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseSuccessListObjectsObject(
            string? transactionRef,
            string? description,
            string? source,
            string? meta,
            string? transactionType,
            string? primaryUrl,
            string? secondaryUrl,
            string? deletedAt,
            int? deletionStatus,
            string? ipAddress,
            string? createdAt)
        {
            this.TransactionRef = transactionRef;
            this.Description = description;
            this.Source = source;
            this.Meta = meta;
            this.TransactionType = transactionType;
            this.PrimaryUrl = primaryUrl;
            this.SecondaryUrl = secondaryUrl;
            this.DeletedAt = deletedAt;
            this.DeletionStatus = deletionStatus;
            this.IpAddress = ipAddress;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSuccessListObjectsObject" /> class.
        /// </summary>
        public ResponseSuccessListObjectsObject()
        {
        }

    }
}