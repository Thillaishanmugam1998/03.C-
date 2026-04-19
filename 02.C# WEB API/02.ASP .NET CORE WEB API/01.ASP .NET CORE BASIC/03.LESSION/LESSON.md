# Default ASP.NET Core Web API Files and Folders

## 1. Introduction

When we create a new ASP.NET Core Web API project, Visual Studio or `dotnet new webapi` creates some default files and folders.

Understanding these files is very important because every Web API project is built around them.

In this lesson, the sample project is:

- `03.LESSION/ProjectStructureSample`

## 2. Default ASP.NET Core Web API Files and Folders

Common files and folders:

- `Controllers` -> contains controller classes
- `Models` -> contains model classes
- `Services` -> contains business logic or reusable service classes
- `Properties` -> contains launch settings
- `appsettings.json` -> contains configuration values
- `Program.cs` -> application startup file
- `ProjectStructureSample.csproj` -> project file
- `ProjectStructureSample.http` -> request testing file
- `obj` -> generated build-related files
- `bin` -> compiled output files after build

## 3. ASP.NET Core Web API Project File

The project file is:

- `ProjectStructureSample.csproj`

This file tells .NET:

- which SDK is used
- which target framework is used
- which NuGet packages are installed

Example from this project:

```xml
<Project Sdk="Microsoft.NET.Sdk.Web">
  <PropertyGroup>
    <TargetFramework>net10.0</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
  </PropertyGroup>
</Project>
```

Meaning:

- `Microsoft.NET.Sdk.Web` -> this is a web project
- `net10.0` -> target framework
- `Nullable` -> nullable reference type support
- `ImplicitUsings` -> common namespaces added automatically

## 4. ASP.NET Core Web API Main Method

In modern ASP.NET Core Web API projects, we usually do not see a separate `Main()` method written manually.

Instead, `Program.cs` uses top-level statements.

But internally, this is still the application entry point.

In this project, `Program.cs` is responsible for:

- creating the builder
- registering services
- building the app
- configuring middleware
- mapping controllers
- running the application

Main lines:

```csharp
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();
app.MapControllers();
app.Run();
```

## 5. Controllers in ASP.NET Core Web API

Controllers handle incoming HTTP requests.

In this project:

- `Controllers/EmployeesController.cs`

The controller:

- receives client request
- calls the service
- returns the response

Example route:

- `GET /api/employees`

## 6. Models in ASP.NET Core Web API

Models represent data.

In this project:

- `Models/Employee.cs`

This class represents employee data:

```csharp
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
}
```

Models are commonly used for:

- request body
- response body
- database entity structure

## 7. Services in ASP.NET Core Web API

Services contain reusable business logic.

In this project:

- `Services/IEmployeeService.cs`
- `Services/EmployeeService.cs`

Why service is used:

- keeps controller clean
- separates business logic from HTTP handling
- makes project easier to maintain

Example:

- controller calls `employeeService.GetAll()`
- service returns employee data

## 8. ASP.NET Core Web API AppSettings.json file

`appsettings.json` stores configuration values.

In this project:

```json
"ApplicationSettings": {
  "CompanyName": "Thillai Technologies",
  "ProjectTitle": "Project Structure Sample API"
}
```

These values are read in the controller using `IConfiguration`.

Example:

```csharp
var companyName = configuration["ApplicationSettings:CompanyName"];
```

Why `appsettings.json` is useful:

- store application settings
- avoid hardcoding values
- easy to change values later

ASP.NET Core can also use multiple environment-based settings files:

- `appsettings.json` -> common settings for all environments
- `appsettings.Development.json` -> used when environment is `Development`
- `appsettings.Production.json` -> used when environment is `Production`

Loading order usually works like this:

1. `appsettings.json`
2. `appsettings.{Environment}.json`

So environment-specific values override the common values.

Example:

- local machine can use `appsettings.Development.json`
- live server can use `appsettings.Production.json`

This helps us keep different settings for local and production environments.

## 9. launchSettings.json file

`launchSettings.json` is mainly used while running the project locally from Visual Studio or `dotnet run`.

In this project:

- `Properties/launchSettings.json`

Important values:

- `applicationUrl` -> defines the local HTTP and HTTPS URLs
- `launchBrowser` -> controls whether browser opens automatically
- `dotnetRunMessages` -> shows launch information in terminal
- `ASPNETCORE_ENVIRONMENT` -> sets the environment such as `Development`

Why this file is useful:

- controls local run behavior
- sets ports for the app
- helps load the correct environment-based settings file

## 10. How request flow works in this project

Flow:

1. Client sends `GET /api/employees`
2. Request reaches `EmployeesController`
3. Controller calls `IEmployeeService`
4. Service returns employee list
5. Controller reads values from `appsettings.json`
6. Response is returned as JSON

## 11. Sample project structure

Inside `03.LESSION/ProjectStructureSample`:

- `Program.cs`
- `Controllers/EmployeesController.cs`
- `Models/Employee.cs`
- `Services/IEmployeeService.cs`
- `Services/EmployeeService.cs`
- `appsettings.json`
- `appsettings.Development.json`
- `appsettings.Production.json`
- `Properties/launchSettings.json`
- `ProjectStructureSample.csproj`
- `ProjectStructureSample.http`

## 12. Example response

When calling:

```http
GET /api/employees
```

Sample response:

```json
{
  "companyName": "Thillai Technologies",
  "projectTitle": "Project Structure Sample API",
  "employees": [
    {
      "id": 1,
      "name": "Arun",
      "department": "HR"
    },
    {
      "id": 2,
      "name": "Divya",
      "department": "IT"
    }
  ]
}
```

## 13. Summary

In ASP.NET Core Web API:

- `Program.cs` starts the application
- `Controllers` handle HTTP requests
- `Models` represent data
- `Services` contain business logic
- `appsettings.json` stores configuration
- `launchSettings.json` controls local startup behavior
- `appsettings.Development.json` and `appsettings.Production.json` help manage environment-specific values
- `.csproj` defines project settings and packages

If you understand these files and folders, it becomes much easier to read and build Web API projects.
