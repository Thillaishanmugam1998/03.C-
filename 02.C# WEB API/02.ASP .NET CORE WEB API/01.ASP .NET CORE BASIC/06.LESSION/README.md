# Lesson 06 - ASP.NET Core Out Of Process Hosting Model

## Topic

- `ASP.NET Core Out Of Process Hosting Model`

## Sample project

- `06.LESSION/OutOfProcessHostingSample`

## Main idea

If `.csproj` contains:

```xml
<AspNetCoreHostingModel>OutOfProcess</AspNetCoreHostingModel>
```

then:

- the app runs Out-Of-Process
- Kestrel becomes the actual server for the app
- IIS / IIS Express behaves like a proxy
- common process name is `dotnet.exe`

## Controller example

This sample includes:

- `GET /api/hostingtype`

This endpoint returns the process name and a simple hosting-type explanation.
