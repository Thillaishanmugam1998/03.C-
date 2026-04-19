# 24 Interface Realtime Examples

## Concept Explanation
Interfaces are widely used in real-world applications for payments, logging, notifications, repositories, authentication, and device communication because they allow different implementations to plug into the same system.

## Real-World Analogy
Different payment providers such as card, UPI, and wallet can all follow the same payment contract while processing transactions differently.

## Syntax
```csharp
public interface IPaymentGateway
{
    void Pay(decimal amount);
}
```

## Step-by-Step Explanation
1. Define a common interface.
2. Create multiple real implementations.
3. Use the interface in application logic.
4. Swap implementations without changing calling code.

## Best Practices
- Use interfaces at application boundaries.
- Design for easy replacement and testing.
- Keep contracts business-focused.

## Common Mistakes
- Building interfaces too early without a real need.
- Naming interfaces too generically.
