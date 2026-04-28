#nullable enable

namespace APITemplate
{
    public partial interface IPdfManipulationApiClient
    {
        /// <summary>
        /// Join/Merge multiple PDFs<br/>
        /// This endpoint merges/joins multiple PDF URLs into a single PDF file
        /// </summary>
        /// <param name="postactionS3Filekey"></param>
        /// <param name="postactionS3Bucket"></param>
        /// <param name="postactionEnabled"></param>
        /// <param name="meta"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::APITemplate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::APITemplate.ResponseSuccessSingleFile> MergePdfsAsync(

            global::APITemplate.MergePdfsRequest request,
            string? postactionS3Filekey = default,
            string? postactionS3Bucket = default,
            string? postactionEnabled = default,
            string? meta = default,
            global::APITemplate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Join/Merge multiple PDFs<br/>
        /// This endpoint merges/joins multiple PDF URLs into a single PDF file
        /// </summary>
        /// <param name="postactionS3Filekey"></param>
        /// <param name="postactionS3Bucket"></param>
        /// <param name="postactionEnabled"></param>
        /// <param name="meta"></param>
        /// <param name="urls">
        /// URL array. We support normal http/https URLs and data URLs<br/>
        /// - Normal URLs: URLs start with http/https, e.g: "https://fileserver.com/a1.pdf")<br/>
        /// - Data URLs: URLs prefixed with the "data:" scheme, e.g "data:application/pdf;base64,JVBERi0xLjIg...[truncated]"<br/>
        /// Example: [https://fileserver.com/a1.pdf, https://fileserver.com/b2.pdf, data:application/pdf;base64,JVBERi0xLjIg...[truncated]]
        /// </param>
        /// <param name="exportType">
        /// - Either `file` or `json`(Default).<br/>
        ///   - The option `json` returns a JSON object, and the output PDF is stored on a CDN.<br/>
        ///   - The option `file` returns binary data of the generated PDF(Secure and completely private) and the response HTTP header Content-Disposition is set to attachment. It has a file size limit of 6MB.<br/>
        /// Example: json
        /// </param>
        /// <param name="expiration">
        /// - Expiration of the generated PDF in minutes(default to `0`, store permanently)<br/>
        ///   - Use `0` to store on cdn permanently<br/>
        ///   - Or use the range between `1` minute and `43200` minutes(30 days) to specify the expiration of the generated PDF<br/>
        /// Example: 5
        /// </param>
        /// <param name="cloudStorage">
        /// - Upload the generated PDFs/images to our storage CDN, default to `1`. If you have configured `Post Action` to upload the PDFs/Images to your own S3, please set it to `0`.<br/>
        /// Example: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::APITemplate.ResponseSuccessSingleFile> MergePdfsAsync(
            global::System.Collections.Generic.IList<object> urls,
            string? postactionS3Filekey = default,
            string? postactionS3Bucket = default,
            string? postactionEnabled = default,
            string? meta = default,
            string? exportType = default,
            int? expiration = default,
            int? cloudStorage = default,
            global::APITemplate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}