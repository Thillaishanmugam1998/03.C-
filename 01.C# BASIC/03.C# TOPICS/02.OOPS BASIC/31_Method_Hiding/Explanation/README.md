# 31 Method Hiding

## Concept Explanation
Method hiding happens when a derived class defines a method with the same name as a base class method using the `new` keyword. It does not replace the base implementation for runtime polymorphism.

## Real-World Analogy
Two departments may have documents with the same title, but they are still different documents depending on which department you open them from.

## Syntax
```csharp
public class BaseClass
{
    public void Show() { }
}

public class DerivedClass : BaseClass
{
    public new void Show() { }
}
```

## Step-by-Step Explanation
1. Create a method in the base class.
2. Create a method with the same name in the derived class.
3. Use `new` to indicate hiding.
4. Observe that reference type affects which method is called.

## Best Practices
- Prefer overriding over hiding when polymorphism is intended.
- Use hiding only for a clear design reason.
- Document behavior to avoid confusion.

## Common Mistakes
- Expecting hidden methods to behave like overridden methods.
- Forgetting the `new` keyword.
