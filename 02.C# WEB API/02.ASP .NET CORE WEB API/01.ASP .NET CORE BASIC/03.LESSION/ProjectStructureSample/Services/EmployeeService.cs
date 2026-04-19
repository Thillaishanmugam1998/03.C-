using ProjectStructureSample.Models;

namespace ProjectStructureSample.Services;

public class EmployeeService : IEmployeeService
{
    #region 01. GET ALL EMPLOYEES

    public List<Employee> GetAll()
    {
        return
        [
            new Employee { Id = 1, Name = "Arun", Department = "HR" },
            new Employee { Id = 2, Name = "Divya", Department = "IT" },
            new Employee { Id = 3, Name = "Kumar", Department = "Finance" }
        ];
    }

    #endregion
}
