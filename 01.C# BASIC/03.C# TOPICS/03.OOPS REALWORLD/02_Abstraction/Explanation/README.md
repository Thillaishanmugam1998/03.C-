# Abstraction - Real-Time Examples

## Concept Explanation

Abstraction means showing only the important behavior of an object and hiding the complex internal implementation details. It helps us focus on what an object does instead of how it does it.

In C#, abstraction is commonly achieved using abstract classes and interfaces.

## Real-World Analogy

Think about making a payment in an online shopping application.

- You choose a payment method such as Credit Card or UPI.
- You enter the required details and click pay.
- You do not see the hidden technical steps like server validation, bank communication, fraud checks, or transaction confirmation handling.

You only use the essential operation: making a payment. The internal complexity is hidden. That is abstraction.

## Comparison Between Real-World Scenario and Code Implementation

| Real-World Scenario | Code Implementation |
| --- | --- |
| Customer chooses a payment option | Program uses a `PaymentMethod` reference |
| App shows only the payment action | Abstract class defines `ProcessPayment()` |
| Credit Card and UPI work differently internally | `CreditCardPayment` and `UpiPayment` implement different logic |
| Checkout system does not handle every payment detail itself | `CheckoutService` works with the abstraction |
| Hidden technical workflow is still executed | Concrete classes perform their own processing steps |

## Syntax

```csharp
public abstract class PaymentMethod
{
    public abstract void ProcessPayment(decimal amount);
}

public class CreditCardPayment : PaymentMethod
{
    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine("Processing credit card payment...");
    }
}
```

## Step-by-Step Explanation

1. Create an abstract class named `PaymentMethod`.
2. Add an abstract method named `ProcessPayment(decimal amount)`.
3. Create child classes such as `CreditCardPayment` and `UpiPayment`.
4. Override `ProcessPayment()` in each class with its own internal steps.
5. Create a `CheckoutService` that works with `PaymentMethod` instead of a specific payment type.
6. Call the service using different payment objects and observe that the same abstraction is used in a simple way.

## Best Practices

- Hide unnecessary implementation details from the caller.
- Design around common behavior that multiple classes share.
- Keep the abstract contract simple and meaningful.
- Put shared functionality in the abstract base class only when it truly belongs there.
- Use abstraction to reduce coupling between classes.
- Keep `Program.cs` minimal and move behavior into dedicated files.

## Common Mistakes

- Exposing too many internal details to the caller.
- Creating abstractions that are too generic or unclear.
- Putting unrelated logic into the abstract base class.
- Forgetting to override abstract members in derived classes.
- Writing all example logic directly inside `Program.cs`.
