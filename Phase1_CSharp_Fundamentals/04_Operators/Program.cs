// ============================================================
// Project  : Phase 1 - C# Language Fundamentals
// Topic    : Operators
// Purpose  : Interview preparation & learning
// Standard : C# 10 / .NET 6+
// ============================================================

Console.WriteLine("PHASE 1 - C# LANGUAGE FUNDAMENTALS"); // Output: PHASE 1 - C# LANGUAGE FUNDAMENTALS
Console.WriteLine("Topic: Operators"); // Output: Topic: Operators
PrintSeparator();

#region 01 - Arithmetic Operators
// Arithmetic operators are used for normal calculations.
// They are common in billing, cart totals, score calculation, and quantity processing.
// + adds, - subtracts, * multiplies, / divides, and % gives the remainder.
// A very common beginner mistake is forgetting that int / int returns int.

int firstNumber = 20;
int secondNumber = 6;
int sum = firstNumber + secondNumber;
int difference = firstNumber - secondNumber;
int product = firstNumber * secondNumber;
int integerDivision = firstNumber / secondNumber;
int remainder = firstNumber % secondNumber;
double decimalDivision = (double)firstNumber / secondNumber;

Console.WriteLine("01 - Arithmetic Operators"); // Output: 01 - Arithmetic Operators
Console.WriteLine($"Addition: {sum}"); // Output: Addition: 26
Console.WriteLine($"Subtraction: {difference}"); // Output: Subtraction: 14
Console.WriteLine($"Multiplication: {product}"); // Output: Multiplication: 120
Console.WriteLine($"Integer Division: {integerDivision}"); // Output: Integer Division: 3
Console.WriteLine($"Decimal Division: {decimalDivision}"); // Output: Decimal Division: 3.3333333333333335
Console.WriteLine($"Remainder: {remainder}"); // Output: Remainder: 2

// Mistake:
// If both values are int, the result is also int.
// So 20 / 6 becomes 3, not 3.33.

// 🌍 Real-World Analogy:
// Think of arithmetic operators like the buttons on a basic calculator.
// You press different buttons depending on the kind of calculation you need.
#endregion

PrintSeparator();

#region 02 - Relational Operators
// Relational operators compare two values.
// The result is always true or false.
// They are used in validation, filtering, and decision-making logic.
// One of the most common mistakes is confusing = with ==.

int mathsMarks = 85;
int passingMarks = 35;
bool isEqual = mathsMarks == passingMarks;
bool isNotEqual = mathsMarks != passingMarks;
bool isGreater = mathsMarks > passingMarks;
bool isLess = mathsMarks < passingMarks;
bool isGreaterOrEqual = mathsMarks >= 85;
bool isLessOrEqual = passingMarks <= 35;

Console.WriteLine("02 - Relational Operators"); // Output: 02 - Relational Operators
Console.WriteLine($"Equal: {isEqual}"); // Output: Equal: False
Console.WriteLine($"Not Equal: {isNotEqual}"); // Output: Not Equal: True
Console.WriteLine($"Greater Than: {isGreater}"); // Output: Greater Than: True
Console.WriteLine($"Less Than: {isLess}"); // Output: Less Than: False
Console.WriteLine($"Greater Or Equal: {isGreaterOrEqual}"); // Output: Greater Or Equal: True
Console.WriteLine($"Less Or Equal: {isLessOrEqual}"); // Output: Less Or Equal: True

// Mistake:
// = assigns a value, but == compares values.
// In conditions, using the wrong operator causes bugs and confusion.

// 🌍 Real-World Analogy:
// Think of relational operators like comparing exam marks with pass marks.
// You are checking how one value stands against another.
#endregion

PrintSeparator();

#region 03 - Logical Operators
// Logical operators combine boolean conditions.
// && means both conditions must be true.
// || means at least one condition must be true.
// ! reverses the boolean result.

bool isUserNameCorrect = true;
bool isPasswordCorrect = false;
bool loginSuccess = isUserNameCorrect && isPasswordCorrect;
bool canShowHelp = isUserNameCorrect || isPasswordCorrect;
bool loginFailed = !loginSuccess;

Console.WriteLine("03 - Logical Operators"); // Output: 03 - Logical Operators
Console.WriteLine($"AND Result: {loginSuccess}"); // Output: AND Result: False
Console.WriteLine($"OR Result: {canShowHelp}"); // Output: OR Result: True
Console.WriteLine($"NOT Result: {loginFailed}"); // Output: NOT Result: True
Console.WriteLine($"True AND True: {true && true}"); // Output: True AND True: True
Console.WriteLine($"False OR False: {false || false}"); // Output: False OR False: False

// Mistake:
// When conditions become long, beginners often group them incorrectly.
// Read the full condition carefully before combining AND and OR logic.

// 🌍 Real-World Analogy:
// Think of a login system.
// A user usually needs the correct username AND the correct password.
#endregion

PrintSeparator();

#region 04 - Short-Circuit Behavior (&& vs &)
// && is the short-circuit AND operator.
// If the left side is false, C# does not check the right side.
// & with booleans checks both sides every time.
// This matters when the right side calls a method or touches risky data.

bool firstCheckFailed = false;

Console.WriteLine("04 - Short-Circuit Behavior (&& vs &)"); // Output: 04 - Short-Circuit Behavior (&& vs &)
bool resultWithShortCircuit = firstCheckFailed && CheckSecondCondition("&&");
bool resultWithSingleAnd = firstCheckFailed & CheckSecondCondition("&");
Console.WriteLine($"Result With &&: {resultWithShortCircuit}"); // Output: Result With &&: False
Console.WriteLine($"Result With &: {resultWithSingleAnd}"); // Output: Result With &: False

// Mistake:
// Some learners use & when they really mean &&.
// That can run extra logic and even cause avoidable errors.

// 🌍 Real-World Analogy:
// Think of a security gate.
// If the first ID check fails, there is no reason to continue to the second check.
#endregion

PrintSeparator();

#region 05 - Bitwise Operators
// Bitwise operators work directly on the binary bits of numbers.
// They are different from logical operators, even though some symbols look similar.
// They are useful in flags, permissions, and low-level data work.
// For beginners, the key idea is to think in ON and OFF switches.

int bitValueOne = 5;
int bitValueTwo = 3;
int bitwiseAnd = bitValueOne & bitValueTwo;
int bitwiseOr = bitValueOne | bitValueTwo;
int bitwiseXor = bitValueOne ^ bitValueTwo;
int bitwiseNot = ~bitValueOne;

Console.WriteLine("05 - Bitwise Operators"); // Output: 05 - Bitwise Operators
Console.WriteLine($"Value One: {bitValueOne}"); // Output: Value One: 5
Console.WriteLine($"Value Two: {bitValueTwo}"); // Output: Value Two: 3
Console.WriteLine($"Bitwise AND: {bitwiseAnd}"); // Output: Bitwise AND: 1
Console.WriteLine($"Bitwise OR: {bitwiseOr}"); // Output: Bitwise OR: 7
Console.WriteLine($"Bitwise XOR: {bitwiseXor}"); // Output: Bitwise XOR: 6
Console.WriteLine($"Bitwise NOT: {bitwiseNot}"); // Output: Bitwise NOT: -6

// Mistake:
// Do not confuse logical AND/OR with bitwise AND/OR.
// Logical operators work with true or false, but bitwise operators work with bits in numbers.

// 🌍 Real-World Analogy:
// Think of each bit as a small switch that is either ON or OFF.
// Bitwise operators compare or flip those switches.
#endregion

PrintSeparator();

#region 06 - Shift Operators (<<, >>)
// Shift operators move bits left or right.
// Left shift usually doubles the number for each move.
// Right shift usually halves the number for each move.
// This happens because the bits are moved to new positions.

int baseValue = 8;
int leftShiftedValue = baseValue << 1;
int rightShiftedValue = baseValue >> 1;
int doubleLeftShiftedValue = baseValue << 2;

Console.WriteLine("06 - Shift Operators (<<, >>)"); // Output: 06 - Shift Operators (<<, >>)
Console.WriteLine($"Base Value: {baseValue}"); // Output: Base Value: 8
Console.WriteLine($"Left Shift By 1: {leftShiftedValue}"); // Output: Left Shift By 1: 16
Console.WriteLine($"Right Shift By 1: {rightShiftedValue}"); // Output: Right Shift By 1: 4
Console.WriteLine($"Left Shift By 2: {doubleLeftShiftedValue}"); // Output: Left Shift By 2: 32

// Mistake:
// If you only memorize the answer and ignore the bit movement, shift operators feel confusing.
// Learn the idea of moving bits, not just the final number.

// 🌍 Real-World Analogy:
// Think of shift operators like moving digits left or right on a place-value chart.
// Their position changes, so the number changes too.
#endregion

PrintSeparator();

#region 07 - Ternary Operator (?:)
// Ternary is a short way to write a simple if-else decision.
// It is useful when you want one value for true and another for false.
// This keeps short decisions compact.
// Avoid nesting many ternary operators because readability drops fast.

int score = 78;
string examResult = score >= 35 ? "Pass" : "Fail";
string discountLabel = score >= 75 ? "Priority Student" : "Regular Student";

Console.WriteLine("07 - Ternary Operator (?:)"); // Output: 07 - Ternary Operator (?:)
Console.WriteLine($"Exam Result: {examResult}"); // Output: Exam Result: Pass
Console.WriteLine($"Discount Label: {discountLabel}"); // Output: Discount Label: Priority Student

// Mistake:
// Ternary is best for small decisions.
// If the logic becomes long, use a normal if-else block for clarity.

// 🌍 Real-World Analogy:
// Think of ternary like a quick decision switch.
// If the condition is true, choose one side; otherwise choose the other side.
#endregion

PrintSeparator();

#region 08 - Null-Coalescing (??)
// ?? gives a fallback value when the left side is null.
// This is very useful when reading optional API data, configuration, or user profile values.
// It helps avoid null-related crashes and messy if checks.

string? apiDisplayName = null;
string? apiCity = "Chennai";
string displayName = apiDisplayName ?? "Guest User";
string cityName = apiCity ?? "Unknown City";

Console.WriteLine("08 - Null-Coalescing (??)"); // Output: 08 - Null-Coalescing (??)
Console.WriteLine($"Display Name: {displayName}"); // Output: Display Name: Guest User
Console.WriteLine($"City Name: {cityName}"); // Output: City Name: Chennai

// Mistake:
// If you ignore possible null values, your program may break later.
// ?? gives you a safe fallback value immediately.

// 🌍 Real-World Analogy:
// Think of ?? like keeping a backup option ready.
// If the first choice is missing, you use the fallback choice.
#endregion

PrintSeparator();

#region 09 - Null-Coalescing Assignment (??=)
// ??= assigns a value only when the variable is currently null.
// It is useful for defaults, lazy setup, and avoiding accidental overwrites.
// This keeps existing values safe.

string? connectionString = null;
connectionString ??= "Server=DEV;Database=TrainingDb;";
connectionString ??= "Server=PROD;Database=MainDb;";

List<string>? errorMessages = null;
errorMessages ??= new List<string>();
errorMessages.Add("Invalid email address");

Console.WriteLine("09 - Null-Coalescing Assignment (??=)"); // Output: 09 - Null-Coalescing Assignment (??=)
Console.WriteLine($"Connection String: {connectionString}"); // Output: Connection String: Server=DEV;Database=TrainingDb;
Console.WriteLine($"Error Count: {errorMessages.Count}"); // Output: Error Count: 1

// Mistake:
// Beginners sometimes assign defaults again and again.
// ??= protects existing values by filling only when the variable is empty.

// 🌍 Real-World Analogy:
// Think of ??= like filling an empty form field.
// If the field already has a value, you leave it untouched.
#endregion

PrintSeparator();

#region 10 - Null-Conditional (?.)
// ?. safely accesses a member only when the object is not null.
// If the object is null, the full expression returns null instead of crashing.
// This is useful with optional user data, API responses, and nested objects.

CustomerProfile? registeredCustomer = new CustomerProfile
{
    FullName = "Aarav",
    Address = new CustomerAddress
    {
        City = "Coimbatore"
    }
};

CustomerProfile? guestCustomer = null;
string? registeredCustomerName = registeredCustomer?.FullName;
string? registeredCustomerCity = registeredCustomer?.Address?.City;
string? guestCustomerName = guestCustomer?.FullName;

Console.WriteLine("10 - Null-Conditional (?.)"); // Output: 10 - Null-Conditional (?.)
Console.WriteLine($"Registered Customer Name: {registeredCustomerName}"); // Output: Registered Customer Name: Aarav
Console.WriteLine($"Registered Customer City: {registeredCustomerCity}"); // Output: Registered Customer City: Coimbatore
Console.WriteLine($"Guest Customer Name: {guestCustomerName ?? "null"}"); // Output: Guest Customer Name: null

// Mistake:
// Accessing properties on a null object causes NullReferenceException.
// ?. lets you check and access in one safe step.

// 🌍 Real-World Analogy:
// Think of ?. like checking whether a door exists before trying to open it.
// If there is no door, you stop safely instead of crashing into a wall.
#endregion

PrintSeparator();

#region 11 - Combined Real-World Scenarios
// Real applications often combine multiple operators in one workflow.
// This section shows simple business-style scenarios using the operators from earlier regions.
// These examples are useful for interviews because they feel close to everyday app code.

string enteredUserName = "admin";
string enteredPassword = "Pass@123";
bool isLoginAllowed = enteredUserName == "admin" && enteredPassword == "Pass@123";

string? optionalCouponCode = null;
string appliedCouponCode = optionalCouponCode ?? "NO-COUPON";

ApiResponse? apiResponse = new ApiResponse
{
    Customer = new CustomerProfile
    {
        FullName = "Divya",
        Address = new CustomerAddress
        {
            City = "Madurai"
        }
    }
};

string customerCityFromApi = apiResponse?.Customer?.Address?.City ?? "City Not Available";
int finalMarks = 91;
string grade = finalMarks >= 90 ? "A" : "B";

const int readPermission = 1;
const int writePermission = 2;
int userPermissions = readPermission | writePermission;
bool hasWritePermission = (userPermissions & writePermission) == writePermission;

Console.WriteLine("11 - Combined Real-World Scenarios"); // Output: 11 - Combined Real-World Scenarios
Console.WriteLine($"Login Allowed: {isLoginAllowed}"); // Output: Login Allowed: True
Console.WriteLine($"Applied Coupon Code: {appliedCouponCode}"); // Output: Applied Coupon Code: NO-COUPON
Console.WriteLine($"Customer City From API: {customerCityFromApi}"); // Output: Customer City From API: Madurai
Console.WriteLine($"Grade: {grade}"); // Output: Grade: A
Console.WriteLine($"User Permissions Value: {userPermissions}"); // Output: User Permissions Value: 3
Console.WriteLine($"Has Write Permission: {hasWritePermission}"); // Output: Has Write Permission: True

// Mistake:
// In real code, beginners often learn operators one by one but struggle to combine them.
// Practice small real-world scenarios so the operators feel natural together.

// 🌍 Real-World Analogy:
// Think of this region like a mini business app.
// One screen can validate login, apply defaults, read API data, assign grades, and check permissions.
#endregion

PrintSeparator();

Console.WriteLine("\n✅ All topics completed! Press any key to exit..."); // Output: ✅ All topics completed! Press any key to exit...
if (!Console.IsInputRedirected)
{
    Console.ReadKey();
}

void PrintSeparator()
{
    Console.WriteLine("\n========================================\n"); // Output: ========================================
}

bool CheckSecondCondition(string operatorUsed)
{
    Console.WriteLine($"Second Check Called With: {operatorUsed}"); // Output: Second Check Called With: &
    return true;
}

class CustomerProfile
{
    public string? FullName { get; set; }
    public CustomerAddress? Address { get; set; }
}

class CustomerAddress
{
    public string? City { get; set; }
}

class ApiResponse
{
    public CustomerProfile? Customer { get; set; }
}
