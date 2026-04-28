
#nullable enable

namespace APITemplate
{
    /// <summary>
    /// # Introduction<br/>
    /// Welcome to the [APITemplate.io](https://apitemplate.io) API v2!<br/>
    /// APITemplate.io provides PDF generation services including [Template-based PDF generation](https://apitemplate.io/pdf-generation-api/), [HTML to PDF](https://apitemplate.io/html-to-pdf-api/), and [URL to PDF conversions](https://apitemplate.io/create-pdf-from-url/), as well as an [image generation API](https://apitemplate.io/image-generation-api/).<br/>
    /// This page contains the documentation on how to use APITemplate.io through API calls. With the APITemplate.io API, you can create PDF documents and images, as well as manage your templates.<br/>
    /// Our API is built on RESTful HTTP, so you can utilize any HTTP/REST library of your choice in your preferred programming language to interact with APITemplate.io's API.<br/>
    /// **Steps to produce PDFs/Images**<br/>
    /// 1. Design your template(s) using our intuitive drag-and-drop template editor or the HTML editor and save it.<br/>
    /// 2. Integrate your workflow, either with platforms like Zapier, Make.com/Integromat, Bubble.io, or any programming languages that support REST API, to send us the JSON data along with the template ID/URL/or HTML content.<br/>
    /// 3. Our REST API will then return a download URL for the images (in PNG and JPEG formats) or PDFs.<br/>
    /// # Authentication<br/>
    /// Upon signing up for an account, an API key will be generated for you. If needed, you can reset this API key via the web console (under the "API Integration" section).<br/>
    /// To integrate with our services, you need to authenticate with the APITemplate.io API. Provide your secret key in the request header using the X-API-KEY field.<br/>
    /// # Content Type and CORS<br/>
    /// **Request Content-Type**<br/>
    /// The Content-Type for POST and GET requests is set to application/json.<br/>
    /// **Cross-Origin Resource Sharing**<br/>
    /// This API features Cross-Origin Resource Sharing (CORS) implemented in compliance with  [W3C spec](https://www.w3.org/TR/cors/).<br/>
    /// And that allows cross-domain communication from the browser.<br/>
    /// All responses have a wildcard same-origin which makes them completely public and accessible to everyone, including any code on any site.<br/>
    /// # Regional API endpoint(s)<br/>
    /// A regional API endpoint is intended for customers in the same region. The data for the requests and generated PDFs/images are processed and stored within the region.<br/>
    /// The regions are:<br/>
    /// | Region               | Endpoint                            | Max Timeout (Seconds) | Max Payload Size(MB)** |<br/>
    /// |----------------------|-------------------------------------|-----------------------|-------------------------|<br/>
    /// | Default (Singapore)  | https://rest.apitemplate.io         | 100                   | 4                       |<br/>
    /// | Europe (Frankfurt)   | https://rest-de.apitemplate.io      | 100                   | 4                       |<br/>
    /// | US East (N. Virginia)| https://rest-us.apitemplate.io      | 100                   | 4                       |<br/>
    /// | Australia (Sydney)   | https://rest-au.apitemplate.io      | 30                    | 6                       |<br/>
    /// Alternative Regions:<br/>
    /// | Region               | Endpoint                            | Max Timeout (Seconds) | Max Payload Size(MB)** |<br/>
    /// |----------------------|-------------------------------------|-----------------------|-------------------------|<br/>
    /// | Default (Singapore)  | https://rest-alt.apitemplate.io     | 30                    | 6                       |<br/>
    /// | Europe (Frankfurt)   | https://rest-alt-de.apitemplate.io  | 30                    | 6                       |<br/>
    /// | US East (N. Virginia)| https://rest-alt-us.apitemplate.io  | 30                    | 6                       |<br/>
    /// ** Note:<br/>
    /// - Payload size applies to request and response<br/>
    /// - If "export_type" is set to `json` which output file that on AWS S3 doesn't have the limitation<br/>
    /// - If the "export_type" is set to `file` which returns binary data of the generated PDF, the file size of the generated PDF is limited to either 6MB or 1MB based on the region<br/>
    /// Other regions are available on request, contact us at hello@apitemplate.io for more information<br/>
    /// # Rate limiting<br/>
    /// Our API enforces IP-based rate limits to ensure fair usage and maintain optimal performance:<br/>
    /// - 100 requests per 10 seconds per IP address<br/>
    /// - 100 concurrent synchronous PDF-generation requests per user account<br/>
    /// If you exceed these limits, you’ll receive an HTTP 429 response, indicating that you’ve hit the rate cap and should pause before retrying.<br/>
    /// # IP Whitelisting<br/>
    /// To ensure our PDF and image generation services can retrieve any geo-restricted assets you host, please whitelist our outbound IP addresses in your firewall or CDN settings. Without this, requests to your content may be blocked.<br/>
    /// The following IP addresses are the IP addresses of our outgoing traffic.<br/>
    /// | Region    | IP Address       |<br/>
    /// |-----------|------------------|<br/>
    /// | Singapore | 54.169.31.181/32 |<br/>
    /// | US        | 52.21.225.83/32  |<br/>
    /// | Germany   | 35.159.181.52/32 |<br/>
    /// | Australia | 3.105.245.173/32 |<br/>
    /// Once whitelisted, our services will be able to access your protected resources without interruption.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class APITemplateClient : global::APITemplate.IAPITemplateClient, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://rest.apitemplate.io/";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => ResolveDisplayedBaseUri();

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::APITemplate.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif

        /// <inheritdoc/>
        public global::APITemplate.AutoSDKClientOptions Options { get; }


        internal global::APITemplate.AutoSDKServerConfiguration AutoSDKServerConfiguration { get; set; } = new global::APITemplate.AutoSDKServerConfiguration();
        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; } = global::APITemplate.SourceGenerationContext.Default;


        /// <summary>
        /// 
        /// </summary>
        public ApiIntegrationClient ApiIntegration => new ApiIntegrationClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// 
        /// </summary>
        public PdfManipulationApiClient PdfManipulationApi => new PdfManipulationApiClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// 
        /// </summary>
        public TemplateManagementClient TemplateManagement => new TemplateManagementClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };


        private static readonly global::APITemplate.AutoSDKServer[] s_availableServers = new global::APITemplate.AutoSDKServer[]
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

        /// <summary>
        /// The server options available for this client.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::APITemplate.AutoSDKServer> AvailableServers => s_availableServers;

        /// <summary>
        /// The currently selected server for this client, if any.
        /// </summary>
        public global::APITemplate.AutoSDKServer? SelectedServer
        {
            get => ResolveSelectedServer();
            set => SelectServer(value);
        }

        /// <summary>
        /// Creates a new instance of the APITemplateClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public APITemplateClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::APITemplate.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri,
                authorizations,
                options: null,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the APITemplateClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public APITemplateClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::APITemplate.EndPointAuthorization>? authorizations = null,
            global::APITemplate.AutoSDKClientOptions? options = null,
            bool disposeHttpClient = true)
        {

            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::APITemplate.EndPointAuthorization>();
            Options = options ?? new global::APITemplate.AutoSDKClientOptions();
            _disposeHttpClient = disposeHttpClient;

            AutoSDKServerConfiguration.ExplicitBaseUri = baseUri ?? httpClient?.BaseAddress;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);


        /// <summary>
        /// Selects one of the generated server options by id.
        /// </summary>
        public bool TrySelectServer(string serverId)
        {
            if (string.IsNullOrWhiteSpace(serverId))
            {
                return false;
            }

            foreach (var server in s_availableServers)
            {
                if (string.Equals(server.Id, serverId, global::System.StringComparison.OrdinalIgnoreCase))
                {
                    AutoSDKServerConfiguration.SelectedServer = server;
                    AutoSDKServerConfiguration.ExplicitBaseUri = null;
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Clears the currently selected server.
        /// </summary>
        public void ClearSelectedServer()
        {
            AutoSDKServerConfiguration.SelectedServer = null;
        }

        private global::APITemplate.AutoSDKServer? ResolveSelectedServer()
        {
            var selectedServer = AutoSDKServerConfiguration.SelectedServer;
            if (selectedServer is null)
            {
                return null;
            }

            foreach (var server in s_availableServers)
            {
                if (string.Equals(server.Id, selectedServer.Id, global::System.StringComparison.Ordinal))
                {
                    return server;
                }
            }

            return null;
        }

        private void SelectServer(global::APITemplate.AutoSDKServer? server)
        {
            if (server is null)
            {
                AutoSDKServerConfiguration.SelectedServer = null;
                return;
            }

            foreach (var candidate in s_availableServers)
            {
                if (string.Equals(candidate.Id, server.Id, global::System.StringComparison.Ordinal))
                {
                    AutoSDKServerConfiguration.SelectedServer = candidate;
                    AutoSDKServerConfiguration.ExplicitBaseUri = null;
                    return;
                }
            }

            throw new global::System.ArgumentException("The provided server is not available for this client.", nameof(server));
        }

        private global::System.Uri? ResolveDisplayedBaseUri()
        {
            if (AutoSDKServerConfiguration.ExplicitBaseUri is global::System.Uri explicitBaseUri)
            {
                return explicitBaseUri;
            }

            return ResolveSelectedServer()?.Uri ?? HttpClient.BaseAddress;
        }

        private global::System.Uri? ResolveBaseUri(
            global::APITemplate.AutoSDKServer[] servers,
            string defaultBaseUrl)
        {
            if (AutoSDKServerConfiguration.ExplicitBaseUri is global::System.Uri explicitBaseUri)
            {
                return explicitBaseUri;
            }

            if (AutoSDKServerConfiguration.SelectedServer is global::APITemplate.AutoSDKServer selectedServer)
            {
                foreach (var server in servers)
                {
                    if (string.Equals(server.Id, selectedServer.Id, global::System.StringComparison.Ordinal))
                    {
                        return server.Uri;
                    }
                }
            }

            if (servers.Length > 0)
            {
                return servers[0].Uri;
            }

            return string.IsNullOrWhiteSpace(defaultBaseUrl)
                ? HttpClient.BaseAddress
                : new global::System.Uri(defaultBaseUrl, global::System.UriKind.RelativeOrAbsolute);
        }
    }
}