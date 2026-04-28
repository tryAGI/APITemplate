
#nullable enable

namespace APITemplate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Error
    {
        /// <summary>
        /// Value of the status: error<br/>
        /// Example: error
        /// </summary>
        /// <example>error</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Error message<br/>
        /// Example: This is an error message
        /// </summary>
        /// <example>This is an error message</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        /// <param name="status">
        /// Value of the status: error<br/>
        /// Example: error
        /// </param>
        /// <param name="message">
        /// Error message<br/>
        /// Example: This is an error message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Error(
            string status,
            string message)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        public Error()
        {
        }
    }
}