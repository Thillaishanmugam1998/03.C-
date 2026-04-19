using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace KestrelServerSample.Controllers;

[ApiController]
[Route("api/[controller]")]
public class KestrelInfoController(IWebHostEnvironment environment, IConfiguration configuration) : ControllerBase
{
    #region 01. GET KESTREL INFORMATION

    // Route: GET /api/kestrelinfo
    // This endpoint returns simple values used to explain Kestrel hosting.
    [HttpGet]
    public IActionResult GetKestrelInfo()
    {
        return Ok(new
        {
            ServerName = configuration["ServerSettings:ServerName"],
            Environment = environment.EnvironmentName,
            ApplicationName = environment.ApplicationName,
            ContentRootPath = environment.ContentRootPath,
            ProcessName = Process.GetCurrentProcess().ProcessName,
            MachineName = Environment.MachineName
        });
    }

    #endregion
}
