# Stack and Heap Memory in .NET

## Concept Explanation
In basic .NET understanding:
- Stack memory is commonly used for local value-type data and method calls.
- Heap memory is used for objects created with `new`.

## Real-World Analogy
Think of the stack like a small working desk and the heap like a larger storage area.

## Syntax
```csharp
int number = 10;
Person person = new Person();
```

## Step-by-Step Explanation
1. `number` is a value type local variable.
2. `person` is a reference variable.
3. The actual object for `person` is created on the heap.

## Best Practices
- Learn the conceptual difference first.
- Avoid oversimplifying advanced memory behavior in production code discussions.

## Common Mistakes
- Thinking all value types always live only on the stack in every scenario.
- Confusing object references with the object itself.
