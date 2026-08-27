
#nullable enable

namespace APITemplate
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResponseSuccessListTemplatesTemplate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string? TemplateId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        public string? Format { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_name")]
        public string? GroupName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSuccessListTemplatesTemplate" /> class.
        /// </summary>
        /// <param name="templateId"></param>
        /// <param name="name"></param>
        /// <param name="status"></param>
        /// <param name="format"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="groupName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseSuccessListTemplatesTemplate(
            string? templateId,
            string? name,
            string? status,
            string? format,
            string? createdAt,
            string? updatedAt,
            string? groupName)
        {
            this.TemplateId = templateId;
            this.Name = name;
            this.Status = status;
            this.Format = format;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.GroupName = groupName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSuccessListTemplatesTemplate" /> class.
        /// </summary>
        public ResponseSuccessListTemplatesTemplate()
        {
        }

    }
}