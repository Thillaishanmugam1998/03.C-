# Interface - Real-Time Examples

## Concept Explanation

An interface is a contract that defines what members a class must implement. It describes required behavior without providing the complete implementation.

Interfaces are useful when different classes need to provide the same capability even if they are not related by inheritance.

## Real-World Analogy

Think about a shipment tracking feature in an e-commerce application.

- The app wants one capability: track a package.
- Different courier companies such as BlueDart and DTDC can both provide that capability.
- The app does not need to know their internal systems.
- It only needs them to follow the tracking contract.

That contract is similar to an interface in C#.

## Comparison Between Real-World Scenario and Code Implementation

| Real-World Scenario | Code Implementation |
| --- | --- |
| Tracking portal expects package tracking support | `IShipmentTracker` defines `TrackShipment()` |
| BlueDart provides tracking | `BlueDartTracker` implements the interface |
| DTDC also provides tracking | `DtdcTracker` implements the interface |
| Portal works with any courier following the contract | `TrackingPortal` depends on `IShipmentTracker` |
| Companies can implement tracking differently | Each class writes its own implementation |

## Syntax

```csharp
public interface IWorker
{
    void DoWork();
}

public class Driver : IWorker
{
    public void DoWork()
    {
        Console.WriteLine("Driving...");
    }
}
```

## Step-by-Step Explanation

1. Create an interface that defines the required behavior.
2. Add method declarations without implementation.
3. Create classes that implement the interface.
4. Write the method bodies inside those classes.
5. Use the interface type in dependent classes.
6. Pass different implementations and observe that the same contract works for all of them.

## Best Practices

- Use interfaces for shared capabilities across multiple classes.
- Keep interface names clear, usually beginning with `I`.
- Keep interfaces focused on one responsibility.
- Program against interfaces instead of concrete implementations where possible.
- Use interfaces to make code flexible and easier to extend.

## Common Mistakes

- Making one interface do too many unrelated things.
- Depending directly on concrete classes when an interface would be better.
- Creating interfaces without a real need for abstraction.
- Forgetting to implement all required members.
