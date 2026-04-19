using Microsoft.AspNetCore.Mvc;
using ProjectStructureSample.Services;

namespace ProjectStructureSample.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeesController(IEmployeeService employeeService, IConfiguration configuration) : ControllerBase
{
    #region 01. GET ALL EMPLOYEES

    // Route: GET /api/employees
    // This method calls the service layer and also reads values from appsettings.json.
    [HttpGet]
    public IActionResult GetEmployees()
    {
        var companyName = configuration["ApplicationSettings:CompanyName"];
        var projectTitle = configuration["ApplicationSettings:ProjectTitle"];
        var employees = employeeService.GetAll();

        return Ok(new
        {
            CompanyName = companyName,
            ProjectTitle = projectTitle,
            Employees = employees
        });
    }

    #endregion
}
