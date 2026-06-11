#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace APITemplate.CLI.Commands;

internal static partial class TemplateManagementUpdateTemplateCommandApiCommand
{
    private static Option<string> TemplateId { get; } = new(
        name: @"--template-id")
    {
        Description = @"Your template id, it can be obtained in the web console(Manage Templates)
",
        Required = true,
    };

    private static Option<string?> Body { get; } = new(
        name: @"--body")
    {
        Description = @"The HTML body
",
    };

    private static Option<string?> Css { get; } = new(
        name: @"--css")
    {
        Description = @"The css
",
    };

    private static Option<global::APITemplate.UpdateTemplateRequestSettings?> Settings { get; } = new(
        name: @"--settings")
    {
        Description = @"Settings of the template, the followings is an example:
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

                    private static string FormatResponse(ParseResult parseResult, global::APITemplate.ResponseSuccess value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::APITemplate.ResponseSuccess value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"update-template", @"Update PDF Template
This endpoint updates PDF template (**This is an experimental API, contact support to learn more**)");
                        command.Options.Add(TemplateId);
                        command.Options.Add(Body);
                        command.Options.Add(Css);
                        command.Options.Add(Settings);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::APITemplate.UpdateTemplateRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::APITemplate.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var templateId = parseResult.GetRequiredValue(TemplateId);
                        var body = CliRuntime.WasSpecified(parseResult, Body) ? parseResult.GetValue(Body) : __requestBase is not null ? __requestBase.Body : default;
                        var css = CliRuntime.WasSpecified(parseResult, Css) ? parseResult.GetValue(Css) : __requestBase is not null ? __requestBase.Css : default;
                        var settings = CliRuntime.WasSpecified(parseResult, Settings) ? parseResult.GetValue(Settings) : __requestBase is not null ? __requestBase.Settings : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.TemplateManagement.UpdateTemplateAsync(
                                    templateId: templateId,
                                    body: body,
                                    css: css,
                                    settings: settings,
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