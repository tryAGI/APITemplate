#nullable enable

namespace APITemplate
{
    public partial interface IApiIntegrationClient
    {
        /// <summary>
        /// Create an Image<br/>
        /// This endpoint creates a JPEG file(along with PNG) with JSON data and your template
        /// </summary>
        /// <param name="templateId"></param>
        /// <param name="outputImageType"></param>
        /// <param name="expiration"></param>
        /// <param name="cloudStorage"></param>
        /// <param name="generationDelay"></param>
        /// <param name="resizeImages"></param>
        /// <param name="resizeMaxWidth"></param>
        /// <param name="resizeMaxHeight"></param>
        /// <param name="resizeFormat"></param>
        /// <param name="postactionS3Filekey"></param>
        /// <param name="postactionS3Bucket"></param>
        /// <param name="postactionEnabled"></param>
        /// <param name="meta"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::APITemplate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::APITemplate.ResponseSuccessImageFile> CreateImageAsync(
            string templateId,

            object request,
            string? outputImageType = default,
            int? expiration = default,
            int? cloudStorage = default,
            int? generationDelay = default,
            bool? resizeImages = default,
            int? resizeMaxWidth = default,
            int? resizeMaxHeight = default,
            string? resizeFormat = default,
            string? postactionS3Filekey = default,
            string? postactionS3Bucket = default,
            string? postactionEnabled = default,
            string? meta = default,
            global::APITemplate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an Image<br/>
        /// This endpoint creates a JPEG file(along with PNG) with JSON data and your template
        /// </summary>
        /// <param name="templateId"></param>
        /// <param name="outputImageType"></param>
        /// <param name="expiration"></param>
        /// <param name="cloudStorage"></param>
        /// <param name="generationDelay"></param>
        /// <param name="resizeImages"></param>
        /// <param name="resizeMaxWidth"></param>
        /// <param name="resizeMaxHeight"></param>
        /// <param name="resizeFormat"></param>
        /// <param name="postactionS3Filekey"></param>
        /// <param name="postactionS3Bucket"></param>
        /// <param name="postactionEnabled"></param>
        /// <param name="meta"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::APITemplate.ResponseSuccessImageFile> CreateImageAsync(
            string templateId,
            string? outputImageType = default,
            int? expiration = default,
            int? cloudStorage = default,
            int? generationDelay = default,
            bool? resizeImages = default,
            int? resizeMaxWidth = default,
            int? resizeMaxHeight = default,
            string? resizeFormat = default,
            string? postactionS3Filekey = default,
            string? postactionS3Bucket = default,
            string? postactionEnabled = default,
            string? meta = default,
            global::APITemplate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}