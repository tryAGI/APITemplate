#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace APITemplate.CLI.Commands;

internal static partial class TemplateManagementListTemplatesCommandApiCommand
{
    private static Option<string?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Retrieve only the number of records specified. Default to 300",
    };

    private static Option<string?> Offset { get; } = new(
        name: @"--offset")
    {
        Description = @"Offset is used to skip the number of records from the results. Default to 0",
    };

    private static Option<string?> Format { get; } = new(
        name: @"--format")
    {
        Description = @"To filter the templates by either 'PDF' or 'JPEG'",
    };

    private static Option<string?> TemplateId { get; } = new(
        name: @"--template-id")
    {
        Description = @"To filter the templates by template id",
    };

    private static Option<string?> GroupName { get; } = new(
        name: @"--group-name")
    {
        Description = @"To filter the templates by the group name",
    };

    private static Option<string?> WithLayerInfo { get; } = new(
        name: @"--with-layer-info")
    {
        Description = @"Return along with layer information for image templates, 0=false , 1=true. Default to '0'",
    };

                    private static string FormatResponse(ParseResult parseResult, global::APITemplate.ResponseSuccessListTemplates value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::APITemplate.ResponseSuccessListTemplates value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"list-templates", @"List Templates
Retrieves the information of templates
");
                        command.Options.Add(Limit);
                        command.Options.Add(Offset);
                        command.Options.Add(Format);
                        command.Options.Add(TemplateId);
                        command.Options.Add(GroupName);
                        command.Options.Add(WithLayerInfo);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var limit = parseResult.GetValue(Limit);
                        var offset = parseResult.GetValue(Offset);
                        var format = parseResult.GetValue(Format);
                        var templateId = parseResult.GetValue(TemplateId);
                        var groupName = parseResult.GetValue(GroupName);
                        var withLayerInfo = parseResult.GetValue(WithLayerInfo);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.TemplateManagement.ListTemplatesAsync(
                                    limit: limit,
                                    offset: offset,
                                    format: format,
                                    templateId: templateId,
                                    groupName: groupName,
                                    withLayerInfo: withLayerInfo,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::APITemplate.SourceGenerationContext.Default,
                                        @"Templates",
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