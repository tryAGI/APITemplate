
#nullable enable

namespace APITemplate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseSuccessDeleteObject
    {
        /// <summary>
        /// Example: success
        /// </summary>
        /// <example>success</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Example: 1618d386-2343-3d234-b9c7-99c82bb9f104
        /// </summary>
        /// <example>1618d386-2343-3d234-b9c7-99c82bb9f104</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("transaction_ref")]
        public object? TransactionRef { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSuccessDeleteObject" /> class.
        /// </summary>
        /// <param name="status">
        /// Example: success
        /// </param>
        /// <param name="transactionRef">
        /// Example: 1618d386-2343-3d234-b9c7-99c82bb9f104
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseSuccessDeleteObject(
            string? status,
            object? transactionRef)
        {
            this.Status = status;
            this.TransactionRef = transactionRef;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSuccessDeleteObject" /> class.
        /// </summary>
        public ResponseSuccessDeleteObject()
        {
        }

    }
}