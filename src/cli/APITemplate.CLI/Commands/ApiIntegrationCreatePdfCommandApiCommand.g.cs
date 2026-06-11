#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace APITemplate.CLI.Commands;

internal static partial class ApiIntegrationCreatePdfCommandApiCommand
{
    private static Option<string> TemplateId { get; } = new(
        name: @"--template-id")
    {
        Description = @"Your template id, it can be obtained in the web console",
        Required = true,
    };

    private static Option<string?> ExportType { get; } = new(
        name: @"--export-type")
    {
        Description = @"- Either `file` or `json`(Default).
  - The option `json` returns a JSON object, and the output PDF is stored on a CDN. Use this with the parameter `expiration`
  - The option `file` returns binary data of the generated PDF(Secure and completely private) and the response HTTP header Content-Disposition is set to attachment.
",
    };

    private static Option<string?> ExportInBase64 { get; } = new(
        name: @"--export-in-base64")
    {
        Description = @"- If export_type = `file`, the PDF can be downloaded in binary or base64 format. The value is either `1` or `0`(Default).
  - The export_in_base64 is set `0` is to download the PDF in binary
  - The export_in_base64 is set `1` is to download the PDF in base64 format

",
    };

    private static Option<int?> Expiration { get; } = new(
        name: @"--expiration")
    {
        Description = @"- Expiration of the generated PDF in minutes(default to `0`, store permanently)
  - Use `0` to store on cdn permanently
  - Or use the range between `1` minute and `10080` minutes(7 days) to specify the expiration of the generated PDF
",
    };

    private static Option<string?> OutputHtml { get; } = new(
        name: @"--output-html")
    {
        Description = @"- Either `1` or `0`(Default).
- To enable output of html content, set the value to `1` and it will return in the JSON response as html_url field (as a URL)
",
    };

    private static Option<string?> OutputFormat { get; } = new(
        name: @"--output-format")
    {
        Description = @"Specifies the desired output format. Options are `pdf` (default), `html`, `png`, or `jpeg`.
- By default, a PDF is generated.
- To return HTML instead, set `output_format=html`; the response will include a `download_url` field pointing to the HTML.
- To produce an image, set `output_format=png` or `output_format=jpeg`.
",
    };

    private static Option<string?> Filename { get; } = new(
        name: @"--filename")
    {
        Description = @"- Default to UUID (e.g 0c93bd9e-9ebb-4634-a70f-de9131848416.pdf). Use this to specify custom file name, it should end with `.pdf`
",
    };

    private static Option<string?> DirectDownload { get; } = new(
        name: @"--direct-download")
    {
        Description = @"- ContentDisposition set to attachment. 1=true, 0=false. Default to '0'
",
    };

    private static Option<int?> CloudStorage { get; } = new(
        name: @"--cloud-storage")
    {
        Description = @"- Upload the generated PDFs/images to our storage CDN, default to `1`. If you have configured `Post Action` to upload the PDFs/Images to your own S3, please set it to `0`.
",
    };

    private static Option<string?> LoadDataFrom { get; } = new(
        name: @"--load-data-from")
    {
        Description = @"Load JSON data from a remote URL instead of the request body. If load_data_from is specified, the JSON data in the request will be ignored.
",
    };

    private static Option<int?> ExtractLink { get; } = new(
        name: @"--extract-link")
    {
        Description = @"- Extract links from the HTML content, default to `0`.
",
    };

    private static Option<int?> GenerationDelay { get; } = new(
        name: @"--generation-delay")
    {
        Description = @"Delay in milliseconds before PDF/image generation
",
    };

    private static Option<string?> ImageResampleRes { get; } = new(
        name: @"--image-resample-res")
    {
        Description = @"- We embed the original images by default, meaning large PDF file sizes. Specifying the option 'image_resample_res' helps reduce the PDF file size by downsampling the images of the current PDF to a resolution(in DPI). Common values are 72, 96, 150, 300 and 600.
",
    };

    private static Option<int?> ResizeImages { get; } = new(
        name: @"--resize-images")
    {
        Description = @"- Preprocess images or re-size images in the PDF, either `1`=true or `0`=false. Default to '0'
- If `resize_images` is set to `1`, specify the `resize_max_width`, `resize_max_height` in pixels.
- Images to be resized need to satisfy the following conditions:
  - The images with the content-type `image/jpeg`, `image/jpg` or `image/png`
  - The image URLs with the extension `.jpg`, `.jpeg` or `.png`
",
    };

    private static Option<int?> ResizeMaxWidth { get; } = new(
        name: @"--resize-max-width")
    {
        Description = @"- If `resize_images` is set to `1`, specify the maximum width of the image in pixels. Default to '1000'
",
    };

    private static Option<int?> ResizeMaxHeight { get; } = new(
        name: @"--resize-max-height")
    {
        Description = @"- If `resize_images` is set to `1`, specify the maximum height of the image in pixels. Default to '1000'
",
    };

    private static Option<string?> ResizeFormat { get; } = new(
        name: @"--resize-format")
    {
        Description = @"- If `resize_images` is set to `1`, specify the format of the image. Either `jpeg` or `png`
",
    };

    private static Option<string?> PostactionS3Filekey { get; } = new(
        name: @"--postaction-s3-filekey")
    {
        Description = @"- This is to specify the file name for `Post Action(AWS S3/Cloudflare R2/Azure Storage)`.
- Please do not specify the file extension
- Please make sure the file name is unique
- You might use slash (/) as the folder delimiter
- It's default to transaction_ref
",
    };

    private static Option<string?> PostactionS3Bucket { get; } = new(
        name: @"--postaction-s3-bucket")
    {
        Description = @"- This is to overwrite the AWS Bucket for `Post Action(AWS S3/Cloudflare R2 Storage)` or the container for `Post Action(Azure Storage)`.
",
    };

    private static Option<string?> PostactionEnabled { get; } = new(
        name: @"--postaction-enabled")
    {
        Description = @"- This setting enables the Post Actions.
- Acceptable values: `0` (disabled) or `1` (enabled; default).
- It is enabled by default. However, if you have enabled BYOS and do not upload the generated PDF/image of this request to your own storage, please set this to `0`.
",
    };

    private static Option<string?> Meta { get; } = new(
        name: @"--meta")
    {
        Description = @"- Specify an external reference ID for your own reference. It appears in the `list-objects` API.
",
    };

    private static Option<string?> Async { get; } = new(
        name: @"--async")
    {
        Description = @"- Either `1` or `0`(Default).  `0` is synchronous call(default), `1` is asynchronous call
- To generate PDF asynchronously, set the value to `1` and the API call returns immediately. Once the PDF document is generated, we will make a HTTP/HTTPS GET to your URL(webhook_url) and will retry for 3 times before giving up.
- If `async` is set to `1`, then `webhook_url` is mandatory
",
    };

    private static Option<string?> WebhookUrl { get; } = new(
        name: @"--webhook-url")
    {
        Description = @"- It is the URL of your webhook URL, it starts with http:// or https:// and has to be urlencoded.
- If `async` is set to `1`, then you have to specify the `webhook_url`.


#### Format of Webhook callback

Once the PDF is generated, we will initiate a HTTP/HTTPS GET call to the following URL:

https://`[yourwebserver.com]`?&primary_url=`[primary_url]`&transaction_ref=`[transaction_ref]`&status=`[status]`&message=`[message]`

- `[yourwebserver.com]`: The web services to handle the callback, which is the `webhook_url`
- `[primary_url]`: The URL to the PDF document
- `[transaction_ref]`: The transaction reference number
- `[status]` : Status of the transaction, either `success` or `error`
- `[message]` : Status message

***The following is a sample webhook call back to your server***

https://yourwebserver.com?&primary_url=https%3A%2F%2Fpub-cdn.apitemplate.io%2F2021%2F06%2Fb692183d-46d7-3213-891a-460a5814ad3f.pdf&transaction_ref=b692183d-46d7-3213-891a-460a5814ad3f&status=success
",
    };

    private static Option<string?> WebhookMethod { get; } = new(
        name: @"--webhook-method")
    {
        Description = @"- The HTTP method of the webhook, either `POST` or `GET`. Default to `GET`
",
    };

    private static Option<string?> WebhookHeaders { get; } = new(
        name: @"--webhook-headers")
    {
        Description = @"- The HTTP headers of the webhook, it should be a base64 encoded JSON object.
- The following is an example of base64 encoded JSON:
  ```json
  eyJ3b3JrZmxvdy1hcGkta2V5Ijoia2V5X0VLc3MxNWJKRXFBMkRHYzM4bkNXNzlaRER1ZUZJeiJ9
  ```

  The JSON object in clear text for the above base64 encoded JSON:
  ```json
  {
    ""workflow-api-key"": ""key_EKss15bJEqA2DGc38nCW79ZDDueFIz""
  }
  ```
",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::APITemplate.ResponseSuccessPDFFile value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::APITemplate.ResponseSuccessPDFFile value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-pdf", @"Create a PDF
This endpoint creates a PDF file with JSON data and your template. We support synchoronus and asynchronous PDF generation.");
                        command.Options.Add(TemplateId);
                        command.Options.Add(ExportType);
                        command.Options.Add(ExportInBase64);
                        command.Options.Add(Expiration);
                        command.Options.Add(OutputHtml);
                        command.Options.Add(OutputFormat);
                        command.Options.Add(Filename);
                        command.Options.Add(DirectDownload);
                        command.Options.Add(CloudStorage);
                        command.Options.Add(LoadDataFrom);
                        command.Options.Add(ExtractLink);
                        command.Options.Add(GenerationDelay);
                        command.Options.Add(ImageResampleRes);
                        command.Options.Add(ResizeImages);
                        command.Options.Add(ResizeMaxWidth);
                        command.Options.Add(ResizeMaxHeight);
                        command.Options.Add(ResizeFormat);
                        command.Options.Add(PostactionS3Filekey);
                        command.Options.Add(PostactionS3Bucket);
                        command.Options.Add(PostactionEnabled);
                        command.Options.Add(Meta);
                        command.Options.Add(Async);
                        command.Options.Add(WebhookUrl);
                        command.Options.Add(WebhookMethod);
                        command.Options.Add(WebhookHeaders);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount != 1)
              {
                  result.AddError(@"Specify exactly one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var templateId = parseResult.GetRequiredValue(TemplateId);
                        var exportType = parseResult.GetValue(ExportType);
                        var exportInBase64 = parseResult.GetValue(ExportInBase64);
                        var expiration = parseResult.GetValue(Expiration);
                        var outputHtml = parseResult.GetValue(OutputHtml);
                        var outputFormat = parseResult.GetValue(OutputFormat);
                        var filename = parseResult.GetValue(Filename);
                        var directDownload = parseResult.GetValue(DirectDownload);
                        var cloudStorage = parseResult.GetValue(CloudStorage);
                        var loadDataFrom = parseResult.GetValue(LoadDataFrom);
                        var extractLink = parseResult.GetValue(ExtractLink);
                        var generationDelay = parseResult.GetValue(GenerationDelay);
                        var imageResampleRes = parseResult.GetValue(ImageResampleRes);
                        var resizeImages = parseResult.GetValue(ResizeImages);
                        var resizeMaxWidth = parseResult.GetValue(ResizeMaxWidth);
                        var resizeMaxHeight = parseResult.GetValue(ResizeMaxHeight);
                        var resizeFormat = parseResult.GetValue(ResizeFormat);
                        var postactionS3Filekey = parseResult.GetValue(PostactionS3Filekey);
                        var postactionS3Bucket = parseResult.GetValue(PostactionS3Bucket);
                        var postactionEnabled = parseResult.GetValue(PostactionEnabled);
                        var meta = parseResult.GetValue(Meta);
                        var async = parseResult.GetValue(Async);
                        var webhookUrl = parseResult.GetValue(WebhookUrl);
                        var webhookMethod = parseResult.GetValue(WebhookMethod);
                        var webhookHeaders = parseResult.GetValue(WebhookHeaders);
                        var request = await CliRuntime.ReadRequestAsync<object>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::APITemplate.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ApiIntegration.CreatePdfAsync(
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
                                    request: request,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::APITemplate.SourceGenerationContext.Default,
                                        @"PostActions",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::APITemplate.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}