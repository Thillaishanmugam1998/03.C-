# Abstract Class - Real-Time Examples

## Concept Explanation

An abstract class is a base class that cannot be instantiated directly. It is used when multiple derived classes share common behavior, but some parts of the behavior must be defined differently by each derived class.

An abstract class can contain:

- Normal methods with implementation
- Abstract methods without implementation
- Fields, properties, and constructors

## Real-World Analogy

Think about a report generation system.

- Every report follows common steps like collecting data and formatting content.
- But the final export step depends on the required file type.
- A PDF report exports as PDF.
- An Excel report exports as Excel.

The common process is shared, while the final specific step is defined by each report type.

## Comparison Between Real-World Scenario and Code Implementation

| Real-World Scenario | Code Implementation |
| --- | --- |
| All reports follow a common preparation process | `ReportGenerator` contains `GenerateReport()` |
| Some report steps are shared | Common logic is written once in the abstract class |
| Final export differs by format | `Export()` is abstract and overridden in derived classes |
| PDF and Excel are specific report types | `PdfReportGenerator` and `ExcelReportGenerator` inherit from the base |
| Base idea exists, but not as a direct object | Abstract class cannot be created directly |

## Syntax

```csharp
public abstract class Report
{
    public void Prepare()
    {
        Console.WriteLine("Preparing...");
    }

    public abstract void Export();
}
```

## Step-by-Step Explanation

1. Create an abstract base class.
2. Add common methods with shared implementation.
3. Add abstract methods for behavior that must vary.
4. Create derived classes from the abstract base class.
5. Override the abstract methods in each derived class.
6. Use the base class reference to work with different concrete report types.

## Best Practices

- Use abstract classes when there is shared state or shared implementation.
- Place common workflow in the abstract base class.
- Keep abstract members focused on the parts that genuinely vary.
- Use protected members when behavior should stay inside the hierarchy.
- Prefer an abstract class only when the relationship is strongly shared.

## Common Mistakes

- Trying to instantiate an abstract class directly.
- Using an abstract class when there is no shared implementation.
- Putting too much unrelated logic into the base class.
- Forgetting to override abstract members in derived classes.
