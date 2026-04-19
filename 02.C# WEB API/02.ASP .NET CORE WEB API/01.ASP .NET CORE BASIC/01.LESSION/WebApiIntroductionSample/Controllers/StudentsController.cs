using Microsoft.AspNetCore.Mvc;
using WebApiIntroductionSample.BAL;
using WebApiIntroductionSample.Models;

namespace WebApiIntroductionSample.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentsController : ControllerBase
{
    private readonly StudentBAL studentBAL;

    #region 00. CONSTRUCTOR 
    // Constructor Injection - 
    public StudentsController(StudentBAL _studentBAL)
    {
        studentBAL = _studentBAL;
    }
    #endregion

    #region 01. GET STUDENTS

    // Route: GET /api/students
    // We return Ok(...) so the client gets HTTP 200 with proper JSON data.
    // Returning a plain string here is not a good API practice when we need structured response data.
    [HttpGet]
    public ActionResult<IEnumerable<Student>> GetStudents()
    {
        return Ok(studentBAL.GetAll());
    }

    #endregion

    #region 02. GET STUDENT BY ID

    // Route: GET /api/students/{id}
    // We return different HTTP responses based on the result.
    // Ok(...) means the student exists and data is returned successfully.
    [HttpGet("{id:int}")]
    public ActionResult<Student> GetStudentById(int id)
    {
        var student = studentBAL.GetById(id);

        if (student is null)
        {
            // NotFound(...) sends HTTP 404.
            // This is more specific than returning a normal string like "Student not found".
            return NotFound(new { message = $"Student with id {id} was not found." });
        }

        return Ok(student);
    }

    #endregion

    #region 03. CREATE STUDENT

    // Route: POST /api/students
    // This is the recommended insert method for Web API.
    // We use specific HTTP responses instead of plain string values.
    [HttpPost]
    public ActionResult<Student> CreateStudent(CreateStudentRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Name) || string.IsNullOrWhiteSpace(request.Email) || string.IsNullOrWhiteSpace(request.Course))
        {
            // BadRequest(...) sends HTTP 400 when the client input is invalid.
            // This clearly tells the client that the request data is wrong.
            return BadRequest(new { message = "Name, Email, and Course are required." });
        }

        var student = studentBAL.Add(request);

        // CreatedAtAction(...) sends HTTP 201 Created.
        // It also tells the client which endpoint can be used to fetch the new record.
        return CreatedAtAction(nameof(GetStudentById), new { id = student.Id }, student);
    }

    #endregion

    #region 04. CREATE STUDENT WITH STRING RESPONSE

    // Route: POST /api/students/CreateStudent
    // This method is only for understanding the difference.
    // Here we return plain string messages, so the API still responds with HTTP 200 OK by default.
    // Because of that, the client cannot clearly know whether it is a validation error or a successful insert from the status code alone.
    [HttpPost("CreateStudent")]
    public string CreateStudentWithStringResponse(CreateStudentRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Name) || string.IsNullOrWhiteSpace(request.Email) || string.IsNullOrWhiteSpace(request.Course))
        {
            return "Name, Email, and Course are required."; // HTTP status remains 200 OK by default
        }

        var student = studentBAL.Add(request);

        return "Successfully Inserted"; // HTTP status remains 200 OK by default
    }

    #endregion
}
