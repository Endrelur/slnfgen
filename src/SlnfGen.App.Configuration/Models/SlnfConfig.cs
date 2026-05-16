using System.ComponentModel;
// ReSharper disable ClassNeverInstantiated.Global

namespace SlnfGen.App.Configuration.Models;

[Description("Configuration for generating a solutionfilter (slnf)")]
public record SlnfConfig(
    [property: Description("Absolute or relative path to the solution (.slnx, .sln)")]
    string SolutionPath,
    [property: Description("List of projects to include in the solutionfilter (slnf)")]
    SlnfProjectConfig[] Projects,
    
    [property: Description("Output folder to the the generated solutionfilter (slnf), placed besides config if not provided.")]
    string? OutputFolderPath = null,
    [property: Description("Whether missing folders should be generated or not, defaults to true.")]
    bool CreateFolders = true
);

[Description("Configuration for a project to include in the solutionfilter (slnf)")]
public record SlnfProjectConfig(
    [property: Description("Name of the project to include in the solutionfilter (slnf)")]
    string ProjectName,
    [property: Description("Whether to include transient projects (i.e. project references) in the generated solutionfilter (slnf), defaults to true.")]
    bool IncludeTransientProjects = false
);