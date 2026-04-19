# 04 Exception Handling

## Overview
This console app is now organized topic by topic. Instead of one banking scenario, each exception-handling concept has its own class file with its own explanation and demo.

## Topic Class Files
- `Topics/ExceptionHandlingInCSharpTopic.cs`
- `Topics/MultipleCatchBlocksTopic.cs`
- `Topics/FinallyBlockTopic.cs`
- `Topics/CustomExceptionsTopic.cs`
- `Topics/InnerExceptionTopic.cs`
- `Topics/ExceptionHandlingAbuseTopic.cs`

## Why This Structure
- `Program.cs` remains the entry point only.
- `ExceptionHandlingModule.cs` coordinates the learning flow.
- Each topic has a dedicated class, so the concepts are easier to study one by one.
- The examples are short, beginner-friendly, and interview-ready.

## Topic-Wise Explanation

### 1. Exception Handling in C#
Exception handling is used to manage runtime errors safely. When invalid input, file issues, or calculation problems happen, `try-catch` prevents the whole application from crashing.

Real-world analogy:
A receptionist handles a system error calmly and informs the user instead of shutting down the whole office.

### 2. Multiple Catch Blocks
Different errors need different responses. `FormatException`, `DivideByZeroException`, and `FileNotFoundException` should not always be handled in the same way.

Real-world analogy:
A customer support center sends billing issues to billing staff and technical issues to the technical team.

### 3. Finally Block
The `finally` block always runs. It is useful for cleanup tasks like closing files, releasing connections, or ending a transaction safely.

Real-world analogy:
After any lab test, the technician always cleans the table whether the test succeeds or fails.

### 4. Custom Exceptions
Custom exceptions help represent business-specific problems clearly. Built-in exceptions are not always enough for domain rules like account balance failures or invalid ticket reuse.

Real-world analogy:
A cinema displays a special message like "Ticket already used" instead of showing a generic entry error.

### 5. Inner Exception
An inner exception preserves the original low-level reason while a new higher-level exception adds business context.

Real-world analogy:
A manager tells the client, "The report was not delivered because the printer failed." The explanation gives both context and cause.

### 6. Exception Handling Abuse
Exceptions should not be used for normal validation or ordinary control flow. Expected input issues should usually be handled with validation methods like `TryParse`.

Real-world analogy:
A school office should not escalate every small form typo to the principal.

## Best Practices
- Catch specific exceptions when possible.
- Keep `Program.cs` minimal.
- Use `finally` for cleanup.
- Create custom exceptions only for meaningful business rules.
- Preserve root causes using inner exceptions.
- Avoid using exceptions for regular validation.

## Common Mistakes
- Catching `Exception` everywhere without thought.
- Writing all logic in `Program.cs`.
- Ignoring cleanup work.
- Throwing a new exception and losing the original cause.
- Using exceptions instead of simple validation.

## Learning Result
This structure makes the project easier to study because each topic is isolated in its own class file and can be understood independently.
