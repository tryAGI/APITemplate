#nullable enable

namespace APITemplate
{
    public partial interface IApiIntegrationClient
    {
        /// <summary>
        /// Delete an Object<br/>
        /// Delete a PDF or an image from CDN and mark the transaction as deleted
        /// </summary>
        /// <param name="transactionRef"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::APITemplate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::APITemplate.ResponseSuccessDeleteObject> DeleteObjectAsync(
            string transactionRef,
            global::APITemplate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}