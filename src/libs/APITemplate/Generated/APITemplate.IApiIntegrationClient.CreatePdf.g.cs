#nullable enable

namespace APITemplate
{
    public partial interface IApiIntegrationClient
    {
        /// <summary>
        /// Create a PDF<br/>
        /// This endpoint creates a PDF file with JSON data and your template. We support synchoronus and asynchronous PDF generation.
        /// </summary>
        /// <param name="templateId"></param>
        /// <param name="exportType"></param>
        /// <param name="exportInBase64"></param>
        /// <param name="expiration"></param>
        /// <param name="outputHtml"></param>
        /// <param name="outputFormat"></param>
        /// <param name="filename"></param>
        /// <param name="directDownload"></param>
        /// <param name="cloudStorage"></param>
        /// <param name="loadDataFrom"></param>
        /// <param name="extractLink"></param>
        /// <param name="generationDelay"></param>
        /// <param name="imageResampleRes"></param>
        /// <param name="resizeImages"></param>
        /// <param name="resizeMaxWidth"></param>
        /// <param name="resizeMaxHeight"></param>
        /// <param name="resizeFormat"></param>
        /// <param name="einvoice"></param>
        /// <param name="einvoiceFormat"></param>
        /// <param name="einvoiceProfile"></param>
        /// <param name="einvoiceVersion"></param>
        /// <param name="einvoiceValidate"></param>
        /// <param name="postactionS3Filekey"></param>
        /// <param name="postactionS3Bucket"></param>
        /// <param name="postactionEnabled"></param>
        /// <param name="meta"></param>
        /// <param name="async"></param>
        /// <param name="webhookUrl"></param>
        /// <param name="webhookMethod"></param>
        /// <param name="webhookHeaders"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::APITemplate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::APITemplate.ResponseSuccessCreatePDF> CreatePdfAsync(
            string templateId,

            global::APITemplate.CreatePdfRequest request,
            string? exportType = default,
            string? exportInBase64 = default,
            int? expiration = default,
            string? outputHtml = default,
            string? outputFormat = default,
            string? filename = default,
            string? directDownload = default,
            int? cloudStorage = default,
            string? loadDataFrom = default,
            int? extractLink = default,
            int? generationDelay = default,
            string? imageResampleRes = default,
            bool? resizeImages = default,
            int? resizeMaxWidth = default,
            int? resizeMaxHeight = default,
            string? resizeFormat = default,
            bool? einvoice = default,
            global::APITemplate.CreatePdfEinvoiceFormat? einvoiceFormat = default,
            global::APITemplate.CreatePdfEinvoiceProfile? einvoiceProfile = default,
            int? einvoiceVersion = default,
            bool? einvoiceValidate = default,
            string? postactionS3Filekey = default,
            string? postactionS3Bucket = default,
            string? postactionEnabled = default,
            string? meta = default,
            string? async = default,
            string? webhookUrl = default,
            string? webhookMethod = default,
            string? webhookHeaders = default,
            global::APITemplate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a PDF<br/>
        /// This endpoint creates a PDF file with JSON data and your template. We support synchoronus and asynchronous PDF generation.
        /// </summary>
        /// <param name="templateId"></param>
        /// <param name="exportType"></param>
        /// <param name="exportInBase64"></param>
        /// <param name="expiration"></param>
        /// <param name="outputHtml"></param>
        /// <param name="outputFormat"></param>
        /// <param name="filename"></param>
        /// <param name="directDownload"></param>
        /// <param name="cloudStorage"></param>
        /// <param name="loadDataFrom"></param>
        /// <param name="extractLink"></param>
        /// <param name="generationDelay"></param>
        /// <param name="imageResampleRes"></param>
        /// <param name="resizeImages"></param>
        /// <param name="resizeMaxWidth"></param>
        /// <param name="resizeMaxHeight"></param>
        /// <param name="resizeFormat"></param>
        /// <param name="einvoice"></param>
        /// <param name="einvoiceFormat"></param>
        /// <param name="einvoiceProfile"></param>
        /// <param name="einvoiceVersion"></param>
        /// <param name="einvoiceValidate"></param>
        /// <param name="postactionS3Filekey"></param>
        /// <param name="postactionS3Bucket"></param>
        /// <param name="postactionEnabled"></param>
        /// <param name="meta"></param>
        /// <param name="async"></param>
        /// <param name="webhookUrl"></param>
        /// <param name="webhookMethod"></param>
        /// <param name="webhookHeaders"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::APITemplate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::APITemplate.AutoSDKHttpResponse<global::APITemplate.ResponseSuccessCreatePDF>> CreatePdfAsResponseAsync(
            string templateId,

            global::APITemplate.CreatePdfRequest request,
            string? exportType = default,
            string? exportInBase64 = default,
            int? expiration = default,
            string? outputHtml = default,
            string? outputFormat = default,
            string? filename = default,
            string? directDownload = default,
            int? cloudStorage = default,
            string? loadDataFrom = default,
            int? extractLink = default,
            int? generationDelay = default,
            string? imageResampleRes = default,
            bool? resizeImages = default,
            int? resizeMaxWidth = default,
            int? resizeMaxHeight = default,
            string? resizeFormat = default,
            bool? einvoice = default,
            global::APITemplate.CreatePdfEinvoiceFormat? einvoiceFormat = default,
            global::APITemplate.CreatePdfEinvoiceProfile? einvoiceProfile = default,
            int? einvoiceVersion = default,
            bool? einvoiceValidate = default,
            string? postactionS3Filekey = default,
            string? postactionS3Bucket = default,
            string? postactionEnabled = default,
            string? meta = default,
            string? async = default,
            string? webhookUrl = default,
            string? webhookMethod = default,
            string? webhookHeaders = default,
            global::APITemplate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a PDF<br/>
        /// This endpoint creates a PDF file with JSON data and your template. We support synchoronus and asynchronous PDF generation.
        /// </summary>
        /// <param name="templateId"></param>
        /// <param name="exportType"></param>
        /// <param name="exportInBase64"></param>
        /// <param name="expiration"></param>
        /// <param name="outputHtml"></param>
        /// <param name="outputFormat"></param>
        /// <param name="filename"></param>
        /// <param name="directDownload"></param>
        /// <param name="cloudStorage"></param>
        /// <param name="loadDataFrom"></param>
        /// <param name="extractLink"></param>
        /// <param name="generationDelay"></param>
        /// <param name="imageResampleRes"></param>
        /// <param name="resizeImages"></param>
        /// <param name="resizeMaxWidth"></param>
        /// <param name="resizeMaxHeight"></param>
        /// <param name="resizeFormat"></param>
        /// <param name="einvoice"></param>
        /// <param name="einvoiceFormat"></param>
        /// <param name="einvoiceProfile"></param>
        /// <param name="einvoiceVersion"></param>
        /// <param name="einvoiceValidate"></param>
        /// <param name="postactionS3Filekey"></param>
        /// <param name="postactionS3Bucket"></param>
        /// <param name="postactionEnabled"></param>
        /// <param name="meta"></param>
        /// <param name="async"></param>
        /// <param name="webhookUrl"></param>
        /// <param name="webhookMethod"></param>
        /// <param name="webhookHeaders"></param>
        /// <param name="einvoiceXml">
        /// Reserved key. The ZUGFeRD/Factur-X invoice XML to embed, as a string. It must use the UN/CEFACT CII syntax with the root element `rsm:CrossIndustryInvoice` (`rsm:CrossIndustryDocument` for ZUGFeRD 1); UBL is not supported. It must not contain a DOCTYPE declaration. Required when `einvoice=true`; never passed to the template.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::APITemplate.ResponseSuccessCreatePDF> CreatePdfAsync(
            string templateId,
            string? exportType = default,
            string? exportInBase64 = default,
            int? expiration = default,
            string? outputHtml = default,
            string? outputFormat = default,
            string? filename = default,
            string? directDownload = default,
            int? cloudStorage = default,
            string? loadDataFrom = default,
            int? extractLink = default,
            int? generationDelay = default,
            string? imageResampleRes = default,
            bool? resizeImages = default,
            int? resizeMaxWidth = default,
            int? resizeMaxHeight = default,
            string? resizeFormat = default,
            bool? einvoice = default,
            global::APITemplate.CreatePdfEinvoiceFormat? einvoiceFormat = default,
            global::APITemplate.CreatePdfEinvoiceProfile? einvoiceProfile = default,
            int? einvoiceVersion = default,
            bool? einvoiceValidate = default,
            string? postactionS3Filekey = default,
            string? postactionS3Bucket = default,
            string? postactionEnabled = default,
            string? meta = default,
            string? async = default,
            string? webhookUrl = default,
            string? webhookMethod = default,
            string? webhookHeaders = default,
            string? einvoiceXml = default,
            global::APITemplate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}