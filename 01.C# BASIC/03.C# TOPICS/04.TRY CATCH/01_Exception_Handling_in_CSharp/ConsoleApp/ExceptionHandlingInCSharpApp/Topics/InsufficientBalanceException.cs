namespace ExceptionHandlingInCSharpApp.Topics;

public sealed class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message)
        : base(message)
    {
    }
}
