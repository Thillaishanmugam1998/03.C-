// ============================================================
// Project  : Phase 1 - C# Language Fundamentals
// Topic    : Data Types, Value vs Reference Types, Stack vs Heap
// Purpose  : Interview preparation & C# learning reference
// Audience : Beginners, Junior Devs, Interview Candidates
// Standard : C# 10 / .NET 6+
// ============================================================

using System.Globalization;

Console.WriteLine("PHASE 1 - C# LANGUAGE FUNDAMENTALS"); 
Console.WriteLine("Topic: Data Types & Type System"); 
Console.WriteLine("=".PadLeft(40, '=')); 
PrintSeparator();

#region 01 - int, long
// int and long are whole number types.
// int is the common default choice for counts, ages, ids, and loop values.
// long is used when numbers can grow much bigger than int.
//
// int size    : 4 bytes
// int range   : -2,147,483,648 to 2,147,483,647
// long size   : 8 bytes
// long range  : very large whole numbers
//
// Common mistake:
// Using int for values that can grow too much over time.
// Example: a database id in a large system or total app downloads in a global app.

int employeeAge = 28;
long totalVideoViews = 9_500_000_000; //Here _ just for read ablity 

Console.WriteLine($"int value: {employeeAge}"); // Output: int value: 28
Console.WriteLine($"long value: {totalVideoViews}"); // Output: long value: 9500000000
Console.WriteLine($"int MaxValue: {int.MaxValue}"); // Output: int MaxValue: 2147483647
Console.WriteLine($"int MinValue: {int.MinValue}"); // Output: int MinValue: -2147483648
Console.WriteLine($"long MaxValue: {long.MaxValue}"); // Output: long MaxValue: 9223372036854775807

try
{
    int nearMaxInt = int.MaxValue;
    int overflowedInt = checked(nearMaxInt + 1);
    Console.WriteLine($"Overflowed int: {overflowedInt}"); // Output: this line will not execute
}
catch (OverflowException ex)
{
    Console.WriteLine($"Overflow example: {ex.GetType().Name}"); // Output: Overflow example: OverflowException
}

// When to use:
// Use int for employee age, order quantity, and page number.
// Use long for huge counters like total app users across many years.
//
// ─────────────────────────────────────────────
// Real-World Analogy:
// Think of int like a city population counter.
// It works well for normal day-to-day numbers.
// Think of long like a world population counter over centuries.
// Use long when the number can become very large.
// ─────────────────────────────────────────────
#endregion

PrintSeparator();

#region 02 - float, double
// float and double store numbers with decimal points.
// float is smaller and less precise.
// double is larger and more precise.
//
// float needs the 'f' suffix.
// Without 'f', C# treats decimal-point numbers as double by default.
//
// Common mistake:
// Comparing float or double values with ==.
// Small precision differences can make comparison fail.

float playerSpeed = 10.1234567f;
double gpsLatitude = 10.123456789012345;
float floatMathResult = 0.1f + 0.2f;
bool floatComparisonResult = floatMathResult == 0.3f;

Console.WriteLine($"float value: {playerSpeed.ToString("G9", CultureInfo.InvariantCulture)}"); // Output: float value: 10.1234567
Console.WriteLine($"double value: {gpsLatitude.ToString("G17", CultureInfo.InvariantCulture)}"); // Output: double value: 10.123456789012345
Console.WriteLine($"float result: {floatMathResult.ToString("G9", CultureInfo.InvariantCulture)}"); // Output: float result: 0.300000012
Console.WriteLine($"float == comparison: {floatComparisonResult}"); // Output: float == comparison: False
Console.WriteLine($"double MaxValue: {double.MaxValue.ToString("G17", CultureInfo.InvariantCulture)}"); // Output: double MaxValue: 1.7976931348623157E+308

// When to use:
// Use float when rough precision is enough, like a game object position.
// Use double for more accurate values, like GPS coordinates or scientific data.
//
// ─────────────────────────────────────────────
// Real-World Analogy:
// Think of float like a game character position on screen.
// Small mistakes are usually okay there.
// Think of double like GPS coordinates in a map app.
// Use double when better precision matters.
// ─────────────────────────────────────────────
#endregion

PrintSeparator();

#region 03 - decimal
// decimal is also for decimal-point numbers.
// But it is designed for exact decimal precision.
// That is why decimal is the best choice for money.
//
// decimal needs the 'm' suffix.
//
// Common mistake:
// Using double for price, tax, and invoice values.
// That can create tiny rounding issues in financial apps.

decimal productPrice = 199.99m;
double doubleMoneyResult = 0.1 + 0.2;
decimal decimalMoneyResult = 0.1m + 0.2m;

Console.WriteLine($"decimal value: {productPrice}"); // Output: decimal value: 199.99
Console.WriteLine($"double money result: {doubleMoneyResult.ToString("G17", CultureInfo.InvariantCulture)}"); // Output: double money result: 0.30000000000000004
Console.WriteLine($"decimal money result: {decimalMoneyResult}"); // Output: decimal money result: 0.3
Console.WriteLine($"decimal MaxValue: {decimal.MaxValue}"); // Output: decimal MaxValue: 79228162514264337593543950335

// When to use:
// Use decimal for bank balance, tax, discount, total bill, and invoice amount.
//
// ─────────────────────────────────────────────
// Real-World Analogy:
// Think of decimal like money in a banking app.
// Your bank account cannot afford even a tiny math mistake.
// Use decimal for prices, salaries, tax, and invoice totals.
// ─────────────────────────────────────────────
#endregion

PrintSeparator();

#region 04 - bool
// bool stores only two values: true or false.
// It is used for yes/no, on/off, pass/fail type logic.
//
// Common mistake:
// Writing if (isLoggedIn == true)
// Better style is simply: if (isLoggedIn)

bool isLoggedIn = true;
bool isPaymentSuccessful = false;
bool isAdult = employeeAge >= 18;

Console.WriteLine($"isLoggedIn: {isLoggedIn}"); // Output: isLoggedIn: True
Console.WriteLine($"isPaymentSuccessful: {isPaymentSuccessful}"); // Output: isPaymentSuccessful: False
Console.WriteLine($"employeeAge >= 18: {isAdult}"); // Output: employeeAge >= 18: True

if (isLoggedIn)
{
    Console.WriteLine("User can access dashboard."); // Output: User can access dashboard.
}

// When to use:
// Use bool for login status, API success flag, email verified status, and feature toggle.
//
// ─────────────────────────────────────────────
// Real-World Analogy:
// Think of bool like a light switch.
// It is either on or off.
// In apps, it is like logged in or not logged in.
// ─────────────────────────────────────────────
#endregion

PrintSeparator();

#region 05 - char
// char stores a single character.
// char uses single quotes: 'A'
// string uses double quotes: "A"
//
// Common mistake:
// Writing "A" when you really need a char.
// "A" is a string, not a char.

char gradeLetter = 'A';
char firstInitial = 'R';
int gradeLetterNumber = gradeLetter;
bool isGradeA = gradeLetter == 'A';

Console.WriteLine($"char value: {gradeLetter}"); // Output: char value: A
Console.WriteLine($"second char value: {firstInitial}"); // Output: second char value: R
Console.WriteLine($"char numeric value: {gradeLetterNumber}"); // Output: char numeric value: 65
Console.WriteLine($"char comparison result: {isGradeA}"); // Output: char comparison result: True

// When to use:
// Use char for grade letter, keyboard key, menu option, or one symbol at a time.
//
// ─────────────────────────────────────────────
// Real-World Analogy:
// Think of char like one key on a keyboard.
// It holds only one symbol at a time.
// Good for grades like 'A' or menu choices like 'Y'.
// ─────────────────────────────────────────────
#endregion

PrintSeparator();

#region 06 - string
// string stores text.
// string is a reference type.
// But it feels safe like a value type because string is immutable.
// Immutable means the existing string text is not changed.
// When text changes, a new string object is created.
//
// Common mistake:
// Using + inside a loop many times for large text building.
// In that case, StringBuilder is a better tool.

string firstName = "Raj";
string copiedName = firstName;
bool sameStringReferenceBeforeChange = ReferenceEquals(firstName, copiedName);
string modifiedName = copiedName + " Kumar";
bool sameStringReferenceAfterChange = ReferenceEquals(firstName, modifiedName);
string fullNameByInterpolation = $"{firstName} Kumar";
string fullNameByConcatenation = firstName + " Kumar";
string? middleName = null;

Console.WriteLine($"string value: {firstName}"); // Output: string value: Raj
Console.WriteLine($"string length: {firstName.Length}"); // Output: string length: 3
Console.WriteLine($"string upper: {firstName.ToUpper()}"); // Output: string upper: RAJ
Console.WriteLine($"string interpolation: {fullNameByInterpolation}"); // Output: string interpolation: Raj Kumar
Console.WriteLine($"string concatenation: {fullNameByConcatenation}"); // Output: string concatenation: Raj Kumar
Console.WriteLine($"same reference before change: {sameStringReferenceBeforeChange}"); // Output: same reference before change: True
Console.WriteLine($"same reference after change: {sameStringReferenceAfterChange}"); // Output: same reference after change: False
Console.WriteLine($"original string after copy change: {firstName}"); // Output: original string after copy change: Raj
Console.WriteLine($"modified string: {modifiedName}"); // Output: modified string: Raj Kumar
Console.WriteLine($"string.IsNullOrEmpty(middleName): {string.IsNullOrEmpty(middleName)}"); // Output: string.IsNullOrEmpty(middleName): True

// When to use:
// Use string for name, email, city, product title, and any text field.
//
// ─────────────────────────────────────────────
// Real-World Analogy:
// Think of string like a printed document.
// If you edit the text, you get a new printed copy.
// The old paper is still there.
// Use string for all text data in real projects.
// ─────────────────────────────────────────────
#endregion

PrintSeparator();

#region 07 - var
// var lets the compiler find the type from the value on the right side.
// var is still strongly typed.
// It is not like JavaScript where the same variable changes type freely.
//
// Common mistake:
// Thinking var means dynamic typing.
// It does not.
//
// Invalid example:
// var unknownValue;
// This will not compile because var needs an initial value.

var orderCount = 5;
var customerName = "Anu";
var discountRate = 12.5;
var cartItems = new List<string> { "Keyboard", "Mouse" };

Console.WriteLine($"var int type: {orderCount.GetType().Name}"); // Output: var int type: Int32
Console.WriteLine($"var string type: {customerName.GetType().Name}"); // Output: var string type: String
Console.WriteLine($"var double type: {discountRate.GetType().Name}"); // Output: var double type: Double
Console.WriteLine($"var list type: {cartItems.GetType().Name}"); // Output: var list type: List`1
Console.WriteLine($"var list count: {cartItems.Count}"); // Output: var list count: 2

// When to use:
// Use var when the type is already obvious from the right side.
// Example: new List<string>(), new DateTime(), or long method calls.
//
// ─────────────────────────────────────────────
// Real-World Analogy:
// Think of ordering food without saying the item name directly.
// The waiter understands from your full description.
// But the order is still one fixed item, not a random thing.
// ─────────────────────────────────────────────
#endregion

PrintSeparator();

#region 08 - object
// object is the base type for almost all C# types.
// It can store many different kinds of values.
// When a value type goes into object, boxing happens.
// When we take it back out, unboxing happens.
//
// Common mistake:
// Overusing object everywhere instead of using the correct type or generics.
// That makes code slower and harder to maintain.

object boxedId = 101;
object boxedTitle = "Laptop";
object boxedStatus = true;

int unboxedId = (int)boxedId;
string unboxedTitle = (string)boxedTitle;
bool unboxedStatus = (bool)boxedStatus;

Console.WriteLine($"object int value: {boxedId}"); // Output: object int value: 101
Console.WriteLine($"object string value: {boxedTitle}"); // Output: object string value: Laptop
Console.WriteLine($"object bool value: {boxedStatus}"); // Output: object bool value: True
Console.WriteLine($"unboxed int: {unboxedId}"); // Output: unboxed int: 101
Console.WriteLine($"unboxed string: {unboxedTitle}"); // Output: unboxed string: Laptop
Console.WriteLine($"unboxed bool: {unboxedStatus}"); // Output: unboxed bool: True
Console.WriteLine($"actual type of boxedId: {boxedId.GetType().Name}"); // Output: actual type of boxedId: Int32
Console.WriteLine($"actual type of boxedTitle: {boxedTitle.GetType().Name}"); // Output: actual type of boxedTitle: String

// When to use:
// Use object only when you really need one variable to hold different types.
// In most real apps, proper classes and generics are better.
//
// ─────────────────────────────────────────────
// Real-World Analogy:
// Think of object like a universal storage box.
// You can keep anything inside it.
// But when you open it, you must know what item you stored.
// ─────────────────────────────────────────────
#endregion

PrintSeparator();

#region 09 - dynamic
// dynamic delays type checking until runtime.
// That means the compiler trusts you.
// If something is wrong, the app fails later while running.
//
// var vs dynamic:
// var decides the type at compile time.
// dynamic decides member access at runtime.
//
// Common mistake:
// Using dynamic everywhere just for flexibility.
// That removes compile-time safety.

dynamic flexibleValue = "Hello";
var fixedValue = "Hello";

Console.WriteLine($"dynamic initial type: {flexibleValue.GetType().Name}"); // Output: dynamic initial type: String
flexibleValue = 500;
Console.WriteLine($"dynamic changed type: {flexibleValue.GetType().Name}"); // Output: dynamic changed type: Int32
Console.WriteLine($"var type stays fixed: {fixedValue.GetType().Name}"); // Output: var type stays fixed: String

dynamic runtimeText = "codex";
Console.WriteLine($"dynamic method call: {runtimeText.ToUpper()}"); // Output: dynamic method call: CODEX

try
{
    runtimeText.UnknownMethod();
}
catch (Exception ex)
{
    Console.WriteLine($"dynamic runtime error: {ex.GetType().Name}"); // Output: dynamic runtime error: RuntimeBinderException
}

// When to use:
// Use dynamic only in special cases like old COM libraries, scripting, or some JSON scenarios.
// For normal app code, prefer strong typing.
//
// ─────────────────────────────────────────────
// Real-World Analogy:
// Think of var like a GPS route fixed at the start.
// Think of dynamic like driving and deciding each turn on the road.
// It feels flexible, but mistakes can happen late.
// ─────────────────────────────────────────────
#endregion

PrintSeparator();

#region 10 - Value Types vs Reference Types
// Value types copy the actual value.
// Changing the copy does not change the original.
//
// Reference types copy the reference.
// Two variables can point to the same object.
// If one changes the object, the other sees the change too.
//
// struct is a value type.
// class is a reference type.
// string is also a reference type, but it is immutable.
//
// Common mistake:
// Expecting a class object copy to behave like int.

int originalScore = 100;
int copiedScore = originalScore;
copiedScore = 200;

CustomerProfile customerOne = new("Ravi");
CustomerProfile customerTwo = customerOne;
customerTwo.Name = "Priya";

string originalText = "Code";
string copiedText = originalText;
bool sameTextReferenceBeforeEdit = ReferenceEquals(originalText, copiedText);
copiedText += " Review";
bool sameTextReferenceAfterEdit = ReferenceEquals(originalText, copiedText);

PointCoordinate pointOne = new(10, 20);
PointCoordinate pointTwo = pointOne;
pointTwo.X = 99;

CustomerProfile? optionalCustomer = null;
string? optionalNote = null;

Console.WriteLine($"value type original: {originalScore}"); // Output: value type original: 100
Console.WriteLine($"value type copy: {copiedScore}"); // Output: value type copy: 200
Console.WriteLine($"reference type original name: {customerOne.Name}"); // Output: reference type original name: Priya
Console.WriteLine($"reference type copy name: {customerTwo.Name}"); // Output: reference type copy name: Priya
Console.WriteLine($"string same reference before edit: {sameTextReferenceBeforeEdit}"); // Output: string same reference before edit: True
Console.WriteLine($"string same reference after edit: {sameTextReferenceAfterEdit}"); // Output: string same reference after edit: False
Console.WriteLine($"string original after edit: {originalText}"); // Output: string original after edit: Code
Console.WriteLine($"string copied after edit: {copiedText}"); // Output: string copied after edit: Code Review
Console.WriteLine($"struct original: ({pointOne.X}, {pointOne.Y})"); // Output: struct original: (10, 20)
Console.WriteLine($"struct copy: ({pointTwo.X}, {pointTwo.Y})"); // Output: struct copy: (99, 20)
Console.WriteLine($"optionalCustomer is null: {optionalCustomer is null}"); // Output: optionalCustomer is null: True
Console.WriteLine($"optionalNote is null: {optionalNote is null}"); // Output: optionalNote is null: True

// Before nullable value types, normal value types like int could not be null.
// Reference types can be null because they can hold no object reference.
//
// ─────────────────────────────────────────────
// Real-World Analogy:
// Value type is like a photocopy of a document.
// You edit your copy, and the original stays safe.
// Reference type is like a shared Google Doc.
// If one person edits it, everyone sees the same updated content.
// ─────────────────────────────────────────────
#endregion

PrintSeparator();

#region 11 - Stack vs Heap
// Stack:
// Fast memory area used for local work.
// It follows LIFO: Last In, First Out.
// It is limited in size and cleaned automatically when the method ends.
//
// Heap:
// Bigger memory area used for objects.
// It is more flexible and managed by the Garbage Collector.
// Access is usually through references.
//
// Simple beginner rule:
// Stack usually holds local values and references.
// Heap usually holds the actual reference-type objects.
//
// Which types usually go where:
// Stack: int, double, bool, char, struct, local variables
// Heap : string, object, class instances, arrays
//
// Important note:
// The reference variable itself is local, but the object it points to lives on the heap.
// That is why a class variable can sit in one place and still point to data somewhere else.
//
// Common mistake:
// Thinking string is a value type because it feels safe like one.
// string is actually a reference type.
//
// ASCII diagram:
//  Stack                          Heap
//  ──────────────────             ─────────────────────────────
//  | age = 25       |             | EmployeeRecord            |
//  | isActive=True  |             | Name = "Raj"              |
//  | employee = ref | ─────────►  | Age  = 25                 |
//  ──────────────────             ─────────────────────────────

int age = 25;
bool isActive = true;
EmployeeRecord employee = new("Raj", 25);
EmployeeRecord sameEmployee = employee;

Console.WriteLine($"stack int value: {age}"); // Output: stack int value: 25
Console.WriteLine($"stack bool value: {isActive}"); // Output: stack bool value: True
Console.WriteLine($"heap object name: {employee.Name}"); // Output: heap object name: Raj
Console.WriteLine($"heap object age: {employee.Age}"); // Output: heap object age: 25
Console.WriteLine($"same object reference: {ReferenceEquals(employee, sameEmployee)}"); // Output: same object reference: True

// Practical idea:
// age and isActive are simple local values.
// employee is a local reference variable.
// The real EmployeeRecord object exists separately on the heap.
//
// ─────────────────────────────────────────────
// Real-World Analogy:
// Think of stack like your office desk.
// It is fast, close to you, and has limited space.
// Think of heap like the company storage room.
// It is bigger, and you access items there using a reference number.
// ─────────────────────────────────────────────
#endregion

PrintSeparator();

Console.WriteLine("\n✅ All topics completed! Press any key to exit..."); 
if (!Console.IsInputRedirected)
{
    Console.ReadKey();
}

void PrintSeparator()
{
    Console.WriteLine("\n========================================\n");
}

class CustomerProfile
{
    public CustomerProfile(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
}

class EmployeeRecord
{
    public EmployeeRecord(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; set; }

    public int Age { get; set; }
}

struct PointCoordinate
{
    public PointCoordinate(int x, int y)
    {
        X = x;
        Y = y;
    }

    public int X { get; set; }

    public int Y { get; set; }
}
