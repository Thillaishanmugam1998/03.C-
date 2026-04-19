namespace ExceptionHandlingInCSharpApp.Topics;

public static class CustomExceptionsTopic
{
    public static void Display()
    {
        #region Explanation
        // 1. Topic: Custom Exceptions
        // 2. Concept: Built-in exceptions போதாத business rule failures-க்கு own exception class create பண்ணுவது.
        // 3. Real-world analogy: Cinema special warning board "Ticket already used" என்று காட்டுவது.
        // 4. Comparison:
        //    - Special rule violation -> custom exception
        //    - Specific warning message -> meaningful exception name/message
        // 5. Syntax:
        //    public class InsufficientBalanceException : Exception
        //    {
        //        public InsufficientBalanceException(string message) : base(message) { }
        //    }
        // 6. Best practice: Meaningful domain-specific exceptions மட்டும் create பண்ணணும்.
        // 7. Common mistake: தேவையில்லாமல் நிறைய custom exceptions உருவாக்குவது.
        #endregion

        #region RealWorldExample
        // 1. Scenario: Bank withdrawal amount balance-ஐ விட அதிகம்.
        // 2. இந்த business rule violation-க்கு custom exception throw பண்ணுறோம்.
        // 3. Catch பண்ணும் போது error meaning clear-a தெரியும்.
        #endregion

        #region CodeExample
        try
        {
            WithdrawMoney(balance: 1000m, withdrawAmount: 1500m);
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine($"Handled safely: {ex.Message}");
        }
        #endregion

        #region Output
        // 1. Output meaning: Business-specific error custom exception மூலம் handle ஆனது.
        // 2. Error message readable-ஆவும் clear-ஆவும் இருக்கு.
        Console.WriteLine();
        #endregion
    }

    private static void WithdrawMoney(decimal balance, decimal withdrawAmount)
    {
        if (withdrawAmount > balance)
        {
            throw new InsufficientBalanceException(
                $"Withdrawal failed. Balance is {balance:C}, but requested amount is {withdrawAmount:C}.");
        }
    }
}
