#nullable enable

using System.CommandLine;

namespace APITemplate.CLI.Commands;

internal static class APIIntegrationApiGroupCommand
{
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
        return command;
    }
}