
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
    public partial interface IAPITemplateClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }


        /// <summary>
        /// The server options available for this client.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::APITemplate.AutoSDKServer> AvailableServers { get; }

        /// <summary>
        /// The currently selected server for this client, if any.
        /// </summary>
        public global::APITemplate.AutoSDKServer? SelectedServer { get; set; }

        /// <summary>
        /// Selects one of the generated server options by id.
        /// </summary>
        public bool TrySelectServer(string serverId);

        /// <summary>
        /// Clears the currently selected server.
        /// </summary>
        public void ClearSelectedServer();

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::APITemplate.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::APITemplate.AutoSDKClientOptions Options { get; }


        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public ApiIntegrationClient ApiIntegration { get; }

        /// <summary>
        /// 
        /// </summary>
        public PdfManipulationApiClient PdfManipulationApi { get; }

        /// <summary>
        /// 
        /// </summary>
        public TemplateManagementClient TemplateManagement { get; }

    }
}