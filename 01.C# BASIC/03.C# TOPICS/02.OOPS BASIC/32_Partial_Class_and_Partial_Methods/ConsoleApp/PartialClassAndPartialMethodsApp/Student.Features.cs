namespace PartialClassAndPartialMethodsApp;

internal partial class Student
{
    public void ShowDetails()
    {
        Console.WriteLine($"Student: {Name}, Course: {Course}");
    }

    partial void OnCreated()
    {
        Console.WriteLine("Student object created through partial class parts.");
    }
}
