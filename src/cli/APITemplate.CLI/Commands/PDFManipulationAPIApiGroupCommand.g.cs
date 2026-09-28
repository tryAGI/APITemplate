#nullable enable

using System.CommandLine;

namespace APITemplate.CLI.Commands;

internal static partial class PDFManipulationAPIApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"pdf-manipulation-api", @"PDF Manipulation API endpoint commands.");
                         command.Subcommands.Add(PdfManipulationApiMergePdfsCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}