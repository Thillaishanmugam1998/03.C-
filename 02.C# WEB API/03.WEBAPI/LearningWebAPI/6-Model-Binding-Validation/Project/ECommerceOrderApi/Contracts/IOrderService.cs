using ECommerceOrderApi.Models;

namespace ECommerceOrderApi.Contracts;

public interface IOrderService
{
    IReadOnlyList<Order> GetByFilters(GetOrdersQueryRequest request);

    Order? GetById(int id);

    Order Create(CreateOrderRequest request);

    Order? Update(int id, UpdateOrderRequest request);

    Order? UpdateStatus(int id, string status);

    bool Delete(int id);
}
