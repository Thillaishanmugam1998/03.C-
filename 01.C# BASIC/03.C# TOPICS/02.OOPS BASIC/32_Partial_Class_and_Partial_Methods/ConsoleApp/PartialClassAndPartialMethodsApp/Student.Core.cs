namespace PartialClassAndPartialMethodsApp;

internal partial class Student
{
    public Student(string name, string course)
    {
        Name = name;
        Course = course;
        OnCreated();
    }

    public string Name { get; }
    public string Course { get; }

    partial void OnCreated();
}
