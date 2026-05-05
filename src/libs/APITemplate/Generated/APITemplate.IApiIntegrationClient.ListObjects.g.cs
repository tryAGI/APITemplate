#nullable enable

namespace APITemplate
{
    public partial interface IApiIntegrationClient
    {
        /// <summary>
        /// List Generated Objects<br/>
        /// Retrieves all the generated PDFs and images
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="templateId"></param>
        /// <param name="transactionType"></param>
        /// <param name="transactionRef"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::APITemplate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::APITemplate.ResponseSuccessListObjects> ListObjectsAsync(
            string? limit = default,
            string? offset = default,
            string? templateId = default,
            string? transactionType = default,
            string? transactionRef = default,
            global::APITemplate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Generated Objects<br/>
        /// Retrieves all the generated PDFs and images
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="templateId"></param>
        /// <param name="transactionType"></param>
        /// <param name="transactionRef"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::APITemplate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::APITemplate.AutoSDKHttpResponse<global::APITemplate.ResponseSuccessListObjects>> ListObjectsAsResponseAsync(
            string? limit = default,
            string? offset = default,
            string? templateId = default,
            string? transactionType = default,
            string? transactionRef = default,
            global::APITemplate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}