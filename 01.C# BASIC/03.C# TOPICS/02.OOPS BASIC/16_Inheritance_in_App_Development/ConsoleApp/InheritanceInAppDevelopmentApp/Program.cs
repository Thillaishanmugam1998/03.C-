namespace InheritanceInAppDevelopmentApp;

internal class Program
{
    private static void Main()
    {
        #region Explanation
        // In app development, inheritance can help model user roles with shared behavior.
        // A base class holds common details and child classes add role-specific actions.
        #endregion

        #region Example
        AdminUser admin = new() { Name = "System Admin", Email = "admin@sample.com" };
        CustomerUser customer = new() { Name = "Riya", Email = "riya@sample.com" };

        admin.ShowProfile();
        admin.ManageUsers();

        customer.ShowProfile();
        customer.PlaceOrder();
        #endregion

        #region Output
        Console.WriteLine();
        Console.WriteLine("Expected learning outcome:");
        Console.WriteLine("1. Shared user data lives in the base class.");
        Console.WriteLine("2. Specialized actions stay inside the derived classes.");
        #endregion
    }
}

internal class AppUser
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public void ShowProfile()
    {
        Console.WriteLine($"User: {Name}, Email: {Email}");
    }
}

internal class AdminUser : AppUser
{
    public void ManageUsers()
    {
        Console.WriteLine($"{Name} is managing application users.");
    }
}

internal class CustomerUser : AppUser
{
    public void PlaceOrder()
    {
        Console.WriteLine($"{Name} placed a new order.");
    }
}
