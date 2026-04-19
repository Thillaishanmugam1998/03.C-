# ASP.NET Core In-Process Hosting Model

## 1. Introduction

When an ASP.NET Core Web API application runs on IIS, it can use different hosting models.

One important hosting model is:

- `In-Process Hosting`

This lesson explains what it means, how it works, why it is used, and where it is configured.

Sample project for this lesson:

- `04.LESSION/InProcessHostingSample`

## 2. What is In-Process Hosting?

In the In-Process Hosting Model, the ASP.NET Core application runs:

- inside the IIS worker process

The IIS worker process is:

- `w3wp.exe`

That means IIS and the ASP.NET Core app run in the same process.

## 3. Simple definition

In-Process Hosting means:

- IIS directly hosts the ASP.NET Core app in its own worker process
- request handling stays inside the same process
- there is no extra reverse-proxy hop between IIS and a separate ASP.NET Core process

## 4. How request flow works

In In-Process Hosting:

1. Client sends request
2. IIS receives the request
3. IIS forwards the request directly inside the same worker process
4. ASP.NET Core middleware and controller handle the request
5. Response is sent back through IIS to the client

Simple flow:

`Client -> IIS (same process) -> ASP.NET Core App -> Response`

## 5. What process is used?

For IIS hosting:

- In-Process -> `w3wp.exe`
- The app runs inside IIS worker process

This is different from Out-Of-Process hosting, where ASP.NET Core runs in a separate process such as:

- `dotnet.exe`

## 6. Where is it configured?

In this sample project, it is configured in:

- `InProcessHostingSample.csproj`

Example:

```xml
<AspNetCoreHostingModel>InProcess</AspNetCoreHostingModel>
```

This tells IIS hosting to use the In-Process model.

## 7. Why use In-Process Hosting?

Benefits:

- better performance
- fewer communication layers
- lower request overhead
- simpler request pipeline between IIS and app

Because the app runs in the IIS worker process itself, it is usually faster than Out-Of-Process hosting.

## 8. Important condition

In-Process Hosting is mainly related to:

- IIS hosting

If the app is not hosted on IIS, this setting is not the main factor.

For example:

- if you run using only Kestrel locally, IIS in-process behavior is not the actual hosting path being used

## 9. In-Process vs Out-Of-Process

### In-Process

- app runs inside IIS worker process
- faster
- no reverse proxy hop to separate ASP.NET Core process

### Out-Of-Process

- IIS works as reverse proxy
- ASP.NET Core app runs in separate process
- request goes through IIS and then to Kestrel

Simple comparison:

- In-Process: `Client -> IIS/w3wp -> App`
- Out-Of-Process: `Client -> IIS -> Kestrel/dotnet -> App`

## 10. Files involved

In this sample project:

- `Program.cs` -> starts the Web API application
- `InProcessHostingSample.csproj` -> contains hosting model property
- `Controllers/HostingInfoController.cs` -> simple endpoint for hosting/runtime details
- `appsettings.json` -> contains hosting-related sample value
- `Properties/launchSettings.json` -> local development launch settings

## 11. About Program.cs in this lesson

`Program.cs` still looks normal.

That is important to understand:

- Hosting model is not mostly controlled by writing special code in `Program.cs`
- It is usually controlled by hosting environment and project/publish configuration

So even for In-Process Hosting, `Program.cs` usually contains:

- service registration
- middleware setup
- controller mapping
- app run

## 12. About launchSettings.json

`launchSettings.json` is used for local development.

It defines:

- local URLs
- environment name
- run profile

It does not itself mean the app is running in IIS In-Process in production.

It mainly helps when running locally from Visual Studio or `dotnet run`.

## 13. About appsettings.json

In this sample:

```json
"Hosting": {
  "Model": "InProcess"
}
```

This is only a teaching value in configuration so the sample endpoint can display it.

Important:

- real hosting behavior is not controlled only by this JSON key
- the actual IIS hosting model is controlled by hosting configuration such as the project/publish setup

## 14. Sample endpoint

This lesson includes:

- `GET /api/hostinginfo`

This endpoint returns values like:

- environment name
- application name
- content root path
- configured hosting model text
- current process name

This helps you understand what the application can inspect at runtime.

## 15. Example response

```json
{
  "environment": "Development",
  "applicationName": "InProcessHostingSample",
  "contentRootPath": "D:\\ProjectPath\\04.LESSION\\InProcessHostingSample",
  "hostingModel": "InProcess",
  "currentProcess": "InProcessHostingSample",
  "machineName": "YOUR-MACHINE"
}
```

If hosted in IIS In-Process, the real worker process behavior would be tied to IIS worker process execution.

## 16. Advantages

- high performance
- reduced latency
- fewer moving parts between IIS and app
- efficient request handling

## 17. Limitations / Notes

- mainly meaningful for IIS hosting
- not the same as just running from terminal with `dotnet run`
- configuration must match deployment environment
- runtime process details can differ between local run and IIS deployment

## 18. Summary

ASP.NET Core In-Process Hosting Model means the app runs inside the IIS worker process.

Key points:

- IIS and the ASP.NET Core app run in the same process
- usually configured with `AspNetCoreHostingModel`
- provides better performance than Out-Of-Process in many IIS scenarios
- `Program.cs` does not change much, but hosting configuration matters

If you understand this, it becomes easier to understand how ASP.NET Core apps run behind IIS.
