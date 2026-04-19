# 05 Why We Need Constructors

## Concept Explanation
Constructors are needed to initialize an object as soon as it is created. They help ensure required values are assigned, reduce duplicate setup code, and keep objects in a valid state from the start.

## Real-World Analogy
When you create a bank account, the bank immediately assigns an account number, customer name, and opening balance. That setup is similar to what a constructor does for an object.

## Syntax
```csharp
public class BankAccount
{
    public string AccountHolder { get; }
    public decimal Balance { get; }

    public BankAccount(string accountHolder, decimal openingBalance)
    {
        AccountHolder = accountHolder;
        Balance = openingBalance;
    }
}
```

## Step-by-Step Explanation
1. Identify the values an object must have when it starts.
2. Add those values as constructor parameters.
3. Assign them inside the constructor.
4. Create objects with all required information.
5. Benefit from reliable object initialization.

## Best Practices
- Use constructors for required setup.
- Validate input when important values are mandatory.
- Keep objects consistent from the moment they are created.
- Avoid repeated manual initialization outside the class.

## Common Mistakes
- Creating objects first and initializing them later in many places.
- Allowing invalid objects to exist.
- Overusing public setters instead of constructor-based setup.
- Ignoring constructor validation where needed.
