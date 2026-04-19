# 12 Encapsulation

## Concept Explanation
Encapsulation means bundling data and the methods that operate on that data into one unit, usually a class. It also means controlling access to internal data so objects can protect their own state.

## Real-World Analogy
An ATM machine hides its internal wiring and logic. You interact through buttons and screen options. That controlled interaction is like encapsulation.

## Syntax
```csharp
public class BankAccount
{
    private decimal _balance;

    public void Deposit(decimal amount)
    {
        _balance += amount;
    }

    public decimal GetBalance()
    {
        return _balance;
    }
}
```

## Step-by-Step Explanation
1. Store important data in private fields.
2. Provide public methods or properties for controlled access.
3. Validate values before updating internal state.
4. Prevent invalid direct changes from outside the class.

## Best Practices
- Keep fields private whenever possible.
- Use methods or properties to validate changes.
- Protect object state from invalid values.
- Encapsulate behavior close to related data.

## Common Mistakes
- Exposing fields directly.
- Allowing outside code to set invalid values.
- Using getters and setters without any real control when behavior is needed.
