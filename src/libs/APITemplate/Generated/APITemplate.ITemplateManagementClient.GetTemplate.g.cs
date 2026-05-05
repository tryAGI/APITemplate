#nullable enable

namespace APITemplate
{
    public partial interface ITemplateManagementClient
    {
        /// <summary>
        /// Get PDF template<br/>
        /// Retrieves information of the PDF template (**This is an experimental API, contact support to learn more**)
        /// </summary>
        /// <param name="templateId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::APITemplate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::APITemplate.ResponseSuccessTemplate> GetTemplateAsync(
            string? templateId = default,
            global::APITemplate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get PDF template<br/>
        /// Retrieves information of the PDF template (**This is an experimental API, contact support to learn more**)
        /// </summary>
        /// <param name="templateId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::APITemplate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::APITemplate.AutoSDKHttpResponse<global::APITemplate.ResponseSuccessTemplate>> GetTemplateAsResponseAsync(
            string? templateId = default,
            global::APITemplate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}