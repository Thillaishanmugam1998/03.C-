namespace WhyWeNeedConstructorsApp;

internal class Program
{
    private static void Main()
    {
        #region Explanation
        // Constructors are useful because they ensure an object gets required values at creation time.
        // This avoids incomplete or invalid objects.
        #endregion

        #region Example
        BankAccount savingsAccount = new("Kavin", 5000m);
        savingsAccount.ShowSummary();
        #endregion

        #region Output
        Console.WriteLine();
        Console.WriteLine("Expected learning outcome:");
        Console.WriteLine("1. Required data is provided at the time of object creation.");
        Console.WriteLine("2. The object starts in a valid and meaningful state.");
        #endregion
    }
}

internal class BankAccount
{
    public string AccountHolder { get; }
    public decimal Balance { get; }

    public BankAccount(string accountHolder, decimal openingBalance)
    {
        AccountHolder = accountHolder;
        Balance = openingBalance;
    }

    public void ShowSummary()
    {
        Console.WriteLine($"Account Holder: {AccountHolder}");
        Console.WriteLine($"Opening Balance: {Balance:C}");
    }
}
