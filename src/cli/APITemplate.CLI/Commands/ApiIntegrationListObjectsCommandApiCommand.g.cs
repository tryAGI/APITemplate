#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace APITemplate.CLI.Commands;

internal static partial class ApiIntegrationListObjectsCommandApiCommand
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

    private static Option<string?> TemplateId { get; } = new(
        name: @"--template-id")
    {
        Description = @"Filtered by template id",
    };

    private static Option<string?> TransactionType { get; } = new(
        name: @"--transaction-type")
    {
        Description = @"Filtered by transaction type, options are `PDF`, `JPEG` or `MERGE`",
    };

    private static Option<string?> TransactionRef { get; } = new(
        name: @"--transaction-ref")
    {
        Description = @"Transaction reference",
    };

                    private static string FormatResponse(ParseResult parseResult, global::APITemplate.ResponseSuccessListObjects value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::APITemplate.ResponseSuccessListObjects value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"list-objects", @"List Generated Objects
Retrieves all the generated PDFs and images
");
                        command.Options.Add(Limit);
                        command.Options.Add(Offset);
                        command.Options.Add(TemplateId);
                        command.Options.Add(TransactionType);
                        command.Options.Add(TransactionRef);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var limit = parseResult.GetValue(Limit);
                        var offset = parseResult.GetValue(Offset);
                        var templateId = parseResult.GetValue(TemplateId);
                        var transactionType = parseResult.GetValue(TransactionType);
                        var transactionRef = parseResult.GetValue(TransactionRef);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ApiIntegration.ListObjectsAsync(
                                    limit: limit,
                                    offset: offset,
                                    templateId: templateId,
                                    transactionType: transactionType,
                                    transactionRef: transactionRef,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::APITemplate.SourceGenerationContext.Default,
                                        @"Objects",
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