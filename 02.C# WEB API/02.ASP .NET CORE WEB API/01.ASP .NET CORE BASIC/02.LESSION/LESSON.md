# HTTP (HyperText Transfer Protocol)

## 1. What is HTTP?

HTTP stands for HyperText Transfer Protocol.

It is the communication protocol used between:

- Client
- Server

In web development:

- Browser, mobile app, Postman, or frontend application acts as the client
- Web API or website acts as the server

Simple flow:

1. Client sends an HTTP request
2. Server receives the request
3. Server processes it
4. Server sends an HTTP response

## 2. Why is HTTP important in Web API?

ASP.NET Core Web API works completely on top of HTTP.

That means:

- Every API call is an HTTP request
- Every API result is an HTTP response
- Routes, verbs, headers, body, and status codes are all part of HTTP

Without understanding HTTP, Web API concepts will feel confusing.

## 3. Full form meaning

### HyperText

Originally, HTTP was used to transfer HTML documents.

### Transfer

It transfers data between client and server.

### Protocol

A protocol is a set of rules.

So HTTP means:

- A rule-based system for transferring web data

## 4. Main parts of HTTP

HTTP has two main parts:

- Request
- Response

### Request

The client sends the request.

It usually contains:

- Method
- URL
- Headers
- Body

### Response

The server sends the response.

It usually contains:

- Status code
- Headers
- Body

## 5. HTTP Methods

HTTP methods tell the server what action the client wants to perform.

### GET

Used to fetch data.

Example:

```http
GET /api/students
```

### POST

Used to send data to the server, usually to create new data.

Example:

```http
POST /api/students
Content-Type: application/json

{
  "name": "Kumar",
  "email": "kumar@example.com",
  "course": "C# Web API"
}
```

### PUT

Used to update full data.

Example:

```http
PUT /api/students/1
Content-Type: application/json

{
  "id": 1,
  "name": "Kumar",
  "email": "kumar@example.com",
  "course": "ASP.NET Core Advanced"
}
```

### PATCH

Used to update only part of the data.

Example:

```http
PATCH /api/students/1
Content-Type: application/json

{
  "course": "ASP.NET Core Advanced"
}
```

### DELETE

Used to delete data.

Example:

```http
DELETE /api/students/1
```

## 6. URL in HTTP

A URL tells where the request must go.

Example:

`https://localhost:5001/api/students/1`

Breakdown:

- `https` -> protocol
- `localhost:5001` -> server address and port
- `/api/students/1` -> route/path

## 7. Headers in HTTP

Headers carry extra information with the request or response.

Common headers:

- `Content-Type`
- `Accept`
- `Authorization`

Example:

```http
Content-Type: application/json
Accept: application/json
```

### Content-Type

Tells what format the request body is in.

Example:

- `application/json`

### Accept

Tells what response format the client expects.

Example:

- `application/json`

## 8. Body in HTTP

The body contains the actual data being sent.

Usually:

- `GET` does not use a body
- `POST`, `PUT`, and `PATCH` usually use a body

Example JSON body:

```json
{
  "name": "Arun",
  "email": "arun@example.com",
  "course": "Web API"
}
```

## 9. Status Codes

HTTP status codes tell the client what happened.

### 200 OK

Request succeeded.

### 201 Created

A new resource was created successfully.

### 400 Bad Request

Client sent invalid data.

### 401 Unauthorized

Authentication is required.

### 403 Forbidden

Client is authenticated but not allowed.

### 404 Not Found

Requested resource was not found.

### 500 Internal Server Error

Something failed on the server side.

## 10. Request and Response example

### Request

```http
POST /api/students HTTP/1.1
Host: localhost:5145
Content-Type: application/json
Accept: application/json

{
  "name": "Divya",
  "email": "divya@example.com",
  "course": "ASP.NET Core"
}
```

### Response

```http
HTTP/1.1 201 Created
Content-Type: application/json; charset=utf-8

{
  "id": 3,
  "name": "Divya",
  "email": "divya@example.com",
  "course": "ASP.NET Core"
}
```

## 11. HTTP in ASP.NET Core Web API

In ASP.NET Core Web API, HTTP methods are mapped using attributes.

Examples:

```csharp
[HttpGet]
[HttpPost]
[HttpPut]
[HttpDelete]
```

Example:

```csharp
[HttpGet]
public IActionResult GetStudents()
{
    return Ok();
}
```

This means:

- Method type is `GET`
- The action returns HTTP response

In this lesson sample project `HttpProtocolSample`, HTTP methods are demonstrated through the `BooksController`.

Sample routes:

- `GET /api/books`
- `GET /api/books/{id}`
- `POST /api/books`
- `PUT /api/books/{id}`
- `PATCH /api/books/{id}/price`
- `DELETE /api/books/{id}`

## 12. Difference between HTTP method and route

These two are different:

- Method tells what action to perform
- Route tells where the action is located

Example:

- `GET /api/students`
- `POST /api/students`

Same route, different method, different meaning.

## 13. HTTP vs HTTPS

### HTTP

- Data is not encrypted
- Less secure

### HTTPS

- Data is encrypted using SSL/TLS
- More secure
- Recommended for real applications

In ASP.NET Core, we usually use HTTPS.

## 14. Real-time examples

### Browser opening a page

Browser sends:

```http
GET / HTTP/1.1
```

### Fetch all students from API

```http
GET /api/students HTTP/1.1
```

### Insert a student

```http
POST /api/students HTTP/1.1
Content-Type: application/json
```

## 15. What this lesson teaches

This lesson helps you understand:

- What HTTP is
- Why HTTP is important for Web API
- Request and response structure
- HTTP methods
- Headers
- Body
- Status codes
- Route and method difference
- HTTP vs HTTPS
- How all major HTTP methods look in one sample ASP.NET Core Web API project

## 16. Sample project structure

Inside `02.LESSION/HttpProtocolSample`:

- `Program.cs` -> application startup and service registration
- `Controllers/BooksController.cs` -> endpoints for all HTTP methods
- `Models/Book.cs` -> main response model
- `Models/CreateBookRequest.cs` -> POST request model
- `Models/UpdateBookRequest.cs` -> PUT request model
- `Models/PatchBookPriceRequest.cs` -> PATCH request model
- `BAL/BookBAL.cs` -> in-memory data handling
- `HttpProtocolSample.http` -> ready-to-run HTTP request samples

## 17. Summary

HTTP is the foundation of Web API communication.
When a client talks to an ASP.NET Core Web API, it uses HTTP requests and receives HTTP responses.

If you understand:

- Method
- Route
- Header
- Body
- Status code

then Web API becomes much easier to learn.
