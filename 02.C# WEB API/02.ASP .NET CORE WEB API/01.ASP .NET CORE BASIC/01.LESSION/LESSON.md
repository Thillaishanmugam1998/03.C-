# Introduction to ASP.NET Core Web API

## 1. What is ASP.NET Core Web API?

ASP.NET Core Web API is a framework used to build HTTP-based services.
These services are usually consumed by:

- Web applications
- Mobile applications
- Desktop applications
- Other APIs or backend systems

In simple words, a Web API receives an HTTP request, processes it, and sends an HTTP response.

Example:

- Client sends `GET /api/students`
- API returns a list of students in JSON format

## 2. What is an API?

API stands for Application Programming Interface.

For Web API development, it usually means:

- A set of URLs called endpoints
- Each endpoint performs an operation
- Data is commonly exchanged in JSON format

Example endpoints:

- `GET /api/students` -> Get all students
- `GET /api/students/1` -> Get one student
- `POST /api/students` -> Create a new student

## 3. Why use ASP.NET Core Web API?

ASP.NET Core Web API is popular because it is:

- Cross-platform
- Fast and lightweight
- Easy to test
- Good for RESTful services
- Well integrated with dependency injection, routing, configuration, and middleware

## 4. Important concepts

### Request

A request is sent by the client to the server.

Examples:

- `GET`
- `POST`
- `PUT`
- `DELETE`

### Response

A response is sent back by the API to the client.

Examples:

- `200 OK`
- `201 Created`
- `400 Bad Request`
- `404 Not Found`

### Endpoint

An endpoint is a URL that performs a specific task.

Example:

- `https://localhost:5001/api/students`

### JSON

JSON is the common format used to send and receive data.

Example:

```json
{
  "id": 1,
  "name": "Arun",
  "email": "arun@example.com",
  "course": "ASP.NET Core"
}
```

### Controller

A controller is a class that handles incoming HTTP requests.

In this sample:

- `StudentsController` handles student-related requests

### Routing

Routing decides which URL goes to which controller action.

In this sample:

- `[Route("api/[controller]")]`
- For `StudentsController`, the route becomes `api/students`

## 5. Project structure in this lesson

Inside `01.LESSION/WebApiIntroductionSample`:

- `Program.cs` -> application startup and service configuration
- `Controllers/StudentsController.cs` -> API endpoints
- `Models/Student.cs` -> response model
- `Models/CreateStudentRequest.cs` -> request model
- `BAL/StudentBAL.cs` -> simple in-memory business access layer

The controller and BAL class are also organized with separate `#region` blocks for each method, using uppercase numbered names.

## 6. Explanation of Program.cs

`Program.cs` is the starting point of the application.

Key parts:

```csharp
builder.Services.AddControllers();
```

This enables controller support.

```csharp
builder.Services.AddSingleton<StudentBAL>();
```

This registers `StudentBAL` in the dependency injection container so it can be used in the controller.

```csharp
app.MapControllers();
```

This maps controller routes so endpoints become active.

## 7. Explanation of StudentsController

`StudentsController` contains four endpoints:

### `GET /api/students`

Returns all students.

This method returns `Ok(...)`, which sends `HTTP 200 OK` with JSON data.

### `GET /api/students/{id}`

Returns one student by ID.

If the ID does not exist, it returns `404 Not Found`.

This is better than returning a plain string because the client can understand the exact HTTP status.

### `POST /api/students`

Creates a new student.

If required fields are missing, it returns `400 Bad Request`.

If successful, it returns `201 Created`.

This is the recommended Web API style because it returns meaningful status codes such as:

- `BadRequest(...)`
- `CreatedAtAction(...)`

### `POST /api/students/CreateStudent`

This method also inserts a student, but it returns a plain string.

Example:

- `"Name, Email, and Course are required."`
- `"Successfully Inserted"`

This approach is used in the sample only to show the difference.
When a plain string is returned directly, the response usually comes back as `HTTP 200 OK` by default, so the client cannot clearly identify validation errors or creation success from the status code alone.

## 8. Dependency Injection

Dependency Injection means ASP.NET Core creates required objects for us.

In this sample:

- `StudentBAL` is registered in `Program.cs`
- `StudentsController` receives it through the constructor

This makes the code cleaner and easier to maintain.

## 9. Sample requests

### Get all students

```http
GET /api/students
```

### Get one student

```http
GET /api/students/1
```

### Create a student with proper status codes

```http
POST /api/students
Content-Type: application/json

{
  "name": "Kumar",
  "email": "kumar@example.com",
  "course": "C# Web API"
}
```

### Create a student with plain string response

```http
POST /api/students/CreateStudent
Content-Type: application/json

{
  "name": "Kumar",
  "email": "kumar@example.com",
  "course": "C# Web API"
}
```

## 10. How to run the sample

Open terminal inside:

`01.LESSION/WebApiIntroductionSample`

Run:

```powershell
dotnet run
```

Then test the API using:

- Browser for GET requests
- Postman
- Visual Studio HTTP file
- Swagger/OpenAPI client if enabled in your setup

## 11. What this sample teaches

This sample helps you understand:

- How to create a Web API project
- How routing works
- How controllers work
- How to return HTTP status codes
- How to accept JSON request bodies
- How dependency injection is used
- The difference between `ActionResult` responses and plain string responses

## 12. Important note

This sample uses in-memory data only.
That means data is not saved permanently.

When the application restarts, the data resets.

In real projects, we usually connect the API to:

- SQL Server
- Entity Framework Core
- Authentication and authorization
- Logging
- Validation libraries

## 13. Summary

ASP.NET Core Web API is used to create backend services that communicate over HTTP.
It is a powerful way to build APIs for web, mobile, and enterprise applications.

In this lesson, you now have:

- Basic theory
- A simple controller-based API sample
- Real endpoints to test and understand
