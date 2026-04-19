# Encapsulation - Real-Time Examples

## Concept Explanation

Encapsulation is the process of bundling data and the methods that operate on that data into a single unit, usually a class. It also means restricting direct access to important internal data so that it cannot be changed in unsafe ways.

In simple terms, encapsulation protects an object's data and allows updates only through controlled methods.

## Real-World Analogy

Think about a bank account.

- Your account balance is sensitive data.
- You cannot directly edit the balance whenever you want.
- The bank provides controlled actions such as deposit, withdraw, and check balance.
- Those actions validate the request before changing the data.

This is exactly how encapsulation works in code.

## Comparison Between Real-World Scenario and Code Implementation

| Real-World Scenario | Code Implementation |
| --- | --- |
| Bank account stores money securely | `BankAccount` class stores `_balance` privately |
| Customer cannot directly edit balance in the bank system | Other classes cannot directly access `_balance` |
| Bank allows deposit and withdrawal through approved operations | `Deposit()` and `Withdraw()` methods control access |
| Bank checks for invalid actions | Methods validate negative amounts and insufficient balance |
| Customer can view available balance safely | `GetBalance()` gives controlled read access |

## Syntax

```csharp
public class BankAccount
{
    private decimal _balance;

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            _balance += amount;
        }
    }

    public decimal GetBalance()
    {
        return _balance;
    }
}
```

## Step-by-Step Explanation

1. Create a class named `BankAccount`.
2. Keep the important field `_balance` as `private`.
3. Expose safe public methods such as `Deposit()`, `Withdraw()`, and `GetBalance()`.
4. Add validation inside those methods.
5. Use the class from `Program.cs` through an example runner class.
6. Observe that external code cannot directly modify the private balance.

## Best Practices

- Keep sensitive fields `private`.
- Provide meaningful public methods instead of exposing internal data directly.
- Validate data before updating object state.
- Keep business rules inside the class that owns the data.
- Use clear method names such as `Deposit`, `Withdraw`, and `GetBalance`.
- Keep `Program.cs` clean and move logic into separate class files.

## Common Mistakes

- Making fields `public` when they should be hidden.
- Allowing invalid values such as negative deposits or withdrawals.
- Writing all logic inside `Program.cs`.
- Exposing setters for sensitive data without validation.
- Mixing unrelated responsibilities inside one class.
