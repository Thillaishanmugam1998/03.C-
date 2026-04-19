namespace ExceptionHandlingInCSharpApp.Topics;

public static class InnerExceptionTopic
{
    public static void Display()
    {
        #region Explanation
        // 1. Topic: Inner Exception
        // 2. Concept: Original exception-ஐ preserve பண்ணி, மேலொரு context message உடன் wrap பண்ணுவது.
        // 3. Real-world analogy: Manager "Report fail ஆனது, reason printer failure" என்று explain பண்ணுவது.
        // 4. Comparison:
        //    - Original cause -> inner exception
        //    - High-level message -> outer exception
        // 5. Syntax:
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Higher-level message", ex);
        //    }
        // 6. Best practice: Original cause-ஐ lose பண்ணாம inner exception-ஆ pass பண்ணணும்.
        // 7. Common mistake: New exception throw பண்ணி original cause-ஐ மறைத்துவிடுவது.
        #endregion

        #region RealWorldExample
        // 1. Scenario: Invoice load fail ஆகுது.
        // 2. Real cause database connection issue.
        // 3. User-friendly context message உடன் original cause preserve பண்ணுறோம்.
        #endregion

        #region CodeExample
        try
        {
            LoadInvoice();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Outer message: {ex.Message}");
            Console.WriteLine($"Inner message: {ex.InnerException?.Message}");
        }
        #endregion

        #region Output
        // 1. Output meaning: Outer message business context கொடுக்குது.
        // 2. Inner message root technical cause-ஐ preserve பண்ணுது.
        Console.WriteLine();
        #endregion
    }

    private static void LoadInvoice()
    {
        try
        {
            ConnectToDatabase();
        }
        catch (Exception ex)
        {
            throw new Exception("Invoice loading failed while preparing the monthly statement.", ex);
        }
    }

    private static void ConnectToDatabase()
    {
        throw new InvalidOperationException("Database server is not reachable.");
    }
}
