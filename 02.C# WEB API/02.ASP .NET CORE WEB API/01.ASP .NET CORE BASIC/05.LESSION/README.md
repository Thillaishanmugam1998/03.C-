# Lesson 05 - ASP.NET Core Kestrel Web Server

## Topic

- `ASP.NET Core Kestrel Web Server`

## Sample project

- `05.LESSION/KestrelServerSample`

## Main files

- `Program.cs`
- `Controllers/KestrelInfoController.cs`
- `appsettings.json`
- `Properties/launchSettings.json`
- `KestrelServerSample.http`

## 1. First basic idea

When an ASP.NET Core Web API runs, the important question is:

- which web server is handling the HTTP requests?

There are two important servers to understand here:

- `IIS / IIS Express`
- `Kestrel`

### IIS / IIS Express

- mainly Windows-based
- Visual Studio commonly uses `IIS Express` for local development

### Kestrel

- default web server that comes with ASP.NET Core
- cross-platform
- works on Windows, Linux, and macOS

## 2. What is In-Process Hosting?

In In-Process Hosting:

- your API runs inside `IIS` or `IIS Express`
- no separate Kestrel process is needed for request handling
- everything runs in the same process
- performance is usually better

Simple idea:

- API runs inside `iisexpress.exe` or `w3wp.exe`

### How to identify it

Open:

- `Task Manager`
- `Details` tab

If you see:

- `iisexpress.exe`
- or `w3wp.exe`

then it is:

- `In-Process Hosting`

## 3. What is Out-Of-Process Hosting?

In Out-Of-Process Hosting:

- your API runs in a separate process
- Kestrel handles the application requests
- IIS / IIS Express acts like a forwarder or proxy
- request flow becomes `IIS -> Kestrel -> App`

Simple idea:

- API runs inside `dotnet.exe`

### How to identify it

If you see:

- `dotnet.exe`

then it is usually:

- `Out-Of-Process Hosting`
- with `Kestrel`

## 4. Your current normal Visual Studio situation

If you normally:

- open Visual Studio
- select `IIS Express`
- click the Run button

then usually your API runs as:

- `In-Process Hosting`

That means:

- Server -> `IIS Express`
- Process name -> `iisexpress.exe`

## 5. Very important note about Kestrel

Kestrel is the default ASP.NET Core web server.

If you run using:

- `http`
- `https`
- `dotnet run`

then the app usually runs with:

- `Kestrel`

But if you run with:

- `IIS Express`

then your local development flow is usually:

- `In-Process` with `IIS Express`

So:

- `Kestrel` and `In-Process` are not the same thing
- `IIS Express` and `Kestrel` are not the same thing

## 6. One-view comparison

| Item | In-Process Hosting | Out-Of-Process Hosting |
|---|---|---|
| Which server handles app hosting? | `IIS / IIS Express` | `Kestrel` |
| Process name | `iisexpress.exe` or `w3wp.exe` | `dotnet.exe` |
| Performance | Faster | Slightly less than In-Process |
| Normal Visual Studio IIS Express run | Yes | No |
| Good for | Windows + IIS setup | Flexible hosting, Linux, proxy-based hosting |

## 7. Very short conclusion

If you are asking:

- "I am using Visual Studio normally"
- "I selected IIS Express"
- "What is my hosting type?"

Then the simple answer is:

- `In-Process Hosting`

If you are asking:

- "When does Kestrel come directly?"

Then the answer is:

- when you run with `http`
- when you run with `https`
- when you use `dotnet run`

## 8. Final clear understanding

- `IIS Express` run -> usually `In-Process`
- `dotnet run` -> usually `Kestrel`
- `http / https` -> run profiles
- `InProcess / OutOfProcess` -> hosting model
- `Kestrel` -> web server

These are related, but all are not equal.

## 9. If `.csproj` contains `OutOfProcess`

If you add this in `.csproj`:

```xml
<PropertyGroup>
  <AspNetCoreHostingModel>OutOfProcess</AspNetCoreHostingModel>
</PropertyGroup>
```

then the hosting model becomes:

- `Out-Of-Process`

In that case:

- the ASP.NET Core app runs with `Kestrel`
- IIS or IIS Express works like a proxy / forwarder
- the real app process is usually `dotnet.exe`

### Simple table

| What is in `.csproj`? | Hosting Model | Actual server used for app | Common process name |
|---|---|---|---|
| Nothing / default or `InProcess` | `In-Process` | `IIS / IIS Express` | `iisexpress.exe` or `w3wp.exe` |
| `OutOfProcess` | `Out-Of-Process` | `Kestrel` | `dotnet.exe` |

### Very simple meaning

If you write:

```xml
<AspNetCoreHostingModel>OutOfProcess</AspNetCoreHostingModel>
```

then:

- Kestrel becomes the active server for the ASP.NET Core app
- IIS / IIS Express only forwards the request
- request flow becomes:

`Client -> IIS / IIS Express -> Kestrel -> ASP.NET Core App`

### Short conclusion

- `OutOfProcess` -> `Kestrel`
- `InProcess` -> `IIS / IIS Express`
