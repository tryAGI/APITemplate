#nullable enable

namespace APITemplate
{
    public partial interface ITemplateManagementClient
    {
        /// <summary>
        /// Update PDF Template<br/>
        /// This endpoint updates PDF template (**This is an experimental API, contact support to learn more**)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::APITemplate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::APITemplate.ResponseSuccess> UpdateTemplateAsync(

            global::APITemplate.UpdateTemplateRequest request,
            global::APITemplate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update PDF Template<br/>
        /// This endpoint updates PDF template (**This is an experimental API, contact support to learn more**)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::APITemplate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::APITemplate.AutoSDKHttpResponse<global::APITemplate.ResponseSuccess>> UpdateTemplateAsResponseAsync(

            global::APITemplate.UpdateTemplateRequest request,
            global::APITemplate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update PDF Template<br/>
        /// This endpoint updates PDF template (**This is an experimental API, contact support to learn more**)
        /// </summary>
        /// <param name="templateId">
        /// Your template id, it can be obtained in the web console(Manage Templates)<br/>
        /// Example: 00377b2b1e0ee394
        /// </param>
        /// <param name="body">
        /// The HTML body<br/>
        /// Example: &lt;h1&gt;Title&lt;/h1&gt;
        /// </param>
        /// <param name="css">
        /// The css<br/>
        /// Example: {body{ background: white;}
        /// </param>
        /// <param name="settings">
        /// Settings of the template, the followings is an example:<br/>
        /// Example: {"custom_header":"\u003Cstyle\u003E#header, #footer { padding: 0 !important; }\u003C/style\u003E","custom_footer":"\u003Cstyle\u003E#header, #footer { padding: 0 !important; }\u003C/style\u003E"}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::APITemplate.ResponseSuccess> UpdateTemplateAsync(
            string templateId,
            string? body = default,
            string? css = default,
            global::APITemplate.UpdateTemplateRequestSettings? settings = default,
            global::APITemplate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}