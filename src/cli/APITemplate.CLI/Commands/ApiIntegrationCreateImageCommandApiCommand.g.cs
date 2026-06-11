#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace APITemplate.CLI.Commands;

internal static partial class ApiIntegrationCreateImageCommandApiCommand
{
    private static Option<string> TemplateId { get; } = new(
        name: @"--template-id")
    {
        Description = @"Your template id, it can be obtained in the web console",
        Required = true,
    };

    private static Option<string?> OutputImageType { get; } = new(
        name: @"--output-image-type")
    {
        Description = @"- Output image type(JPEG or PNG format), default to `all`. Options are `all`, `jpegOnly`,`pngOnly`.
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

                    private static string FormatResponse(ParseResult parseResult, global::APITemplate.ResponseSuccessImageFile value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::APITemplate.ResponseSuccessImageFile value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-image", @"Create an Image
This endpoint creates a JPEG file(along with PNG) with JSON data and your template
");
                        command.Options.Add(TemplateId);
                        command.Options.Add(OutputImageType);
                        command.Options.Add(Expiration);
                        command.Options.Add(CloudStorage);
                        command.Options.Add(GenerationDelay);
                        command.Options.Add(ResizeImages);
                        command.Options.Add(ResizeMaxWidth);
                        command.Options.Add(ResizeMaxHeight);
                        command.Options.Add(ResizeFormat);
                        command.Options.Add(PostactionS3Filekey);
                        command.Options.Add(PostactionS3Bucket);
                        command.Options.Add(PostactionEnabled);
                        command.Options.Add(Meta);
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
                        var outputImageType = parseResult.GetValue(OutputImageType);
                        var expiration = parseResult.GetValue(Expiration);
                        var cloudStorage = parseResult.GetValue(CloudStorage);
                        var generationDelay = parseResult.GetValue(GenerationDelay);
                        var resizeImages = parseResult.GetValue(ResizeImages);
                        var resizeMaxWidth = parseResult.GetValue(ResizeMaxWidth);
                        var resizeMaxHeight = parseResult.GetValue(ResizeMaxHeight);
                        var resizeFormat = parseResult.GetValue(ResizeFormat);
                        var postactionS3Filekey = parseResult.GetValue(PostactionS3Filekey);
                        var postactionS3Bucket = parseResult.GetValue(PostactionS3Bucket);
                        var postactionEnabled = parseResult.GetValue(PostactionEnabled);
                        var meta = parseResult.GetValue(Meta);
                        var request = await CliRuntime.ReadRequestAsync<object>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::APITemplate.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ApiIntegration.CreateImageAsync(
                                    templateId: templateId,
                                    outputImageType: outputImageType,
                                    expiration: expiration,
                                    cloudStorage: cloudStorage,
                                    generationDelay: generationDelay,
                                    resizeImages: resizeImages,
                                    resizeMaxWidth: resizeMaxWidth,
                                    resizeMaxHeight: resizeMaxHeight,
                                    resizeFormat: resizeFormat,
                                    postactionS3Filekey: postactionS3Filekey,
                                    postactionS3Bucket: postactionS3Bucket,
                                    postactionEnabled: postactionEnabled,
                                    meta: meta,
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