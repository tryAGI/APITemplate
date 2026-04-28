
#nullable enable

namespace APITemplate
{
    public partial class ApiIntegrationClient
    {

        private static readonly global::APITemplate.AutoSDKServer[] s_CreatePdfServers = new global::APITemplate.AutoSDKServer[]
        {            new global::APITemplate.AutoSDKServer(
                id: "https-rest-apitemplate-io",
                name: "rest.apitemplate.io",
                url: "https://rest.apitemplate.io/",
                description: ""),
            new global::APITemplate.AutoSDKServer(
                id: "https-rest-au-apitemplate-io",
                name: "rest-au.apitemplate.io",
                url: "https://rest-au.apitemplate.io/",
                description: ""),
            new global::APITemplate.AutoSDKServer(
                id: "https-rest-de-apitemplate-io",
                name: "rest-de.apitemplate.io",
                url: "https://rest-de.apitemplate.io/",
                description: ""),
            new global::APITemplate.AutoSDKServer(
                id: "https-rest-us-apitemplate-io",
                name: "rest-us.apitemplate.io",
                url: "https://rest-us.apitemplate.io/",
                description: ""),
        };


        private static readonly global::APITemplate.EndPointSecurityRequirement s_CreatePdfSecurityRequirement0 =
            new global::APITemplate.EndPointSecurityRequirement
            {
                Authorizations = new global::APITemplate.EndPointAuthorizationRequirement[]
                {                    new global::APITemplate.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "ApikeyXApiKey",
                        Location = "Header",
                        Name = "X-API-KEY",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::APITemplate.EndPointSecurityRequirement[] s_CreatePdfSecurityRequirements =
            new global::APITemplate.EndPointSecurityRequirement[]
            {                s_CreatePdfSecurityRequirement0,
            };
        partial void PrepareCreatePdfArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string templateId,
            ref string? exportType,
            ref string? exportInBase64,
            ref int? expiration,
            ref string? outputHtml,
            ref string? outputFormat,
            ref string? filename,
            ref string? directDownload,
            ref int? cloudStorage,
            ref string? loadDataFrom,
            ref int? extractLink,
            ref int? generationDelay,
            ref string? imageResampleRes,
            ref bool? resizeImages,
            ref int? resizeMaxWidth,
            ref int? resizeMaxHeight,
            ref string? resizeFormat,
            ref string? postactionS3Filekey,
            ref string? postactionS3Bucket,
            ref string? postactionEnabled,
            ref string? meta,
            ref string? async,
            ref string? webhookUrl,
            ref string? webhookMethod,
            ref string? webhookHeaders,
            object request);
        partial void PrepareCreatePdfRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string templateId,
            string? exportType,
            string? exportInBase64,
            int? expiration,
            string? outputHtml,
            string? outputFormat,
            string? filename,
            string? directDownload,
            int? cloudStorage,
            string? loadDataFrom,
            int? extractLink,
            int? generationDelay,
            string? imageResampleRes,
            bool? resizeImages,
            int? resizeMaxWidth,
            int? resizeMaxHeight,
            string? resizeFormat,
            string? postactionS3Filekey,
            string? postactionS3Bucket,
            string? postactionEnabled,
            string? meta,
            string? async,
            string? webhookUrl,
            string? webhookMethod,
            string? webhookHeaders,
            object request);
        partial void ProcessCreatePdfResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreatePdfResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::APITemplate.ResponseSuccessPDFFile> CreatePdfAsync(
            string templateId,

            object request,
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
            string? postactionS3Filekey = default,
            string? postactionS3Bucket = default,
            string? postactionEnabled = default,
            string? meta = default,
            string? async = default,
            string? webhookUrl = default,
            string? webhookMethod = default,
            string? webhookHeaders = default,
            global::APITemplate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreatePdfArguments(
                httpClient: HttpClient,
                templateId: ref templateId,
                exportType: ref exportType,
                exportInBase64: ref exportInBase64,
                expiration: ref expiration,
                outputHtml: ref outputHtml,
                outputFormat: ref outputFormat,
                filename: ref filename,
                directDownload: ref directDownload,
                cloudStorage: ref cloudStorage,
                loadDataFrom: ref loadDataFrom,
                extractLink: ref extractLink,
                generationDelay: ref generationDelay,
                imageResampleRes: ref imageResampleRes,
                resizeImages: ref resizeImages,
                resizeMaxWidth: ref resizeMaxWidth,
                resizeMaxHeight: ref resizeMaxHeight,
                resizeFormat: ref resizeFormat,
                postactionS3Filekey: ref postactionS3Filekey,
                postactionS3Bucket: ref postactionS3Bucket,
                postactionEnabled: ref postactionEnabled,
                meta: ref meta,
                async: ref async,
                webhookUrl: ref webhookUrl,
                webhookMethod: ref webhookMethod,
                webhookHeaders: ref webhookHeaders,
                request: request);


            var __authorizations = global::APITemplate.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreatePdfSecurityRequirements,
                operationName: "CreatePdfAsync");

            using var __timeoutCancellationTokenSource = global::APITemplate.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::APITemplate.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::APITemplate.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::APITemplate.PathBuilder(
                                path: "/v2/create-pdf",
                                baseUri: ResolveBaseUri(
                                servers: s_CreatePdfServers,
                                defaultBaseUrl: "https://rest.apitemplate.io/")); 
                            __pathBuilder
                                .AddRequiredParameter("template_id", templateId)
                                .AddOptionalParameter("export_type", exportType)
                                .AddOptionalParameter("export_in_base64", exportInBase64)
                                .AddOptionalParameter("expiration", expiration?.ToString())
                                .AddOptionalParameter("output_html", outputHtml)
                                .AddOptionalParameter("output_format", outputFormat)
                                .AddOptionalParameter("filename", filename)
                                .AddOptionalParameter("direct_download", directDownload)
                                .AddOptionalParameter("cloud_storage", cloudStorage?.ToString())
                                .AddOptionalParameter("load_data_from", loadDataFrom)
                                .AddOptionalParameter("extract_link", extractLink?.ToString())
                                .AddOptionalParameter("generation_delay", generationDelay?.ToString())
                                .AddOptionalParameter("image_resample_res", imageResampleRes)
                                .AddOptionalParameter("resize_images", resizeImages?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("resize_max_width", resizeMaxWidth?.ToString())
                                .AddOptionalParameter("resize_max_height", resizeMaxHeight?.ToString())
                                .AddOptionalParameter("resize_format", resizeFormat)
                                .AddOptionalParameter("postaction_s3_filekey", postactionS3Filekey)
                                .AddOptionalParameter("postaction_s3_bucket", postactionS3Bucket)
                                .AddOptionalParameter("postaction_enabled", postactionEnabled)
                                .AddOptionalParameter("meta", meta)
                                .AddOptionalParameter("async", async)
                                .AddOptionalParameter("webhook_url", webhookUrl)
                                .AddOptionalParameter("webhook_method", webhookMethod)
                                .AddOptionalParameter("webhook_headers", webhookHeaders) 
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::APITemplate.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }
                            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, request.GetType(), JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::APITemplate.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreatePdfRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    templateId: templateId,
                    exportType: exportType,
                    exportInBase64: exportInBase64,
                    expiration: expiration,
                    outputHtml: outputHtml,
                    outputFormat: outputFormat,
                    filename: filename,
                    directDownload: directDownload,
                    cloudStorage: cloudStorage,
                    loadDataFrom: loadDataFrom,
                    extractLink: extractLink,
                    generationDelay: generationDelay,
                    imageResampleRes: imageResampleRes,
                    resizeImages: resizeImages,
                    resizeMaxWidth: resizeMaxWidth,
                    resizeMaxHeight: resizeMaxHeight,
                    resizeFormat: resizeFormat,
                    postactionS3Filekey: postactionS3Filekey,
                    postactionS3Bucket: postactionS3Bucket,
                    postactionEnabled: postactionEnabled,
                    meta: meta,
                    async: async,
                    webhookUrl: webhookUrl,
                    webhookMethod: webhookMethod,
                    webhookHeaders: webhookHeaders,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::APITemplate.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::APITemplate.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreatePdf",
                                methodName: "CreatePdfAsync",
                                pathTemplate: "\"/v2/create-pdf\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::APITemplate.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::APITemplate.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreatePdf",
                                methodName: "CreatePdfAsync",
                                pathTemplate: "\"/v2/create-pdf\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::APITemplate.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::APITemplate.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::APITemplate.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::APITemplate.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreatePdf",
                                methodName: "CreatePdfAsync",
                                pathTemplate: "\"/v2/create-pdf\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::APITemplate.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessCreatePdfResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::APITemplate.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::APITemplate.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreatePdf",
                                methodName: "CreatePdfAsync",
                                pathTemplate: "\"/v2/create-pdf\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::APITemplate.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::APITemplate.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreatePdf",
                                methodName: "CreatePdfAsync",
                                pathTemplate: "\"/v2/create-pdf\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // unexpected error
                            if (!__response.IsSuccessStatusCode)
                            {
                                string? __content_default = null;
                                global::System.Exception? __exception_default = null;
                                global::APITemplate.Error? __value_default = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_default = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_default = global::APITemplate.Error.FromJson(__content_default, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_default = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_default = global::APITemplate.Error.FromJson(__content_default, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_default = __ex;
                                }

                                throw new global::APITemplate.ApiException<global::APITemplate.Error>(
                                    message: __content_default ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_default,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_default,
                                    ResponseObject = __value_default,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessCreatePdfResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::APITemplate.ResponseSuccessPDFFile.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw new global::APITemplate.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::APITemplate.ResponseSuccessPDFFile.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw new global::APITemplate.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
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
        /// <param name="postactionS3Filekey"></param>
        /// <param name="postactionS3Bucket"></param>
        /// <param name="postactionEnabled"></param>
        /// <param name="meta"></param>
        /// <param name="async"></param>
        /// <param name="webhookUrl"></param>
        /// <param name="webhookMethod"></param>
        /// <param name="webhookHeaders"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::APITemplate.ResponseSuccessPDFFile> CreatePdfAsync(
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
            string? postactionS3Filekey = default,
            string? postactionS3Bucket = default,
            string? postactionEnabled = default,
            string? meta = default,
            string? async = default,
            string? webhookUrl = default,
            string? webhookMethod = default,
            string? webhookHeaders = default,
            global::APITemplate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new object
            {
            };

            return await CreatePdfAsync(
                templateId: templateId,
                exportType: exportType,
                exportInBase64: exportInBase64,
                expiration: expiration,
                outputHtml: outputHtml,
                outputFormat: outputFormat,
                filename: filename,
                directDownload: directDownload,
                cloudStorage: cloudStorage,
                loadDataFrom: loadDataFrom,
                extractLink: extractLink,
                generationDelay: generationDelay,
                imageResampleRes: imageResampleRes,
                resizeImages: resizeImages,
                resizeMaxWidth: resizeMaxWidth,
                resizeMaxHeight: resizeMaxHeight,
                resizeFormat: resizeFormat,
                postactionS3Filekey: postactionS3Filekey,
                postactionS3Bucket: postactionS3Bucket,
                postactionEnabled: postactionEnabled,
                meta: meta,
                async: async,
                webhookUrl: webhookUrl,
                webhookMethod: webhookMethod,
                webhookHeaders: webhookHeaders,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}