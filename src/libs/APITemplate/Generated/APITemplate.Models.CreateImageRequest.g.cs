
#nullable enable

namespace APITemplate
{
    /// <summary>
    /// JSON data<br/>
    /// - The following is the json format in the post body to generate an image<br/>
    /// ```<br/>
    /// {<br/>
    ///     "overrides": [<br/>
    ///         {<br/>
    ///             "name": "&lt;object name 1&gt;",<br/>
    ///             "property_1": "&lt;value 1&gt;",<br/>
    ///             "property_2": "&lt;value 2&gt;",<br/>
    ///             "property_3": "&lt;value 3&gt;",<br/>
    ///             ...<br/>
    ///         },<br/>
    ///         {<br/>
    ///             "name": "&lt;object name 2&gt;",<br/>
    ///             "property_2": "&lt;value 2&gt;",<br/>
    ///             ...<br/>
    ///         }<br/>
    ///     ]<br/>
    /// }<br/>
    /// ```<br/>
    /// Example: {"overrides":[{"name":"text_1","text":"hello world","textBackgroundColor":"rgba(246, 243, 243, 0)"},{"name":"image_1","src":"https://via.placeholder.com/150"}]}
    /// </summary>
    public sealed partial class CreateImageRequest
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}