using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace InProcessHostingSample.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HostingInfoController(IWebHostEnvironment environment, IConfiguration configuration) : ControllerBase
{
    #region 01. GET HOSTING INFORMATION

    // Route: GET /api/hostinginfo
    // This endpoint returns runtime values that help explain hosting behavior.
    [HttpGet]
    public IActionResult GetHostingInfo()
    {
        return Ok(new
        {
            Environment = environment.EnvironmentName,
            ApplicationName = environment.ApplicationName,
            ContentRootPath = environment.ContentRootPath,
            HostingModel = configuration["Hosting:Model"],
            CurrentProcess = Process.GetCurrentProcess().ProcessName,
            MachineName = Environment.MachineName
        });
    }

    #endregion
}
