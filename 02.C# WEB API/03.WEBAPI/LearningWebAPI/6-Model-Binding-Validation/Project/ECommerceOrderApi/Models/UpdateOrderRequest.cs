using System.ComponentModel.DataAnnotations;

namespace ECommerceOrderApi.Models;

public class UpdateOrderRequest
{
    [Required]
    [StringLength(100, MinimumLength = 3)]
    public string CustomerName { get; set; } = string.Empty;

    [Required]
    [StringLength(120, MinimumLength = 3)]
    public string ProductName { get; set; } = string.Empty;

    [Range(1, 20)]
    public int Quantity { get; set; }

    [Range(typeof(decimal), "1", "100000")]
    public decimal TotalAmount { get; set; }

    [Required]
    [StringLength(20, MinimumLength = 3)]
    public string Status { get; set; } = string.Empty;
}
