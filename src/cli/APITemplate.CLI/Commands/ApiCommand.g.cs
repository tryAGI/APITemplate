#nullable enable

using System.CommandLine;

namespace APITemplate.CLI.Commands;

internal static partial class ApiCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command("api", "Generated endpoint commands.");

                         command.Subcommands.Add(APIIntegrationApiGroupCommand.Create());
                         command.Subcommands.Add(PDFManipulationAPIApiGroupCommand.Create());
                         command.Subcommands.Add(TemplateManagementApiGroupCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}