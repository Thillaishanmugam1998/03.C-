namespace InheritanceApp;

internal class Program
{
    private static void Main()
    {
        #region Explanation
        // Inheritance lets a derived class reuse members from a base class.
        // It is useful when there is a true parent-child relationship.
        #endregion

        #region Example
        Dog petDog = new() { Name = "Bruno", Age = 3 };
        petDog.ShowAnimalInfo();
        petDog.Bark();
        #endregion

        #region Output
        Console.WriteLine();
        Console.WriteLine("Expected learning outcome:");
        Console.WriteLine("1. Dog inherits common members from Animal.");
        Console.WriteLine("2. Dog also adds its own specialized behavior.");
        #endregion
    }
}

internal class Animal
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }

    public void ShowAnimalInfo()
    {
        Console.WriteLine($"Animal Name: {Name}, Age: {Age}");
    }
}

internal class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine($"{Name} is barking.");
    }
}
