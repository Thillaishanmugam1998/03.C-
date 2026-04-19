using ProjectStructureSample.Services;

// Creates the WebApplicationBuilder and loads configuration, logging, and services.
var builder = WebApplication.CreateBuilder(args);


// Adds controller support so classes inside Controllers can handle HTTP requests.
builder.Services.AddControllers();

// Enables OpenAPI document generation for API description/testing.
builder.Services.AddOpenApi();

// Registers EmployeeService with the DI container using singleton lifetime.
builder.Services.AddSingleton<IEmployeeService, EmployeeService>(); 

var app = builder.Build(); // Builds the application pipeline from the registered services and middleware.

if (app.Environment.IsDevelopment()) // Checks whether the app is running in the Development environment.
{
    app.MapOpenApi(); // Exposes the OpenAPI endpoint only during development.
}

app.UseHttpsRedirection(); // Redirects incoming HTTP requests to HTTPS for safer communication.
app.MapControllers(); // Maps attribute-routed controller actions like /api/employees.

app.Run(); // Starts the application and begins listening for incoming requests.
