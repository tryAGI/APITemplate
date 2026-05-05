#nullable enable

namespace APITemplate
{
    public partial interface ITemplateManagementClient
    {
        /// <summary>
        /// List Templates<br/>
        /// Retrieves the information of templates
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="format"></param>
        /// <param name="templateId"></param>
        /// <param name="groupName"></param>
        /// <param name="withLayerInfo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::APITemplate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::APITemplate.ResponseSuccessListTemplates> ListTemplatesAsync(
            string? limit = default,
            string? offset = default,
            string? format = default,
            string? templateId = default,
            string? groupName = default,
            string? withLayerInfo = default,
            global::APITemplate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Templates<br/>
        /// Retrieves the information of templates
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="format"></param>
        /// <param name="templateId"></param>
        /// <param name="groupName"></param>
        /// <param name="withLayerInfo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::APITemplate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::APITemplate.AutoSDKHttpResponse<global::APITemplate.ResponseSuccessListTemplates>> ListTemplatesAsResponseAsync(
            string? limit = default,
            string? offset = default,
            string? format = default,
            string? templateId = default,
            string? groupName = default,
            string? withLayerInfo = default,
            global::APITemplate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}