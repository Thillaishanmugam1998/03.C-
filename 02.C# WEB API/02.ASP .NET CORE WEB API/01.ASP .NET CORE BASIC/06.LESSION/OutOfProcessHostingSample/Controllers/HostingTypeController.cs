using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace OutOfProcessHostingSample.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HostingTypeController(IWebHostEnvironment environment, IConfiguration configuration) : ControllerBase
{
    #region 01. GET HOSTING TYPE

    // Route: GET /api/hostingtype
    // This method returns the current process name and a simple hosting-type explanation.
    [HttpGet]
    public IActionResult GetHostingType()
    {
        #region
        //switch (processName)
        //{
        //    case "dotnet":
        //        hostingType = "Out-Of-Process Hosting with Kestrel";
        //        break;
        //    case "iisexpress":
        //    case "w3wp":
        //        hostingType = "In-Process Hosting with IIS / IIS Express";
        //        break;
        //    default:
        //        hostingType = $"Unknown / Custom Process ({processName})";
        //        break;
        //}
        #endregion

        var processName = Process.GetCurrentProcess().ProcessName.ToLower();

        var hostingType = processName switch
        {
            "dotnet" => "Out-Of-Process Hosting with Kestrel",
            "iisexpress" or "w3wp" => "In-Process Hosting with IIS / IIS Express",
            _ => $"Unknown / Custom Process ({processName})"
        };

        return Ok(new
        {
            ConfiguredHostingModel = configuration["Hosting:Model"],
            HostingType = hostingType,
            ProcessName = processName,
            Environment = environment.EnvironmentName,
            ApplicationName = environment.ApplicationName,
            Message = "If the process is dotnet, the app is typically running out of process with Kestrel."
        });
    }

    #endregion
}
