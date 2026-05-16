using SlnfGen.App.Configuration.Commands;
using SlnfGen.Utils.Results;

namespace SlnfGen.App.Configuration;

internal static class ConfigInitializer
{
    public static Result<ConfigModuleError> InitializeConfig(InitConfigCommand.Settings settings) =>
        InitializeConfig(settings.Name, settings.SolutionPath, settings.OutputPath, settings.IncludeSchema);

    private static Result<ConfigModuleError> InitializeConfig(string name, string? solutionPath, string? outputPath, bool includeSchema) =>
        throw new NotImplementedException();
}