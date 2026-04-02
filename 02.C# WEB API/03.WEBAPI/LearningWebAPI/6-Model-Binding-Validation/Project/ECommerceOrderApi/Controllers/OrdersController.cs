using ECommerceOrderApi.Contracts;
using ECommerceOrderApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceOrderApi.Controllers;

#region Controller
// Marks this class as an API controller and enables API-specific behavior.
[ApiController]
// Base route: "api/orders" for OrdersController.
[Route("api/[controller]")]
public class OrdersController(IOrderService orderService) : ControllerBase
{
    #region Read Actions
    // Binds filter values from the query string like ?status=Pending&customerName=Arun.
    [HttpGet]
    public ActionResult<IEnumerable<Order>> GetAll([FromQuery] GetOrdersQueryRequest request)
    {
        var orders = orderService.GetByFilters(request);

        return Ok(orders);
    }

    // Matches GET /api/orders/1. The ":int" route constraint allows only integer ids.
    [HttpGet("{id:int}")]
    public ActionResult<Order> GetById([FromRoute] int id)
    {
        var order = orderService.GetById(id);

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
    public ActionResult<Order> Create([FromBody] CreateOrderRequest request)
    {
        var order = orderService.Create(request);

        // 201 Created with a link to the GetById action for the newly created order.
        return CreatedAtAction(nameof(GetById), new { id = order.Id }, order);
    }

    // Matches PUT /api/orders/1 to replace the full resource representation.
    [HttpPut("{id:int}")]
    public ActionResult<Order> Update([FromRoute] int id, [FromBody] UpdateOrderRequest request)
    {
        var order = orderService.Update(id, request);

        if (order is null)
        {
            return NotFound(new { message = $"Order with id {id} was not found." });
        }

        return Ok(order);
    }

    // Matches PUT /api/orders/1/status to update only the order status.
    [HttpPut("{id:int}/status")]
    public ActionResult<Order> UpdateStatus([FromRoute] int id, [FromBody] UpdateOrderStatusRequest request)
    {
        var order = orderService.UpdateStatus(id, request.Status);

        if (order is null)
        {
            return NotFound(new { message = $"Order with id {id} was not found." });
        }

        return Ok(order);
    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete([FromRoute] int id)
    {
        var deleted = orderService.Delete(id);

        if (!deleted)
        {
            return NotFound(new { message = $"Order with id {id} was not found." });
        }

        return NoContent();
    }
    #endregion
}
#endregion
