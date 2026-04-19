namespace ExceptionHandlingInCSharpApp.Topics;

public static class ExceptionHandlingAbuseTopic
{
    public static void Display()
    {
        #region Explanation
        // 1. Topic: Exception Handling Abuse
        // 2. Concept: Expected situations-க்கு exception use பண்ணுவது wrong practice.
        // 3. Real-world analogy: Small form typo-க்கு principal-ஐ அழைப்பது unnecessary escalation.
        // 4. Comparison:
        //    - Small validation -> normal if / TryParse
        //    - Unexpected failure -> exception
        // 5. Syntax:
        //    if (int.TryParse(input, out int number))
        //    {
        //        Console.WriteLine(number);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid input");
        //    }
        // 6. Best practice: Validation use பண்ணு, avoidable exceptions create பண்ணாதே.
        // 7. Common mistake: ஒவ்வொரு user input-க்கும் try-catch use பண்ணுவது.
        #endregion

        #region RealWorldExample
        // 1. Scenario: Registration form age input validate பண்ணணும்.
        // 2. "abc" போன்ற input வந்தா அது expected validation issue.
        // 3. அதனால exception throw பண்ணாமல் TryParse use பண்ணுறோம்.
        #endregion

        #region CodeExample
        var ageText = "abc";

        if (int.TryParse(ageText, out var age))
        {
            Console.WriteLine($"Valid age: {age}");
        }
        else
        {
            Console.WriteLine("Handled correctly without exception abuse: Age must be a valid number.");
        }
        #endregion

        #region Output
        // 1. Output meaning: Validation மூலம் issue handle ஆனது.
        // 2. Avoidable exception throw ஆகவில்லை.
        Console.WriteLine();
        #endregion
    }
}
