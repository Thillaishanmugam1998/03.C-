# 04.LESSION README

## Topic

- `ASP.NET Core In-Process Hosting Model`

## Lesson files

- `04.LESSION/LESSON.md`
- `04.LESSION/InProcessHostingSample`

## Main files to see

- `InProcessHostingSample.csproj`
- `Program.cs`
- `Controllers/HostingInfoController.cs`
- `appsettings.json`
- `Properties/launchSettings.json`

## What is In-Process Hosting?

In-Process Hosting means:

- the ASP.NET Core app runs inside the IIS worker process itself
- request handling happens inside the same IIS process
- this usually gives better performance than Out-Of-Process hosting

Process names:

- `iisexpress.exe` -> IIS Express In-Process
- `w3wp.exe` -> IIS In-Process
- `dotnet.exe` -> usually Out-Of-Process / Kestrel-based run

## How to identify whether the app is In-Process or Out-Of-Process

### 1. Best and easiest way: Task Manager

Run the project using:

- `IIS Express`
- or full `IIS`

Open:

- `Task Manager`
- `Details` tab

Then check the process name:

| Process Name | Hosting Model | Meaning |
|---|---|---|
| `iisexpress.exe` | `In-Process` | App is running inside IIS Express |
| `w3wp.exe` | `In-Process` | App is running inside IIS |
| `dotnet.exe` | `Out-Of-Process` | App is running separately and IIS works like a reverse proxy |

Simple rule:

- `iisexpress.exe` or `w3wp.exe` -> `In-Process`
- `dotnet.exe` -> `Out-Of-Process`

## Check using code

You can also create an endpoint and inspect the current process:

```csharp
using System.Diagnostics;

[HttpGet("hosting")]
public IActionResult GetHostingModel()
{
    string processName = Process.GetCurrentProcess().ProcessName.ToLower();

    string hostingModel = processName switch
    {
        "w3wp" or "iisexpress" => "In-Process Hosting (IIS)",
        "dotnet" => "Out-of-Process Hosting (Kestrel)",
        _ => "Unknown - " + processName
    };

    return Ok(new
    {
        HostingModel = hostingModel,
        ProcessName = processName,
        Message = "In-Process is faster and recommended when using IIS"
    });
}
```

## Check in `.csproj`

If the project file contains:

```xml
<AspNetCoreHostingModel>InProcess</AspNetCoreHostingModel>
```

then the hosting model is explicitly set to `In-Process`.

If it contains:

```xml
<AspNetCoreHostingModel>OutOfProcess</AspNetCoreHostingModel>
```

then the hosting model is explicitly set to `Out-Of-Process`.

## If `AspNetCoreHostingModel` is not mentioned

This is the most important doubt.

If:

- `.csproj` does not contain `AspNetCoreHostingModel`
- you run the app normally with `IIS Express`
- or host it with IIS

then in modern ASP.NET Core IIS hosting, you can generally treat it as:

- `In-Process Hosting`

So for normal Visual Studio + `IIS Express` use:

- no explicit tag
- normal run
- result is usually `In-Process`

## Very important difference: Run profile vs Hosting model

These are not the same.

### Run profiles

Examples:

- `http`
- `https`
- `IIS Express`
- `WSL`

These decide:

- how Visual Studio starts the project
- which URL/profile/environment is used

### Hosting model

Examples:

- `InProcess`
- `OutOfProcess`

These decide:

- how the app is hosted in IIS / IIS Express
- whether the app runs inside IIS process or in a separate process

So:

- `IIS Express` = run profile
- `InProcess` = hosting model

Both are different. They are not equal.

## About `http`, `https`, `IIS Express`, and `WSL`

### `http`

- local run profile
- runs using HTTP URL

### `https`

- local run profile
- runs using HTTPS URL

### `IIS Express`

- Visual Studio development host based on IIS Express
- useful for IIS-style local testing

### `WSL`

- runs the project inside Windows Subsystem for Linux

These options are launch/run choices.
They do not by themselves mean In-Process or Out-Of-Process.

## About `dotnet run`

If you run using:

```powershell
dotnet run
```

then the app usually runs directly with Kestrel.

In that case:

- IIS hosting model question is not the main thing
- you are not using IIS Express as the hosting path

## In this sample project

This lesson project explicitly uses:

```xml
<AspNetCoreHostingModel>InProcess</AspNetCoreHostingModel>
```

File:

- `04.LESSION/InProcessHostingSample/InProcessHostingSample.csproj`

So this sample is configured clearly for learning.

## Final conclusion

If you ask:

- "I did not mention anything in `.csproj`"
- "I ran normally with IIS Express"
- "What hosting model is it?"

The simple answer is:

- `In-Process Hosting`

If you want to confirm:

1. Run with `IIS Express`
2. Open `Task Manager`
3. Check `iisexpress.exe`

That is the easiest confirmation.
