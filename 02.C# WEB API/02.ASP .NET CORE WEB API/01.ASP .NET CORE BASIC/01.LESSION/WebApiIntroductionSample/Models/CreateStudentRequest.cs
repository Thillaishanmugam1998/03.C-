namespace WebApiIntroductionSample.Models;

public class CreateStudentRequest
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Course { get; set; } = string.Empty;
}
