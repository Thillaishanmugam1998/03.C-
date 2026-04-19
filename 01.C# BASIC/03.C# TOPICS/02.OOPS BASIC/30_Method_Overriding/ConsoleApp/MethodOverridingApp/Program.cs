namespace MethodOverridingApp;

internal class Program
{
    private static void Main()
    {
        #region Explanation
        // Overriding replaces a base virtual method with derived behavior.
        // The actual object type decides which method runs.
        #endregion

        #region Example
        Animal dog = new Dog();
        Animal cat = new Cat();

        dog.Speak();
        cat.Speak();
        #endregion

        #region Output
        Console.WriteLine();
        Console.WriteLine("Expected learning outcome:");
        Console.WriteLine("1. Speak is defined in the base class.");
        Console.WriteLine("2. Each derived class overrides it differently.");
        #endregion
    }
}

internal class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

internal sealed class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog barks.");
    }
}

internal sealed class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Cat meows.");
    }
}
