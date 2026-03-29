using System.Diagnostics;
using System.Text;

// ============================================================
// Project  : Phase 1 - C# Language Fundamentals
// Topic    : String & StringBuilder
// Purpose  : Interview preparation & learning
// Standard : C# 10 / .NET 6+
// ============================================================

Console.WriteLine("PHASE 1 - C# LANGUAGE FUNDAMENTALS"); // Output: PHASE 1 - C# LANGUAGE FUNDAMENTALS
Console.WriteLine("Topic: String & StringBuilder"); // Output: Topic: String & StringBuilder
PrintSeparator();

#region 01 - String Basics
// string stores textual data like names, messages, file paths, and API responses.
// Even though we use it often like a simple value, string is actually a reference type.
// That means the variable holds a reference to text stored in memory.
// A common beginner mistake is thinking string behaves exactly like int or double.

string customerName = "Anand";
string welcomeMessage = "Welcome to the chat app";
bool stringIsReferenceType = !typeof(string).IsValueType;
int welcomeMessageLength = welcomeMessage.Length;

Console.WriteLine("01 - String Basics"); // Output: 01 - String Basics
Console.WriteLine($"Customer Name: {customerName}"); // Output: Customer Name: Anand
Console.WriteLine($"Welcome Message: {welcomeMessage}"); // Output: Welcome Message: Welcome to the chat app
Console.WriteLine($"String is reference type: {stringIsReferenceType}"); // Output: String is reference type: True
Console.WriteLine($"Welcome Message Length: {welcomeMessageLength}"); // Output: Welcome Message Length: 23

// Mistake:
// Do not assume string works like a value type just because assignment looks simple.
// The text data is still managed as a reference type in .NET.

// 🌍 Real-World Analogy:
// Think of a string like a printed document stored in an office file.
// Your variable is like the file label that points to that document.
#endregion

PrintSeparator();

#region 02 - String Immutability
// Strings are immutable.
// That means once text is created, it cannot be changed in place.
// Methods like Replace, Trim, or Substring return a new string object.
// The original text stays unchanged unless you assign the new value back.

string originalStatus = new string("Draft".ToCharArray());
string changedStatus = originalStatus.Replace("Draft", "Final");
bool referenceChanged = !ReferenceEquals(originalStatus, changedStatus);

Console.WriteLine("02 - String Immutability"); // Output: 02 - String Immutability
Console.WriteLine($"Original Status: {originalStatus}"); // Output: Original Status: Draft
Console.WriteLine($"Changed Status: {changedStatus}"); // Output: Changed Status: Final
Console.WriteLine($"Original Still Same: {originalStatus}"); // Output: Original Still Same: Draft
Console.WriteLine($"Reference Changed: {referenceChanged}"); // Output: Reference Changed: True

// Mistake:
// Many beginners call a string method and expect the same string object to change.
// That does not happen. You must capture the returned string.

// 🌍 Real-World Analogy:
// Think of editing a printed document.
// You do not change the old paper. You create a new printed copy with the updated text.
#endregion

PrintSeparator();

#region 03 - String Interpolation
// String interpolation uses the $ symbol.
// It is the cleanest way to place variable values inside text.
// This is very common in logging, UI messages, and API debugging.
// It is easier to read than joining many strings with +.

string studentName = "Meera";
int completedLessons = 7;
string progressMessage = $"Name: {studentName}, Lessons Completed: {completedLessons}";

Console.WriteLine("03 - String Interpolation"); // Output: 03 - String Interpolation
Console.WriteLine(progressMessage); // Output: Name: Meera, Lessons Completed: 7
Console.WriteLine($"Interview Ready Message: {studentName} has completed {completedLessons} lessons."); // Output: Interview Ready Message: Meera has completed 7 lessons.

// Mistake:
// Avoid long chains using + when you build readable messages.
// Interpolation is cleaner and easier to maintain.

// 🌍 Real-World Analogy:
// Think of interpolation like a template with placeholders.
// You plug values into the blank spaces and get the final sentence.
#endregion

PrintSeparator();

#region 04 - Verbatim Strings (@)
// Verbatim strings start with @.
// They are useful for file paths and multi-line text.
// Inside a verbatim string, backslashes do not need escaping.
// This makes copy-paste text easier to read.

string filePath = @"C:\Users\Admin\Files\report.txt";
string emailTemplate = @"Hello Team,
Please review the attached report.
Regards,
Admin";

Console.WriteLine("04 - Verbatim Strings (@)"); // Output: 04 - Verbatim Strings (@)
Console.WriteLine($"File Path: {filePath}"); // Output: File Path: C:\Users\Admin\Files\report.txt
Console.WriteLine("Email Template:"); // Output: Email Template:
Console.WriteLine(emailTemplate); // Output: Hello Team, Please review the attached report. Regards, Admin

// Mistake:
// If you forget @ in Windows file paths, you may run into escape sequence issues.
// For example, \t can behave like a tab instead of normal text.

// 🌍 Real-World Analogy:
// Think of a verbatim string like raw copy-paste text.
// What you type is treated almost exactly as written.
#endregion

PrintSeparator();

#region 05 - Split Method
// Split breaks one string into many parts.
// It returns an array.
// This is useful when reading CSV data, tags, or user-entered values.
// After Split, trimming each part is often important.

string fruitsText = "apple, banana, mango";
string[] fruitParts = fruitsText.Split(',');
string firstFruit = fruitParts[0].Trim();
string secondFruit = fruitParts[1].Trim();
string thirdFruit = fruitParts[2].Trim();

Console.WriteLine("05 - Split Method"); // Output: 05 - Split Method
Console.WriteLine($"Original Text: {fruitsText}"); // Output: Original Text: apple, banana, mango
Console.WriteLine($"First Fruit: {firstFruit}"); // Output: First Fruit: apple
Console.WriteLine($"Second Fruit: {secondFruit}"); // Output: Second Fruit: banana
Console.WriteLine($"Third Fruit: {thirdFruit}"); // Output: Third Fruit: mango
Console.WriteLine($"Total Items: {fruitParts.Length}"); // Output: Total Items: 3

// Mistake:
// Beginners often forget that Split keeps spaces around values.
// Trim the results when input may contain extra spaces.

// 🌍 Real-World Analogy:
// Think of Split like cutting a sentence into separate word cards.
// Each card becomes one item in a collection.
#endregion

PrintSeparator();

#region 06 - Join Method
// Join combines many items into one string using a separator.
// It is cleaner than manual loops for simple text building.
// This is common when making CSV text, tag lists, or log output.

string[] skills = { "C#", ".NET", "SQL" };
string commaSeparatedSkills = string.Join(", ", skills);
string pipeSeparatedSkills = string.Join(" | ", skills);

Console.WriteLine("06 - Join Method"); // Output: 06 - Join Method
Console.WriteLine($"Comma Joined: {commaSeparatedSkills}"); // Output: Comma Joined: C#, .NET, SQL
Console.WriteLine($"Pipe Joined: {pipeSeparatedSkills}"); // Output: Pipe Joined: C# | .NET | SQL

// Mistake:
// Do not write extra loops for simple joining work.
// string.Join is shorter, cleaner, and less error-prone.

// 🌍 Real-World Analogy:
// Think of Join like tying separate word tags into one sentence line.
// The separator is the thread between each tag.
#endregion

PrintSeparator();

#region 07 - Trim Method
// Trim removes unwanted spaces from the start or end of text.
// This is very useful with user input from forms, console, or APIs.
// Use TrimStart when only the front must be cleaned.
// Use TrimEnd when only the end must be cleaned.

string rawUserName = "   learner01   ";
string fullyTrimmed = rawUserName.Trim();
string leftTrimmed = rawUserName.TrimStart();
string rightTrimmed = rawUserName.TrimEnd();

Console.WriteLine("07 - Trim Method"); // Output: 07 - Trim Method
Console.WriteLine($"Original Value: [{rawUserName}]"); // Output: Original Value: [   learner01   ]
Console.WriteLine($"Trim: [{fullyTrimmed}]"); // Output: Trim: [learner01]
Console.WriteLine($"TrimStart: [{leftTrimmed}]"); // Output: TrimStart: [learner01   ]
Console.WriteLine($"TrimEnd: [{rightTrimmed}]"); // Output: TrimEnd: [   learner01]

// Mistake:
// If you forget Trim on user input, login names, emails, and search text may fail to match.
// Extra spaces are a very common real-world bug.

// 🌍 Real-World Analogy:
// Think of Trim like cleaning extra empty margins around printed text.
// The message stays the same, but the messy edges are removed.
#endregion

PrintSeparator();

#region 08 - Replace Method
// Replace swaps characters or words with new values.
// It does not modify the original string.
// This is useful for masking data, formatting text, or updating labels.

string productDescription = "Old Model Phone";
string updatedDescription = productDescription.Replace("Old", "New");
string maskedPhoneNumber = "98765-43210".Replace("-", "");

Console.WriteLine("08 - Replace Method"); // Output: 08 - Replace Method
Console.WriteLine($"Original Description: {productDescription}"); // Output: Original Description: Old Model Phone
Console.WriteLine($"Updated Description: {updatedDescription}"); // Output: Updated Description: New Model Phone
Console.WriteLine($"Masked Phone Number: {maskedPhoneNumber}"); // Output: Masked Phone Number: 9876543210

// Mistake:
// Do not expect Replace to change the existing string object.
// Always store the returned string if you need the updated text.

// 🌍 Real-World Analogy:
// Think of Replace like using Find and Replace in a document editor.
// The editor prepares an updated version of the text for you.
#endregion

PrintSeparator();

#region 09 - Contains & IndexOf
// Contains checks whether text exists.
// IndexOf tells you the position where text starts.
// These are useful for search features, keyword filters, and validation checks.
// By default, case sensitivity matters unless you specify a comparison option.

string browserTitle = "Learn CSharp String Methods";
bool hasStringWord = browserTitle.Contains("String");
int methodsPosition = browserTitle.IndexOf("Methods");
bool caseInsensitiveSearch = browserTitle.Contains("csharp", StringComparison.OrdinalIgnoreCase);

Console.WriteLine("09 - Contains & IndexOf"); // Output: 09 - Contains & IndexOf
Console.WriteLine($"Contains 'String': {hasStringWord}"); // Output: Contains 'String': True
Console.WriteLine($"IndexOf 'Methods': {methodsPosition}"); // Output: IndexOf 'Methods': 20
Console.WriteLine($"Contains 'csharp' Ignore Case: {caseInsensitiveSearch}"); // Output: Contains 'csharp' Ignore Case: True

// Mistake:
// Many learners forget that text search can be case-sensitive.
// When needed, pass StringComparison.OrdinalIgnoreCase for safer matching.

// 🌍 Real-World Analogy:
// Think of this like the search box in a browser.
// One check tells you whether the word exists, and the other tells you where it appears.
#endregion

PrintSeparator();

#region 10 - Substring Method
// Substring extracts part of a string from a given position.
// You can take everything from a start index, or a fixed number of characters.
// This is useful for prefixes, IDs, and date fragments.
// Be careful with indexes so you do not go out of range.

string invoiceCode = "INV-2026-0007";
string invoicePrefix = invoiceCode.Substring(0, 3);
string invoiceYear = invoiceCode.Substring(4, 4);
string invoiceNumber = invoiceCode.Substring(9);

Console.WriteLine("10 - Substring Method"); // Output: 10 - Substring Method
Console.WriteLine($"Invoice Code: {invoiceCode}"); // Output: Invoice Code: INV-2026-0007
Console.WriteLine($"Prefix: {invoicePrefix}"); // Output: Prefix: INV
Console.WriteLine($"Year: {invoiceYear}"); // Output: Year: 2026
Console.WriteLine($"Number: {invoiceNumber}"); // Output: Number: 0007

// Mistake:
// Wrong indexes can cause ArgumentOutOfRangeException.
// Always validate the string length when input may be unpredictable.

// 🌍 Real-World Analogy:
// Think of Substring like cutting one useful portion from a long sentence strip.
// You choose exactly where the cut starts and how much to keep.
#endregion

PrintSeparator();

#region 11 - StringBuilder
// StringBuilder is mutable, which means it can change the same buffer again and again.
// This makes it a better choice when building large text in loops.
// In contrast, repeated string concatenation creates many new string objects.
// That extra object creation can hurt performance.

StringBuilder logBuilder = new();
logBuilder.Append("User Login");
logBuilder.Append(" -> ");
logBuilder.Append("Success");
logBuilder.AppendLine();
logBuilder.AppendLine("Dashboard Loaded");
string builtLog = logBuilder.ToString().TrimEnd();
string builtLogForConsole = builtLog.Replace(Environment.NewLine, " | ");

const int iterationCount = 5000;

Stopwatch stringStopwatch = Stopwatch.StartNew();
string reportText = string.Empty;
for (int index = 0; index < iterationCount; index++)
{
    reportText += index;
}
stringStopwatch.Stop();

Stopwatch builderStopwatch = Stopwatch.StartNew();
StringBuilder reportBuilder = new();
for (int index = 0; index < iterationCount; index++)
{
    reportBuilder.Append(index);
}
string builderResult = reportBuilder.ToString();
builderStopwatch.Stop();

Console.WriteLine("11 - StringBuilder"); // Output: 11 - StringBuilder
Console.WriteLine($"Built Log: {builtLogForConsole}"); // Output: Built Log: User Login -> Success | Dashboard Loaded
Console.WriteLine($"String Length: {reportText.Length}"); // Output: String Length: <number>
Console.WriteLine($"StringBuilder Length: {builderResult.Length}"); // Output: StringBuilder Length: <number>
Console.WriteLine($"String Concatenation Time (ms): {stringStopwatch.ElapsedMilliseconds}"); // Output: String Concatenation Time (ms): <number>
Console.WriteLine($"StringBuilder Time (ms): {builderStopwatch.ElapsedMilliseconds}"); // Output: StringBuilder Time (ms): <number>

// Mistake:
// Do not keep using string + inside large loops when text grows repeatedly.
// StringBuilder is usually the better tool for that job.

// 🌍 Real-World Analogy:
// Think of string like writing on paper and StringBuilder like writing on a whiteboard.
// Paper needs a fresh copy for every change, but a whiteboard can be updated again and again.
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
