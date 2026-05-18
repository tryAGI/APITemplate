
#nullable enable

namespace APITemplate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseSuccessListObjects
    {
        /// <summary>
        /// Example: success
        /// </summary>
        /// <example>success</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Example: [{"transaction_ref":"e9c46f03-1840-44dc-bae7-f280e0be98a9","description":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","source":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","meta":"inv-23ejh23bh","transaction_type":"JPEG","primary_url":"https://pub-cdn.apitemplate.io/e9c46f03-1840-44dc-bae7-f280e0be98a9.jpeg","secondary_url":"https://pub-cdn.apitemplate.io/e9c46f03-1840-44dc-bae7-f280e0be98a9.png","deleted_at":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","deletion_status":0,"ip_address":"1.222.242.231","created_at":"2021-10-16T12:08:59.281Z"}, {"transaction_ref":"c973f544-fb56-465d-a1bd-35ff0e4b77e7","description":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","source":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","meta":"inv-45ekdjkdbh","transaction_type":"PDF","primary_url":"https://pub-cdn.apitemplate.io/2021/10/c973f544-fb56-465d-a1bd-35ff0e4b77e7.pdf","secondary_url":"","deleted_at":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","deletion_status":0,"ip_address":"1.222.242.231","created_at":"2021-10-16T12:07:34.478Z"}, {"transaction_ref":"5ee5e0aa-4431-4d17-b94a-24ac859a5e71","description":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","source":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","meta":"inv-klkjbr34ded","transaction_type":"JPEG","primary_url":"https://pub-cdn.apitemplate.io/5ee5e0aa-4431-4d17-b94a-24ac859a5e71.jpeg","secondary_url":"https://pub-cdn.apitemplate.io/5ee5e0aa-4431-4d17-b94a-24ac859a5e71.png","deleted_at":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","deletion_status":0,"ip_address":"1.222.242.231","created_at":"2021-10-16T12:05:59.111Z"}]
        /// </summary>
        /// <example>[{"transaction_ref":"e9c46f03-1840-44dc-bae7-f280e0be98a9","description":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","source":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","meta":"inv-23ejh23bh","transaction_type":"JPEG","primary_url":"https://pub-cdn.apitemplate.io/e9c46f03-1840-44dc-bae7-f280e0be98a9.jpeg","secondary_url":"https://pub-cdn.apitemplate.io/e9c46f03-1840-44dc-bae7-f280e0be98a9.png","deleted_at":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","deletion_status":0,"ip_address":"1.222.242.231","created_at":"2021-10-16T12:08:59.281Z"}, {"transaction_ref":"c973f544-fb56-465d-a1bd-35ff0e4b77e7","description":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","source":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","meta":"inv-45ekdjkdbh","transaction_type":"PDF","primary_url":"https://pub-cdn.apitemplate.io/2021/10/c973f544-fb56-465d-a1bd-35ff0e4b77e7.pdf","secondary_url":"","deleted_at":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","deletion_status":0,"ip_address":"1.222.242.231","created_at":"2021-10-16T12:07:34.478Z"}, {"transaction_ref":"5ee5e0aa-4431-4d17-b94a-24ac859a5e71","description":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","source":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","meta":"inv-klkjbr34ded","transaction_type":"JPEG","primary_url":"https://pub-cdn.apitemplate.io/5ee5e0aa-4431-4d17-b94a-24ac859a5e71.jpeg","secondary_url":"https://pub-cdn.apitemplate.io/5ee5e0aa-4431-4d17-b94a-24ac859a5e71.png","deleted_at":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","deletion_status":0,"ip_address":"1.222.242.231","created_at":"2021-10-16T12:05:59.111Z"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("objects")]
        public global::System.Collections.Generic.IList<global::APITemplate.ResponseSuccessListObjectsObject>? Objects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSuccessListObjects" /> class.
        /// </summary>
        /// <param name="status">
        /// Example: success
        /// </param>
        /// <param name="objects">
        /// Example: [{"transaction_ref":"e9c46f03-1840-44dc-bae7-f280e0be98a9","description":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","source":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","meta":"inv-23ejh23bh","transaction_type":"JPEG","primary_url":"https://pub-cdn.apitemplate.io/e9c46f03-1840-44dc-bae7-f280e0be98a9.jpeg","secondary_url":"https://pub-cdn.apitemplate.io/e9c46f03-1840-44dc-bae7-f280e0be98a9.png","deleted_at":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","deletion_status":0,"ip_address":"1.222.242.231","created_at":"2021-10-16T12:08:59.281Z"}, {"transaction_ref":"c973f544-fb56-465d-a1bd-35ff0e4b77e7","description":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","source":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","meta":"inv-45ekdjkdbh","transaction_type":"PDF","primary_url":"https://pub-cdn.apitemplate.io/2021/10/c973f544-fb56-465d-a1bd-35ff0e4b77e7.pdf","secondary_url":"","deleted_at":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","deletion_status":0,"ip_address":"1.222.242.231","created_at":"2021-10-16T12:07:34.478Z"}, {"transaction_ref":"5ee5e0aa-4431-4d17-b94a-24ac859a5e71","description":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","source":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","meta":"inv-klkjbr34ded","transaction_type":"JPEG","primary_url":"https://pub-cdn.apitemplate.io/5ee5e0aa-4431-4d17-b94a-24ac859a5e71.jpeg","secondary_url":"https://pub-cdn.apitemplate.io/5ee5e0aa-4431-4d17-b94a-24ac859a5e71.png","deleted_at":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","deletion_status":0,"ip_address":"1.222.242.231","created_at":"2021-10-16T12:05:59.111Z"}]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseSuccessListObjects(
            string? status,
            global::System.Collections.Generic.IList<global::APITemplate.ResponseSuccessListObjectsObject>? objects)
        {
            this.Status = status;
            this.Objects = objects;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSuccessListObjects" /> class.
        /// </summary>
        public ResponseSuccessListObjects()
        {
        }

    }
}