namespace ExceptionHandlingInCSharpApp.Topics;

public static class FinallyBlockTopic
{
    public static void Display()
    {
        #region Explanation
        // 1. Topic: Finally Block
        // 2. Concept: Exception வந்தாலும் வரலையென்றாலும் finally block execute ஆகும்.
        // 3. Real-world analogy: Lab test முடிந்ததும் table clean பண்ணுவது compulsory.
        // 4. Comparison:
        //    - Main work -> try
        //    - Error handling -> catch
        //    - Mandatory cleanup -> finally
        // 5. Syntax:
        //    try { }
        //    catch (Exception ex) { }
        //    finally { }
        // 6. Best practice: Resource cleanup finally-ல் வைக்கணும்.
        // 7. Common mistake: Main business logic-ஐ finally-ல் எழுதக்கூடாது.
        #endregion

        #region RealWorldExample
        // 1. Scenario: Report file open பண்ணி read பண்ணுறோம்.
        // 2. Reading fail ஆனாலும் file close ஆகணும்.
        // 3. அதனால cleanup finally-ல் வைக்கிறோம்.
        #endregion

        #region CodeExample
        var fileIsOpen = false;

        try
        {
            fileIsOpen = true;
            Console.WriteLine("Report file opened.");
            throw new InvalidOperationException("Report format is corrupted.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Handled safely: {ex.Message}");
        }
        finally
        {
            if (fileIsOpen)
            {
                Console.WriteLine("Report file closed in finally.");
            }
        }
        #endregion

        #region Output
        // 1. Output meaning: Error வந்த பிறகும் file close logic execute ஆனது.
        // 2. finally block cleanup guarantee பண்ணுகிறது.
        Console.WriteLine();
        #endregion
    }
}
