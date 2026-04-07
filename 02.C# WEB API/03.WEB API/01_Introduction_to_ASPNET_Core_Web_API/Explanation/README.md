# Introduction to ASP.NET Core Web API

## What is this topic?

ASP.NET Core Web API is a framework used to build HTTP-based services using .NET. A Web API receives requests from clients such as web applications, mobile apps, desktop systems, third-party integrations, or other internal services, processes business logic, and returns structured responses, usually in JSON format.

In simple terms, a Web API is the communication layer between a client and your backend system.

For example:

- A React frontend sends a request to get products.
- An Android app sends a request to place an order.
- A payment gateway sends a callback to update payment status.

All of these interactions can happen through an ASP.NET Core Web API.

## Why is this important?

ASP.NET Core Web API is one of the most important backend development skills in modern .NET engineering because most business systems today are API-driven.

It is important because:

- Frontend and backend are usually separated in real projects.
- Mobile apps, SPA applications, and third-party systems need APIs.
- APIs help different systems communicate in a standard way.
- Enterprise software often exposes business operations through HTTP endpoints.
- ASP.NET Core is fast, cross-platform, modern, and widely used in production.

If you want to become a real-world backend developer in .NET, learning Web API is not optional. It is a core skill.

## What problem does it solve?

Before APIs, applications were often tightly coupled. A web page, business logic, and database interaction were mixed together. That approach becomes hard to scale, hard to maintain, and hard to integrate with other systems.

ASP.NET Core Web API solves these problems by:

- Exposing business features as endpoints
- Returning data in a client-friendly format such as JSON
- Making backend logic reusable across different client applications
- Supporting clean separation of responsibilities
- Helping teams build scalable and maintainable systems

Example problem:

An e-commerce company has:

- A customer website
- A mobile application
- An admin portal
- A warehouse system

Instead of writing separate backend logic for each application, the company can build one central Web API. All clients call the same API, and the business logic stays consistent.

## What happens if we do not use this?

If you do not use a Web API approach where it is needed:

- Different applications may duplicate the same logic
- Data consistency problems can appear
- Integration with external systems becomes harder
- Maintenance becomes more expensive
- Scaling the system becomes more difficult
- Testing and versioning become more painful

In enterprise systems, avoiding a proper API layer usually leads to a messy architecture where every client talks to the database or business rules are scattered in too many places.

## Real-world use case

Consider an enterprise e-commerce platform similar to Amazon.

The company has many consumers of data:

- Customer web app
- Mobile shopping app
- Seller portal
- Admin dashboard
- Inventory management system
- Order processing service

A `Products API` can expose endpoints such as:

- `GET /api/products` to view products
- `GET /api/products/1` to view one product
- `POST /api/products` to add a product
- `PUT /api/products/1` to update a product
- `DELETE /api/products/1` to remove a product

This allows every client application to work with product data through a single, consistent backend contract.

## Step-by-step conceptual explanation

### 1. Client sends an HTTP request

A client sends a request to the API using HTTP.

Examples:

- `GET` for reading data
- `POST` for creating data
- `PUT` for updating data
- `DELETE` for deleting data

### 2. Request reaches a controller

In ASP.NET Core Web API, a controller receives the request.

The controller:

- Matches the route
- Accepts input
- Calls the service layer
- Returns an HTTP response

Controllers should stay thin. They should not contain too much business logic.

### 3. Controller calls a service

The service contains the application logic. In this topic, the service handles product CRUD operations.

This is useful because:

- Controllers stay clean
- Logic becomes reusable
- Testing becomes easier
- Future enhancements become simpler

### 4. Service works with data

For this introduction topic, we are using in-memory storage.

That means:

- Data is stored in a list in memory
- Data is lost when the application stops
- It is good for learning and early demos
- It is not suitable for real production persistence

Later topics can replace this with a database without changing the overall API idea.

### 5. API sends an HTTP response

The controller returns a response such as:

- `200 OK` when data is returned successfully
- `201 Created` when a new resource is created
- `204 No Content` when update or delete succeeds
- `404 Not Found` when the product does not exist

This is how clients know the result of the request.

## Key points to remember

- ASP.NET Core Web API is used to build HTTP services.
- It commonly returns JSON data.
- Controllers handle requests and responses.
- Services contain business logic.
- HTTP verbs represent actions.
- Routes define endpoint URLs.
- In-memory storage is useful for learning, not for permanent data.
- Clean separation makes future topics easier to build on.

## Common mistakes

- Putting all logic inside controllers
- Not understanding the purpose of HTTP verbs
- Mixing UI concerns with API concerns
- Returning unclear or inconsistent responses
- Using in-memory storage as if it were production-ready
- Creating too many unnecessary layers at the beginning
- Building without a clear domain example

As a beginner, one of the best habits you can develop is this:

Keep the design simple, but keep responsibilities clear.

## Summary

ASP.NET Core Web API helps us build backend services that can be consumed by many kinds of clients. It is a modern, scalable, and enterprise-friendly approach for exposing business functionality over HTTP.

In this first project, we start with a simple e-commerce `Products API` and organize it using:

- Controllers
- Interfaces
- Services

We also use in-memory storage so you can focus on understanding the API flow before moving to databases, dependency injection depth, validation, authentication, and other advanced topics.

This gives us a strong foundation for all future topics in the same long-term project.
