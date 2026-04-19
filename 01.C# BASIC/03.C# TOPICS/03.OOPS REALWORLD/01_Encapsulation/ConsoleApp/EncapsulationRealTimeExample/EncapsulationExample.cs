namespace EncapsulationRealTimeExample;

public class EncapsulationExample
{
    public void Run()
    {
        #region Explanation
        Console.WriteLine("ENCAPSULATION - REAL-TIME EXAMPLE");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Encapsulation means hiding sensitive data and allowing access through safe methods.");
        Console.WriteLine("In this example, a bank account protects its balance and only allows valid deposit and withdrawal operations.");
        Console.WriteLine();
        #endregion

        #region RealWorldExample
        Console.WriteLine("Real-World Analogy:");
        Console.WriteLine("Think of an ATM or banking app.");
        Console.WriteLine("You cannot directly open the bank database and change your balance.");
        Console.WriteLine("Instead, you use safe actions like deposit, withdraw, or check balance.");
        Console.WriteLine();
        #endregion

        #region CodeExample
        var account = new BankAccount(
            accountHolderName: "Arun Kumar",
            accountNumber: "SB-1001",
            openingBalance: 10000m);

        Console.WriteLine($"Account Holder : {account.AccountHolderName}");
        Console.WriteLine($"Account Number : {account.AccountNumber}");
        Console.WriteLine($"Opening Balance: {account.GetBalance():C}");
        Console.WriteLine();

        account.Deposit(2500m);
        account.Withdraw(1200m);
        account.Withdraw(15000m);
        account.Deposit(-500m);
        Console.WriteLine();
        #endregion

        #region Output
        Console.WriteLine("Final Output:");
        Console.WriteLine($"Available Balance: {account.GetBalance():C}");
        Console.WriteLine();
        Console.WriteLine("Key Learning:");
        Console.WriteLine("The balance is protected inside the class.");
        Console.WriteLine("Outside code must use the class methods, which enforce the business rules.");
        #endregion
    }
}
