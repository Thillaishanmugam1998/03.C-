namespace EncapsulationApp;

internal class Program
{
    private static void Main()
    {
        #region Explanation
        // Encapsulation protects object data by exposing controlled methods.
        // Outside code cannot directly change important internal fields.
        #endregion

        #region Example
        BankAccount account = new("Nila");
        account.Deposit(2500m);
        account.Withdraw(500m);
        Console.WriteLine($"Available Balance: {account.GetBalance():C}");
        #endregion

        #region Output
        Console.WriteLine();
        Console.WriteLine("Expected learning outcome:");
        Console.WriteLine("1. Balance is hidden from direct external modification.");
        Console.WriteLine("2. Public methods validate and control updates.");
        #endregion
    }
}

internal class BankAccount
{
    private decimal _balance;
    public string AccountHolder { get; }

    public BankAccount(string accountHolder)
    {
        AccountHolder = accountHolder;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit must be greater than zero.");
            return;
        }

        _balance += amount;
        Console.WriteLine($"{AccountHolder} deposited {amount:C}.");
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0 || amount > _balance)
        {
            Console.WriteLine("Invalid withdrawal amount.");
            return;
        }

        _balance -= amount;
        Console.WriteLine($"{AccountHolder} withdrew {amount:C}.");
    }

    public decimal GetBalance()
    {
        return _balance;
    }
}
