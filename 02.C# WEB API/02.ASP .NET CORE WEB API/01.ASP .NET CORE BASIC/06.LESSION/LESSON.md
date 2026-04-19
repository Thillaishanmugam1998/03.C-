# Lesson 06 - ASP.NET Core Out Of Process Hosting Model

## 1. Introduction

ASP.NET Core applications hosted with IIS can run in two major ways:

- In-Process
- Out-Of-Process

This lesson explains the Out-Of-Process Hosting Model in a simple way.

Sample project:

- `06.LESSION/OutOfProcessHostingSample`

## 2. What is Out-Of-Process Hosting?

In Out-Of-Process Hosting:

- the ASP.NET Core application runs in a separate process
- Kestrel handles the application requests
- IIS or IIS Express forwards the request to Kestrel

Simple flow:

`Client -> IIS / IIS Express -> Kestrel -> ASP.NET Core App -> Response`

## 3. Which process is used?

When the app runs Out-Of-Process, the common process is:

- `dotnet.exe`

That means the app is not running directly inside `iisexpress.exe` or `w3wp.exe`.

## 4. Why is it called Out-Of-Process?

It is called Out-Of-Process because:

- the ASP.NET Core app runs outside the IIS worker process
- IIS is only forwarding the request
- the actual app work happens in a separate process

## 5. Where is it configured?

In this sample project:

- `OutOfProcessHostingSample.csproj`

contains:

```xml
<AspNetCoreHostingModel>OutOfProcess</AspNetCoreHostingModel>
```

This explicitly sets the hosting model as Out-Of-Process.

## 6. What is the role of Kestrel here?

In Out-Of-Process Hosting:

- Kestrel becomes the actual ASP.NET Core web server
- IIS / IIS Express works like a proxy or forwarder

So:

- `OutOfProcess` -> `Kestrel`

## 7. Out-Of-Process vs In-Process

| Item | In-Process | Out-Of-Process |
|---|---|---|
| Actual app hosting | IIS / IIS Express | Kestrel |
| Common process name | `iisexpress.exe` or `w3wp.exe` | `dotnet.exe` |
| Request path | `Client -> IIS -> App` | `Client -> IIS -> Kestrel -> App` |
| Performance | Faster | Slightly less than In-Process |

## 8. When is Out-Of-Process useful?

Out-Of-Process is useful when:

- Kestrel is the main server
- reverse proxy style hosting is used
- cross-platform style understanding is needed
- flexible deployment is preferred

## 9. Sample project files

Inside `06.LESSION/OutOfProcessHostingSample`:

- `Program.cs`
- `OutOfProcessHostingSample.csproj`
- `Controllers/HostingTypeController.cs`
- `appsettings.json`
- `Properties/launchSettings.json`
- `OutOfProcessHostingSample.http`

## 10. Controller example in this lesson

This lesson includes:

- `GET /api/hostingtype`

This controller method returns:

- configured hosting model
- detected hosting type
- current process name
- environment
- application name

This helps you understand what type of hosting is being used at runtime.

## 11. Example response

```json
{
  "configuredHostingModel": "OutOfProcess",
  "hostingType": "Out-Of-Process Hosting with Kestrel",
  "processName": "dotnet",
  "environment": "Development",
  "applicationName": "OutOfProcessHostingSample",
  "message": "If the process is dotnet, the app is typically running out of process with Kestrel."
}
```

## 12. Important note

`http`, `https`, `IIS Express`, and `WSL` are run profiles or run choices.

They are not the same as:

- `InProcess`
- `OutOfProcess`

Those two are hosting models.

## 13. Summary

ASP.NET Core Out-Of-Process Hosting means:

- the app runs in a separate process
- Kestrel handles the requests
- IIS / IIS Express forwards the request

Short form:

- `OutOfProcess` -> `Kestrel`
- common process -> `dotnet.exe`
