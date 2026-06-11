#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace APITemplate.CLI.Commands;

internal static partial class TemplateManagementGetTemplateCommandApiCommand
{
    private static Option<string?> TemplateId { get; } = new(
        name: @"--template-id")
    {
        Description = @"Your template id, it can be obtained in the web console(Manage Templates)",
    };

                    private static string FormatResponse(ParseResult parseResult, global::APITemplate.ResponseSuccessTemplate value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::APITemplate.ResponseSuccessTemplate value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-template", @"Get PDF template
Retrieves information of the PDF template (**This is an experimental API, contact support to learn more**)
");
                        command.Options.Add(TemplateId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var templateId = parseResult.GetValue(TemplateId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.TemplateManagement.GetTemplateAsync(
                                    templateId: templateId,
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