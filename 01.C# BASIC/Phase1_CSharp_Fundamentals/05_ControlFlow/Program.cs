// ============================================================
// Project  : Phase 1 - C# Language Fundamentals
// Topic    : Control Flow
// Purpose  : Interview preparation & learning
// Standard : C# 10 / .NET 6+
// ============================================================

Console.WriteLine("PHASE 1 - C# LANGUAGE FUNDAMENTALS"); // Output: PHASE 1 - C# LANGUAGE FUNDAMENTALS
Console.WriteLine("Topic: Control Flow"); // Output: Topic: Control Flow
PrintSeparator();

#region 01 - if / else / else if
// if, else if, and else help the program choose one path from many options.
// This is basic decision-making in C#.
// It is common in login checks, marks grading, and status-based actions.
// A common mistake is writing conditions in the wrong order.

int trafficSignalCode = 2;
string trafficAction;

if (trafficSignalCode == 1)
{
    trafficAction = "Stop";
}
else if (trafficSignalCode == 2)
{
    trafficAction = "Get Ready";
}
else
{
    trafficAction = "Go";
}

Console.WriteLine("01 - if / else / else if"); // Output: 01 - if / else / else if
Console.WriteLine($"Traffic Signal Code: {trafficSignalCode}"); // Output: Traffic Signal Code: 2
Console.WriteLine($"Traffic Action: {trafficAction}"); // Output: Traffic Action: Get Ready

// Mistake:
// If you put a broad condition first, more specific conditions may never run.
// Read condition order carefully from top to bottom.

// 🌍 Real-World Analogy:
// Think of a traffic signal.
// Different light values lead to different driving decisions.
#endregion

PrintSeparator();

#region 02 - Nested if
// Nested if means writing one if block inside another if block.
// This is useful when one check should happen only after another check passes.
// It is common in security, payments, and approval flows.
// Too much nesting makes code hard to read.

bool isCardInserted = true;
bool isPinCorrect = true;
string atmAccessResult;

if (isCardInserted)
{
    if (isPinCorrect)
    {
        atmAccessResult = "ATM Access Granted";
    }
    else
    {
        atmAccessResult = "Invalid PIN";
    }
}
else
{
    atmAccessResult = "Insert Card First";
}

Console.WriteLine("02 - Nested if"); // Output: 02 - Nested if
Console.WriteLine($"ATM Access Result: {atmAccessResult}"); // Output: ATM Access Result: ATM Access Granted

// Mistake:
// Deep nesting quickly becomes confusing.
// When nesting grows too much, consider simpler conditions or separate methods.

// 🌍 Real-World Analogy:
// Think of security checks inside other security checks.
// First the door opens, then the ID is checked inside.
#endregion

PrintSeparator();

#region 03 - switch Statement
// switch is useful when one value can match many fixed options.
// It is cleaner than a long chain of else if in many menu-like cases.
// It works well with numbers, strings, and enums.
// Each case should end properly so control does not fall through by mistake.

int menuOption = 3;
string menuResult;

switch (menuOption)
{
    case 1:
        menuResult = "Open Account";
        break;
    case 2:
        menuResult = "Deposit Money";
        break;
    case 3:
        menuResult = "Withdraw Money";
        break;
    default:
        menuResult = "Invalid Option";
        break;
}

string dayName = "Sunday";
string workingStatus;

switch (dayName)
{
    case "Saturday":
    case "Sunday":
        workingStatus = "Holiday";
        break;
    default:
        workingStatus = "Working Day";
        break;
}

Console.WriteLine("03 - switch Statement"); // Output: 03 - switch Statement
Console.WriteLine($"Menu Result: {menuResult}"); // Output: Menu Result: Withdraw Money
Console.WriteLine($"Working Status: {workingStatus}"); // Output: Working Status: Holiday

// Mistake:
// Beginners sometimes forget break in normal switch cases.
// That makes code harder to understand and can lead to errors in older-style switch usage.

// 🌍 Real-World Analogy:
// Think of switch like a menu selection system.
// One selected option decides which block runs.
#endregion

PrintSeparator();

#region 04 - switch Expression (C# 8+)
// switch expression is a shorter and cleaner form for simple value mapping.
// It returns a value directly.
// This is useful when one input should become one output in a clear table-like way.
// Keep it simple so readability stays high.

int ticketPriority = 2;
string supportQueue = ticketPriority switch
{
    1 => "Low Priority Queue",
    2 => "Normal Priority Queue",
    3 => "High Priority Queue",
    _ => "General Queue"
};

string weatherCode = "R";
string weatherMessage = weatherCode switch
{
    "S" => "Sunny",
    "R" => "Rainy",
    "C" => "Cloudy",
    _ => "Unknown Weather"
};

Console.WriteLine("04 - switch Expression (C# 8+)"); // Output: 04 - switch Expression (C# 8+)
Console.WriteLine($"Support Queue: {supportQueue}"); // Output: Support Queue: Normal Priority Queue
Console.WriteLine($"Weather Message: {weatherMessage}"); // Output: Weather Message: Rainy

// Mistake:
// Do not force large or complicated business rules into one switch expression.
// Use it when the mapping is short and clear.

// 🌍 Real-World Analogy:
// Think of switch expression like a shortcut decision table.
// One input points straight to one output value.
#endregion

PrintSeparator();

#region 05 - for Loop
// for loop is used when you know how many times something should repeat.
// It is great for counters, reports, and fixed-size processing.
// It has three parts: start, condition, and step.
// A wrong condition can create an infinite loop.

int totalForLoopCount = 0;

Console.WriteLine("05 - for Loop"); // Output: 05 - for Loop
for (int reportPageNumber = 1; reportPageNumber <= 3; reportPageNumber++)
{
    totalForLoopCount++;
    Console.WriteLine($"Report Page Number: {reportPageNumber}"); // Output: Report Page Number: 1 / 2 / 3
}
Console.WriteLine($"Total For Loop Count: {totalForLoopCount}"); // Output: Total For Loop Count: 3

// Mistake:
// If the loop condition never becomes false, the loop keeps running forever.
// Always check that the counter moves toward the stop condition.

// 🌍 Real-World Analogy:
// Think of a for loop like printing a fixed number of report pages.
// You know in advance how many times the task should repeat.
#endregion

PrintSeparator();

#region 06 - foreach Loop
// foreach is used to read items from a collection one by one.
// It is simple and safer than index-based access for many cases.
// This is common with arrays, lists, and query results.
// Do not try to change the collection structure while iterating in a simple foreach.

string[] branchNames = { "Chennai", "Madurai", "Coimbatore" };
int totalBranches = 0;

Console.WriteLine("06 - foreach Loop"); // Output: 06 - foreach Loop
foreach (string branchName in branchNames)
{
    totalBranches++;
    Console.WriteLine($"Branch Name: {branchName}"); // Output: Branch Name: Chennai / Madurai / Coimbatore
}
Console.WriteLine($"Total Branches: {totalBranches}"); // Output: Total Branches: 3

// Mistake:
// Beginners sometimes try to add or remove items from the same collection inside foreach.
// That can cause runtime problems.

// 🌍 Real-World Analogy:
// Think of foreach like reading products from a printed list one by one.
// You move through each item in order.
#endregion

PrintSeparator();

#region 07 - while Loop
// while loop runs as long as the condition stays true.
// It is useful when the number of repetitions is not fixed in advance.
// This is common for retries, polling, and waiting-style logic.
// If the condition never changes, the loop never ends.

int pendingOrders = 3;

Console.WriteLine("07 - while Loop"); // Output: 07 - while Loop
while (pendingOrders > 0)
{
    Console.WriteLine($"Pending Orders: {pendingOrders}"); // Output: Pending Orders: 3 / 2 / 1
    pendingOrders--;
}
Console.WriteLine($"Final Pending Orders: {pendingOrders}"); // Output: Final Pending Orders: 0

// Mistake:
// Do not forget to update the condition variable inside the loop.
// If it stays the same, the while loop can become infinite.

// 🌍 Real-World Analogy:
// Think of while like repeating a task until no pending work remains.
// As long as the condition is true, work continues.
#endregion

PrintSeparator();

#region 08 - do-while Loop
// do-while is similar to while, but it runs the block at least once.
// The condition is checked after the first execution.
// This is useful when one attempt must happen before checking whether to continue.
// It is common in retry or menu loops.

int atmPinAttempts = 0;
bool isPinVerified = false;

Console.WriteLine("08 - do-while Loop"); // Output: 08 - do-while Loop
do
{
    atmPinAttempts++;
    if (atmPinAttempts == 2)
    {
        isPinVerified = true;
    }

    Console.WriteLine($"ATM PIN Attempt: {atmPinAttempts}"); // Output: ATM PIN Attempt: 1 / 2
} while (!isPinVerified && atmPinAttempts < 3);

Console.WriteLine($"PIN Verified: {isPinVerified}"); // Output: PIN Verified: True

// Mistake:
// Some learners use do-while without realizing it always runs once.
// Use it only when one first attempt is required.

// 🌍 Real-World Analogy:
// Think of an ATM PIN retry.
// The user gets at least one attempt before the system decides whether to continue.
#endregion

PrintSeparator();

#region 09 - break
// break exits the current loop immediately.
// This is useful when you already found what you need.
// It saves unnecessary extra iterations.
// Be careful in nested loops because break exits only the nearest loop.

int[] invoiceNumbers = { 101, 102, 103, 104 };
int searchInvoice = 103;
bool invoiceFound = false;

Console.WriteLine("09 - break"); // Output: 09 - break
foreach (int invoiceNumber in invoiceNumbers)
{
    Console.WriteLine($"Checking Invoice: {invoiceNumber}"); // Output: Checking Invoice: 101 / 102 / 103
    if (invoiceNumber == searchInvoice)
    {
        invoiceFound = true;
        break;
    }
}
Console.WriteLine($"Invoice Found: {invoiceFound}"); // Output: Invoice Found: True

// Mistake:
// In nested loops, break does not stop every loop.
// It only exits the loop where it appears.

// 🌍 Real-World Analogy:
// Think of break like an emergency stop button.
// Once you press it, the current running loop stops immediately.
#endregion

PrintSeparator();

#region 10 - continue
// continue skips the current iteration and moves to the next one.
// This is useful when some items should be ignored but the loop should keep running.
// It is common for validation and filtering.
// Use it carefully so you do not skip important work by accident.

int[] paymentAmounts = { 500, -50, 1200, -10, 300 };
int validPaymentCount = 0;

Console.WriteLine("10 - continue"); // Output: 10 - continue
foreach (int paymentAmount in paymentAmounts)
{
    if (paymentAmount <= 0)
    {
        continue;
    }

    validPaymentCount++;
    Console.WriteLine($"Valid Payment: {paymentAmount}"); // Output: Valid Payment: 500 / 1200 / 300
}
Console.WriteLine($"Valid Payment Count: {validPaymentCount}"); // Output: Valid Payment Count: 3

// Mistake:
// continue is helpful, but it can skip code that you actually needed to run.
// Always check what logic appears after the continue point.

// 🌍 Real-World Analogy:
// Think of continue like skipping one damaged product on a conveyor belt.
// You ignore that one item and keep processing the rest.
#endregion

PrintSeparator();

#region 11 - return & goto (avoid)
// return exits a method and sends control back to the caller.
// It is clean and common for validation and early exits.
// goto jumps to another labeled place in code.
// goto should usually be avoided because it makes code harder to follow.

string validOrderStatus = GetOrderValidationMessage(2500);
string invalidOrderStatus = GetOrderValidationMessage(-100);
int gotoExampleResult = GetGotoExampleValue();

Console.WriteLine("11 - return & goto (avoid)"); // Output: 11 - return & goto (avoid)
Console.WriteLine($"Valid Order Status: {validOrderStatus}"); // Output: Valid Order Status: Order Accepted
Console.WriteLine($"Invalid Order Status: {invalidOrderStatus}"); // Output: Invalid Order Status: Invalid Amount
Console.WriteLine($"Goto Example Result: {gotoExampleResult}"); // Output: Goto Example Result: 2

// Mistake:
// Overusing goto makes code jump around in a confusing way.
// Prefer clear conditions, loops, and methods instead.

// 🌍 Real-World Analogy:
// Think of return like leaving a room through the exit door.
// Think of goto like jumping randomly between rooms without a clean path.
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

string GetOrderValidationMessage(decimal orderAmount)
{
    if (orderAmount <= 0)
    {
        return "Invalid Amount";
    }

    return "Order Accepted";
}

int GetGotoExampleValue()
{
    int counter = 0;

StartPoint:
    counter++;
    if (counter < 2)
    {
        goto StartPoint;
    }

    return counter;
}
