using SlnfGen.App.Configuration.Commands;
using Spectre.Console;
using Spectre.Console.Cli;

var app = new CommandApp();

app.Configure(config =>
{
    config.SetApplicationName("slnfgen");
    config.ValidateExamples();

    config.AddCommand<InitConfigCommand>("init-config");
});

await app.RunAsync(args);