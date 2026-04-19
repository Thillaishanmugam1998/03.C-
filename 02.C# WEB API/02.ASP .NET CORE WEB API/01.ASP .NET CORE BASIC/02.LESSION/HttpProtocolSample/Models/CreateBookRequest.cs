namespace HttpProtocolSample.Models;

public class CreateBookRequest
{
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Category { get; set; } = string.Empty;
}
