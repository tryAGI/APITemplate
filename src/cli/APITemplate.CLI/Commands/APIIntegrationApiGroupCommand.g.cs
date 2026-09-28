#nullable enable

using System.CommandLine;

namespace APITemplate.CLI.Commands;

internal static partial class APIIntegrationApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"api-integration", @"API Integration endpoint commands.");
                         command.Subcommands.Add(ApiIntegrationAccountInformationCommandApiCommand.Create());
                         command.Subcommands.Add(ApiIntegrationCreateImageCommandApiCommand.Create());
                         command.Subcommands.Add(ApiIntegrationCreatePdfCommandApiCommand.Create());
                         command.Subcommands.Add(ApiIntegrationCreatePdfFromHtmlCommandApiCommand.Create());
                         command.Subcommands.Add(ApiIntegrationCreatePdfFromMarkdownCommandApiCommand.Create());
                         command.Subcommands.Add(ApiIntegrationCreatePdfFromUrlCommandApiCommand.Create());
                         command.Subcommands.Add(ApiIntegrationDeleteObjectCommandApiCommand.Create());
                         command.Subcommands.Add(ApiIntegrationListObjectsCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}