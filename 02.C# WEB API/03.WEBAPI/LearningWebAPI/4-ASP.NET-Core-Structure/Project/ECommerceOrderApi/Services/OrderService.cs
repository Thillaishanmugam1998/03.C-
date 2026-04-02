using ECommerceOrderApi.Contracts;
using ECommerceOrderApi.Models;

namespace ECommerceOrderApi.Services;

#region Service
public class OrderService : IOrderService
{
    #region Fields
    private readonly List<Order> _orders =
    [
        new Order
        {
            Id = 1,
            CustomerName = "Arun Kumar",
            ProductName = "Wireless Mouse",
            Quantity = 2,
            TotalAmount = 1598.00m,
            Status = "Pending"
        },
        new Order
        {
            Id = 2,
            CustomerName = "Priya",
            ProductName = "Mechanical Keyboard",
            Quantity = 1,
            TotalAmount = 3499.00m,
            Status = "Confirmed"
        }
    ];
    #endregion

    #region Query Methods
    public IReadOnlyList<Order> GetAll()
    {
        return _orders;
    }

    public IReadOnlyList<Order> GetByStatus(string status)
    {
        return _orders
            .Where(order => order.Status.Equals(status.Trim(), StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    public Order? GetById(int id)
    {
        return _orders.FirstOrDefault(order => order.Id == id);
    }
    #endregion

    #region Command Methods
    public Order Create(CreateOrderRequest request)
    {
        var order = new Order
        {
            Id = _orders.Count == 0 ? 1 : _orders.Max(order => order.Id) + 1,
            CustomerName = request.CustomerName.Trim(),
            ProductName = request.ProductName.Trim(),
            Quantity = request.Quantity,
            TotalAmount = request.TotalAmount,
            Status = "Pending"
        };

        _orders.Add(order);

        return order;
    }

    public Order? Update(int id, UpdateOrderRequest request)
    {
        var order = GetById(id);

        if (order is null)
        {
            return null;
        }

        order.CustomerName = request.CustomerName.Trim();
        order.ProductName = request.ProductName.Trim();
        order.Quantity = request.Quantity;
        order.TotalAmount = request.TotalAmount;
        order.Status = request.Status.Trim();

        return order;
    }

    public Order? UpdateStatus(int id, string status)
    {
        var order = GetById(id);

        if (order is null)
        {
            return null;
        }

        order.Status = status.Trim();
        return order;
    }

    public bool Delete(int id)
    {
        var order = GetById(id);

        if (order is null)
        {
            return false;
        }

        _orders.Remove(order);
        return true;
    }
    #endregion
}
#endregion
