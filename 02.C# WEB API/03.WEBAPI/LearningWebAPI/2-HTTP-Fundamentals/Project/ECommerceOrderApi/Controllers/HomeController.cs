using Microsoft.AspNetCore.Mvc;

namespace ECommerceOrderApi.Controllers;

[ApiController]
[Route("/")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            message = "E-Commerce Order API is running.",
            topic = "HTTP Fundamentals",
            availableEndpoints = new[]
            {
                "GET /api/orders",
                "GET /api/orders/{id}",
                "POST /api/orders",
                "PUT /api/orders/{id}/status",
                "DELETE /api/orders/{id}"
            }
        });
    }
}

