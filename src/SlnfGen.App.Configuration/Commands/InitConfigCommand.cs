using System.ComponentModel;
using System.Text.Json.Schema;
using Spectre.Console.Cli;
// ReSharper disable ClassNeverInstantiated.Global

namespace SlnfGen.App.Configuration.Commands;

[Description("Initialize a new configuration file")]
public class InitConfigCommand : Command<InitConfigCommand.Settings>
{
    public sealed class Settings : CommandSettings
    {
        [CommandArgument(0, "<NAME>")]
        [Description("Name of config file to generate")]
        public string Name  { get; set; } = string.Empty;
        
        [CommandOption("-s|--solution <SOLUTION>")]
        [Description("Generate config for solution")]
        public string? SolutionPath { get; set; }
        
        [CommandOption("-o|--output <CONFIG_PATH>")]
        [Description("Path to where the config file should be generated")]
        public string? OutputPath { get; set; }

        [CommandOption("--include-schema")]
        [Description("Include JSON schema in generated config file")]
        public bool IncludeSchema { get; set; } = false;
    }

    protected override int Execute(CommandContext context, Settings settings, CancellationToken cancellationToken) =>
        throw new NotImplementedException();
}