# Polymorphism - Real-Time Examples

## Concept Explanation

Polymorphism means "many forms." In object-oriented programming, it allows the same method call to behave differently based on the actual object involved.

This makes code flexible, reusable, and easier to extend.

## Real-World Analogy

Think about customer notifications in an application.

- The system has one goal: send a message.
- That message may be sent by email, SMS, or push notification.
- The action name is the same, but each channel handles the message differently.

That is polymorphism in real life: one action, many possible forms of behavior.

## Comparison Between Real-World Scenario and Code Implementation

| Real-World Scenario | Code Implementation |
| --- | --- |
| App sends notifications in multiple ways | `NotificationChannel` is the common base type |
| Email works differently from SMS | `EmailNotification` and `SmsNotification` override behavior |
| Push notifications also follow the same request | `PushNotification` also overrides `Send()` |
| The system uses one common send flow | `NotificationService` calls `SendNotification()` |
| Actual behavior depends on the chosen channel | Runtime chooses the correct overridden method |

## Syntax

```csharp
public class Animal
{
    public virtual void MakeSound() { }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}
```

## Step-by-Step Explanation

1. Create a base type with a common method.
2. Mark the method `virtual` or `abstract`.
3. Create derived classes and override that method.
4. Use the base type reference to store different derived objects.
5. Call the same method through the base reference.
6. Observe that the output changes based on the actual object type.

## Best Practices

- Use polymorphism to reduce repeated condition checks.
- Prefer clear common contracts for related behavior.
- Keep each derived class responsible for its own implementation.
- Write code against the parent type where possible.
- Use meaningful real-world examples to demonstrate behavior differences.

## Common Mistakes

- Forgetting to mark the base method `virtual`, `abstract`, or use an interface.
- Writing large `if-else` blocks instead of using polymorphism.
- Creating unrelated classes under one common parent just to force polymorphism.
- Mixing too many responsibilities inside one derived class.
