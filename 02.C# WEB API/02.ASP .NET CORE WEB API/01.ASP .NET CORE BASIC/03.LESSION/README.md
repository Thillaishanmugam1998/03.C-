# 03.LESSION README

## Project in this lesson

- `03.LESSION/ProjectStructureSample`

## What is covered here

- `Program.cs` line-by-line purpose
- default ASP.NET Core Web API files and folders
- `launchSettings.json` values and why they are used
- `appsettings.json`
- `appsettings.Development.json`
- `appsettings.Production.json`

## Program.cs

The `Program.cs` file is the startup file of the application.

In this lesson project, comments are added directly inside:

- `03.LESSION/ProjectStructureSample/Program.cs`

It explains:

- why `WebApplication.CreateBuilder(args)` is used
- why `AddControllers()` is needed
- why `AddOpenApi()` is used
- why service registration is done
- why `Build()` is called
- why `IsDevelopment()` is checked
- why `UseHttpsRedirection()` is used
- why `MapControllers()` is required
- why `Run()` is the final step

## launchSettings.json

File:

- `03.LESSION/ProjectStructureSample/Properties/launchSettings.json`

This file is mainly used during local development.

### Important values

`commandName`

- Tells Visual Studio / `dotnet run` how to start the project.

`dotnetRunMessages`

- Shows runtime launch messages in the console.

`launchBrowser`

- Decides whether browser should open automatically after run.

`applicationUrl`

- Sets the local URLs and ports used while running the project.
- Example:
  - `http://localhost:5189`
  - `https://localhost:7099`

`ASPNETCORE_ENVIRONMENT`

- Sets the current environment.
- Here it is `Development`.
- Because of this, `appsettings.Development.json` is loaded on top of `appsettings.json`.

## appsettings.json files

### appsettings.json

- Base configuration file
- Common settings for all environments

Example uses:

- common application settings
- logging settings
- allowed hosts

### appsettings.Development.json

- Used only in Development environment
- Overrides values from `appsettings.json`

Example uses:

- local testing values
- development-only API URLs
- debug-friendly settings

### appsettings.Production.json

- Used only in Production environment
- Overrides values from `appsettings.json`

Example uses:

- production company/project values
- stricter logging
- production-only configuration

## Configuration loading order

ASP.NET Core usually reads configuration like this:

1. `appsettings.json`
2. `appsettings.{Environment}.json`
3. environment variables
4. command-line arguments

That means environment-specific files override base settings.

## Example

If environment is `Development`:

- `appsettings.json` loads first
- `appsettings.Development.json` loads next

If both files contain:

```json
"ApplicationSettings": {
  "CompanyName": "..."
}
```

then Development value wins.

## Why multiple appsettings files are useful

- keeps base config separate
- allows different values for Development and Production
- avoids changing the same file again and again
- makes deployment cleaner

## Simple idea

- `appsettings.json` -> common values
- `appsettings.Development.json` -> local/developer values
- `appsettings.Production.json` -> server/live values
