using System.ComponentModel.DataAnnotations;

namespace ECommerceOrderApi.Models;

public class GetOrdersQueryRequest
{
    [StringLength(20)]
    public string? Status { get; set; }

    [StringLength(100)]
    public string? CustomerName { get; set; }
}
