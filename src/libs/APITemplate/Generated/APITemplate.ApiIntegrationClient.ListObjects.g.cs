
#nullable enable

namespace APITemplate
{
    public partial class ApiIntegrationClient
    {

        private static readonly global::APITemplate.AutoSDKServer[] s_ListObjectsServers = new global::APITemplate.AutoSDKServer[]
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


        private static readonly global::APITemplate.EndPointSecurityRequirement s_ListObjectsSecurityRequirement0 =
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
        private static readonly global::APITemplate.EndPointSecurityRequirement[] s_ListObjectsSecurityRequirements =
            new global::APITemplate.EndPointSecurityRequirement[]
            {                s_ListObjectsSecurityRequirement0,
            };
        partial void PrepareListObjectsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? limit,
            ref string? offset,
            ref string? templateId,
            ref string? transactionType,
            ref string? transactionRef);
        partial void PrepareListObjectsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? limit,
            string? offset,
            string? templateId,
            string? transactionType,
            string? transactionRef);
        partial void ProcessListObjectsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListObjectsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::APITemplate.ResponseSuccessListObjects> ListObjectsAsync(
            string? limit = default,
            string? offset = default,
            string? templateId = default,
            string? transactionType = default,
            string? transactionRef = default,
            global::APITemplate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await ListObjectsAsResponseAsync(
                limit: limit,
                offset: offset,
                templateId: templateId,
                transactionType: transactionType,
                transactionRef: transactionRef,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
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
        public async global::System.Threading.Tasks.Task<global::APITemplate.AutoSDKHttpResponse<global::APITemplate.ResponseSuccessListObjects>> ListObjectsAsResponseAsync(
            string? limit = default,
            string? offset = default,
            string? templateId = default,
            string? transactionType = default,
            string? transactionRef = default,
            global::APITemplate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListObjectsArguments(
                httpClient: HttpClient,
                limit: ref limit,
                offset: ref offset,
                templateId: ref templateId,
                transactionType: ref transactionType,
                transactionRef: ref transactionRef);


            var __authorizations = global::APITemplate.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ListObjectsSecurityRequirements,
                operationName: "ListObjectsAsync");

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
                                path: "/v2/list-objects",
                                baseUri: ResolveBaseUri(
                                servers: s_ListObjectsServers,
                                defaultBaseUrl: "https://rest.apitemplate.io/"));
                            __pathBuilder
                                .AddOptionalParameter("limit", limit)
                                .AddOptionalParameter("offset", offset)
                                .AddOptionalParameter("template_id", templateId)
                                .AddOptionalParameter("transaction_type", transactionType)
                                .AddOptionalParameter("transaction_ref", transactionRef)
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::APITemplate.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
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
                global::APITemplate.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareListObjectsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    limit: limit,
                    offset: offset,
                    templateId: templateId,
                    transactionType: transactionType,
                    transactionRef: transactionRef);

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
                                operationId: "ListObjects",
                                methodName: "ListObjectsAsync",
                                pathTemplate: "\"/v2/list-objects\"",
                                httpMethod: "GET",
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
                                operationId: "ListObjects",
                                methodName: "ListObjectsAsync",
                                pathTemplate: "\"/v2/list-objects\"",
                                httpMethod: "GET",
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
                                operationId: "ListObjects",
                                methodName: "ListObjectsAsync",
                                pathTemplate: "\"/v2/list-objects\"",
                                httpMethod: "GET",
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
                ProcessListObjectsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::APITemplate.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::APITemplate.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListObjects",
                                methodName: "ListObjectsAsync",
                                pathTemplate: "\"/v2/list-objects\"",
                                httpMethod: "GET",
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
                                operationId: "ListObjects",
                                methodName: "ListObjectsAsync",
                                pathTemplate: "\"/v2/list-objects\"",
                                httpMethod: "GET",
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


                                throw global::APITemplate.ApiException<global::APITemplate.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_default ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_default,
                                    responseBody: __content_default,
                                    responseObject: __value_default,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
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
                                ProcessListObjectsResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::APITemplate.ResponseSuccessListObjects.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::APITemplate.AutoSDKHttpResponse<global::APITemplate.ResponseSuccessListObjects>(
                                        statusCode: __response.StatusCode,
                                        headers: global::APITemplate.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::APITemplate.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
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

                                    var __value = await global::APITemplate.ResponseSuccessListObjects.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::APITemplate.AutoSDKHttpResponse<global::APITemplate.ResponseSuccessListObjects>(
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

                                    throw global::APITemplate.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}