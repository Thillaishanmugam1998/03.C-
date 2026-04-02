using Microsoft.AspNetCore.Mvc;

namespace ECommerceOrderApi.Controllers;

#region Controller
[ApiController]
[Route("/")]
public class HomeController : ControllerBase
{
    #region Actions
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            message = "E-Commerce Order API is running.",
            topic = "Model Binding & Validation",
            availableEndpoints = new[]
            {
                "GET /api/orders",
                "GET /api/orders?status=Pending&customerName=Arun",
                "GET /api/orders/{id}",
                "POST /api/orders",
                "PUT /api/orders/{id}",
                "PUT /api/orders/{id}/status",
                "DELETE /api/orders/{id}"
            }
        });
    }
    #endregion
}
#endregion
