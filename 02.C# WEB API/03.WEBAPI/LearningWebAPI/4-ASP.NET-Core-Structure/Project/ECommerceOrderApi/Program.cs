using ECommerceOrderApi.Contracts;
using ECommerceOrderApi.Services;

#region Builder
var builder = WebApplication.CreateBuilder(args);

// Enable controller-based Web API support.
builder.Services.AddControllers();

// Register the order service through its contract to keep structure clean.
builder.Services.AddSingleton<IOrderService, OrderService>();
#endregion

#region App
var app = builder.Build();

// Expose endpoints defined in controller attributes.
app.MapControllers();

app.Run();
#endregion
