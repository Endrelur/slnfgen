# SlnfGen

SlnfGen is a .NET console application for maintaining Visual Studio solution filters (`.slnf`) with less manual work.

The goal is to make solution filter generation repeatable, configurable, and easy to run from the command line — for both individual developers and CI pipelines.

## Planned Features

### Generation

- Generate solution filters from solution launch file definitions.
- Generate solution filters from a JSON config format that:
  - targets a specific solution (`.sln` or `.slnx`),
  - defines which projects to include,
  - defines where output files should be written.
- Support both `.sln` and `.slnx` solution formats.
- Optionally resolve and include transitive project references (configurable on/off).
- Glob/wildcard project selection (e.g. `**/Tests/**`) and exclude patterns.
- Named profiles — multiple filter definitions in a single config file (e.g. `backend`, `frontend`, `tests`).
- Config inheritance — base configs that child configs can extend or override.

### Performance

- Optional multithreaded generation mode (configurable on/off).

### Validation & Maintenance

- **Dry-run mode** — preview what filters would be generated without writing any files.
- **Validation mode** — check existing `.slnf` files against the solution to detect stale or missing project references.
- **Diff output** — show what changed between the current and newly generated filter.
- **Watch mode** — monitor the solution file for changes and regenerate filters automatically.
- **CI check mode** — fail if generated filters differ from committed ones (guards against drift).

### CLI Experience

- `generate` — generate filters from config or launch files.
- `init` — scaffold a starter config file interactively.
- `validate` — check existing filters for correctness.
- `list` — show all projects in a solution with their paths.
- Verbose (`-v`) and quiet (`-q`) log levels.
- Meaningful exit codes for CI (0 = success, 1 = validation failure, 2 = config error, etc.).

### Distribution

- Package and distribute as a standalone executable.
- Distribute as a `dotnet tool` (`dotnet tool install slnfgen`).
- Run directly from the command line in local dev and CI scenarios.

## Project Scope

SlnfGen focuses on solution filter maintenance workflows for larger .NET solutions where team members or build pipelines need consistent, automated `.slnf` outputs. It is not a replacement for the solution file itself — it only generates and validates filters on top of an existing solution.

## Status

🚧 Early stage — requirements and feature planning.

Implementation details, usage examples, and a JSON config schema will be added as the application is built.

## License

TBD

