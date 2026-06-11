#nullable enable

using System.CommandLine;

namespace APITemplate.CLI.Commands;

internal sealed record PDFGenerationSettingsObjectOptionSet(
    Option<string?> PaperSize,
                     Option<string?> CustomWidth,
                     Option<string?> CustomHeight,
                     Option<string?> Orientation,
                     Option<string?> HeaderFontSize,
                     Option<string?> MarginTop,
                     Option<string?> MarginRight,
                     Option<string?> MarginBottom,
                     Option<string?> MarginLeft,
                     Option<string?> PrintBackground,
                     Option<bool?> DisplayHeaderFooter,
                     Option<string?> CustomHeader,
                     Option<string?> CustomFooter)
{
    public static PDFGenerationSettingsObjectOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new PDFGenerationSettingsObjectOptionSet(
                        PaperSize: new Option<string?>($"--{normalizedPrefix}paper-size")
                {
                    Description = @"Specifies the paper size for the PDF. The available options are Letter, Legal, Tabloid, Ledger, A0, A1, A2, A3, A4, A5,A6 or custom. custom dimensions specified as ""custom_width"" and ""custom_height"".
",
                },
                CustomWidth: new Option<string?>($"--{normalizedPrefix}custom-width")
                {
                    Description = @"Custom width for the custom paper size. Valid units are mm, px and cm. eg: 30mm
",
                },
                CustomHeight: new Option<string?>($"--{normalizedPrefix}custom-height")
                {
                    Description = @"Custom height for the custom paper size. Valid units are mm, px and cm. eg: 30mm
",
                },
                Orientation: new Option<string?>($"--{normalizedPrefix}orientation")
                {
                    Description = @"Specifies the orientation of the PDF. The available options are ""1"" for portrait and ""2"" for landscape.
",
                },
                HeaderFontSize: new Option<string?>($"--{normalizedPrefix}header-font-size")
                {
                    Description = @"Specifies the font size for the header in the PDF.
",
                },
                MarginTop: new Option<string?>($"--{normalizedPrefix}margin-top")
                {
                    Description = @"Specify the top margin for the PDF in millimeters (mm).
",
                },
                MarginRight: new Option<string?>($"--{normalizedPrefix}margin-right")
                {
                    Description = @"Specify the right margin for the PDF in millimeters (mm).
",
                },
                MarginBottom: new Option<string?>($"--{normalizedPrefix}margin-bottom")
                {
                    Description = @"Specify the bottom margin for the PDF in millimeters (mm).
",
                },
                MarginLeft: new Option<string?>($"--{normalizedPrefix}margin-left")
                {
                    Description = @"Specify the left margin for the PDF in millimeters (mm).
",
                },
                PrintBackground: new Option<string?>($"--{normalizedPrefix}print-background")
                {
                    Description = @"Specifies whether to print the background graphics and colors in the PDF. Set to ""1"" to include backgrounds or ""0"" to exclude them.
",
                },
                DisplayHeaderFooter: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}display-header-footer", description: @"Specifies whether to display the header and footer in the PDF. Set to true to include the header and footer or false to exclude them.
"),
                CustomHeader: new Option<string?>($"--{normalizedPrefix}custom-header")
                {
                    Description = @"Specify custom HTML markup for the headerof the PDF. These properties should contain valid HTML markup, including any necessary CSS styles.
",
                },
                CustomFooter: new Option<string?>($"--{normalizedPrefix}custom-footer")
                {
                    Description = @"Specify custom HTML markup for the footer of the PDF. These properties should contain valid HTML markup, including any necessary CSS styles.
",
                }
        );
    }
}