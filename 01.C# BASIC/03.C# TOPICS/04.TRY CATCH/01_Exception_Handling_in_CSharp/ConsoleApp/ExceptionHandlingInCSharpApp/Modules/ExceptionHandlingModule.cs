using ExceptionHandlingInCSharpApp.Topics;

namespace ExceptionHandlingInCSharpApp.Modules;

public static class ExceptionHandlingModule
{
    public static void Run()
    {
        Console.Title = "04 Exception Handling";

        ExceptionHandlingInCSharpTopic.Display();
        MultipleCatchBlocksTopic.Display();
        FinallyBlockTopic.Display();
        CustomExceptionsTopic.Display();
        InnerExceptionTopic.Display();
        ExceptionHandlingAbuseTopic.Display();
    }
}
