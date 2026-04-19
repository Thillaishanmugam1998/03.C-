# 26 Multiple Inheritance Realtime Example

## Concept Explanation
In real projects, a class often needs multiple behaviors such as printing, emailing, and saving. In C#, this is achieved by implementing multiple interfaces.

## Real-World Analogy
A business report system may need to print reports, email reports, and export reports. One class can support all these capabilities through multiple interfaces.

## Syntax
```csharp
public interface IPrintable { void Print(); }
public interface IEmailable { void SendEmail(); }
public interface IExportable { void Export(); }
```

## Step-by-Step Explanation
1. Create separate interfaces for separate responsibilities.
2. Build a class that implements all needed interfaces.
3. Use the object through whichever capability is required.

## Best Practices
- Prefer capability-based interfaces.
- Use interfaces to keep systems extensible.
- Separate responsibilities clearly.

## Common Mistakes
- Putting too many unrelated features into one interface.
- Using inheritance when interfaces are the real fit.
