using WebApiIntroductionSample.BAL;

var builder = WebApplication.CreateBuilder(args);

// Register framework services used by the API.
builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddSingleton<StudentBAL>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// Map attribute-routed controllers such as api/students.
app.MapControllers();

app.Run();
