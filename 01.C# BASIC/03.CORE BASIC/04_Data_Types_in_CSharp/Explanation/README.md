# Data Types in C#

## Concept Explanation
Data types in C# define the kind of data a variable can store. They help the compiler understand how much memory to use, what operations are allowed, and how values should behave.

Some common data types are:
- `int` for whole numbers
- `double` for decimal numbers
- `char` for a single character
- `bool` for true or false values
- `string` for text

C# data types are broadly grouped into value types and reference types.

## Real-World Analogy
Think of data types like labeled containers:

- A water bottle is for water only.
- A lunch box is for food.
- A pencil box is for stationery.

In the same way, each variable type is meant to store a specific kind of value.

## Syntax
```csharp
int age = 25;
double price = 99.99;
char grade = 'A';
bool isActive = true;
string name = "John";
```

## Step-by-Step Explanation
1. `int age = 25;` stores a whole number.
2. `double price = 99.99;` stores a decimal value.
3. `char grade = 'A';` stores one single character.
4. `bool isActive = true;` stores a true or false value.
5. `string name = "John";` stores text.
6. Each data type controls what kind of data can be assigned to the variable.

## Best Practices
- Choose the correct data type for the value you want to store.
- Use `string` for text and `char` only for a single character.
- Use `bool` for decision-making values.
- Prefer clear variable names that match the stored data.

## Common Mistakes
- Using double quotes for `char` instead of single quotes.
- Trying to store text inside numeric data types.
- Confusing `int` and `double`.
- Using unclear variable names that hide the purpose of the data.
