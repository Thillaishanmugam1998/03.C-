// ============================================================
// Project  : Phase 1 - C# Language Fundamentals
// Topic    : Type Conversion
// Purpose  : Interview preparation & C# learning reference
// Standard : C# 10 / .NET 6+
// ============================================================

Console.WriteLine("PHASE 1 - C# LANGUAGE FUNDAMENTALS"); // Output: PHASE 1 - C# LANGUAGE FUNDAMENTALS
Console.WriteLine("Topic: Type Conversion"); // Output: Topic: Type Conversion
PrintSeparator();

#region 01 - Implicit Conversion
// Implicit conversion happens automatically.
// C# does it when moving from a smaller safe type to a bigger safe type.
// No manual cast is needed.
// No data loss should happen in this kind of conversion.

int totalOrders = 150;
long totalOrdersInLong = totalOrders;
float productRating = 4.5f;
double productRatingInDouble = productRating;

Console.WriteLine("01 - Implicit Conversion"); // Output: 01 - Implicit Conversion
Console.WriteLine($"int value: {totalOrders}"); // Output: int value: 150
Console.WriteLine($"converted long value: {totalOrdersInLong}"); // Output: converted long value: 150
Console.WriteLine($"float value: {productRating}"); // Output: float value: 4.5
Console.WriteLine($"converted double value: {productRatingInDouble}"); // Output: converted double value: 4.5

// Real-World Analogy:
// Think of pouring water from a small glass into a big bottle.
// It fits safely.
// Use implicit conversion when the target type can hold the value without trouble.
#endregion

PrintSeparator();

#region 02 - Explicit Conversion (Casting)
// Explicit conversion means we force the conversion using a cast.
// C# asks for this because data loss may happen.
// This is common when moving from a bigger type to a smaller type.

double productPrice = 199.99;
int roundedPriceByCast = (int)productPrice;
long hugeVisitorCount = 3_000_000_000;
int visitorCountAsInt = (int)hugeVisitorCount;

Console.WriteLine("02 - Explicit Conversion (Casting)"); // Output: 02 - Explicit Conversion (Casting)
Console.WriteLine($"double value: {productPrice}"); // Output: double value: 199.99
Console.WriteLine($"cast int value: {roundedPriceByCast}"); // Output: cast int value: 199
Console.WriteLine($"long value: {hugeVisitorCount}"); // Output: long value: 3000000000
Console.WriteLine($"cast int with data loss: {visitorCountAsInt}"); // Output: cast int with data loss: -1294967296

// Real-World Analogy:
// Think of pouring water from a big bucket into a small cup.
// Some water may spill.
// Use explicit conversion carefully because some value may be lost.
#endregion

PrintSeparator();

#region 03 - Convert Class
// Convert class gives helper methods for many common conversions.
// It is useful when converting values from user input, database values, or object values.
// Convert.ToInt32(null) returns 0 for nullable or object input.
// This makes it different from Parse().

string quantityText = "25";
object? nullableValue = null;
double billAmount = 1499.75;

int convertedQuantity = Convert.ToInt32(quantityText);
int convertedNullValue = Convert.ToInt32(nullableValue);
string billAsText = Convert.ToString(billAmount)!;

Console.WriteLine("03 - Convert Class"); // Output: 03 - Convert Class
Console.WriteLine($"Convert.ToInt32(\"25\"): {convertedQuantity}"); // Output: Convert.ToInt32("25"): 25
Console.WriteLine($"Convert.ToInt32(null): {convertedNullValue}"); // Output: Convert.ToInt32(null): 0
Console.WriteLine($"Convert.ToString(1499.75): {billAsText}"); // Output: Convert.ToString(1499.75): 1499.75

// Real-World Analogy:
// Think of Convert like a helpful office assistant.
// It can handle many common format changes for you.
// It is good when app data comes in different shapes.
#endregion

PrintSeparator();

#region 04 - Parse()
// Parse() is strict.
// It expects the text to be in the correct format.
// If the format is wrong, it throws an exception.
// Use it only when you are very sure the input is valid.

string ageText = "30";
string badAgeText = "30Years";
int parsedAge = int.Parse(ageText);

Console.WriteLine("04 - Parse()"); // Output: 04 - Parse()
Console.WriteLine($"int.Parse(\"30\"): {parsedAge}"); // Output: int.Parse("30"): 30

try
{
    int.Parse(badAgeText);
}
catch (FormatException ex)
{
    Console.WriteLine($"Parse invalid text error: {ex.GetType().Name}"); // Output: Parse invalid text error: FormatException
}

// Real-World Analogy:
// Think of Parse like a strict security guard.
// If the ID card format is not correct, entry is denied.
// Use Parse only when the text is already clean and trusted.
#endregion

PrintSeparator();

#region 05 - TryParse()
// TryParse() is the safe version of Parse().
// It does not throw an exception for bad input.
// It returns true or false.
// The converted value comes through the out variable.
// This is the best choice for user input in many real apps.

string validMarksText = "85";
string invalidMarksText = "eighty five";

bool validParseResult = int.TryParse(validMarksText, out int validMarks);
bool invalidParseResult = int.TryParse(invalidMarksText, out int invalidMarks);

Console.WriteLine("05 - TryParse()"); // Output: 05 - TryParse()
Console.WriteLine($"TryParse valid result: {validParseResult}"); // Output: TryParse valid result: True
Console.WriteLine($"TryParse valid value: {validMarks}"); // Output: TryParse valid value: 85
Console.WriteLine($"TryParse invalid result: {invalidParseResult}"); // Output: TryParse invalid result: False
Console.WriteLine($"TryParse invalid value: {invalidMarks}"); // Output: TryParse invalid value: 0

// Real-World Analogy:
// Think of TryParse like checking a ticket politely.
// If the ticket is valid, entry is allowed.
// If not, the app stays calm and continues safely.
#endregion

PrintSeparator();

#region 06 - is Operator
// is operator checks type safely.
// It answers: "Is this object of this type?"
// It returns true or false.
// It is useful when working with object variables, inheritance, or mixed data.

object loginCount = 10;
object customerCode = "CUST-1001";
bool isLoginCountInt = loginCount is int;
bool isCustomerCodeString = customerCode is string;
bool isCustomerCodeDateTime = customerCode is DateTime;

Console.WriteLine("06 - is Operator"); // Output: 06 - is Operator
Console.WriteLine($"loginCount is int: {isLoginCountInt}"); // Output: loginCount is int: True
Console.WriteLine($"customerCode is string: {isCustomerCodeString}"); // Output: customerCode is string: True
Console.WriteLine($"customerCode is DateTime: {isCustomerCodeDateTime}"); // Output: customerCode is DateTime: False

// Real-World Analogy:
// Think of is like checking a label on a package.
// Before opening it, you first check what kind of item is inside.
// It helps you avoid using the wrong type.
#endregion

PrintSeparator();

#region 07 - as Operator
// as operator tries safe casting.
// If the cast works, it returns the object in the new type.
// If the cast fails, it returns null.
// It works only with reference types and nullable types.
// It does not throw an exception for a failed cast.

object employeeNameObject = "Ravi";
object quantityObject = 25;

string? employeeName = employeeNameObject as string;
string? quantityAsString = quantityObject as string;

Console.WriteLine("07 - as Operator"); // Output: 07 - as Operator
Console.WriteLine($"employeeName using as: {employeeName}"); // Output: employeeName using as: Ravi
Console.WriteLine($"quantityAsString is null: {quantityAsString is null}"); // Output: quantityAsString is null: True

// Real-World Analogy:
// Think of as like trying a key in a lock.
// If the key matches, the door opens.
// If not, nothing breaks. You simply get no result.
#endregion

PrintSeparator();

#region 08 - Boxing & Unboxing
// Boxing means storing a value type inside an object reference.
// Unboxing means taking the original value type back out from the object.
// Boxing and unboxing add extra work.
// So in performance-heavy code, avoid unnecessary boxing.

int score = 100;
object boxedScore = score;
int unboxedScore = (int)boxedScore;

Console.WriteLine("08 - Boxing & Unboxing"); // Output: 08 - Boxing & Unboxing
Console.WriteLine($"original int value: {score}"); // Output: original int value: 100
Console.WriteLine($"boxed object value: {boxedScore}"); // Output: boxed object value: 100
Console.WriteLine($"boxed object type: {boxedScore.GetType().Name}"); // Output: boxed object type: Int32
Console.WriteLine($"unboxed int value: {unboxedScore}"); // Output: unboxed int value: 100

// Real-World Analogy:
// Think of boxing like placing a small item inside a storage box.
// Unboxing means opening the box and taking the exact item back out.
// It works, but repeated packing and unpacking takes extra effort.
#endregion

PrintSeparator();

Console.WriteLine("All topics completed!"); // Output: All topics completed!
if (!Console.IsInputRedirected)
{
    Console.ReadKey();
}

void PrintSeparator()
{
    Console.WriteLine("\n========================================\n"); 
}
