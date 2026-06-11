#nullable enable

using System.CommandLine;

namespace APITemplate.CLI.Commands;

internal static class PDFManipulationAPIApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"pdf-manipulation-api", @"PDF Manipulation API endpoint commands.");
                         command.Subcommands.Add(PdfManipulationApiMergePdfsCommandApiCommand.Create());
        return command;
    }
}