
#nullable enable

namespace APITemplate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseSuccessListTemplates
    {
        /// <summary>
        /// Example: success
        /// </summary>
        /// <example>success</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Example: [{"template_id":"12577b29420496","name":"Positive Review","status":"ACTIVE","format":"JPEG","created_at":"2021-10-15T06:29:01.308Z","updated_at":"2021-10-15T13:03:43.615Z","group_name":""}, {"template_id":"004271e0ee394","name":"Test Template PDF","status":"ACTIVE","format":"PDF","created_at":"2021-10-09T09:57:52.224Z","updated_at":"2021-10-16T11:18:10.613Z","group_name":""}, {"template_id":"8bf77213e06b670","name":"New Template","status":"ACTIVE","format":"PDF","created_at":"2021-10-09T08:54:49.486Z","updated_at":"2021-10-09T09:54:44.667Z","group_name":""}]
        /// </summary>
        /// <example>[{"template_id":"12577b29420496","name":"Positive Review","status":"ACTIVE","format":"JPEG","created_at":"2021-10-15T06:29:01.308Z","updated_at":"2021-10-15T13:03:43.615Z","group_name":""}, {"template_id":"004271e0ee394","name":"Test Template PDF","status":"ACTIVE","format":"PDF","created_at":"2021-10-09T09:57:52.224Z","updated_at":"2021-10-16T11:18:10.613Z","group_name":""}, {"template_id":"8bf77213e06b670","name":"New Template","status":"ACTIVE","format":"PDF","created_at":"2021-10-09T08:54:49.486Z","updated_at":"2021-10-09T09:54:44.667Z","group_name":""}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("templates")]
        public global::System.Collections.Generic.IList<global::APITemplate.ResponseSuccessListTemplatesTemplate>? Templates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSuccessListTemplates" /> class.
        /// </summary>
        /// <param name="status">
        /// Example: success
        /// </param>
        /// <param name="templates">
        /// Example: [{"template_id":"12577b29420496","name":"Positive Review","status":"ACTIVE","format":"JPEG","created_at":"2021-10-15T06:29:01.308Z","updated_at":"2021-10-15T13:03:43.615Z","group_name":""}, {"template_id":"004271e0ee394","name":"Test Template PDF","status":"ACTIVE","format":"PDF","created_at":"2021-10-09T09:57:52.224Z","updated_at":"2021-10-16T11:18:10.613Z","group_name":""}, {"template_id":"8bf77213e06b670","name":"New Template","status":"ACTIVE","format":"PDF","created_at":"2021-10-09T08:54:49.486Z","updated_at":"2021-10-09T09:54:44.667Z","group_name":""}]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseSuccessListTemplates(
            string? status,
            global::System.Collections.Generic.IList<global::APITemplate.ResponseSuccessListTemplatesTemplate>? templates)
        {
            this.Status = status;
            this.Templates = templates;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSuccessListTemplates" /> class.
        /// </summary>
        public ResponseSuccessListTemplates()
        {
        }

    }
}