using ECommerceOrderApi.Contracts;
using ECommerceOrderApi.Services;
using ECommerceOrderApi.Validators;
using FluentValidation;
using FluentValidation.AspNetCore;

#region Builder
var builder = WebApplication.CreateBuilder(args);

// Enable controller-based Web API support.
builder.Services.AddControllers();
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssemblyContaining<CreateOrderRequestValidator>();

// Register the order service through its contract to keep structure clean.
builder.Services.AddSingleton<IOrderService, OrderService>();
#endregion

#region App
var app = builder.Build();

// Expose endpoints defined in controller attributes.
app.MapControllers();

app.Run();
#endregion
