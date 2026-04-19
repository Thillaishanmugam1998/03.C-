namespace ExceptionHandlingInCSharpApp.Topics;

public static class MultipleCatchBlocksTopic
{
    public static void Display()
    {
        #region Explanation
        // 1. Topic: Multiple Catch Blocks
        // 2. Concept: ஒரே try block-ல் different exception types வரலாம்.
        // 3. Real-world analogy: Billing issue billing team-kku, technical issue technical team-kku போகும்.
        // 4. Comparison:
        //    - Different teams -> different catch blocks
        //    - Correct routing -> matching exception catch
        // 5. Syntax:
        //    try { }
        //    catch (FormatException) { }
        //    catch (DivideByZeroException) { }
        // 6. Best practice: Specific catch first, generic catch last.
        // 7. Common mistake: catch (Exception) first வைப்பது.
        #endregion

        #region RealWorldExample
        // 1. Scenario: Loan calculator number of months read பண்ணுது.
        // 2. Months "0"னா divide by zero issue வரும்.
        // 3. Months "abc"னா format issue வரும்.
        // 4. ஒவ்வொரு error-க்கும் separate catch block எழுதலாம்.
        #endregion

        #region CodeExample
        try
        {
            var monthsText = "0";
            var months = int.Parse(monthsText);
            var monthlyPayment = 120000 / months;
            Console.WriteLine($"Monthly payment: {monthlyPayment}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Handled safely: The number of months must be numeric.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Handled safely: The number of months cannot be zero.");
        }
        #endregion

        #region Output
        // 1. Output meaning: DivideByZeroException specific catch block-ல் handle ஆனது.
        // 2. இது exact error-kku exact response கொடுக்க உதவுகிறது.
        Console.WriteLine();
        #endregion
    }
}
