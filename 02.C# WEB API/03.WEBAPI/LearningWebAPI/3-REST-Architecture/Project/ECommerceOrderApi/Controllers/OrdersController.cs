using ECommerceOrderApi.Models;
using ECommerceOrderApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceOrderApi.Controllers;

#region Controller
// Marks this class as an API controller and enables API-specific behavior.
[ApiController]
// Base route: "api/orders" for OrdersController.
[Route("api/[controller]")]
public class OrdersController(OrderStore orderStore) : ControllerBase
{
    #region Read Actions
    // Returns a collection of orders.
    [HttpGet]
    public ActionResult<IEnumerable<Order>> GetAll([FromQuery] string? status)
    {
        var orders = string.IsNullOrWhiteSpace(status)
            ? orderStore.GetAll()
            : orderStore.GetByStatus(status);

        return Ok(orders);
    }

    // Matches GET /api/orders/1. The ":int" route constraint allows only integer ids.
    [HttpGet("{id:int}")]
    public ActionResult<Order> GetById(int id)
    {
        var order = orderStore.GetById(id);

        if (order is null)
        {
            // 404 Not Found when the requested order does not exist.
            return NotFound(new { message = $"Order with id {id} was not found." });
        }

        return Ok(order);
    }
    #endregion

    #region Write Actions
    [HttpPost]
    public ActionResult<Order> Create(CreateOrderRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.CustomerName) || string.IsNullOrWhiteSpace(request.ProductName) ||
            request.Quantity <= 0 || request.TotalAmount <= 0)
        {
            // 400 Bad Request when the client sends invalid input.
            return BadRequest(new
            {
                message = "CustomerName, ProductName, Quantity, and TotalAmount must have valid values."
            });
        }

        var order = orderStore.Create(request);

        // 201 Created with a link to the GetById action for the newly created order.
        return CreatedAtAction(nameof(GetById), new { id = order.Id }, order);
    }

    // Matches PUT /api/orders/1 to replace the full resource representation.
    [HttpPut("{id:int}")]
    public ActionResult<Order> Update(int id, UpdateOrderRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.CustomerName) ||
            string.IsNullOrWhiteSpace(request.ProductName) ||
            string.IsNullOrWhiteSpace(request.Status) ||
            request.Quantity <= 0 ||
            request.TotalAmount <= 0)
        {
            return BadRequest(new
            {
                message = "CustomerName, ProductName, Quantity, TotalAmount, and Status must have valid values."
            });
        }

        var order = orderStore.Update(id, request);

        if (order is null)
        {
            return NotFound(new { message = $"Order with id {id} was not found." });
        }

        return Ok(order);
    }

    // Matches PUT /api/orders/1/status to update only the order status.
    [HttpPut("{id:int}/status")]
    public ActionResult<Order> UpdateStatus(int id, UpdateOrderStatusRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Status))
        {
            return BadRequest(new { message = "Status is required." });
        }

        var order = orderStore.UpdateStatus(id, request.Status);

        if (order is null)
        {
            return NotFound(new { message = $"Order with id {id} was not found." });
        }

        return Ok(order);
    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        var deleted = orderStore.Delete(id);

        if (!deleted)
        {
            return NotFound(new { message = $"Order with id {id} was not found." });
        }

        return NoContent();
    }
    #endregion
}
#endregion
