#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace APITemplate.CLI.Commands;

internal static partial class PdfManipulationApiMergePdfsCommandApiCommand
{
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

    private static Option<global::System.Collections.Generic.IList<object>> Urls { get; } = new(
        name: @"--urls")
    {
        Description = @"URL array. We support normal http/https URLs and data URLs
- Normal URLs: URLs start with http/https, e.g: ""https://fileserver.com/a1.pdf"")
- Data URLs: URLs prefixed with the ""data:"" scheme, e.g ""data:application/pdf;base64,JVBERi0xLjIg...[truncated]""
",
        Required = true,
    };

    private static Option<string?> ExportType { get; } = new(
        name: @"--export-type")
    {
        Description = @"- Either `file` or `json`(Default).
  - The option `json` returns a JSON object, and the output PDF is stored on a CDN.
  - The option `file` returns binary data of the generated PDF(Secure and completely private) and the response HTTP header Content-Disposition is set to attachment. It has a file size limit of 6MB.
",
    };

    private static Option<int?> Expiration { get; } = new(
        name: @"--expiration")
    {
        Description = @"- Expiration of the generated PDF in minutes(default to `0`, store permanently)
  - Use `0` to store on cdn permanently
  - Or use the range between `1` minute and `43200` minutes(30 days) to specify the expiration of the generated PDF
",
    };

    private static Option<int?> CloudStorage { get; } = new(
        name: @"--cloud-storage")
    {
        Description = @"- Upload the generated PDFs/images to our storage CDN, default to `1`. If you have configured `Post Action` to upload the PDFs/Images to your own S3, please set it to `0`.
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

                    private static string FormatResponse(ParseResult parseResult, global::APITemplate.ResponseSuccessSingleFile value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::APITemplate.ResponseSuccessSingleFile value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"merge-pdfs", @"Join/Merge multiple PDFs
This endpoint merges/joins multiple PDF URLs into a single PDF file");
                        command.Options.Add(PostactionS3Filekey);
                        command.Options.Add(PostactionS3Bucket);
                        command.Options.Add(PostactionEnabled);
                        command.Options.Add(Meta);
                        command.Options.Add(Urls);
                        command.Options.Add(ExportType);
                        command.Options.Add(Expiration);
                        command.Options.Add(CloudStorage);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::APITemplate.MergePdfsRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::APITemplate.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var postactionS3Filekey = parseResult.GetValue(PostactionS3Filekey);
                        var postactionS3Bucket = parseResult.GetValue(PostactionS3Bucket);
                        var postactionEnabled = parseResult.GetValue(PostactionEnabled);
                        var meta = parseResult.GetValue(Meta);
                        var urls = parseResult.GetRequiredValue(Urls);
                        var exportType = CliRuntime.WasSpecified(parseResult, ExportType) ? parseResult.GetValue(ExportType) : (__requestBase is { } __ExportTypeBaseValue ? __ExportTypeBaseValue.ExportType : default);
                        var expiration = CliRuntime.WasSpecified(parseResult, Expiration) ? parseResult.GetValue(Expiration) : (__requestBase is { } __ExpirationBaseValue ? __ExpirationBaseValue.Expiration : default);
                        var cloudStorage = CliRuntime.WasSpecified(parseResult, CloudStorage) ? parseResult.GetValue(CloudStorage) : (__requestBase is { } __CloudStorageBaseValue ? __CloudStorageBaseValue.CloudStorage : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.PdfManipulationApi.MergePdfsAsync(
                                    postactionS3Filekey: postactionS3Filekey,
                                    postactionS3Bucket: postactionS3Bucket,
                                    postactionEnabled: postactionEnabled,
                                    meta: meta,
                                    urls: urls,
                                    exportType: exportType,
                                    expiration: expiration,
                                    cloudStorage: cloudStorage,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::APITemplate.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}