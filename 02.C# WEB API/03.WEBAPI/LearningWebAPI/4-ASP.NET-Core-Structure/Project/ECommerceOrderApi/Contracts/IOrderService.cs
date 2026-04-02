using ECommerceOrderApi.Models;

namespace ECommerceOrderApi.Contracts;

public interface IOrderService
{
    IReadOnlyList<Order> GetAll();

    IReadOnlyList<Order> GetByStatus(string status);

    Order? GetById(int id);

    Order Create(CreateOrderRequest request);

    Order? Update(int id, UpdateOrderRequest request);

    Order? UpdateStatus(int id, string status);

    bool Delete(int id);
}
