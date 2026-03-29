// ============================================================
// Project  : Phase 1 - C# Language Fundamentals
// Topic    : Methods
// Purpose  : Interview preparation & learning
// Standard : C# 10 / .NET 6+
// ============================================================

Console.WriteLine("PHASE 1 - C# LANGUAGE FUNDAMENTALS"); // Output: PHASE 1 - C# LANGUAGE FUNDAMENTALS
Console.WriteLine("Topic: Methods"); // Output: Topic: Methods
PrintSeparator();

#region 01 - Method Basics
// Methods help us group reusable logic into one named block.
// Some methods return a value, and some methods do work without returning anything.
// This is useful in calculators, banking apps, APIs, and validation logic.
// A common mistake is forgetting to return a value from a method that promises one.

int firstAmount = 1200;
int secondAmount = 800;
int totalAmount = AddAmounts(firstAmount, secondAmount);
string greetingMessage = GetGreetingMessage("Asha");

Console.WriteLine("01 - Method Basics"); // Output: 01 - Method Basics
Console.WriteLine($"Total Amount: {totalAmount}"); // Output: Total Amount: 2000
Console.WriteLine($"Greeting Message: {greetingMessage}"); // Output: Greeting Message: Welcome, Asha
DisplayProcessStatus("Method Basics Completed");

// Mistake:
// If a method has a return type, you must return a value of that type.
// If the method is void, it does not send a value back.

// 🌍 Real-World Analogy:
// Think of a method like a machine.
// It takes input, does work, and may return an output.
#endregion

PrintSeparator();

#region 02 - Parameters (Value Type)
// Value type parameters are passed by value by default.
// That means the method receives a copy of the original variable.
// Changes inside the method affect only the copy.
// The original variable outside the method remains unchanged.

int walletBalance = 500;
IncreaseBalanceByValue(walletBalance);

Console.WriteLine("02 - Parameters (Value Type)"); // Output: 02 - Parameters (Value Type)
Console.WriteLine($"Wallet Balance After Method Call: {walletBalance}"); // Output: Wallet Balance After Method Call: 500

// Mistake:
// Beginners often expect the original variable to change.
// With normal value parameters, only the copied value changes inside the method.

// 🌍 Real-World Analogy:
// Think of value passing like giving a photocopy of a document.
// Edits on the copy do not affect the original paper.
#endregion

PrintSeparator();

#region 03 - ref Parameter
// ref passes the variable by reference.
// The method works with the original variable, not a copy.
// The variable must already be initialized before passing it with ref.
// This is useful when a method needs to update the caller's value directly.

decimal accountBalance = 1000m;
AddBonus(ref accountBalance, 250m);

Console.WriteLine("03 - ref Parameter"); // Output: 03 - ref Parameter
Console.WriteLine($"Account Balance After Bonus: {accountBalance}"); // Output: Account Balance After Bonus: 1250

// Mistake:
// A ref variable must have a value before you pass it.
// If it is not initialized, the code will not compile.

// 🌍 Real-World Analogy:
// Think of ref like a shared document.
// Both the caller and the method are editing the same file.
#endregion

PrintSeparator();

#region 04 - out Parameter
// out is used when a method must send extra values back to the caller.
// The variable does not need a value before the call.
// But the method must assign a value before it finishes.
// This is common in parsing and multi-result methods.

bool divisionSuccess = TryDivide(20, 4, out int divisionResult, out string divisionStatus);

Console.WriteLine("04 - out Parameter"); // Output: 04 - out Parameter
Console.WriteLine($"Division Success: {divisionSuccess}"); // Output: Division Success: True
Console.WriteLine($"Division Result: {divisionResult}"); // Output: Division Result: 5
Console.WriteLine($"Division Status: {divisionStatus}"); // Output: Division Status: Division Completed

// Mistake:
// Every out parameter must be assigned inside the method.
// If you forget, the code will not compile.

// 🌍 Real-World Analogy:
// Think of out like getting multiple outputs from one machine.
// One method can return a status and also hand back extra result values.
#endregion

PrintSeparator();

#region 05 - in Parameter
// in passes a value by reference, but it is read-only inside the method.
// This avoids copying while still protecting the value from modification.
// It is useful when you want safe read-only access.
// Trying to change an in parameter inside the method causes a compile-time error.

decimal yearlySalary = 600000m;
decimal taxAmount = CalculateTax(in yearlySalary);

Console.WriteLine("05 - in Parameter"); // Output: 05 - in Parameter
Console.WriteLine($"Yearly Salary: {yearlySalary}"); // Output: Yearly Salary: 600000
Console.WriteLine($"Tax Amount: {taxAmount}"); // Output: Tax Amount: 60000

// Mistake:
// Do not try to assign a new value to an in parameter inside the method.
// It is meant for read-only access.

// 🌍 Real-World Analogy:
// Think of in like view-only access to a document.
// You can read it carefully, but you cannot edit it.
#endregion

PrintSeparator();

#region 06 - Optional Parameters
// Optional parameters have default values.
// This lets the caller skip some arguments when the default is acceptable.
// They are useful in report generation, logging, and formatting helpers.
// Optional parameters should come after required parameters.

string defaultReceipt = CreateReceipt("INV-1001");
string customReceipt = CreateReceipt("INV-1002", "Paid", "Online");

Console.WriteLine("06 - Optional Parameters"); // Output: 06 - Optional Parameters
Console.WriteLine($"Default Receipt: {defaultReceipt}"); // Output: Default Receipt: Invoice: INV-1001, Status: Pending, Mode: Cash
Console.WriteLine($"Custom Receipt: {customReceipt}"); // Output: Custom Receipt: Invoice: INV-1002, Status: Paid, Mode: Online

// Mistake:
// Required parameters should not appear after optional ones in a method signature.
// Keep optional parameters at the end.

// 🌍 Real-World Analogy:
// Think of optional parameters like default app settings.
// If you do not change them, the system uses the standard values.
#endregion

PrintSeparator();

#region 07 - Named Parameters
// Named parameters let you pass arguments using parameter names.
// This improves readability when a method has multiple inputs of the same type.
// It is very helpful in APIs and report helpers.
// Use names carefully so the call stays clear and consistent.

string bookingSummary = CreateBookingSummary(customerName: "Kiran", city: "Chennai", roomType: "Deluxe");
string reorderedBookingSummary = CreateBookingSummary(roomType: "Suite", customerName: "Latha", city: "Madurai");

Console.WriteLine("07 - Named Parameters"); // Output: 07 - Named Parameters
Console.WriteLine($"Booking Summary: {bookingSummary}"); // Output: Booking Summary: Customer: Kiran, City: Chennai, Room Type: Deluxe
Console.WriteLine($"Reordered Booking Summary: {reorderedBookingSummary}"); // Output: Reordered Booking Summary: Customer: Latha, City: Madurai, Room Type: Suite

// Mistake:
// Mixing positional and named arguments carelessly can make the call confusing.
// Named arguments are best when they improve clarity.

// 🌍 Real-World Analogy:
// Think of named parameters like filling a form with labeled fields.
// The labels make it clear which value belongs where.
#endregion

PrintSeparator();

#region 08 - Method Overloading
// Method overloading means using the same method name with different parameter lists.
// C# chooses the correct version based on the arguments you pass.
// This keeps related logic grouped under one clear method name.
// Different overloads must have different signatures.

int sumOfTwoNumbers = MethodExamples.CalculateTotal(10, 20);
decimal sumOfThreeAmounts = MethodExamples.CalculateTotal(10.5m, 20.5m, 30.0m);
string combinedNames = MethodExamples.CalculateTotal("Ravi", "Kumar");

Console.WriteLine("08 - Method Overloading"); // Output: 08 - Method Overloading
Console.WriteLine($"Sum Of Two Numbers: {sumOfTwoNumbers}"); // Output: Sum Of Two Numbers: 30
Console.WriteLine($"Sum Of Three Amounts: {sumOfThreeAmounts}"); // Output: Sum Of Three Amounts: 61.0
Console.WriteLine($"Combined Names: {combinedNames}"); // Output: Combined Names: Ravi Kumar

// Mistake:
// Changing only the return type is not enough for overloads.
// The parameter list must be different.

// 🌍 Real-World Analogy:
// Think of overloading like different versions of the same tool.
// The tool name is the same, but each version handles a different kind of input.
#endregion

PrintSeparator();

#region 09 - params Keyword
// params lets a method accept a variable number of arguments.
// It is useful when you do not know how many values the caller will send.
// This is common in calculators, totals, and tag builders.
// Only one params parameter is allowed, and it must be the last parameter.

int weekendSalesTotal = CalculateSalesTotal(150, 200, 300, 450);
int noSalesTotal = CalculateSalesTotal();

Console.WriteLine("09 - params Keyword"); // Output: 09 - params Keyword
Console.WriteLine($"Weekend Sales Total: {weekendSalesTotal}"); // Output: Weekend Sales Total: 1100
Console.WriteLine($"No Sales Total: {noSalesTotal}"); // Output: No Sales Total: 0

// Mistake:
// params must appear only once and at the end of the parameter list.
// Otherwise, the method signature is invalid.

// 🌍 Real-World Analogy:
// Think of params like a shopping cart.
// You can keep adding items, and the method handles however many arrive.
#endregion

PrintSeparator();

#region 10 - Local Functions
// A local function is a function declared inside another method.
// It is useful when one method needs a small helper that is not useful anywhere else.
// This keeps related logic close together.
// Overusing local functions can make long methods harder to read.

int invoiceTotal = BuildInvoiceTotal(100, 200, 50);

Console.WriteLine("10 - Local Functions"); // Output: 10 - Local Functions
Console.WriteLine($"Invoice Total: {invoiceTotal}"); // Output: Invoice Total: 350

// Mistake:
// Do not keep adding many local functions into one method until it becomes crowded.
// Use them when they truly support one focused task.

// 🌍 Real-World Analogy:
// Think of a local function like a small helper standing inside the main task area.
// It helps the current job, but it is not meant for the whole building.
#endregion

PrintSeparator();

#region 11 - Expression-Bodied Methods
// Expression-bodied methods use => for short single-expression logic.
// They are clean for simple calculations and formatting.
// They are not a good choice for long or complex business logic.
// Use them when the method is small and obvious.

int squareValue = GetSquare(6);
string customerCode = FormatCustomerCode("cst", 108);

Console.WriteLine("11 - Expression-Bodied Methods"); // Output: 11 - Expression-Bodied Methods
Console.WriteLine($"Square Value: {squareValue}"); // Output: Square Value: 36
Console.WriteLine($"Customer Code: {customerCode}"); // Output: Customer Code: CST-108

// Mistake:
// Expression-bodied methods are best for short logic.
// If the logic grows, switch back to a normal method body.

// 🌍 Real-World Analogy:
// Think of expression-bodied methods like a shortcut formula.
// One compact line gives the result quickly.
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

int AddAmounts(int firstValue, int secondValue)
{
    return firstValue + secondValue;
}

string GetGreetingMessage(string userName)
{
    return $"Welcome, {userName}";
}

void DisplayProcessStatus(string statusMessage)
{
    Console.WriteLine($"Process Status: {statusMessage}"); // Output: Process Status: Method Basics Completed
}

void IncreaseBalanceByValue(int balance)
{
    balance += 100;
}

void AddBonus(ref decimal balance, decimal bonusAmount)
{
    balance += bonusAmount;
}

bool TryDivide(int dividend, int divisor, out int result, out string status)
{
    if (divisor == 0)
    {
        result = 0;
        status = "Division Failed";
        return false;
    }

    result = dividend / divisor;
    status = "Division Completed";
    return true;
}

decimal CalculateTax(in decimal annualSalary)
{
    return annualSalary * 0.10m;
}

string CreateReceipt(string invoiceNumber, string status = "Pending", string paymentMode = "Cash")
{
    return $"Invoice: {invoiceNumber}, Status: {status}, Mode: {paymentMode}";
}

string CreateBookingSummary(string customerName, string city, string roomType)
{
    return $"Customer: {customerName}, City: {city}, Room Type: {roomType}";
}

int CalculateSalesTotal(params int[] saleAmounts)
{
    int total = 0;

    foreach (int saleAmount in saleAmounts)
    {
        total += saleAmount;
    }

    return total;
}

int BuildInvoiceTotal(int productAmount, int shippingAmount, int taxAmount)
{
    int AddLineItems()
    {
        return productAmount + shippingAmount + taxAmount;
    }

    return AddLineItems();
}

int GetSquare(int number) => number * number;

string FormatCustomerCode(string prefix, int number) => $"{prefix.ToUpperInvariant()}-{number}";

static class MethodExamples
{
    public static int CalculateTotal(int firstNumber, int secondNumber)
    {
        return firstNumber + secondNumber;
    }

    public static decimal CalculateTotal(decimal firstAmount, decimal secondAmount, decimal thirdAmount)
    {
        return firstAmount + secondAmount + thirdAmount;
    }

    public static string CalculateTotal(string firstName, string lastName)
    {
        return $"{firstName} {lastName}";
    }
}
