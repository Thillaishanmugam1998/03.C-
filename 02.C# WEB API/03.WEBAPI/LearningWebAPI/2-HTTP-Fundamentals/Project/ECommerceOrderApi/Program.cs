using ECommerceOrderApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Enable controller-based Web API support.
builder.Services.AddControllers();

// Register the in-memory store used by this topic.
builder.Services.AddSingleton<OrderStore>();

var app = builder.Build();

// Expose endpoints defined in controller attributes.
app.MapControllers();

app.Run();
