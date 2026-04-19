# 18 Generalization and Specialization

## Concept Explanation
Generalization means moving common features from specific classes into a more general parent class. Specialization means creating child classes that add unique behavior to the generalized parent.

## Real-World Analogy
`SavingsAccount` and `CurrentAccount` can both be generalized into `BankAccount`. Then each specialized account type can add its own rules.

## Syntax
```csharp
public class BankAccount
{
    public string AccountNumber { get; set; } = string.Empty;
}

public class SavingsAccount : BankAccount
{
    public decimal InterestRate { get; set; }
}
```

## Step-by-Step Explanation
1. Find common members in similar classes.
2. Move them into a generalized base class.
3. Keep specialized behavior in child classes.
4. Reuse the common design across all specialized types.

## Best Practices
- Generalize only truly common features.
- Keep specialized classes meaningful.
- Avoid moving child-specific logic to the base class.
- Review the hierarchy as the app evolves.

## Common Mistakes
- Creating a base class too early.
- Overgeneralizing unrelated features.
- Making child classes too dependent on parent internals.
