namespace EncapsulationRealTimeExample;

public class BankAccount
{
    public string AccountHolderName { get; }
    public string AccountNumber { get; }

    // The balance is private so it cannot be changed directly from outside the class.
    private decimal _balance;

    public BankAccount(string accountHolderName, string accountNumber, decimal openingBalance)
    {
        if (string.IsNullOrWhiteSpace(accountHolderName))
        {
            throw new ArgumentException("Account holder name is required.", nameof(accountHolderName));
        }

        if (string.IsNullOrWhiteSpace(accountNumber))
        {
            throw new ArgumentException("Account number is required.", nameof(accountNumber));
        }

        if (openingBalance < 0)
        {
            throw new ArgumentException("Opening balance cannot be negative.", nameof(openingBalance));
        }

        AccountHolderName = accountHolderName;
        AccountNumber = accountNumber;
        _balance = openingBalance;
    }

    // A controlled read-only way to see the balance.
    public decimal GetBalance()
    {
        return _balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit failed: amount must be greater than zero.");
            return;
        }

        _balance += amount;
        Console.WriteLine($"Deposit successful: {amount:C} added to account {AccountNumber}.");
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdrawal failed: amount must be greater than zero.");
            return;
        }

        if (amount > _balance)
        {
            Console.WriteLine("Withdrawal failed: insufficient balance.");
            return;
        }

        _balance -= amount;
        Console.WriteLine($"Withdrawal successful: {amount:C} withdrawn from account {AccountNumber}.");
    }
}
