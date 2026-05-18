
#nullable enable

namespace APITemplate
{
    public partial class ApiIntegrationClient
    {

        private static readonly global::APITemplate.AutoSDKServer[] s_CreatePdfFromUrlServers = new global::APITemplate.AutoSDKServer[]
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


        private static readonly global::APITemplate.EndPointSecurityRequirement s_CreatePdfFromUrlSecurityRequirement0 =
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
        private static readonly global::APITemplate.EndPointSecurityRequirement[] s_CreatePdfFromUrlSecurityRequirements =
            new global::APITemplate.EndPointSecurityRequirement[]
            {                s_CreatePdfFromUrlSecurityRequirement0,
            };
        partial void PrepareCreatePdfFromUrlArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? exportType,
            ref int? expiration,
            ref string? outputFormat,
            ref string? filename,
            ref string? directDownload,
            ref int? cloudStorage,
            ref int? generationDelay,
            ref string? imageResampleRes,
            ref int? resizeImages,
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
            global::APITemplate.CreatePdfFromUrlRequest request);
        partial void PrepareCreatePdfFromUrlRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? exportType,
            int? expiration,
            string? outputFormat,
            string? filename,
            string? directDownload,
            int? cloudStorage,
            int? generationDelay,
            string? imageResampleRes,
            int? resizeImages,
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
            global::APITemplate.CreatePdfFromUrlRequest request);
        partial void ProcessCreatePdfFromUrlResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreatePdfFromUrlResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::APITemplate.ResponseSuccessPDFFile> CreatePdfFromUrlAsync(

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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await CreatePdfFromUrlAsResponseAsync(

                request: request,
                exportType: exportType,
                expiration: expiration,
                outputFormat: outputFormat,
                filename: filename,
                directDownload: directDownload,
                cloudStorage: cloudStorage,
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
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
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
        public async global::System.Threading.Tasks.Task<global::APITemplate.AutoSDKHttpResponse<global::APITemplate.ResponseSuccessPDFFile>> CreatePdfFromUrlAsResponseAsync(

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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreatePdfFromUrlArguments(
                httpClient: HttpClient,
                exportType: ref exportType,
                expiration: ref expiration,
                outputFormat: ref outputFormat,
                filename: ref filename,
                directDownload: ref directDownload,
                cloudStorage: ref cloudStorage,
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
                request: request);


            var __authorizations = global::APITemplate.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreatePdfFromUrlSecurityRequirements,
                operationName: "CreatePdfFromUrlAsync");

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
                                path: "/v2/create-pdf-from-url",
                                baseUri: ResolveBaseUri(
                                servers: s_CreatePdfFromUrlServers,
                                defaultBaseUrl: "https://rest.apitemplate.io/"));
                            __pathBuilder
                                .AddOptionalParameter("export_type", exportType)
                                .AddOptionalParameter("expiration", expiration?.ToString())
                                .AddOptionalParameter("output_format", outputFormat)
                                .AddOptionalParameter("filename", filename)
                                .AddOptionalParameter("direct_download", directDownload)
                                .AddOptionalParameter("cloud_storage", cloudStorage?.ToString())
                                .AddOptionalParameter("generation_delay", generationDelay?.ToString())
                                .AddOptionalParameter("image_resample_res", imageResampleRes)
                                .AddOptionalParameter("resize_images", resizeImages?.ToString())
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
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
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
                PrepareCreatePdfFromUrlRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    exportType: exportType,
                    expiration: expiration,
                    outputFormat: outputFormat,
                    filename: filename,
                    directDownload: directDownload,
                    cloudStorage: cloudStorage,
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
                                operationId: "CreatePdfFromUrl",
                                methodName: "CreatePdfFromUrlAsync",
                                pathTemplate: "\"/v2/create-pdf-from-url\"",
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
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
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
                        var __retryDelay = global::APITemplate.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::APITemplate.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::APITemplate.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreatePdfFromUrl",
                                methodName: "CreatePdfFromUrlAsync",
                                pathTemplate: "\"/v2/create-pdf-from-url\"",
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
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::APITemplate.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::APITemplate.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::APITemplate.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::APITemplate.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::APITemplate.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreatePdfFromUrl",
                                methodName: "CreatePdfFromUrlAsync",
                                pathTemplate: "\"/v2/create-pdf-from-url\"",
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
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::APITemplate.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
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
                ProcessCreatePdfFromUrlResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::APITemplate.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::APITemplate.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreatePdfFromUrl",
                                methodName: "CreatePdfFromUrlAsync",
                                pathTemplate: "\"/v2/create-pdf-from-url\"",
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
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::APITemplate.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::APITemplate.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreatePdfFromUrl",
                                methodName: "CreatePdfFromUrlAsync",
                                pathTemplate: "\"/v2/create-pdf-from-url\"",
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
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
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
                                ProcessCreatePdfFromUrlResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::APITemplate.ResponseSuccessPDFFile.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::APITemplate.AutoSDKHttpResponse<global::APITemplate.ResponseSuccessPDFFile>(
                                        statusCode: __response.StatusCode,
                                        headers: global::APITemplate.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
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

                                    var __value = await global::APITemplate.ResponseSuccessPDFFile.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::APITemplate.AutoSDKHttpResponse<global::APITemplate.ResponseSuccessPDFFile>(
                                        statusCode: __response.StatusCode,
                                        headers: global::APITemplate.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
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
        public async global::System.Threading.Tasks.Task<global::APITemplate.ResponseSuccessPDFFile> CreatePdfFromUrlAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::APITemplate.CreatePdfFromUrlRequest
            {
                Url = url,
                Settings = settings,
            };

            return await CreatePdfFromUrlAsync(
                exportType: exportType,
                expiration: expiration,
                outputFormat: outputFormat,
                filename: filename,
                directDownload: directDownload,
                cloudStorage: cloudStorage,
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
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}