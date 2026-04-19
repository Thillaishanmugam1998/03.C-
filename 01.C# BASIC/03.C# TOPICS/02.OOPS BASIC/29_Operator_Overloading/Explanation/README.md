# 29 Operator Overloading

## Concept Explanation
Operator overloading allows custom types to define how operators such as `+`, `-`, or `==` behave. This is useful when objects represent values that naturally support such operations.

## Real-World Analogy
If two money objects are added together, the result should be a new money value with the combined amount. Operator overloading makes that expression natural.

## Syntax
```csharp
public static Money operator +(Money left, Money right)
{
    return new Money(left.Amount + right.Amount);
}
```

## Step-by-Step Explanation
1. Create a custom value class.
2. Decide which operator makes sense for that type.
3. Define the operator as a static method.
4. Use the operator naturally with objects.

## Best Practices
- Overload only operators that feel natural for the type.
- Keep overloaded behavior intuitive.
- Pair operator overloads with clear object design.

## Common Mistakes
- Overloading operators in surprising ways.
- Using operator overloading when normal methods are clearer.
