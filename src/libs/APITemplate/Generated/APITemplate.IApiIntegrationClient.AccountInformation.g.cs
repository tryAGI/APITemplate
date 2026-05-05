#nullable enable

namespace APITemplate
{
    public partial interface IApiIntegrationClient
    {
        /// <summary>
        /// Query account information<br/>
        /// Query Account information
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::APITemplate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::APITemplate.ResponseSuccessAccountInformation> AccountInformationAsync(
            global::APITemplate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query account information<br/>
        /// Query Account information
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::APITemplate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::APITemplate.AutoSDKHttpResponse<global::APITemplate.ResponseSuccessAccountInformation>> AccountInformationAsResponseAsync(
            global::APITemplate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}