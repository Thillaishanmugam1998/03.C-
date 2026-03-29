internal static class RealWorldUsage
{
    public static void Run()
    {
        ShowTupleVsClassOrRecord();
        ShowPracticalExamples();
        ShowTupleEquality();
    }

    #region 01 - Tuple vs Class Or Record
    private static void ShowTupleVsClassOrRecord()
    {
        // Tuple is best for short-lived grouped values and method returns.
        // Record or class is better when the data has long-term meaning, behavior, or many fields.
        // Tuples become less readable when many elements are involved.
        // Choose tuples for convenience, not for rich domain models.

        (bool Success, string Message) quickResult = (true, "Saved");
        ApiUserRecord apiUser = new(101, "Asha", "asha@example.com");

        Console.WriteLine("\n01 - Tuple vs Class Or Record"); // Output: 01 - Tuple vs Class Or Record
        Console.WriteLine($"Quick Result: {quickResult}"); // Output: Quick Result: (True, Saved)
        Console.WriteLine($"API User Record: {apiUser}"); // Output: API User Record: ApiUserRecord { Id = 101, Name = Asha, Email = asha@example.com }

        // Mistake:
        // Using tuples for long-term business models makes code hard to understand and maintain.
        // When the data has identity or many fields, prefer a class or record.

        // 🌍 Real-World Analogy:
        // Think of a tuple like a short note and a record like a full profile file.
        // A short note is quick, but a full profile is better for long-term use.
    }
    #endregion

    #region 02 - Practical Examples
    private static void ShowPracticalExamples()
    {
        // Tuples are practical for small return shapes from methods.
        // They are often used for success-message responses, id-name pairs, and quick API-like summaries.
        // They also work nicely with LINQ-style thinking when selecting lightweight result shapes.
        // Use them when the result is short and immediately consumed.

        var (success, message) = SaveCustomer();
        (int Id, string Name) userSummary = GetUserSummary();
        List<(int Id, string Name)> activeUsers = GetUsers()
            .Where(user => user.IsActive)
            .Select(user => (user.Id, user.Name))
            .ToList();

        Console.WriteLine("\n02 - Practical Examples"); // Output: 02 - Practical Examples
        Console.WriteLine($"Save Success: {success}"); // Output: Save Success: True
        Console.WriteLine($"Save Message: {message}"); // Output: Save Message: Customer saved
        Console.WriteLine($"User Summary: {userSummary.Id} - {userSummary.Name}"); // Output: User Summary: 701 - Rahul
        Console.WriteLine($"Active User Count: {activeUsers.Count}"); // Output: Active User Count: 2

        foreach ((int userId, string userName) in activeUsers)
        {
            Console.WriteLine($"Active User: {userId} - {userName}"); // Output: Active User: 701 - Rahul ... Active User: 703 - Deepa
        }

        // Mistake:
        // If the tuple is passed around many layers of the app, readability usually starts to drop.
        // Use a record when the data shape needs long-term clarity.

        // 🌍 Real-World Analogy:
        // Think of tuples here like quick dashboard cards.
        // They show a few useful values fast without building a full file.
    }
    #endregion

    #region 03 - Tuple Equality
    private static void ShowTupleEquality()
    {
        // Tuples support value-based equality.
        // Two tuples are equal when their elements match in value and order.
        // This can be useful in tests, comparisons, and quick checks.
        // Tuple equality is based on the actual contents, not object identity.

        (int Id, string Name) firstUser = (501, "Anita");
        (int Id, string Name) secondUser = (501, "Anita");
        (int Id, string Name) thirdUser = (502, "Rahul");

        bool firstEqualsSecond = firstUser == secondUser;
        bool firstEqualsThird = firstUser == thirdUser;

        Console.WriteLine("\n03 - Tuple Equality"); // Output: 03 - Tuple Equality
        Console.WriteLine($"First Equals Second: {firstEqualsSecond}"); // Output: First Equals Second: True
        Console.WriteLine($"First Equals Third: {firstEqualsThird}"); // Output: First Equals Third: False

        // Mistake:
        // Equality checks depend on both value and position.
        // If the order changes, the tuples are not considered the same shape.

        // 🌍 Real-World Analogy:
        // Think of tuple equality like comparing two labels field by field.
        // They match only when the values line up in the same places.
    }
    #endregion

    private static (bool Success, string Message) SaveCustomer()
    {
        return (true, "Customer saved");
    }

    private static (int Id, string Name) GetUserSummary()
    {
        return (701, "Rahul");
    }

    private static List<UserInfo> GetUsers()
    {
        return new List<UserInfo>
        {
            new UserInfo(701, "Rahul", true),
            new UserInfo(702, "Priya", false),
            new UserInfo(703, "Deepa", true)
        };
    }

    private sealed record ApiUserRecord(int Id, string Name, string Email);

    private sealed record UserInfo(int Id, string Name, bool IsActive);
}
