#nullable enable

using System.CommandLine;

namespace APITemplate.CLI.Commands;

internal static class TemplateManagementApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"template-management", @"Template Management endpoint commands.");
                         command.Subcommands.Add(TemplateManagementGetTemplateCommandApiCommand.Create());
                         command.Subcommands.Add(TemplateManagementListTemplatesCommandApiCommand.Create());
                         command.Subcommands.Add(TemplateManagementUpdateTemplateCommandApiCommand.Create());
        return command;
    }
}