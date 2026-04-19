namespace GeneralizationAndSpecializationApp;

internal class Program
{
    private static void Main()
    {
        #region Explanation
        // Generalization moves common features into a base class.
        // Specialization adds specific behavior in child classes.
        #endregion

        #region Example
        SavingsAccount savings = new() { AccountNumber = "SB1001", Balance = 10000m, InterestRate = 6.5m };
        CurrentAccount current = new() { AccountNumber = "CA2001", Balance = 25000m, OverdraftLimit = 5000m };

        savings.ShowCommonDetails();
        savings.ShowSavingsDetails();

        current.ShowCommonDetails();
        current.ShowCurrentDetails();
        #endregion

        #region Output
        Console.WriteLine();
        Console.WriteLine("Expected learning outcome:");
        Console.WriteLine("1. BankAccount contains generalized common members.");
        Console.WriteLine("2. SavingsAccount and CurrentAccount contain specialized members.");
        #endregion
    }
}

internal class BankAccount
{
    public string AccountNumber { get; set; } = string.Empty;
    public decimal Balance { get; set; }

    public void ShowCommonDetails()
    {
        Console.WriteLine($"Account Number: {AccountNumber}, Balance: {Balance:C}");
    }
}

internal class SavingsAccount : BankAccount
{
    public decimal InterestRate { get; set; }

    public void ShowSavingsDetails()
    {
        Console.WriteLine($"Savings Interest Rate: {InterestRate}%");
    }
}

internal class CurrentAccount : BankAccount
{
    public decimal OverdraftLimit { get; set; }

    public void ShowCurrentDetails()
    {
        Console.WriteLine($"Current Account Overdraft Limit: {OverdraftLimit:C}");
    }
}
