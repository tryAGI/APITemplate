#nullable enable

namespace APITemplate
{
    public partial interface IApiIntegrationClient
    {
        /// <summary>
        /// Create a PDF from URL<br/>
        /// - This endpoint creates a PDF file from a URL
        /// </summary>
        /// <param name="exportType"></param>
        /// <param name="expiration"></param>
        /// <param name="outputFormat"></param>
        /// <param name="filename"></param>
        /// <param name="directDownload"></param>
        /// <param name="cloudStorage"></param>
        /// <param name="generationDelay"></param>
        /// <param name="imageResampleRes"></param>
        /// <param name="resizeImages"></param>
        /// <param name="resizeMaxWidth"></param>
        /// <param name="resizeMaxHeight"></param>
        /// <param name="resizeFormat"></param>
        /// <param name="postactionS3Filekey"></param>
        /// <param name="postactionS3Bucket"></param>
        /// <param name="postactionEnabled"></param>
        /// <param name="meta"></param>
        /// <param name="async"></param>
        /// <param name="webhookUrl"></param>
        /// <param name="webhookMethod"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::APITemplate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::APITemplate.ResponseSuccessPDFFile> CreatePdfFromUrlAsync(

            global::APITemplate.CreatePdfFromUrlRequest request,
            string? exportType = default,
            int? expiration = default,
            string? outputFormat = default,
            string? filename = default,
            string? directDownload = default,
            int? cloudStorage = default,
            int? generationDelay = default,
            string? imageResampleRes = default,
            int? resizeImages = default,
            int? resizeMaxWidth = default,
            int? resizeMaxHeight = default,
            string? resizeFormat = default,
            string? postactionS3Filekey = default,
            string? postactionS3Bucket = default,
            string? postactionEnabled = default,
            string? meta = default,
            string? async = default,
            string? webhookUrl = default,
            string? webhookMethod = default,
            global::APITemplate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a PDF from URL<br/>
        /// - This endpoint creates a PDF file from a URL
        /// </summary>
        /// <param name="exportType"></param>
        /// <param name="expiration"></param>
        /// <param name="outputFormat"></param>
        /// <param name="filename"></param>
        /// <param name="directDownload"></param>
        /// <param name="cloudStorage"></param>
        /// <param name="generationDelay"></param>
        /// <param name="imageResampleRes"></param>
        /// <param name="resizeImages"></param>
        /// <param name="resizeMaxWidth"></param>
        /// <param name="resizeMaxHeight"></param>
        /// <param name="resizeFormat"></param>
        /// <param name="postactionS3Filekey"></param>
        /// <param name="postactionS3Bucket"></param>
        /// <param name="postactionEnabled"></param>
        /// <param name="meta"></param>
        /// <param name="async"></param>
        /// <param name="webhookUrl"></param>
        /// <param name="webhookMethod"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::APITemplate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::APITemplate.AutoSDKHttpResponse<global::APITemplate.ResponseSuccessPDFFile>> CreatePdfFromUrlAsResponseAsync(

            global::APITemplate.CreatePdfFromUrlRequest request,
            string? exportType = default,
            int? expiration = default,
            string? outputFormat = default,
            string? filename = default,
            string? directDownload = default,
            int? cloudStorage = default,
            int? generationDelay = default,
            string? imageResampleRes = default,
            int? resizeImages = default,
            int? resizeMaxWidth = default,
            int? resizeMaxHeight = default,
            string? resizeFormat = default,
            string? postactionS3Filekey = default,
            string? postactionS3Bucket = default,
            string? postactionEnabled = default,
            string? meta = default,
            string? async = default,
            string? webhookUrl = default,
            string? webhookMethod = default,
            global::APITemplate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a PDF from URL<br/>
        /// - This endpoint creates a PDF file from a URL
        /// </summary>
        /// <param name="exportType"></param>
        /// <param name="expiration"></param>
        /// <param name="outputFormat"></param>
        /// <param name="filename"></param>
        /// <param name="directDownload"></param>
        /// <param name="cloudStorage"></param>
        /// <param name="generationDelay"></param>
        /// <param name="imageResampleRes"></param>
        /// <param name="resizeImages"></param>
        /// <param name="resizeMaxWidth"></param>
        /// <param name="resizeMaxHeight"></param>
        /// <param name="resizeFormat"></param>
        /// <param name="postactionS3Filekey"></param>
        /// <param name="postactionS3Bucket"></param>
        /// <param name="postactionEnabled"></param>
        /// <param name="meta"></param>
        /// <param name="async"></param>
        /// <param name="webhookUrl"></param>
        /// <param name="webhookMethod"></param>
        /// <param name="url">
        /// The URL<br/>
        /// Example: https://en.wikipedia.org/wiki/Sceloporus_malachiticus
        /// </param>
        /// <param name="settings">
        /// The settings object contains various properties to configure the PDF generation.<br/>
        /// Example: {"paper_size":"A4","orientation":"1","header_font_size":"9px","margin_top":"40","margin_right":"10","margin_bottom":"40","margin_left":"10","print_background":"1","displayHeaderFooter":true,"custom_header":"\u003Cstyle\u003E#header, #footer { padding: 0 !important; }\u003C/style\u003E\n\u003Ctable style=\u0022width: 100%; padding: 0px 5px;margin: 0px!important;font-size: 15px\u0022\u003E\n  \u003Ctr\u003E\n    \u003Ctd style=\u0022text-align:left; width:30%!important;\u0022\u003E\u003Cspan class=\u0022date\u0022\u003E\u003C/span\u003E\u003C/td\u003E\n    \u003Ctd style=\u0022text-align:center; width:30%!important;\u0022\u003E\u003Cspan class=\u0022pageNumber\u0022\u003E\u003C/span\u003E\u003C/td\u003E\n    \u003Ctd style=\u0022text-align:right; width:30%!important;\u0022\u003E\u003Cspan class=\u0022totalPages\u0022\u003E\u003C/span\u003E\u003C/td\u003E\n  \u003C/tr\u003E\n\u003C/table\u003E","custom_footer":"\u003Cstyle\u003E#header, #footer { padding: 0 !important; }\u003C/style\u003E\n\u003Ctable style=\u0022width: 100%; padding: 0px 5px;margin: 0px!important;font-size: 15px\u0022\u003E\n  \u003Ctr\u003E\n    \u003Ctd style=\u0022text-align:left; width:30%!important;\u0022\u003E\u003Cspan class=\u0022date\u0022\u003E\u003C/span\u003E\u003C/td\u003E\n    \u003Ctd style=\u0022text-align:center; width:30%!important;\u0022\u003E\u003Cspan class=\u0022pageNumber\u0022\u003E\u003C/span\u003E\u003C/td\u003E\n    \u003Ctd style=\u0022text-align:right; width:30%!important;\u0022\u003E\u003Cspan class=\u0022totalPages\u0022\u003E\u003C/span\u003E\u003C/td\u003E\n  \u003C/tr\u003E\n\u003C/table\u003E"}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::APITemplate.ResponseSuccessPDFFile> CreatePdfFromUrlAsync(
            string? exportType = default,
            int? expiration = default,
            string? outputFormat = default,
            string? filename = default,
            string? directDownload = default,
            int? cloudStorage = default,
            int? generationDelay = default,
            string? imageResampleRes = default,
            int? resizeImages = default,
            int? resizeMaxWidth = default,
            int? resizeMaxHeight = default,
            string? resizeFormat = default,
            string? postactionS3Filekey = default,
            string? postactionS3Bucket = default,
            string? postactionEnabled = default,
            string? meta = default,
            string? async = default,
            string? webhookUrl = default,
            string? webhookMethod = default,
            string? url = default,
            global::APITemplate.PDFGenerationSettingsObject? settings = default,
            global::APITemplate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}