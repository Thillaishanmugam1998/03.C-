using WebApiIntroductionSample.Models;

namespace WebApiIntroductionSample.BAL;

public class StudentBAL
{
    private readonly List<Student> _students =
    [
        new Student { Id = 1, Name = "Arun", Email = "arun@example.com", Course = "ASP.NET Core" },
        new Student { Id = 2, Name = "Divya", Email = "divya@example.com", Course = "Web API Basics" }
    ];

    private int _nextId = 3;

    #region 01. GET ALL STUDENTS

    public List<Student> GetAll()
    {
        return _students;
    }

    #endregion

    #region 02. GET STUDENT BY ID

    public Student? GetById(int id)
    {
        return _students.FirstOrDefault(student => student.Id == id);
    }

    #endregion

    #region 03. ADD STUDENT

    public Student Add(CreateStudentRequest request)
    {
        var student = new Student
        {
            Id = _nextId++,
            Name = request.Name,
            Email = request.Email,
            Course = request.Course
        };

        _students.Add(student);
        return student;
    }

    #endregion
}
