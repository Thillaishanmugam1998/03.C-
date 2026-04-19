namespace OperatorOverloadingApp;

internal class Program
{
    private static void Main()
    {
        #region Explanation
        // Operator overloading lets custom objects work with operators naturally.
        // Here, two Money objects are added using the + operator.
        #endregion

        #region Example
        Money salary = new(25000m);
        Money bonus = new(5000m);
        Money total = salary + bonus;

        Console.WriteLine($"Salary: {salary.Amount:C}");
        Console.WriteLine($"Bonus: {bonus.Amount:C}");
        Console.WriteLine($"Total: {total.Amount:C}");
        #endregion

        #region Output
        Console.WriteLine();
        Console.WriteLine("Expected learning outcome:");
        Console.WriteLine("1. Custom objects can define operator behavior.");
        Console.WriteLine("2. The + operator can be made meaningful for domain types.");
        #endregion
    }
}

internal sealed class Money
{
    public Money(decimal amount)
    {
        Amount = amount;
    }

    public decimal Amount { get; }

    public static Money operator +(Money left, Money right)
    {
        return new Money(left.Amount + right.Amount);
    }
}
