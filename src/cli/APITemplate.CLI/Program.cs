#nullable enable

using System.CommandLine;
using APITemplate.CLI;
using APITemplate.CLI.Commands;

var rootCommand = new RootCommand(@"CLI tool for the APITemplate SDK.");
rootCommand.Options.Add(CliOptions.ApiKey);
rootCommand.Options.Add(CliOptions.BaseUrl);
rootCommand.Options.Add(CliOptions.Json);
rootCommand.Options.Add(CliOptions.Output);
rootCommand.Options.Add(CliOptions.OutputDirectory);
rootCommand.Subcommands.Add(AuthCommand.Create());
rootCommand.Subcommands.Add(APIIntegrationApiGroupCommand.Create());
rootCommand.Subcommands.Add(PDFManipulationAPIApiGroupCommand.Create());
rootCommand.Subcommands.Add(TemplateManagementApiGroupCommand.Create());

return await rootCommand.Parse(args).InvokeAsync().ConfigureAwait(false);