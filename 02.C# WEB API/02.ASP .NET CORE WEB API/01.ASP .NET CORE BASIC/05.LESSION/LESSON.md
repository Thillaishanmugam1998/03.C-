# Lesson 05 - ASP.NET Core Kestrel Web Server

## 1. Introduction

Kestrel is the default cross-platform web server used by ASP.NET Core applications.

Whenever we run an ASP.NET Core Web API using:

- `dotnet run`
- Visual Studio `http`
- Visual Studio `https`

the application usually runs with Kestrel.

Sample project for this lesson:

- `05.LESSION/KestrelServerSample`

## 2. What is Kestrel?

Kestrel is:

- a lightweight web server
- a fast web server
- a cross-platform web server
- the default web server for ASP.NET Core

It can run on:

- Windows
- Linux
- macOS

## 3. Why Kestrel is important

ASP.NET Core applications need a web server to accept HTTP requests.

Kestrel does that job.

It:

- listens on ports
- receives requests
- sends responses
- works with ASP.NET Core middleware pipeline

## 4. Simple request flow

When using Kestrel directly:

`Client -> Kestrel -> ASP.NET Core App -> Response`

If IIS is used as reverse proxy:

`Client -> IIS -> Kestrel -> ASP.NET Core App -> Response`

So Kestrel is the actual ASP.NET Core web server in many cases.

## 5. Kestrel and local development

When you run the project using:

- `http`
- `https`
- `dotnet run`

you are typically running with Kestrel.

That is why local ASP.NET Core applications often show localhost URLs such as:

- `http://localhost:5254`
- `https://localhost:7191`

## 6. Kestrel vs IIS

### Kestrel

- built for ASP.NET Core
- cross-platform
- handles HTTP requests directly
- commonly used in local run and Linux hosting

### IIS

- Windows web server
- can work in front of ASP.NET Core
- may host or proxy requests depending on hosting model

Simple idea:

- Kestrel = ASP.NET Core web server
- IIS = Windows web server / reverse proxy / host depending on setup

## 7. Is Kestrel enough?

Yes, Kestrel can run the app by itself.

But in production, many teams place it behind:

- IIS
- Nginx
- Apache

Why:

- reverse proxy support
- security features
- load balancing
- easier enterprise hosting setup

## 8. Where Kestrel is configured

By default, ASP.NET Core uses Kestrel automatically.

You often do not need to write special configuration just to use it.

The application starts with:

```csharp
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.Run();
```

This is enough for normal Kestrel hosting.

## 9. How ports are decided

Ports are usually controlled by:

- `launchSettings.json` during local development
- environment variables
- command-line arguments
- explicit Kestrel configuration

In this sample:

- `Properties/launchSettings.json`

contains the local HTTP and HTTPS URLs.

## 10. launchSettings.json and Kestrel

Example:

```json
"applicationUrl": "https://localhost:7191;http://localhost:5254"
```

This tells the application which local URLs to listen on during development.

When you run with the `http` or `https` profile in Visual Studio, Kestrel uses these URLs.

## 11. Sample project files

Inside `05.LESSION/KestrelServerSample`:

- `Program.cs` -> app startup
- `Controllers/KestrelInfoController.cs` -> sample endpoint
- `appsettings.json` -> contains simple server name value
- `Properties/launchSettings.json` -> local URLs
- `KestrelServerSample.http` -> test request file
- `KestrelServerSample.csproj` -> project file

## 12. Sample endpoint

This lesson includes:

- `GET /api/kestrelinfo`

It returns:

- configured server name
- environment
- application name
- content root path
- process name
- machine name

This helps us understand the runtime environment when the app is running with Kestrel.

## 13. Example response

```json
{
  "serverName": "Kestrel",
  "environment": "Development",
  "applicationName": "KestrelServerSample",
  "contentRootPath": "D:\\ProjectPath\\05.LESSION\\KestrelServerSample",
  "processName": "KestrelServerSample",
  "machineName": "YOUR-MACHINE"
}
```

If you run with `dotnet run`, the process may also appear as `dotnet` depending on the runtime style.

## 14. Advantages of Kestrel

- fast
- lightweight
- cross-platform
- good performance
- built for ASP.NET Core

## 15. Important note

Kestrel is not the same as:

- `http` profile
- `https` profile
- `IIS Express`

Those are run profiles or hosting choices.

Kestrel is the web server itself.

## 16. Summary

Kestrel is the default web server for ASP.NET Core.

Key points:

- it accepts HTTP requests
- it runs ASP.NET Core apps
- it is used in local development
- it can run directly or behind IIS / Nginx / Apache

If you understand Kestrel, you understand how ASP.NET Core Web API starts receiving requests.
