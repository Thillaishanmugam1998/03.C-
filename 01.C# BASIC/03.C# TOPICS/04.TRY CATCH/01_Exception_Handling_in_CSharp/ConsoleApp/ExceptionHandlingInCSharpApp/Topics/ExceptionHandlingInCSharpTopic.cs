namespace ExceptionHandlingInCSharpApp.Topics;

public static class ExceptionHandlingInCSharpTopic
{
    public static void Display()
    {
        #region Explanation
        // 1. Topic: Exception Handling in C#
        // 2. Concept: Runtime error வந்தாலும் application crash ஆகாமல் safe-a handle பண்ணுவது.
        // 3. Real-world analogy: Hospital reception printer work ஆகலைனா hospital close ஆகாது.
        // 4. Comparison:
        //    - Printer failure -> runtime exception
        //    - Receptionist response -> catch block
        //    - Hospital continues -> program continues safely
        // 5. Syntax:
        //    try
        //    {
        //        // risky code
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        // 6. Best practice: Risky code மட்டும் try block-க்கு உள்ளே வைக்கணும்.
        // 7. Common mistake: எல்லா இடத்திலும் generic catch use பண்ணக்கூடாது.
        #endregion

        #region RealWorldExample
        // 1. Scenario: Student admission form-ல் age number ஆக வரணும்.
        // 2. User "Twenty" nu text கொடுக்கிறான்.
        // 3. System int.Parse use பண்ணும் போது format issue வரும்.
        // 4. அந்த exception-ஐ catch பண்ணி safe-a handle பண்ணுறோம்.
        #endregion

        #region CodeExample
        try
        {
            var ageText = "Twenty";
            var age = int.Parse(ageText);
            Console.WriteLine($"Parsed age: {age}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Handled safely: {ex.Message}");
        }
        #endregion

        #region Output
        // 1. Output meaning: Invalid input exception throw ஆனது.
        // 2. catch block அந்த error-ஐ handle பண்ணி app crash ஆகாமல் காப்பாத்தியது.
        Console.WriteLine();
        #endregion
    }
}
