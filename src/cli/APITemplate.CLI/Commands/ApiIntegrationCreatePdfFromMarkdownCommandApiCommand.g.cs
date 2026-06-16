#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace APITemplate.CLI.Commands;

internal static partial class ApiIntegrationCreatePdfFromMarkdownCommandApiCommand
{
    private static Option<string?> ExportType { get; } = new(
        name: @"--export-type")
    {
        Description = @"- Either `file` or `json`(Default).
  - The option `json` returns a JSON object, and the output PDF is stored on a CDN. Use this with the parameter `expiration`
  - The option `file` returns binary data of the generated PDF(Secure and completely private) and the response HTTP header Content-Disposition is set to attachment.
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

    private static Option<string?> Body { get; } = new(
        name: @"--body")
    {
        Description = @"The Markdown content for the PDF.
",
    };

    private static Option<object?> Data { get; } = new(
        name: @"--data")
    {
        Description = @"The data object containing values for dynamic content in the Markdown body. This object should include properties with corresponding values.
",
    };

    private static Option<string?> Css { get; } = new(
        name: @"--css")
    {
        Description = @"The CSS styles to be applied to the PDF. This property should contain valid CSS markup and should also include the style tag.
",
    };
    private static readonly PDFGenerationSettingsObjectOptionSet SettingsOptions = PDFGenerationSettingsObjectOptionSet.Create(@"settings");
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
        var command = new Command(@"create-pdf-from-markdown", @"Create a PDF from Markdown
- This endpoint creates a PDF file from Markdown
");
                        command.Options.Add(ExportType);
                        command.Options.Add(Expiration);
                        command.Options.Add(OutputFormat);
                        command.Options.Add(Filename);
                        command.Options.Add(DirectDownload);
                        command.Options.Add(CloudStorage);
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
                        command.Options.Add(Body);
                        command.Options.Add(Data);
                        command.Options.Add(Css);                        command.Options.Add(SettingsOptions.PaperSize);
                        command.Options.Add(SettingsOptions.CustomWidth);
                        command.Options.Add(SettingsOptions.CustomHeight);
                        command.Options.Add(SettingsOptions.Orientation);
                        command.Options.Add(SettingsOptions.HeaderFontSize);
                        command.Options.Add(SettingsOptions.MarginTop);
                        command.Options.Add(SettingsOptions.MarginRight);
                        command.Options.Add(SettingsOptions.MarginBottom);
                        command.Options.Add(SettingsOptions.MarginLeft);
                        command.Options.Add(SettingsOptions.PrintBackground);
                        command.Options.Add(SettingsOptions.DisplayHeaderFooter);
                        command.Options.Add(SettingsOptions.CustomHeader);
                        command.Options.Add(SettingsOptions.CustomFooter);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::APITemplate.CreatePdfFromMarkdownRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::APITemplate.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var exportType = parseResult.GetValue(ExportType);
                        var expiration = parseResult.GetValue(Expiration);
                        var outputFormat = parseResult.GetValue(OutputFormat);
                        var filename = parseResult.GetValue(Filename);
                        var directDownload = parseResult.GetValue(DirectDownload);
                        var cloudStorage = parseResult.GetValue(CloudStorage);
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
                        var body = CliRuntime.WasSpecified(parseResult, Body) ? parseResult.GetValue(Body) : (__requestBase is { } __BodyBaseValue ? __BodyBaseValue.Body : default);
                        var data = CliRuntime.WasSpecified(parseResult, Data) ? parseResult.GetValue(Data) : (__requestBase is { } __DataBaseValue ? __DataBaseValue.Data : default);
                        var css = CliRuntime.WasSpecified(parseResult, Css) ? parseResult.GetValue(Css) : (__requestBase is { } __CssBaseValue ? __CssBaseValue.Css : default);

                        var __SettingsBase = __requestBase is { } __SettingsBaseValue ? __SettingsBaseValue.Settings : default;                        var settingsPaperSize = CliRuntime.WasSpecified(parseResult, SettingsOptions.PaperSize) ? parseResult.GetValue(SettingsOptions.PaperSize) : (__SettingsBase is { } __SettingspaperSizeBaseValue ? __SettingspaperSizeBaseValue.PaperSize : default);
                        var settingsCustomWidth = CliRuntime.WasSpecified(parseResult, SettingsOptions.CustomWidth) ? parseResult.GetValue(SettingsOptions.CustomWidth) : (__SettingsBase is { } __SettingscustomWidthBaseValue ? __SettingscustomWidthBaseValue.CustomWidth : default);
                        var settingsCustomHeight = CliRuntime.WasSpecified(parseResult, SettingsOptions.CustomHeight) ? parseResult.GetValue(SettingsOptions.CustomHeight) : (__SettingsBase is { } __SettingscustomHeightBaseValue ? __SettingscustomHeightBaseValue.CustomHeight : default);
                        var settingsOrientation = CliRuntime.WasSpecified(parseResult, SettingsOptions.Orientation) ? parseResult.GetValue(SettingsOptions.Orientation) : (__SettingsBase is { } __SettingsorientationBaseValue ? __SettingsorientationBaseValue.Orientation : default);
                        var settingsHeaderFontSize = CliRuntime.WasSpecified(parseResult, SettingsOptions.HeaderFontSize) ? parseResult.GetValue(SettingsOptions.HeaderFontSize) : (__SettingsBase is { } __SettingsheaderFontSizeBaseValue ? __SettingsheaderFontSizeBaseValue.HeaderFontSize : default);
                        var settingsMarginTop = CliRuntime.WasSpecified(parseResult, SettingsOptions.MarginTop) ? parseResult.GetValue(SettingsOptions.MarginTop) : (__SettingsBase is { } __SettingsmarginTopBaseValue ? __SettingsmarginTopBaseValue.MarginTop : default);
                        var settingsMarginRight = CliRuntime.WasSpecified(parseResult, SettingsOptions.MarginRight) ? parseResult.GetValue(SettingsOptions.MarginRight) : (__SettingsBase is { } __SettingsmarginRightBaseValue ? __SettingsmarginRightBaseValue.MarginRight : default);
                        var settingsMarginBottom = CliRuntime.WasSpecified(parseResult, SettingsOptions.MarginBottom) ? parseResult.GetValue(SettingsOptions.MarginBottom) : (__SettingsBase is { } __SettingsmarginBottomBaseValue ? __SettingsmarginBottomBaseValue.MarginBottom : default);
                        var settingsMarginLeft = CliRuntime.WasSpecified(parseResult, SettingsOptions.MarginLeft) ? parseResult.GetValue(SettingsOptions.MarginLeft) : (__SettingsBase is { } __SettingsmarginLeftBaseValue ? __SettingsmarginLeftBaseValue.MarginLeft : default);
                        var settingsPrintBackground = CliRuntime.WasSpecified(parseResult, SettingsOptions.PrintBackground) ? parseResult.GetValue(SettingsOptions.PrintBackground) : (__SettingsBase is { } __SettingsprintBackgroundBaseValue ? __SettingsprintBackgroundBaseValue.PrintBackground : default);
                        var settingsDisplayHeaderFooter = CliRuntime.WasSpecified(parseResult, SettingsOptions.DisplayHeaderFooter) ? parseResult.GetValue(SettingsOptions.DisplayHeaderFooter) : (__SettingsBase is { } __SettingsdisplayHeaderFooterBaseValue ? __SettingsdisplayHeaderFooterBaseValue.DisplayHeaderFooter : default);
                        var settingsCustomHeader = CliRuntime.WasSpecified(parseResult, SettingsOptions.CustomHeader) ? parseResult.GetValue(SettingsOptions.CustomHeader) : (__SettingsBase is { } __SettingscustomHeaderBaseValue ? __SettingscustomHeaderBaseValue.CustomHeader : default);
                        var settingsCustomFooter = CliRuntime.WasSpecified(parseResult, SettingsOptions.CustomFooter) ? parseResult.GetValue(SettingsOptions.CustomFooter) : (__SettingsBase is { } __SettingscustomFooterBaseValue ? __SettingscustomFooterBaseValue.CustomFooter : default);
                        var __SettingsSpecified = CliRuntime.WasSpecified(parseResult, SettingsOptions.PaperSize) || CliRuntime.WasSpecified(parseResult, SettingsOptions.CustomWidth) || CliRuntime.WasSpecified(parseResult, SettingsOptions.CustomHeight) || CliRuntime.WasSpecified(parseResult, SettingsOptions.Orientation) || CliRuntime.WasSpecified(parseResult, SettingsOptions.HeaderFontSize) || CliRuntime.WasSpecified(parseResult, SettingsOptions.MarginTop) || CliRuntime.WasSpecified(parseResult, SettingsOptions.MarginRight) || CliRuntime.WasSpecified(parseResult, SettingsOptions.MarginBottom) || CliRuntime.WasSpecified(parseResult, SettingsOptions.MarginLeft) || CliRuntime.WasSpecified(parseResult, SettingsOptions.PrintBackground) || CliRuntime.WasSpecified(parseResult, SettingsOptions.DisplayHeaderFooter) || CliRuntime.WasSpecified(parseResult, SettingsOptions.CustomHeader) || CliRuntime.WasSpecified(parseResult, SettingsOptions.CustomFooter);
                        var settings =
                            __SettingsSpecified || __SettingsBase is not null
                                ? new global::APITemplate.PDFGenerationSettingsObject
                                {
	                                PaperSize = settingsPaperSize,
                                CustomWidth = settingsCustomWidth,
                                CustomHeight = settingsCustomHeight,
                                Orientation = settingsOrientation,
                                HeaderFontSize = settingsHeaderFontSize,
                                MarginTop = settingsMarginTop,
                                MarginRight = settingsMarginRight,
                                MarginBottom = settingsMarginBottom,
                                MarginLeft = settingsMarginLeft,
                                PrintBackground = settingsPrintBackground,
                                DisplayHeaderFooter = settingsDisplayHeaderFooter,
                                CustomHeader = settingsCustomHeader,
                                CustomFooter = settingsCustomFooter,

                                }
                                : __SettingsBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ApiIntegration.CreatePdfFromMarkdownAsync(
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
                                    body: body,
                                    data: data,
                                    css: css,
                                    settings: settings,
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