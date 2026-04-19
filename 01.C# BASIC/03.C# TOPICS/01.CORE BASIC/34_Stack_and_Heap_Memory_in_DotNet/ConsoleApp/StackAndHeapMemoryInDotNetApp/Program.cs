using System;

namespace StackAndHeapMemoryInDotNetApp;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Explanation
        /*
            Topic: Stack and Heap Memory in .NET

            Value-type local variables are commonly stored on the stack.
            Objects are created on the heap, and variables can hold references to them.
        */
        #endregion

        #region Example
        int number = 10;
        Person person = new("Arun");

        Console.WriteLine($"Value type local variable: {number}");
        Console.WriteLine($"Reference type object name: {person.Name}");
        Console.WriteLine("number is stored as a local value.");
        Console.WriteLine("person is a reference to an object created on the heap.");
        #endregion

        #region Output
        /*
            Value type local variable: 10
            Reference type object name: Arun
            number is stored as a local value.
            person is a reference to an object created on the heap.
        */
        #endregion
    }
}

internal class Person
{
    public Person(string name)
    {
        Name = name;
    }

    public string Name { get; }
}
